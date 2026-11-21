using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B2 RID: 5554
[NullableContext(1)]
[Nullable(0)]
public class FollowShooterUseLogData : UnitLogData
{
	// Token: 0x170014B0 RID: 5296
	// (get) Token: 0x0600DD41 RID: 56641 RVA: 0x004173AA File Offset: 0x004155AA
	// (set) Token: 0x0600DD42 RID: 56642 RVA: 0x004173B2 File Offset: 0x004155B2
	public override string event_id { get; set; } = "1025";

	// Token: 0x04007CE0 RID: 31968
	public int i_father_area_id;

	// Token: 0x04007CE1 RID: 31969
	public int i_area_id;

	// Token: 0x04007CE2 RID: 31970
	public double f_pos_x;

	// Token: 0x04007CE3 RID: 31971
	public double f_pos_y;

	// Token: 0x04007CE4 RID: 31972
	public double f_pos_z;

	// Token: 0x04007CE5 RID: 31973
	public int i_has_target;
}
