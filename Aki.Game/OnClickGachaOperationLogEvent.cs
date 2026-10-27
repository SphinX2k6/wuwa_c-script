using System;
using System.Runtime.CompilerServices;

// Token: 0x020020ED RID: 8429
[NullableContext(1)]
[Nullable(0)]
public class OnClickGachaOperationLogEvent : PlayerCommonLogData
{
	// Token: 0x17001493 RID: 5267
	// (get) Token: 0x06010903 RID: 67843 RVA: 0x0040AF37 File Offset: 0x00409137
	// (set) Token: 0x06010904 RID: 67844 RVA: 0x0040AF3F File Offset: 0x0040913F
	public override string event_id { get; set; } = "1823";

	// Token: 0x04007C28 RID: 31784
	public int i_gacha_id;

	// Token: 0x04007C29 RID: 31785
	public int i_operation_type;
}
