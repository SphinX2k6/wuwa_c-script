using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E7 RID: 8423
[NullableContext(1)]
[Nullable(0)]
public class SuccessSdkPayEvent : PlayerCommonLogData
{
	// Token: 0x1700148D RID: 5261
	// (get) Token: 0x060108F1 RID: 67825 RVA: 0x0040AE28 File Offset: 0x00409028
	// (set) Token: 0x060108F2 RID: 67826 RVA: 0x0040AE30 File Offset: 0x00409030
	public override string event_id { get; set; } = "1041";

	// Token: 0x04007C19 RID: 31769
	public string s_sdk_pay_order = "";
}
