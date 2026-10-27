using System;

// Token: 0x020000E1 RID: 225
public class LinearCurve : CurveBase
{
	// Token: 0x060006E6 RID: 1766 RVA: 0x00024AEE File Offset: 0x00022CEE
	public override float GetCurrentValueInternal(float key)
	{
		return key;
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00024AF1 File Offset: 0x00022CF1
	public LinearCurve() : base(Array.Empty<float>())
	{
	}
}
