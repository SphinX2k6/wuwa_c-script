using System;
using System.Runtime.CompilerServices;

// Token: 0x020020DA RID: 8410
[NullableContext(1)]
[Nullable(0)]
public class ScanSkillUseLogData : UnitLogData
{
	// Token: 0x17001482 RID: 5250
	// (get) Token: 0x060108CE RID: 67790 RVA: 0x0040AC76 File Offset: 0x00408E76
	// (set) Token: 0x060108CF RID: 67791 RVA: 0x0040AC7E File Offset: 0x00408E7E
	public override string event_id { get; set; } = "1014";

	// Token: 0x04007BDA RID: 31706
	public int i_father_area_id;

	// Token: 0x04007BDB RID: 31707
	public int i_area_id;

	// Token: 0x04007BDC RID: 31708
	public float f_pos_x;

	// Token: 0x04007BDD RID: 31709
	public float f_pos_y;

	// Token: 0x04007BDE RID: 31710
	public float f_pos_z;

	// Token: 0x04007BDF RID: 31711
	public int i_has_target;
}
