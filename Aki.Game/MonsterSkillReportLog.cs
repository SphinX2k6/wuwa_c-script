using System;
using System.Runtime.CompilerServices;

// Token: 0x020020BC RID: 8380
[NullableContext(1)]
[Nullable(0)]
public class MonsterSkillReportLog : PlayerCommonLogData
{
	// Token: 0x06010877 RID: 67703 RVA: 0x0040A1E0 File Offset: 0x004083E0
	public MonsterSkillReportLog(int monsterId, string pbModelConfigId)
	{
		this.i_monster_id = monsterId;
		this.s_pb_model_config_id = pbModelConfigId;
	}

	// Token: 0x17001468 RID: 5224
	// (get) Token: 0x06010878 RID: 67704 RVA: 0x0040A22D File Offset: 0x0040842D
	// (set) Token: 0x06010879 RID: 67705 RVA: 0x0040A235 File Offset: 0x00408435
	public override string event_id { get; set; } = "102803";

	// Token: 0x04007ABF RID: 31423
	public string s_battle_id = "";

	// Token: 0x04007AC0 RID: 31424
	public int i_monster_id;

	// Token: 0x04007AC1 RID: 31425
	public int i_monster_level;

	// Token: 0x04007AC2 RID: 31426
	public string s_pb_model_config_id = "";

	// Token: 0x04007AC3 RID: 31427
	public string s_reports = "";
}
