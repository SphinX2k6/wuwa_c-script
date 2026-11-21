using System;
using System.Runtime.CompilerServices;

// Token: 0x0200161E RID: 5662
[NullableContext(1)]
[Nullable(0)]
public class OnJumpInShortMessageLogEvent : PlayerCommonLogData
{
	// Token: 0x17001519 RID: 5401
	// (get) Token: 0x0600DE7F RID: 56959 RVA: 0x0041859F File Offset: 0x0041679F
	// (set) Token: 0x0600DE80 RID: 56960 RVA: 0x004185A7 File Offset: 0x004167A7
	public override string event_id { get; set; } = "1817";

	// Token: 0x04007EA9 RID: 32425
	public int i_id;

	// Token: 0x04007EAA RID: 32426
	public int i_type;

	// Token: 0x04007EAB RID: 32427
	public int i_role_id;

	// Token: 0x04007EAC RID: 32428
	public long l_received_time;

	// Token: 0x04007EAD RID: 32429
	public int i_trigger_type;

	// Token: 0x04007EAE RID: 32430
	public int i_config_id;
}
