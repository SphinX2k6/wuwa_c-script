using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C0 RID: 5568
[NullableContext(1)]
[Nullable(0)]
public class SdkPayGetServerBillEvent : PlayerCommonLogData
{
	// Token: 0x170014BC RID: 5308
	// (get) Token: 0x0600DD67 RID: 56679 RVA: 0x004175A1 File Offset: 0x004157A1
	// (set) Token: 0x0600DD68 RID: 56680 RVA: 0x004175A9 File Offset: 0x004157A9
	public override string event_id { get; set; } = "1043";

	// Token: 0x04007D1D RID: 32029
	public string s_sdk_pay_order = "";
}
