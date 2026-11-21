using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200164C RID: 5708
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerEnterSelectionLogEvent : PlayerCommonLogData
{
	// Token: 0x17001542 RID: 5442
	// (get) Token: 0x0600DEFF RID: 57087 RVA: 0x00418C66 File Offset: 0x00416E66
	// (set) Token: 0x0600DF00 RID: 57088 RVA: 0x00418C6E File Offset: 0x00416E6E
	public override string event_id { get; set; } = "1933";

	// Token: 0x04007F8B RID: 32651
	public string s_trace_id = "";

	// Token: 0x04007F8C RID: 32652
	public string s_battle_id = "";

	// Token: 0x04007F8D RID: 32653
	public bool s_buff_selection;

	// Token: 0x04007F8E RID: 32654
	public string s_debuff_selection = "";

	// Token: 0x04007F8F RID: 32655
	public List<BuffSelectionData> o_buff_selection = new List<BuffSelectionData>();

	// Token: 0x04007F90 RID: 32656
	public List<DeBuffSelectionData> o_debuff_selection = new List<DeBuffSelectionData>();
}
