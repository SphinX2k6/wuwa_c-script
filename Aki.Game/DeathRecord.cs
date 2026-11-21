using System;
using System.Runtime.CompilerServices;

// Token: 0x020015A0 RID: 5536
[NullableContext(1)]
[Nullable(0)]
public class DeathRecord : PlayerCommonLogData
{
	// Token: 0x170014A0 RID: 5280
	// (get) Token: 0x0600DD0C RID: 56588 RVA: 0x00416E24 File Offset: 0x00415024
	// (set) Token: 0x0600DD0D RID: 56589 RVA: 0x00416E2C File Offset: 0x0041502C
	public override string event_id { get; set; } = "102706";

	// Token: 0x04007C14 RID: 31764
	public int i_area_id;

	// Token: 0x04007C15 RID: 31765
	public int i_area_level;

	// Token: 0x04007C16 RID: 31766
	public float f_x;

	// Token: 0x04007C17 RID: 31767
	public float f_y;

	// Token: 0x04007C18 RID: 31768
	public float f_z;

	// Token: 0x04007C19 RID: 31769
	public int i_death_role_id;

	// Token: 0x04007C1A RID: 31770
	public int i_death_reason;
}
