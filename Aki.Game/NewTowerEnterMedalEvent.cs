using System;
using System.Runtime.CompilerServices;

// Token: 0x020015E7 RID: 5607
[NullableContext(1)]
[Nullable(0)]
public class NewTowerEnterMedalEvent : PlayerCommonLogData
{
	// Token: 0x170014E3 RID: 5347
	// (get) Token: 0x0600DDDC RID: 56796 RVA: 0x00417B95 File Offset: 0x00415D95
	// (set) Token: 0x0600DDDD RID: 56797 RVA: 0x00417B9D File Offset: 0x00415D9D
	public override string event_id { get; set; } = "1069";

	// Token: 0x04007D97 RID: 32151
	public int i_activity_id;

	// Token: 0x04007D98 RID: 32152
	public int i_season_id;
}
