using System;
using System.Runtime.CompilerServices;

// Token: 0x020015A7 RID: 5543
[NullableContext(1)]
[Nullable(0)]
public class PlayFlowLogData : PlayerCommonLogData
{
	// Token: 0x170014A6 RID: 5286
	// (get) Token: 0x0600DD1F RID: 56607 RVA: 0x00417146 File Offset: 0x00415346
	// (set) Token: 0x0600DD20 RID: 56608 RVA: 0x0041714E File Offset: 0x0041534E
	public override string event_id { get; set; } = "1010";

	// Token: 0x04007CA7 RID: 31911
	public int i_bubble_type;

	// Token: 0x04007CA8 RID: 31912
	public string s_flow_file = "";

	// Token: 0x04007CA9 RID: 31913
	public int i_flow_id;

	// Token: 0x04007CAA RID: 31914
	public int i_flow_status_id;

	// Token: 0x04007CAB RID: 31915
	public int i_config_id;

	// Token: 0x04007CAC RID: 31916
	public int i_area_id;

	// Token: 0x04007CAD RID: 31917
	public int i_father_area_id;

	// Token: 0x04007CAE RID: 31918
	public float f_pos_x;

	// Token: 0x04007CAF RID: 31919
	public float f_pos_y;

	// Token: 0x04007CB0 RID: 31920
	public float f_pos_z;
}
