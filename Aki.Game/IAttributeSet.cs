using System;
using Aki.Protocol;

// Token: 0x02002EA4 RID: 11940
public interface IAttributeSet
{
	// Token: 0x060197FB RID: 104443
	float GetBaseValue(EAttributeType attrId);

	// Token: 0x060197FC RID: 104444
	float GetCurrentValue(EAttributeType attrId);
}
