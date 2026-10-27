using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C7 RID: 8391
[NullableContext(1)]
[Nullable(0)]
public class TriggerBuffDamageRecord : PlayerCommonLogData
{
	// Token: 0x17001471 RID: 5233
	// (get) Token: 0x06010896 RID: 67734 RVA: 0x0040A62D File Offset: 0x0040882D
	// (set) Token: 0x06010897 RID: 67735 RVA: 0x0040A635 File Offset: 0x00408835
	public override string event_id { get; set; } = "6";

	// Token: 0x04007B07 RID: 31495
	public string i_area_id = "";

	// Token: 0x04007B08 RID: 31496
	public string s_buff_id = "";

	// Token: 0x04007B09 RID: 31497
	public string f_time = "";

	// Token: 0x04007B0A RID: 31498
	public string f_player_pos_x = "";

	// Token: 0x04007B0B RID: 31499
	public string f_player_pos_y = "";

	// Token: 0x04007B0C RID: 31500
	public string f_player_pos_z = "";

	// Token: 0x04007B0D RID: 31501
	public string i_damage = "";
}
