using System;
using System.Runtime.CompilerServices;

// Token: 0x0200161C RID: 5660
[NullableContext(1)]
[Nullable(0)]
public class OnOpenPhoneViewLogEvent : PlayerCommonLogData
{
	// Token: 0x17001517 RID: 5399
	// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x00418557 File Offset: 0x00416757
	// (set) Token: 0x0600DE7A RID: 56954 RVA: 0x0041855F File Offset: 0x0041675F
	public override string event_id { get; set; } = "1815";

	// Token: 0x04007EA0 RID: 32416
	public int i_open_way;

	// Token: 0x04007EA1 RID: 32417
	public int i_reason;
}
