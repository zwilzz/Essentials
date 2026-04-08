using UnityEngine;
using UnityEngine.AI;

public class NPCflipper : MonoBehaviour
{
    private NavMeshAgent agent;
    private SpriteRenderer spriteRenderer;

    void Awake ()
    {
        agent = GetComponent<NavMeshAgent>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
   
    void Update()
    {
        float xVel = agent.velocity.x;

        if (Mathf.Abs(xVel) > 0.01f)
        {
            spriteRenderer.flipX = xVel < 0f;
        }
    }
}
