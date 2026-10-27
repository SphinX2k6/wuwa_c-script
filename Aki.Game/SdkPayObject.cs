using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DFC RID: 3580
[NullableContext(2)]
[Nullable(0)]
public class SdkPayObject : ISDKPayObject
{
	// Token: 0x170005FE RID: 1534
	// (get) Token: 0x0600564B RID: 22091 RVA: 0x000F9464 File Offset: 0x000F7664
	// (set) Token: 0x0600564C RID: 22092 RVA: 0x000F946C File Offset: 0x000F766C
	public ISDKPayment OrderInfo { get; set; }

	// Token: 0x170005FF RID: 1535
	// (get) Token: 0x0600564D RID: 22093 RVA: 0x000F9475 File Offset: 0x000F7675
	// (set) Token: 0x0600564E RID: 22094 RVA: 0x000F947D File Offset: 0x000F767D
	public ISDKPayRole RoleInfo { get; set; }
}
