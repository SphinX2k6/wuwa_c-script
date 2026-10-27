using System;
using System.Runtime.CompilerServices;

// Token: 0x020020DC RID: 8412
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolGeneralUseLogData : UnitLogData
{
	// Token: 0x17001484 RID: 5252
	// (get) Token: 0x060108D4 RID: 67796 RVA: 0x0040ACBE File Offset: 0x00408EBE
	// (set) Token: 0x060108D5 RID: 67797 RVA: 0x0040ACC6 File Offset: 0x00408EC6
	public override string event_id { get; set; } = "";

	// Token: 0x04007BE8 RID: 31720
	public int i_father_area_id;

	// Token: 0x04007BE9 RID: 31721
	public int i_area_id;

	// Token: 0x04007BEA RID: 31722
	public float f_pos_x;

	// Token: 0x04007BEB RID: 31723
	public float f_pos_y;

	// Token: 0x04007BEC RID: 31724
	public float f_pos_z;

	// Token: 0x04007BED RID: 31725
	public int i_skill_id;

	// Token: 0x04007BEE RID: 31726
	public int i_entity_configId;
}
