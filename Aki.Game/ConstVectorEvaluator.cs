using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000218 RID: 536
public class ConstVectorEvaluator : IVectorParamEvaluator
{
	// Token: 0x0600218E RID: 8590 RVA: 0x000BD72A File Offset: 0x000BB92A
	public ConstVectorEvaluator(FVector vec)
	{
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x000BD739 File Offset: 0x000BB939
	public FVector GetValue(float t)
	{
		return this.<vec>P;
	}

	// Token: 0x0400154E RID: 5454
	[CompilerGenerated]
	private FVector <vec>P = vec;
}
