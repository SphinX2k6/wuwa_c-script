using System;
using System.Runtime.CompilerServices;

// Token: 0x02000215 RID: 533
public class ConstEvaluator : IModifyParamEvaluator
{
	// Token: 0x06002189 RID: 8585 RVA: 0x000BD6AA File Offset: 0x000BB8AA
	public ConstEvaluator(float value)
	{
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x000BD6B9 File Offset: 0x000BB8B9
	public float GetValue(float t)
	{
		return this.<value>P;
	}

	// Token: 0x0400154B RID: 5451
	[CompilerGenerated]
	private float <value>P = value;
}
