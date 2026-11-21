using System;
using System.Runtime.CompilerServices;

// Token: 0x020015BD RID: 5565
[NullableContext(1)]
[Nullable(0)]
public class StartSdkPayEvent : PlayerCommonLogData
{
	// Token: 0x170014B9 RID: 5305
	// (get) Token: 0x0600DD5E RID: 56670 RVA: 0x004174FE File Offset: 0x004156FE
	// (set) Token: 0x0600DD5F RID: 56671 RVA: 0x00417506 File Offset: 0x00415706
	public override string event_id { get; set; } = "1040";

	// Token: 0x04007D15 RID: 32021
	public string s_sdk_pay_order = "";

	// Token: 0x04007D16 RID: 32022
	public string s_sdk_callback_url = "";
}
