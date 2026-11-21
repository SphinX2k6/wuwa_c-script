using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B0 RID: 5552
[NullableContext(1)]
[Nullable(0)]
public class ManipulateSkillUseLogData : UnitLogData
{
	// Token: 0x170014AE RID: 5294
	// (get) Token: 0x0600DD3B RID: 56635 RVA: 0x00417362 File Offset: 0x00415562
	// (set) Token: 0x0600DD3C RID: 56636 RVA: 0x0041736A File Offset: 0x0041556A
	public override string event_id { get; set; } = "1013";

	// Token: 0x04007CD2 RID: 31954
	public int i_father_area_id;

	// Token: 0x04007CD3 RID: 31955
	public int i_area_id;

	// Token: 0x04007CD4 RID: 31956
	public float f_pos_x;

	// Token: 0x04007CD5 RID: 31957
	public float f_pos_y;

	// Token: 0x04007CD6 RID: 31958
	public float f_pos_z;

	// Token: 0x04007CD7 RID: 31959
	public int i_has_target;
}
