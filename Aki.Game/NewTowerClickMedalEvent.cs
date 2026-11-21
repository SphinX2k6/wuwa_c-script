using System;
using System.Runtime.CompilerServices;

// Token: 0x020015E8 RID: 5608
[NullableContext(1)]
[Nullable(0)]
public class NewTowerClickMedalEvent : PlayerCommonLogData
{
	// Token: 0x170014E4 RID: 5348
	// (get) Token: 0x0600DDDF RID: 56799 RVA: 0x00417BB9 File Offset: 0x00415DB9
	// (set) Token: 0x0600DDE0 RID: 56800 RVA: 0x00417BC1 File Offset: 0x00415DC1
	public override string event_id { get; set; } = "1070";

	// Token: 0x04007D9A RID: 32154
	public int i_activity_id;

	// Token: 0x04007D9B RID: 32155
	public int i_season_id;

	// Token: 0x04007D9C RID: 32156
	public int i_item_id;
}
