using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200163E RID: 5694
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingEndEvent : PlayerCommonLogData
{
	// Token: 0x17001536 RID: 5430
	// (get) Token: 0x0600DED9 RID: 57049 RVA: 0x00418A85 File Offset: 0x00416C85
	// (set) Token: 0x0600DEDA RID: 57050 RVA: 0x00418A8D File Offset: 0x00416C8D
	public override string event_id { get; set; } = "1922";

	// Token: 0x04007F52 RID: 32594
	public int i_id;

	// Token: 0x04007F53 RID: 32595
	public int i_first_pass;

	// Token: 0x04007F54 RID: 32596
	public int i_result;

	// Token: 0x04007F55 RID: 32597
	public int i_pass_time;

	// Token: 0x04007F56 RID: 32598
	public int i_total_duration;

	// Token: 0x04007F57 RID: 32599
	public string s_trace_id = "";

	// Token: 0x04007F58 RID: 32600
	[Nullable(2)]
	public List<int> o_path;

	// Token: 0x04007F59 RID: 32601
	public int i_count;

	// Token: 0x04007F5A RID: 32602
	public int i_recount;

	// Token: 0x04007F5B RID: 32603
	public int i_false_count;
}
