using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000E0 RID: 224
public class FloatCurve : CurveBase
{
	// Token: 0x060006E3 RID: 1763 RVA: 0x00024ABE File Offset: 0x00022CBE
	[NullableContext(1)]
	public FloatCurve(UCurveFloat floatCurve) : base(Array.Empty<float>())
	{
		this.CurveFloat = floatCurve;
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00024AD2 File Offset: 0x00022CD2
	public override float GetCurrentValueInternal(float key)
	{
		return this.CurveFloat.GetFloatValue(key);
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x00024AE0 File Offset: 0x00022CE0
	public float GetCurrentValueByTime(float time)
	{
		return this.CurveFloat.GetFloatValue(time);
	}

	// Token: 0x0400058D RID: 1421
	[Nullable(2)]
	private readonly UCurveFloat CurveFloat;
}
