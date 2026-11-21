using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000E2 RID: 226
public class FloatCurve : CurveBase
{
	// Token: 0x06000724 RID: 1828 RVA: 0x00025092 File Offset: 0x00023292
	[NullableContext(1)]
	public FloatCurve(UCurveFloat floatCurve) : base(Array.Empty<float>())
	{
		this.CurveFloat = floatCurve;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x000250A6 File Offset: 0x000232A6
	public override float GetCurrentValueInternal(float key)
	{
		return this.CurveFloat.GetFloatValue(key);
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x000250B4 File Offset: 0x000232B4
	public float GetCurrentValueByTime(float time)
	{
		return this.CurveFloat.GetFloatValue(time);
	}

	// Token: 0x0400059C RID: 1436
	[Nullable(2)]
	private readonly UCurveFloat CurveFloat;
}
