using System;
using System.Runtime.CompilerServices;

// Token: 0x02002110 RID: 8464
[NullableContext(1)]
[Nullable(0)]
public class NewTowerClickMedalEvent : PlayerCommonLogData
{
	// Token: 0x170014B6 RID: 5302
	// (get) Token: 0x0601096C RID: 67948 RVA: 0x0040B485 File Offset: 0x00409685
	// (set) Token: 0x0601096D RID: 67949 RVA: 0x0040B48D File Offset: 0x0040968D
	public override string event_id { get; set; } = "1070";

	// Token: 0x04007C98 RID: 31896
	public int i_activity_id;

	// Token: 0x04007C99 RID: 31897
	public int i_season_id;

	// Token: 0x04007C9A RID: 31898
	public int i_item_id;
}
