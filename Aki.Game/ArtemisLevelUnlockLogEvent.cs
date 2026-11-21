using System;
using System.Runtime.CompilerServices;

// Token: 0x0200161B RID: 5659
[NullableContext(1)]
[Nullable(0)]
public class ArtemisLevelUnlockLogEvent : PlayerCommonLogData
{
	// Token: 0x17001516 RID: 5398
	// (get) Token: 0x0600DE76 RID: 56950 RVA: 0x00418533 File Offset: 0x00416733
	// (set) Token: 0x0600DE77 RID: 56951 RVA: 0x0041853B File Offset: 0x0041673B
	public override string event_id { get; set; } = "1814";

	// Token: 0x04007E9E RID: 32414
	public int i_id;
}
