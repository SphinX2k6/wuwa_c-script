using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E5 RID: 8421
[NullableContext(1)]
[Nullable(0)]
public class ActivityPreheatLogData : PlayerCommonLogData
{
	// Token: 0x1700148B RID: 5259
	// (get) Token: 0x060108EB RID: 67819 RVA: 0x0040ADCA File Offset: 0x00408FCA
	// (set) Token: 0x060108EC RID: 67820 RVA: 0x0040ADD2 File Offset: 0x00408FD2
	public override string event_id { get; set; } = "1030";

	// Token: 0x04007C11 RID: 31761
	public int i_activity_id;

	// Token: 0x04007C12 RID: 31762
	public int i_activity_type;

	// Token: 0x04007C13 RID: 31763
	public int i_time_left;

	// Token: 0x04007C14 RID: 31764
	public int i_type;
}
