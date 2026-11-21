using System;
using System.Runtime.CompilerServices;

// Token: 0x0200161D RID: 5661
[NullableContext(1)]
[Nullable(0)]
public class OnSelectShortMessageLogEvent : PlayerCommonLogData
{
	// Token: 0x17001518 RID: 5400
	// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x0041857B File Offset: 0x0041677B
	// (set) Token: 0x0600DE7D RID: 56957 RVA: 0x00418583 File Offset: 0x00416783
	public override string event_id { get; set; } = "1816";

	// Token: 0x04007EA3 RID: 32419
	public int i_id;

	// Token: 0x04007EA4 RID: 32420
	public int i_type;

	// Token: 0x04007EA5 RID: 32421
	public int i_reason;

	// Token: 0x04007EA6 RID: 32422
	public long l_received_time;

	// Token: 0x04007EA7 RID: 32423
	public int i_role_id;
}
