using System;
using System.Runtime.CompilerServices;

// Token: 0x020000DE RID: 222
public class CubicBezierCurve : CurveBase
{
	// Token: 0x06000719 RID: 1817 RVA: 0x00024D58 File Offset: 0x00022F58
	[NullableContext(1)]
	public CubicBezierCurve(params float[] parameters) : base(Array.Empty<float>())
	{
		float num = parameters[0];
		float num2 = parameters[1];
		float num3 = parameters[2];
		float num4 = parameters[3];
		this.Cx = 3f * num;
		this.Bx = 3f * (num3 - num) - this.Cx;
		this.Ax = 1f - this.Cx - this.Bx;
		this.Cy = 3f * num2;
		this.By = 3f * (num4 - num2) - this.Cy;
		this.Ay = 1f - this.Cy - this.By;
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00024E10 File Offset: 0x00023010
	public override float GetCurrentValueInternal(float key)
	{
		if (key <= 0f)
		{
			return 0f;
		}
		if (key >= 1f)
		{
			return 1f;
		}
		float num = key;
		for (int i = 0; i < CubicBezierCurve.NEWTON_ITERATIONS; i++)
		{
			float num2 = ((this.Ax * num + this.Bx) * num + this.Cx) * num - key;
			if (MathUtils.Instance.IsNearlyZero((double)Math.Abs(num2), new double?(0.0001)))
			{
				break;
			}
			float num3 = (3f * this.Ax * num + 2f * this.Bx) * num + this.Cx;
			num -= num2 / num3;
		}
		return ((this.Ay * num + this.By) * num + this.Cy) * num;
	}

	// Token: 0x0400058F RID: 1423
	private static readonly int NEWTON_ITERATIONS = 6;

	// Token: 0x04000590 RID: 1424
	private readonly float Ax;

	// Token: 0x04000591 RID: 1425
	private readonly float Bx;

	// Token: 0x04000592 RID: 1426
	private readonly float Cx = 1f;

	// Token: 0x04000593 RID: 1427
	private readonly float Ay;

	// Token: 0x04000594 RID: 1428
	private readonly float By;

	// Token: 0x04000595 RID: 1429
	private readonly float Cy = 1f;
}
