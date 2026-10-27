using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000214 RID: 532
public class ConstVectorEvaluator : IVectorParamEvaluator
{
	// Token: 0x060020E0 RID: 8416 RVA: 0x000B640A File Offset: 0x000B460A
	public ConstVectorEvaluator(FVector vec)
	{
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x000B6419 File Offset: 0x000B4619
	public FVector GetValue(float t)
	{
		return this.<vec>P;
	}

	// Token: 0x0400150C RID: 5388
	[CompilerGenerated]
	private FVector <vec>P = vec;
}
