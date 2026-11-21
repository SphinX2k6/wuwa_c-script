using System;
using System.Runtime.CompilerServices;

// Token: 0x020002D4 RID: 724
[NullableContext(2)]
public interface ISDKPayObject
{
	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x06002A82 RID: 10882
	// (set) Token: 0x06002A83 RID: 10883
	ISDKPayment OrderInfo { get; set; }

	// Token: 0x17000663 RID: 1635
	// (get) Token: 0x06002A84 RID: 10884
	// (set) Token: 0x06002A85 RID: 10885
	ISDKPayRole RoleInfo { get; set; }
}
