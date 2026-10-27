using System;
using System.Runtime.CompilerServices;

// Token: 0x02002380 RID: 9088
public abstract class PayShopExtraTagItem : PayShopTagItem
{
	// Token: 0x06012299 RID: 74393
	[NullableContext(1)]
	public abstract void Refresh(IPayShopUnionData data);
}
