using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F9 RID: 5625
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerAdventureJumpLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F5 RID: 5365
	// (get) Token: 0x0600DE12 RID: 56850 RVA: 0x00417FCC File Offset: 0x004161CC
	// (set) Token: 0x0600DE13 RID: 56851 RVA: 0x00417FD4 File Offset: 0x004161D4
	public override string event_id { get; set; } = "2004";

	// Token: 0x04007E10 RID: 32272
	public int i_roleid_id;

	// Token: 0x04007E11 RID: 32273
	public int i_inst_type;

	// Token: 0x04007E12 RID: 32274
	public int i_inst_id;

	// Token: 0x04007E13 RID: 32275
	public int i_time_left;
}
