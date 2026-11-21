using System;
using System.Runtime.CompilerServices;

// Token: 0x0200162E RID: 5678
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRedClearReport : PlayerCommonLogData
{
	// Token: 0x17001527 RID: 5415
	// (get) Token: 0x0600DEAB RID: 57003 RVA: 0x0041881F File Offset: 0x00416A1F
	// (set) Token: 0x0600DEAC RID: 57004 RVA: 0x00418827 File Offset: 0x00416A27
	public override string event_id { get; set; } = "1839";

	// Token: 0x04007F0E RID: 32526
	public int i_activity_id;

	// Token: 0x04007F0F RID: 32527
	public int i_round;

	// Token: 0x04007F10 RID: 32528
	public int i_result;

	// Token: 0x04007F11 RID: 32529
	public int i_way;
}
