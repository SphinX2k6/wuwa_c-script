using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002176 RID: 8566
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoDurationLogEvent : PlayerCommonLogData
{
	// Token: 0x17001515 RID: 5397
	// (get) Token: 0x06010A90 RID: 68240 RVA: 0x0040C594 File Offset: 0x0040A794
	// (set) Token: 0x06010A91 RID: 68241 RVA: 0x0040C59C File Offset: 0x0040A79C
	public override string event_id { get; set; } = "1932";

	// Token: 0x04007E84 RID: 32388
	public int i_total_duration;

	// Token: 0x04007E85 RID: 32389
	public int i_add_time;

	// Token: 0x04007E86 RID: 32390
	public List<int> o_team_character = new List<int>();

	// Token: 0x04007E87 RID: 32391
	public List<FightPhotoTeamSkinData> o_team_suit = new List<FightPhotoTeamSkinData>();

	// Token: 0x04007E88 RID: 32392
	public int i_result;

	// Token: 0x04007E89 RID: 32393
	public int i_inst_id;

	// Token: 0x04007E8A RID: 32394
	public int i_inst_diff;

	// Token: 0x04007E8B RID: 32395
	public string s_trace_id = "";
}
