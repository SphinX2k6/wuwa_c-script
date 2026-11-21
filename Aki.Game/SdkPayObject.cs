using System;
using System.Runtime.CompilerServices;

// Token: 0x020002AF RID: 687
[NullableContext(2)]
[Nullable(0)]
public class SdkPayObject : ISDKPayObject
{
	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x060029DA RID: 10714 RVA: 0x00100C2C File Offset: 0x000FEE2C
	// (set) Token: 0x060029DB RID: 10715 RVA: 0x00100C34 File Offset: 0x000FEE34
	public ISDKPayment OrderInfo { get; set; }

	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x060029DC RID: 10716 RVA: 0x00100C3D File Offset: 0x000FEE3D
	// (set) Token: 0x060029DD RID: 10717 RVA: 0x00100C45 File Offset: 0x000FEE45
	public ISDKPayRole RoleInfo { get; set; }
}
