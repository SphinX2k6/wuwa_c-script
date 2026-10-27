using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C6 RID: 8390
[NullableContext(1)]
[Nullable(0)]
public class InstMonsterSkillReportLog : MonsterSkillReportLog
{
	// Token: 0x06010893 RID: 67731 RVA: 0x0040A5ED File Offset: 0x004087ED
	public InstMonsterSkillReportLog(int monsterId, string pbModelConfigId, int inst_id, string fight_id) : base(monsterId, pbModelConfigId)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x17001470 RID: 5232
	// (get) Token: 0x06010894 RID: 67732 RVA: 0x0040A61C File Offset: 0x0040881C
	// (set) Token: 0x06010895 RID: 67733 RVA: 0x0040A624 File Offset: 0x00408824
	public override string event_id { get; set; } = "102808";

	// Token: 0x04007B04 RID: 31492
	public int i_inst_id;

	// Token: 0x04007B05 RID: 31493
	public string s_fight_id = "";
}
