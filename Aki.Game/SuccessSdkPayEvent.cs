using System;
using System.Runtime.CompilerServices;

// Token: 0x020015BE RID: 5566
[NullableContext(1)]
[Nullable(0)]
public class SuccessSdkPayEvent : PlayerCommonLogData
{
	// Token: 0x170014BA RID: 5306
	// (get) Token: 0x0600DD61 RID: 56673 RVA: 0x00417538 File Offset: 0x00415738
	// (set) Token: 0x0600DD62 RID: 56674 RVA: 0x00417540 File Offset: 0x00415740
	public override string event_id { get; set; } = "1041";

	// Token: 0x04007D18 RID: 32024
	public string s_sdk_pay_order = "";
}
