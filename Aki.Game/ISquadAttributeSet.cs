using System;
using Aki.Protocol;

// Token: 0x02003296 RID: 12950
public interface ISquadAttributeSet
{
	// Token: 0x0601C09D RID: 114845
	float GetBaseValue(ESquadAttributeType attrId);

	// Token: 0x0601C09E RID: 114846
	float GetCurrentValue(ESquadAttributeType attrId);
}
