using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E2 RID: 8418
[NullableContext(1)]
[Nullable(0)]
public class WeeklyChallengeGoToClickLogData : PlayerCommonLogData
{
	// Token: 0x1700148A RID: 5258
	// (get) Token: 0x060108E6 RID: 67814 RVA: 0x0040AD96 File Offset: 0x00408F96
	// (set) Token: 0x060108E7 RID: 67815 RVA: 0x0040AD9E File Offset: 0x00408F9E
	public override string event_id { get; set; } = "1031";

	// Token: 0x04007C03 RID: 31747
	public int i_activity_id;

	// Token: 0x04007C04 RID: 31748
	public int i_activity_type;

	// Token: 0x04007C05 RID: 31749
	public int i_unlock;
}
