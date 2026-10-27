using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000215 RID: 533
public class CurveVectorEvaluator : IVectorParamEvaluator
{
	// Token: 0x060020E2 RID: 8418 RVA: 0x000B6421 File Offset: 0x000B4621
	[NullableContext(1)]
	public CurveVectorEvaluator(UCurveVector curve)
	{
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x000B6430 File Offset: 0x000B4630
	public FVector GetValue(float t)
	{
		return this.<curve>P.GetVectorValue(t);
	}

	// Token: 0x0400150D RID: 5389
	[Nullable(1)]
	[CompilerGenerated]
	private UCurveVector <curve>P = curve;
}
