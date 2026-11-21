using System;
using System.Runtime.CompilerServices;

// Token: 0x020000DF RID: 223
public class CubicCurve : CurveBase
{
	// Token: 0x0600071B RID: 1819 RVA: 0x00024ED0 File Offset: 0x000230D0
	[NullableContext(1)]
	public CubicCurve(params float[] @params) : base(Array.Empty<float>())
	{
		this.A = -2f * (1f - @params[0]);
		this.B = 3f * (1f - @params[0]);
		this.C = @params[0];
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00024F26 File Offset: 0x00023126
	public override float GetCurrentValueInternal(float key)
	{
		return ((this.A * key + this.B) * key + this.C) * key;
	}

	// Token: 0x04000596 RID: 1430
	private readonly float A;

	// Token: 0x04000597 RID: 1431
	private readonly float B;

	// Token: 0x04000598 RID: 1432
	private readonly float C = 1f;
}
