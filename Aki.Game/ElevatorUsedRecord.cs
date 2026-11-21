using System;
using System.Runtime.CompilerServices;

// Token: 0x0200159F RID: 5535
[NullableContext(1)]
[Nullable(0)]
public class ElevatorUsedRecord : PlayerCommonLogData
{
	// Token: 0x1700149F RID: 5279
	// (get) Token: 0x0600DD09 RID: 56585 RVA: 0x00416DB3 File Offset: 0x00414FB3
	// (set) Token: 0x0600DD0A RID: 56586 RVA: 0x00416DBB File Offset: 0x00414FBB
	public override string event_id { get; set; } = "11";

	// Token: 0x04007C0D RID: 31757
	public string i_area_id = "";

	// Token: 0x04007C0E RID: 31758
	public string i_config_id = "";

	// Token: 0x04007C0F RID: 31759
	public string i_state_id = "";

	// Token: 0x04007C10 RID: 31760
	public string f_player_pos_x = "";

	// Token: 0x04007C11 RID: 31761
	public string f_player_pos_y = "";

	// Token: 0x04007C12 RID: 31762
	public string f_player_pos_z = "";
}
