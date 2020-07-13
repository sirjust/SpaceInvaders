using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static bool IsPlayerDead = false;
    private Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerDead)
        {
            Time.timeScale = 0f;
            gameOver.enabled = true;
        }
    }
}
