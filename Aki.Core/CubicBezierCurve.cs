using System;
using System.Runtime.CompilerServices;

// Token: 0x020000DC RID: 220
public class CubicBezierCurve : CurveBase
{
	// Token: 0x060006D8 RID: 1752 RVA: 0x00024784 File Offset: 0x00022984
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

	// Token: 0x060006D9 RID: 1753 RVA: 0x0002483C File Offset: 0x00022A3C
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

	// Token: 0x04000580 RID: 1408
	private static readonly int NEWTON_ITERATIONS = 6;

	// Token: 0x04000581 RID: 1409
	private readonly float Ax;

	// Token: 0x04000582 RID: 1410
	private readonly float Bx;

	// Token: 0x04000583 RID: 1411
	private readonly float Cx = 1f;

	// Token: 0x04000584 RID: 1412
	private readonly float Ay;

	// Token: 0x04000585 RID: 1413
	private readonly float By;

	// Token: 0x04000586 RID: 1414
	private readonly float Cy = 1f;
}
