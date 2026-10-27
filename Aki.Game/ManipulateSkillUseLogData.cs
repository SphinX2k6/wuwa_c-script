using System;
using System.Runtime.CompilerServices;

// Token: 0x020020D9 RID: 8409
[NullableContext(1)]
[Nullable(0)]
public class ManipulateSkillUseLogData : UnitLogData
{
	// Token: 0x17001481 RID: 5249
	// (get) Token: 0x060108CB RID: 67787 RVA: 0x0040AC52 File Offset: 0x00408E52
	// (set) Token: 0x060108CC RID: 67788 RVA: 0x0040AC5A File Offset: 0x00408E5A
	public override string event_id { get; set; } = "1013";

	// Token: 0x04007BD3 RID: 31699
	public int i_father_area_id;

	// Token: 0x04007BD4 RID: 31700
	public int i_area_id;

	// Token: 0x04007BD5 RID: 31701
	public float f_pos_x;

	// Token: 0x04007BD6 RID: 31702
	public float f_pos_y;

	// Token: 0x04007BD7 RID: 31703
	public float f_pos_z;

	// Token: 0x04007BD8 RID: 31704
	public int i_has_target;
}
