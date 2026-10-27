using System;
using System.Runtime.CompilerServices;

// Token: 0x02002143 RID: 8515
[NullableContext(1)]
[Nullable(0)]
public class ArtemisLevelUnlockLogEvent : PlayerCommonLogData
{
	// Token: 0x170014E8 RID: 5352
	// (get) Token: 0x06010A03 RID: 68099 RVA: 0x0040BDEB File Offset: 0x00409FEB
	// (set) Token: 0x06010A04 RID: 68100 RVA: 0x0040BDF3 File Offset: 0x00409FF3
	public override string event_id { get; set; } = "1814";

	// Token: 0x04007D8E RID: 32142
	public int i_id;
}
