using System;
using System.Runtime.CompilerServices;

// Token: 0x02000211 RID: 529
public class ConstEvaluator : IModifyParamEvaluator
{
	// Token: 0x060020DB RID: 8411 RVA: 0x000B638A File Offset: 0x000B458A
	public ConstEvaluator(float value)
	{
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x000B6399 File Offset: 0x000B4599
	public float GetValue(float t)
	{
		return this.<value>P;
	}

	// Token: 0x04001509 RID: 5385
	[CompilerGenerated]
	private float <value>P = value;
}
