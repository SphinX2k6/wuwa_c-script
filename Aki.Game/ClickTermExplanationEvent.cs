using System;
using System.Runtime.CompilerServices;

// Token: 0x0200210E RID: 8462
[NullableContext(1)]
[Nullable(0)]
public class ClickTermExplanationEvent : PlayerCommonLogData
{
	// Token: 0x170014B4 RID: 5300
	// (get) Token: 0x06010966 RID: 67942 RVA: 0x0040B43D File Offset: 0x0040963D
	// (set) Token: 0x06010967 RID: 67943 RVA: 0x0040B445 File Offset: 0x00409645
	public override string event_id { get; set; } = "1068";

	// Token: 0x04007C93 RID: 31891
	public int i_scene;
}
