using System;
using System.Runtime.CompilerServices;

// Token: 0x020015AF RID: 5551
[NullableContext(1)]
[Nullable(0)]
public class HookSkillUseLogData : UnitLogData
{
	// Token: 0x170014AD RID: 5293
	// (get) Token: 0x0600DD38 RID: 56632 RVA: 0x0041733E File Offset: 0x0041553E
	// (set) Token: 0x0600DD39 RID: 56633 RVA: 0x00417346 File Offset: 0x00415546
	public override string event_id { get; set; } = "1012";

	// Token: 0x04007CCB RID: 31947
	public int i_father_area_id;

	// Token: 0x04007CCC RID: 31948
	public int i_area_id;

	// Token: 0x04007CCD RID: 31949
	public float f_pos_x;

	// Token: 0x04007CCE RID: 31950
	public float f_pos_y;

	// Token: 0x04007CCF RID: 31951
	public float f_pos_z;

	// Token: 0x04007CD0 RID: 31952
	public int i_has_target;
}
