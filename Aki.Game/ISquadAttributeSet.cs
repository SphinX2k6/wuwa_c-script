using System;
using Aki.Protocol;

// Token: 0x02002807 RID: 10247
public interface ISquadAttributeSet
{
	// Token: 0x06019CCB RID: 105675
	float GetBaseValue(ESquadAttributeType attrId);

	// Token: 0x06019CCC RID: 105676
	float GetCurrentValue(ESquadAttributeType attrId);
}
