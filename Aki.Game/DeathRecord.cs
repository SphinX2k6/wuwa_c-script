using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C9 RID: 8393
[NullableContext(1)]
[Nullable(0)]
public class DeathRecord : PlayerCommonLogData
{
	// Token: 0x17001473 RID: 5235
	// (get) Token: 0x0601089C RID: 67740 RVA: 0x0040A71C File Offset: 0x0040891C
	// (set) Token: 0x0601089D RID: 67741 RVA: 0x0040A724 File Offset: 0x00408924
	public override string event_id { get; set; } = "102706";

	// Token: 0x04007B16 RID: 31510
	public int i_area_id;

	// Token: 0x04007B17 RID: 31511
	public int i_area_level;

	// Token: 0x04007B18 RID: 31512
	public float f_x;

	// Token: 0x04007B19 RID: 31513
	public float f_y;

	// Token: 0x04007B1A RID: 31514
	public float f_z;

	// Token: 0x04007B1B RID: 31515
	public int i_death_role_id;

	// Token: 0x04007B1C RID: 31516
	public int i_death_reason;
}
