using System;
using System.Runtime.CompilerServices;

// Token: 0x02002111 RID: 8465
[NullableContext(1)]
[Nullable(0)]
public class NewTowerClickMedalSkipEvent : PlayerCommonLogData
{
	// Token: 0x170014B7 RID: 5303
	// (get) Token: 0x0601096F RID: 67951 RVA: 0x0040B4A9 File Offset: 0x004096A9
	// (set) Token: 0x06010970 RID: 67952 RVA: 0x0040B4B1 File Offset: 0x004096B1
	public override string event_id { get; set; } = "1071";

	// Token: 0x04007C9C RID: 31900
	public int i_activity_id;

	// Token: 0x04007C9D RID: 31901
	public int i_season_id;

	// Token: 0x04007C9E RID: 31902
	public int i_item_id;
}
