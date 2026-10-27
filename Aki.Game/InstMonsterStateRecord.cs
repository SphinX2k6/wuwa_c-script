using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C3 RID: 8387
[NullableContext(1)]
[Nullable(0)]
public class InstMonsterStateRecord : MonsterStateRecord
{
	// Token: 0x0601088A RID: 67722 RVA: 0x0040A533 File Offset: 0x00408733
	public InstMonsterStateRecord(int monsterId, string pbModelConfigId, int inst_id, string fight_id) : base(monsterId, pbModelConfigId)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700146D RID: 5229
	// (get) Token: 0x0601088B RID: 67723 RVA: 0x0040A562 File Offset: 0x00408762
	// (set) Token: 0x0601088C RID: 67724 RVA: 0x0040A56A File Offset: 0x0040876A
	public override string event_id { get; set; } = "102805";

	// Token: 0x04007AFB RID: 31483
	public int i_inst_id;

	// Token: 0x04007AFC RID: 31484
	public string s_fight_id = "";
}
