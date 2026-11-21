using System;

// Token: 0x020000E3 RID: 227
public class LinearCurve : CurveBase
{
	// Token: 0x06000727 RID: 1831 RVA: 0x000250C2 File Offset: 0x000232C2
	public override float GetCurrentValueInternal(float key)
	{
		return key;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x000250C5 File Offset: 0x000232C5
	public LinearCurve() : base(Array.Empty<float>())
	{
	}
}
