using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000216 RID: 534
[NullableContext(1)]
[Nullable(0)]
public class CurveFloatEvaluator : IModifyParamEvaluator
{
	// Token: 0x0600218B RID: 8587 RVA: 0x000BD6C1 File Offset: 0x000BB8C1
	public CurveFloatEvaluator(UCurveVector curve, string axis)
	{
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x000BD6D8 File Offset: 0x000BB8D8
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

	// Token: 0x0400154C RID: 5452
	[CompilerGenerated]
	private UCurveVector <curve>P = curve;

	// Token: 0x0400154D RID: 5453
	[CompilerGenerated]
	private string <axis>P = axis;
}
