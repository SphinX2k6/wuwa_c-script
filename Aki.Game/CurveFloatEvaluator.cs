using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000212 RID: 530
[NullableContext(1)]
[Nullable(0)]
public class CurveFloatEvaluator : IModifyParamEvaluator
{
	// Token: 0x060020DD RID: 8413 RVA: 0x000B63A1 File Offset: 0x000B45A1
	public CurveFloatEvaluator(UCurveVector curve, string axis)
	{
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x000B63B8 File Offset: 0x000B45B8
	public float GetValue(float t)
	{
		FVector vectorValue = this.<curve>P.GetVectorValue(t);
		if (this.<axis>P == "X")
		{
			return vectorValue.X;
		}
		if (!(this.<axis>P == "Y"))
		{
			return vectorValue.Z;
		}
		return vectorValue.Y;
	}

	// Token: 0x0400150A RID: 5386
	[CompilerGenerated]
	private UCurveVector <curve>P = curve;

	// Token: 0x0400150B RID: 5387
	[CompilerGenerated]
	private string <axis>P = axis;
}
