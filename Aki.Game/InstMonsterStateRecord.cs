using System;
using System.Runtime.CompilerServices;

// Token: 0x0200159A RID: 5530
[NullableContext(1)]
[Nullable(0)]
public class InstMonsterStateRecord : MonsterStateRecord
{
	// Token: 0x0600DCFA RID: 56570 RVA: 0x00416C3B File Offset: 0x00414E3B
	public InstMonsterStateRecord(int monsterId, string pbModelConfigId, int inst_id, string fight_id) : base(monsterId, pbModelConfigId)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700149A RID: 5274
	// (get) Token: 0x0600DCFB RID: 56571 RVA: 0x00416C6A File Offset: 0x00414E6A
	// (set) Token: 0x0600DCFC RID: 56572 RVA: 0x00416C72 File Offset: 0x00414E72
	public override string event_id { get; set; } = "102805";

	// Token: 0x04007BF9 RID: 31737
	public int i_inst_id;

	// Token: 0x04007BFA RID: 31738
	public string s_fight_id = "";
}
