using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F8 RID: 5624
[NullableContext(1)]
[Nullable(0)]
public class MotorSummonGetOnLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F4 RID: 5364
	// (get) Token: 0x0600DE0F RID: 56847 RVA: 0x00417FA8 File Offset: 0x004161A8
	// (set) Token: 0x0600DE10 RID: 56848 RVA: 0x00417FB0 File Offset: 0x004161B0
	public override string event_id { get; set; } = "2003";

	// Token: 0x04007E0B RID: 32267
	public float pos_x;

	// Token: 0x04007E0C RID: 32268
	public float pos_y;

	// Token: 0x04007E0D RID: 32269
	public float pos_z;

	// Token: 0x04007E0E RID: 32270
	public int operation_type;
}
