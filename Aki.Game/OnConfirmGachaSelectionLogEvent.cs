using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F1 RID: 8433
[NullableContext(1)]
[Nullable(0)]
public class OnConfirmGachaSelectionLogEvent : PlayerCommonLogData
{
	// Token: 0x17001497 RID: 5271
	// (get) Token: 0x0601090F RID: 67855 RVA: 0x0040AFC7 File Offset: 0x004091C7
	// (set) Token: 0x06010910 RID: 67856 RVA: 0x0040AFCF File Offset: 0x004091CF
	public override string event_id { get; set; } = "1855";

	// Token: 0x04007C33 RID: 31795
	public int i_type;

	// Token: 0x04007C34 RID: 31796
	public int i_roleid_id;

	// Token: 0x04007C35 RID: 31797
	public int i_time_left;
}
