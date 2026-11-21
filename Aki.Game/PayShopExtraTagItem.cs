using System;
using System.Runtime.CompilerServices;

// Token: 0x02001865 RID: 6245
public abstract class PayShopExtraTagItem : PayShopTagItem
{
	// Token: 0x0600F749 RID: 63305
	[NullableContext(1)]
	public abstract void Refresh(IPayShopUnionData data);
}
