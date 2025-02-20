using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    public float movespeed = 1f;

    public float maxX = 1f;
    public float minX = -1f;

    private void Update()
    {
        Vector3 curPos = gameObject.transform.localPosition;

        float currentx = curPos.x;

        if (currentx < minX)
        {
           currentx = maxX;
        }
        
        if (currentx > maxX)
        {
            currentx = minX;
        }
        gameObject.transform.localPosition = new Vector3(currentx + movespeed * Time.deltaTime, curPos.y, curPos.z);
    }












}
