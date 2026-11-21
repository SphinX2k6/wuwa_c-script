using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200164E RID: 5710
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoDurationLogEvent : PlayerCommonLogData
{
	// Token: 0x17001543 RID: 5443
	// (get) Token: 0x0600DF03 RID: 57091 RVA: 0x00418CDC File Offset: 0x00416EDC
	// (set) Token: 0x0600DF04 RID: 57092 RVA: 0x00418CE4 File Offset: 0x00416EE4
	public override string event_id { get; set; } = "1932";

	// Token: 0x04007F94 RID: 32660
	public int i_total_duration;

	// Token: 0x04007F95 RID: 32661
	public int i_add_time;

	// Token: 0x04007F96 RID: 32662
	public List<int> o_team_character = new List<int>();

	// Token: 0x04007F97 RID: 32663
	public List<FightPhotoTeamSkinData> o_team_suit = new List<FightPhotoTeamSkinData>();

	// Token: 0x04007F98 RID: 32664
	public int i_result;

	// Token: 0x04007F99 RID: 32665
	public int i_inst_id;

	// Token: 0x04007F9A RID: 32666
	public int i_inst_diff;

	// Token: 0x04007F9B RID: 32667
	public string s_trace_id = "";
}
