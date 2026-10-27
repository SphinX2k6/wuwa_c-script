using System;
using System.Runtime.CompilerServices;

// Token: 0x020020DB RID: 8411
[NullableContext(1)]
[Nullable(0)]
public class FollowShooterUseLogData : UnitLogData
{
	// Token: 0x17001483 RID: 5251
	// (get) Token: 0x060108D1 RID: 67793 RVA: 0x0040AC9A File Offset: 0x00408E9A
	// (set) Token: 0x060108D2 RID: 67794 RVA: 0x0040ACA2 File Offset: 0x00408EA2
	public override string event_id { get; set; } = "1025";

	// Token: 0x04007BE1 RID: 31713
	public int i_father_area_id;

	// Token: 0x04007BE2 RID: 31714
	public int i_area_id;

	// Token: 0x04007BE3 RID: 31715
	public double f_pos_x;

	// Token: 0x04007BE4 RID: 31716
	public double f_pos_y;

	// Token: 0x04007BE5 RID: 31717
	public double f_pos_z;

	// Token: 0x04007BE6 RID: 31718
	public int i_has_target;
}
