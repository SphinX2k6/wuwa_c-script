using System;
using System.Runtime.CompilerServices;

// Token: 0x020020D8 RID: 8408
[NullableContext(1)]
[Nullable(0)]
public class HookSkillUseLogData : UnitLogData
{
	// Token: 0x17001480 RID: 5248
	// (get) Token: 0x060108C8 RID: 67784 RVA: 0x0040AC2E File Offset: 0x00408E2E
	// (set) Token: 0x060108C9 RID: 67785 RVA: 0x0040AC36 File Offset: 0x00408E36
	public override string event_id { get; set; } = "1012";

	// Token: 0x04007BCC RID: 31692
	public int i_father_area_id;

	// Token: 0x04007BCD RID: 31693
	public int i_area_id;

	// Token: 0x04007BCE RID: 31694
	public float f_pos_x;

	// Token: 0x04007BCF RID: 31695
	public float f_pos_y;

	// Token: 0x04007BD0 RID: 31696
	public float f_pos_z;

	// Token: 0x04007BD1 RID: 31697
	public int i_has_target;
}
