using System;
using System.Runtime.CompilerServices;

// Token: 0x0200159E RID: 5534
[NullableContext(1)]
[Nullable(0)]
public class TriggerBuffDamageRecord : PlayerCommonLogData
{
	// Token: 0x1700149E RID: 5278
	// (get) Token: 0x0600DD06 RID: 56582 RVA: 0x00416D35 File Offset: 0x00414F35
	// (set) Token: 0x0600DD07 RID: 56583 RVA: 0x00416D3D File Offset: 0x00414F3D
	public override string event_id { get; set; } = "6";

	// Token: 0x04007C05 RID: 31749
	public string i_area_id = "";

	// Token: 0x04007C06 RID: 31750
	public string s_buff_id = "";

	// Token: 0x04007C07 RID: 31751
	public string f_time = "";

	// Token: 0x04007C08 RID: 31752
	public string f_player_pos_x = "";

	// Token: 0x04007C09 RID: 31753
	public string f_player_pos_y = "";

	// Token: 0x04007C0A RID: 31754
	public string f_player_pos_z = "";

	// Token: 0x04007C0B RID: 31755
	public string i_damage = "";
}
