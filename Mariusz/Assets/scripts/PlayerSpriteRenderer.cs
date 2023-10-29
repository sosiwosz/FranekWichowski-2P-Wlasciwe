using UnityEngine;

public class PlayerSpriteRenderer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerMovement movement;

    public Sprite idle;
    public AnimatedSprite running;



    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponentInParent<PlayerMovement>();
    }

    private void OnEnable()
    {
        spriteRenderer.enabled = true;
    }

    private void OnDisable()
    {
        spriteRenderer.enabled = false;
    }

    private void LateUpdate()
    {
        running.enabled = movement.running;

        if (!movement.running) {
            spriteRenderer.sprite = idle;
        } 
    }

}
