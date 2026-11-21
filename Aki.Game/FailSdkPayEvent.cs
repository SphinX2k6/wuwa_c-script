using System;
using System.Runtime.CompilerServices;

// Token: 0x020015BF RID: 5567
[NullableContext(1)]
[Nullable(0)]
public class FailSdkPayEvent : PlayerCommonLogData
{
	// Token: 0x170014BB RID: 5307
	// (get) Token: 0x0600DD64 RID: 56676 RVA: 0x00417567 File Offset: 0x00415767
	// (set) Token: 0x0600DD65 RID: 56677 RVA: 0x0041756F File Offset: 0x0041576F
	public override string event_id { get; set; } = "1042";

	// Token: 0x04007D1A RID: 32026
	public string s_sdk_pay_order = "";

	// Token: 0x04007D1B RID: 32027
	public string s_reason = "";
}
