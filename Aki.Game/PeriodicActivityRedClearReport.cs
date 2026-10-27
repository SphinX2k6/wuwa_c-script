using System;
using System.Runtime.CompilerServices;

// Token: 0x02002156 RID: 8534
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRedClearReport : PlayerCommonLogData
{
	// Token: 0x170014F9 RID: 5369
	// (get) Token: 0x06010A38 RID: 68152 RVA: 0x0040C0D7 File Offset: 0x0040A2D7
	// (set) Token: 0x06010A39 RID: 68153 RVA: 0x0040C0DF File Offset: 0x0040A2DF
	public override string event_id { get; set; } = "1839";

	// Token: 0x04007DFE RID: 32254
	public int i_activity_id;

	// Token: 0x04007DFF RID: 32255
	public int i_round;

	// Token: 0x04007E00 RID: 32256
	public int i_result;

	// Token: 0x04007E01 RID: 32257
	public int i_way;
}
