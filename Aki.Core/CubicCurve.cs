using System;
using System.Runtime.CompilerServices;

// Token: 0x020000DD RID: 221
public class CubicCurve : CurveBase
{
	// Token: 0x060006DA RID: 1754 RVA: 0x000248FC File Offset: 0x00022AFC
	[NullableContext(1)]
	public CubicCurve(params float[] @params) : base(Array.Empty<float>())
	{
		this.A = -2f * (1f - @params[0]);
		this.B = 3f * (1f - @params[0]);
		this.C = @params[0];
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00024952 File Offset: 0x00022B52
	public override float GetCurrentValueInternal(float key)
	{
		return ((this.A * key + this.B) * key + this.C) * key;
	}

	// Token: 0x04000587 RID: 1415
	private readonly float A;

	// Token: 0x04000588 RID: 1416
	private readonly float B;

	// Token: 0x04000589 RID: 1417
	private readonly float C = 1f;
}
