using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E20 RID: 3616
[NullableContext(2)]
public interface ISDKPayObject
{
	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x060056F2 RID: 22258
	// (set) Token: 0x060056F3 RID: 22259
	ISDKPayment OrderInfo { get; set; }

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x060056F4 RID: 22260
	// (set) Token: 0x060056F5 RID: 22261
	ISDKPayRole RoleInfo { get; set; }
}
