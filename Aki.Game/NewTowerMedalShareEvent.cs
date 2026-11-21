using System;
using System.Runtime.CompilerServices;

// Token: 0x020015EA RID: 5610
[NullableContext(1)]
[Nullable(0)]
public class NewTowerMedalShareEvent : PlayerCommonLogData
{
	// Token: 0x170014E6 RID: 5350
	// (get) Token: 0x0600DDE5 RID: 56805 RVA: 0x00417C01 File Offset: 0x00415E01
	// (set) Token: 0x0600DDE6 RID: 56806 RVA: 0x00417C09 File Offset: 0x00415E09
	public override string event_id { get; set; } = "1072";

	// Token: 0x04007DA2 RID: 32162
	public int i_season_id;

	// Token: 0x04007DA3 RID: 32163
	public string s_item_id = "";
}
