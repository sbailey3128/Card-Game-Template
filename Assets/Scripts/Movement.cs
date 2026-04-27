using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pressed space");
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
    }
}
