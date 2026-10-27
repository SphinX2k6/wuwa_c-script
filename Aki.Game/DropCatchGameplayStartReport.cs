using System;
using System.Runtime.CompilerServices;

// Token: 0x02002160 RID: 8544
[NullableContext(1)]
[Nullable(0)]
public class DropCatchGameplayStartReport : PlayerCommonLogData
{
	// Token: 0x17001502 RID: 5378
	// (get) Token: 0x06010A54 RID: 68180 RVA: 0x0040C244 File Offset: 0x0040A444
	// (set) Token: 0x06010A55 RID: 68181 RVA: 0x0040C24C File Offset: 0x0040A44C
	public override string event_id { get; set; } = "1848";

	// Token: 0x04007E22 RID: 32290
	public int i_activity_id;

	// Token: 0x04007E23 RID: 32291
	public int i_inst_id;

	// Token: 0x04007E24 RID: 32292
	public int i_first_pass;

	// Token: 0x04007E25 RID: 32293
	public string s_trace_id = "";
}
