using System;
using System.Runtime.CompilerServices;

// Token: 0x0200210F RID: 8463
[NullableContext(1)]
[Nullable(0)]
public class NewTowerEnterMedalEvent : PlayerCommonLogData
{
	// Token: 0x170014B5 RID: 5301
	// (get) Token: 0x06010969 RID: 67945 RVA: 0x0040B461 File Offset: 0x00409661
	// (set) Token: 0x0601096A RID: 67946 RVA: 0x0040B469 File Offset: 0x00409669
	public override string event_id { get; set; } = "1069";

	// Token: 0x04007C95 RID: 31893
	public int i_activity_id;

	// Token: 0x04007C96 RID: 31894
	public int i_season_id;
}
