using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002174 RID: 8564
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerEnterSelectionLogEvent : PlayerCommonLogData
{
	// Token: 0x17001514 RID: 5396
	// (get) Token: 0x06010A8C RID: 68236 RVA: 0x0040C51E File Offset: 0x0040A71E
	// (set) Token: 0x06010A8D RID: 68237 RVA: 0x0040C526 File Offset: 0x0040A726
	public override string event_id { get; set; } = "1933";

	// Token: 0x04007E7B RID: 32379
	public string s_trace_id = "";

	// Token: 0x04007E7C RID: 32380
	public string s_battle_id = "";

	// Token: 0x04007E7D RID: 32381
	public bool s_buff_selection;

	// Token: 0x04007E7E RID: 32382
	public string s_debuff_selection = "";

	// Token: 0x04007E7F RID: 32383
	public List<BuffSelectionData> o_buff_selection = new List<BuffSelectionData>();

	// Token: 0x04007E80 RID: 32384
	public List<DeBuffSelectionData> o_debuff_selection = new List<DeBuffSelectionData>();
}
