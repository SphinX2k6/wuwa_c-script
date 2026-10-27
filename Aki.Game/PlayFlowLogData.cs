using System;
using System.Runtime.CompilerServices;

// Token: 0x020020D0 RID: 8400
[NullableContext(1)]
[Nullable(0)]
public class PlayFlowLogData : PlayerCommonLogData
{
	// Token: 0x17001479 RID: 5241
	// (get) Token: 0x060108AF RID: 67759 RVA: 0x0040AA33 File Offset: 0x00408C33
	// (set) Token: 0x060108B0 RID: 67760 RVA: 0x0040AA3B File Offset: 0x00408C3B
	public override string event_id { get; set; } = "1010";

	// Token: 0x04007BA8 RID: 31656
	public int i_bubble_type;

	// Token: 0x04007BA9 RID: 31657
	public string s_flow_file = "";

	// Token: 0x04007BAA RID: 31658
	public int i_flow_id;

	// Token: 0x04007BAB RID: 31659
	public int i_flow_status_id;

	// Token: 0x04007BAC RID: 31660
	public int i_config_id;

	// Token: 0x04007BAD RID: 31661
	public int i_area_id;

	// Token: 0x04007BAE RID: 31662
	public int i_father_area_id;

	// Token: 0x04007BAF RID: 31663
	public float f_pos_x;

	// Token: 0x04007BB0 RID: 31664
	public float f_pos_y;

	// Token: 0x04007BB1 RID: 31665
	public float f_pos_z;
}
