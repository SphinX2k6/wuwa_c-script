using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200280F RID: 10255
public class SquadAttributeSnapshot : ISquadAttributeSet
{
	// Token: 0x06019CDE RID: 105694 RVA: 0x007F2D3E File Offset: 0x007F0F3E
	public float GetBaseValue(ESquadAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x06019CDF RID: 105695 RVA: 0x007F2D48 File Offset: 0x007F0F48
	public float GetCurrentValue(ESquadAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x0400E250 RID: 57936
	[Nullable(1)]
	public readonly float[] BaseValues = new float[3];

	// Token: 0x0400E251 RID: 57937
	[Nullable(1)]
	public readonly float[] CurrentValues = new float[3];
}
