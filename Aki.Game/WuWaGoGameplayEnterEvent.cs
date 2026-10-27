using System;
using System.Runtime.CompilerServices;

// Token: 0x0200216F RID: 8559
[NullableContext(1)]
[Nullable(0)]
public class WuWaGoGameplayEnterEvent : PlayerCommonLogData
{
	// Token: 0x17001511 RID: 5393
	// (get) Token: 0x06010A81 RID: 68225 RVA: 0x0040C48C File Offset: 0x0040A68C
	// (set) Token: 0x06010A82 RID: 68226 RVA: 0x0040C494 File Offset: 0x0040A694
	public override string event_id { get; set; } = "1928";

	// Token: 0x04007E65 RID: 32357
	public int i_level_play_id;
}
