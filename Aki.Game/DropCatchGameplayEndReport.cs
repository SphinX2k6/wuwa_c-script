using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002161 RID: 8545
[NullableContext(1)]
[Nullable(0)]
public class DropCatchGameplayEndReport : PlayerCommonLogData
{
	// Token: 0x17001503 RID: 5379
	// (get) Token: 0x06010A57 RID: 68183 RVA: 0x0040C273 File Offset: 0x0040A473
	// (set) Token: 0x06010A58 RID: 68184 RVA: 0x0040C27B File Offset: 0x0040A47B
	public override string event_id { get; set; } = "1849";

	// Token: 0x04007E27 RID: 32295
	public int i_activity_id;

	// Token: 0x04007E28 RID: 32296
	public int i_inst_id;

	// Token: 0x04007E29 RID: 32297
	public int i_first_pass;

	// Token: 0x04007E2A RID: 32298
	public string s_trace_id = "";

	// Token: 0x04007E2B RID: 32299
	public int i_result;

	// Token: 0x04007E2C RID: 32300
	public int i_reason;

	// Token: 0x04007E2D RID: 32301
	public int i_get_score;

	// Token: 0x04007E2E RID: 32302
	public int i_skill_times;

	// Token: 0x04007E2F RID: 32303
	public int i_cost_time;

	// Token: 0x04007E30 RID: 32304
	public int i_add_time;

	// Token: 0x04007E31 RID: 32305
	[Nullable(2)]
	public List<int> o_item_report;
}
