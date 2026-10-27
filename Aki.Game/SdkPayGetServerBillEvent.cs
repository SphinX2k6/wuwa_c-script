using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E9 RID: 8425
[NullableContext(1)]
[Nullable(0)]
public class SdkPayGetServerBillEvent : PlayerCommonLogData
{
	// Token: 0x1700148F RID: 5263
	// (get) Token: 0x060108F7 RID: 67831 RVA: 0x0040AE91 File Offset: 0x00409091
	// (set) Token: 0x060108F8 RID: 67832 RVA: 0x0040AE99 File Offset: 0x00409099
	public override string event_id { get; set; } = "1043";

	// Token: 0x04007C1E RID: 31774
	public string s_sdk_pay_order = "";
}
