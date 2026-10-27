using System;
using System.Runtime.CompilerServices;

// Token: 0x02002112 RID: 8466
[NullableContext(1)]
[Nullable(0)]
public class NewTowerMedalShareEvent : PlayerCommonLogData
{
	// Token: 0x170014B8 RID: 5304
	// (get) Token: 0x06010972 RID: 67954 RVA: 0x0040B4CD File Offset: 0x004096CD
	// (set) Token: 0x06010973 RID: 67955 RVA: 0x0040B4D5 File Offset: 0x004096D5
	public override string event_id { get; set; } = "1072";

	// Token: 0x04007CA0 RID: 31904
	public int i_season_id;

	// Token: 0x04007CA1 RID: 31905
	public string s_item_id = "";
}
