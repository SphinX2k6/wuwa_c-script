using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C8 RID: 8392
[NullableContext(1)]
[Nullable(0)]
public class ElevatorUsedRecord : PlayerCommonLogData
{
	// Token: 0x17001472 RID: 5234
	// (get) Token: 0x06010899 RID: 67737 RVA: 0x0040A6AB File Offset: 0x004088AB
	// (set) Token: 0x0601089A RID: 67738 RVA: 0x0040A6B3 File Offset: 0x004088B3
	public override string event_id { get; set; } = "11";

	// Token: 0x04007B0F RID: 31503
	public string i_area_id = "";

	// Token: 0x04007B10 RID: 31504
	public string i_config_id = "";

	// Token: 0x04007B11 RID: 31505
	public string i_state_id = "";

	// Token: 0x04007B12 RID: 31506
	public string f_player_pos_x = "";

	// Token: 0x04007B13 RID: 31507
	public string f_player_pos_y = "";

	// Token: 0x04007B14 RID: 31508
	public string f_player_pos_z = "";
}
