using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000219 RID: 537
public class CurveVectorEvaluator : IVectorParamEvaluator
{
	// Token: 0x06002190 RID: 8592 RVA: 0x000BD741 File Offset: 0x000BB941
	[NullableContext(1)]
	public CurveVectorEvaluator(UCurveVector curve)
	{
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x000BD750 File Offset: 0x000BB950
	public FVector GetValue(float t)
	{
		return this.<curve>P.GetVectorValue(t);
	}

	// Token: 0x0400154F RID: 5455
	[Nullable(1)]
	[CompilerGenerated]
	private UCurveVector <curve>P = curve;
}
