using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B1 RID: 5553
[NullableContext(1)]
[Nullable(0)]
public class ScanSkillUseLogData : UnitLogData
{
	// Token: 0x170014AF RID: 5295
	// (get) Token: 0x0600DD3E RID: 56638 RVA: 0x00417386 File Offset: 0x00415586
	// (set) Token: 0x0600DD3F RID: 56639 RVA: 0x0041738E File Offset: 0x0041558E
	public override string event_id { get; set; } = "1014";

	// Token: 0x04007CD9 RID: 31961
	public int i_father_area_id;

	// Token: 0x04007CDA RID: 31962
	public int i_area_id;

	// Token: 0x04007CDB RID: 31963
	public float f_pos_x;

	// Token: 0x04007CDC RID: 31964
	public float f_pos_y;

	// Token: 0x04007CDD RID: 31965
	public float f_pos_z;

	// Token: 0x04007CDE RID: 31966
	public int i_has_target;
}
