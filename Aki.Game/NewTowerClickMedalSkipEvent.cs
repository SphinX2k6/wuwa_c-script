using System;
using System.Runtime.CompilerServices;

// Token: 0x020015E9 RID: 5609
[NullableContext(1)]
[Nullable(0)]
public class NewTowerClickMedalSkipEvent : PlayerCommonLogData
{
	// Token: 0x170014E5 RID: 5349
	// (get) Token: 0x0600DDE2 RID: 56802 RVA: 0x00417BDD File Offset: 0x00415DDD
	// (set) Token: 0x0600DDE3 RID: 56803 RVA: 0x00417BE5 File Offset: 0x00415DE5
	public override string event_id { get; set; } = "1071";

	// Token: 0x04007D9E RID: 32158
	public int i_activity_id;

	// Token: 0x04007D9F RID: 32159
	public int i_season_id;

	// Token: 0x04007DA0 RID: 32160
	public int i_item_id;
}
