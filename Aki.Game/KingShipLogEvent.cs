using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F0 RID: 5616
[NullableContext(1)]
[Nullable(0)]
public class KingShipLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EC RID: 5356
	// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x00417E67 File Offset: 0x00416067
	// (set) Token: 0x0600DDF8 RID: 56824 RVA: 0x00417E6F File Offset: 0x0041606F
	public override string event_id { get; set; } = "1801";

	// Token: 0x04007DFB RID: 32251
	public int i_step_id;
}
