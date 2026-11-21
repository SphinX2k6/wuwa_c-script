using System;
using Aki.Protocol;

// Token: 0x020023F7 RID: 9207
public interface IAttributeSet
{
	// Token: 0x060170DB RID: 94427
	float GetBaseValue(EAttributeType attrId);

	// Token: 0x060170DC RID: 94428
	float GetCurrentValue(EAttributeType attrId);
}
