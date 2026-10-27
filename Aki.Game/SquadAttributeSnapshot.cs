using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200329E RID: 12958
public class SquadAttributeSnapshot : ISquadAttributeSet
{
	// Token: 0x0601C0B0 RID: 114864 RVA: 0x007CBA7E File Offset: 0x007C9C7E
	public float GetBaseValue(ESquadAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x0601C0B1 RID: 114865 RVA: 0x007CBA88 File Offset: 0x007C9C88
	public float GetCurrentValue(ESquadAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x0400DDA9 RID: 56745
	[Nullable(1)]
	public readonly float[] BaseValues = new float[3];

	// Token: 0x0400DDAA RID: 56746
	[Nullable(1)]
	public readonly float[] CurrentValues = new float[3];
}
