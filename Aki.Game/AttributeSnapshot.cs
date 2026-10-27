using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002E5F RID: 11871
public class AttributeSnapshot : IAttributeSet
{
	// Token: 0x060194FA RID: 103674 RVA: 0x00682F12 File Offset: 0x00681112
	public float GetBaseValue(EAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x060194FB RID: 103675 RVA: 0x00682F1C File Offset: 0x0068111C
	public float GetCurrentValue(EAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x0400BC30 RID: 48176
	[Nullable(1)]
	public readonly float[] BaseValues = new float[143];

	// Token: 0x0400BC31 RID: 48177
	[Nullable(1)]
	public readonly float[] CurrentValues = new float[143];
}
