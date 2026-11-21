using System;
using System.Runtime.CompilerServices;

// Token: 0x0200159D RID: 5533
[NullableContext(1)]
[Nullable(0)]
public class InstMonsterSkillReportLog : MonsterSkillReportLog
{
	// Token: 0x0600DD03 RID: 56579 RVA: 0x00416CF5 File Offset: 0x00414EF5
	public InstMonsterSkillReportLog(int monsterId, string pbModelConfigId, int inst_id, string fight_id) : base(monsterId, pbModelConfigId)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700149D RID: 5277
	// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x00416D24 File Offset: 0x00414F24
	// (set) Token: 0x0600DD05 RID: 56581 RVA: 0x00416D2C File Offset: 0x00414F2C
	public override string event_id { get; set; } = "102808";

	// Token: 0x04007C02 RID: 31746
	public int i_inst_id;

	// Token: 0x04007C03 RID: 31747
	public string s_fight_id = "";
}
