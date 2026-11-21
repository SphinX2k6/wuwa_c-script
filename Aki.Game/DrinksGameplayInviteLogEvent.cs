using System;
using System.Runtime.CompilerServices;

// Token: 0x02001626 RID: 5670
[NullableContext(1)]
[Nullable(0)]
public class DrinksGameplayInviteLogEvent : PlayerCommonLogData
{
	// Token: 0x17001521 RID: 5409
	// (get) Token: 0x0600DE97 RID: 56983 RVA: 0x004186E0 File Offset: 0x004168E0
	// (set) Token: 0x0600DE98 RID: 56984 RVA: 0x004186E8 File Offset: 0x004168E8
	public override string event_id { get; set; } = "1833";

	// Token: 0x04007ED5 RID: 32469
	public int i_activity_id;

	// Token: 0x04007ED6 RID: 32470
	public int i_role_id;

	// Token: 0x04007ED7 RID: 32471
	public int i_inst_id;

	// Token: 0x04007ED8 RID: 32472
	public int i_first_pass;

	// Token: 0x04007ED9 RID: 32473
	public string s_trace_id = "";
}
