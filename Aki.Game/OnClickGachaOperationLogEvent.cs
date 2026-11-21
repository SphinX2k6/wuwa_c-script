using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C4 RID: 5572
[NullableContext(1)]
[Nullable(0)]
public class OnClickGachaOperationLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C0 RID: 5312
	// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x00417647 File Offset: 0x00415847
	// (set) Token: 0x0600DD74 RID: 56692 RVA: 0x0041764F File Offset: 0x0041584F
	public override string event_id { get; set; } = "1823";

	// Token: 0x04007D27 RID: 32039
	public int i_gacha_id;

	// Token: 0x04007D28 RID: 32040
	public int i_operation_type;
}
