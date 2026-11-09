using UnityEngine;

public class CalcVector : MonoBehaviour
{
    public Vector3 A = new Vector3(2, 5, -4);
    public Vector3 B = new Vector3(5, 3, 6);
    public Vector3 Result = Vector3.zero;
    public float DotResult = 0;

    void Update()
    {
        Result = CrossMultiply(A, B).normalized;
        DotResult = DotMultiply(A, B);
    }

    /// <summary>
    /// ベクトル同士の足し算
    /// ※ A と B を合成したベクトル
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public Vector3 Subtract(Vector3 a, Vector3 b)
    {
        var result = a + b;

        // ベクトルを可視化
        // Debug.DrawRay（始点、方向、描画色、描画時間、深度設定）
        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0, false);
        Debug.DrawRay(b, a - b, Color.green, 0, false);

        return result;
    }

    public Vector3 Multiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.zero;

        // result.x = (a.y * b.z) - (a.z * b.y);
        // result.y = (a.z * b.x) - (a.x * b.z);
        // result.z = (a.x * b.y) - (a.y * b.x);

        result = Vector3.Scale(a, b);

        return result;
    }

    /// <summary>
    /// べクトル同士の内積
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public float DotMultiply(Vector3 a, Vector3 b)
    {
        var result = (a.x * b.x) + (a.y * b.y) + (a.z * b.z);

        Debug.Log($"{a}と{b}の内積 = {result}");

        return result;
    }

    /// <summary>
    /// べクトル同士の外積
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public Vector3 CrossMultiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.zero;

        // result.x = (a.y * b.z) - (a.z * b.y);
        // result.y = (a.z * b.x) - (a.x * b.z);
        // result.z = (a.x * b.y) - (a.y * b.x);

        result = Vector3.Cross(a, b);

        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0, false);
        Debug.DrawRay(Vector3.zero, result.normalized, Color.green, 0, false);

        Debug.Log($"{a}と{b}の外積 = {result}");

        return result;
    }
}
