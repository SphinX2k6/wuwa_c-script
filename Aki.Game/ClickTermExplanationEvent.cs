using System;
using System.Runtime.CompilerServices;

// Token: 0x020015E6 RID: 5606
[NullableContext(1)]
[Nullable(0)]
public class ClickTermExplanationEvent : PlayerCommonLogData
{
	// Token: 0x170014E2 RID: 5346
	// (get) Token: 0x0600DDD9 RID: 56793 RVA: 0x00417B71 File Offset: 0x00415D71
	// (set) Token: 0x0600DDDA RID: 56794 RVA: 0x00417B79 File Offset: 0x00415D79
	public override string event_id { get; set; } = "1068";

	// Token: 0x04007D95 RID: 32149
	public int i_scene;
}
