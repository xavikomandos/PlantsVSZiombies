using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManages : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length < 3)
        {
            Instantiate(zombiePrefab, GetRandomSpawnPiont(), Quaternion.identity);
        }
    }
    Vector3 GetRandomSpawnPiont()
    {
        Vector3 spawnPoint;
        do
        {
            spawnPoint = UnityEngine.Random.insideUnitSphere;
            spawnPoint.y = 0f;
            spawnPoint = spawnPoint.normalized;
            spawnPoint *= UnityEngine.Random.Range(10f, 20f);
        }
        while (Physics.CheckSphere(new Vector3(spawnPoint.x, 1, spawnPoint.z), 0.9f));

        return spawnPoint;
    }
}
