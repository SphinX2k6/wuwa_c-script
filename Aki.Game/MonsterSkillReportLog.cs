using System;
using System.Runtime.CompilerServices;

// Token: 0x02001593 RID: 5523
[NullableContext(1)]
[Nullable(0)]
public class MonsterSkillReportLog : PlayerCommonLogData
{
	// Token: 0x0600DCE7 RID: 56551 RVA: 0x004168E8 File Offset: 0x00414AE8
	public MonsterSkillReportLog(int monsterId, string pbModelConfigId)
	{
		this.i_monster_id = monsterId;
		this.s_pb_model_config_id = pbModelConfigId;
	}

	// Token: 0x17001495 RID: 5269
	// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x00416935 File Offset: 0x00414B35
	// (set) Token: 0x0600DCE9 RID: 56553 RVA: 0x0041693D File Offset: 0x00414B3D
	public override string event_id { get; set; } = "102803";

	// Token: 0x04007BBD RID: 31677
	public string s_battle_id = "";

	// Token: 0x04007BBE RID: 31678
	public int i_monster_id;

	// Token: 0x04007BBF RID: 31679
	public int i_monster_level;

	// Token: 0x04007BC0 RID: 31680
	public string s_pb_model_config_id = "";

	// Token: 0x04007BC1 RID: 31681
	public string s_reports = "";
}
