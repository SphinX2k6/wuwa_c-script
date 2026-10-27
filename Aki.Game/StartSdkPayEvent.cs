using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E6 RID: 8422
[NullableContext(1)]
[Nullable(0)]
public class StartSdkPayEvent : PlayerCommonLogData
{
	// Token: 0x1700148C RID: 5260
	// (get) Token: 0x060108EE RID: 67822 RVA: 0x0040ADEE File Offset: 0x00408FEE
	// (set) Token: 0x060108EF RID: 67823 RVA: 0x0040ADF6 File Offset: 0x00408FF6
	public override string event_id { get; set; } = "1040";

	// Token: 0x04007C16 RID: 31766
	public string s_sdk_pay_order = "";

	// Token: 0x04007C17 RID: 31767
	public string s_sdk_callback_url = "";
}
