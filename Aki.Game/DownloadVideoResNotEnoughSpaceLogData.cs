using System;
using System.Runtime.CompilerServices;

// Token: 0x020015DF RID: 5599
[NullableContext(1)]
[Nullable(0)]
public class DownloadVideoResNotEnoughSpaceLogData : CommonLogData
{
	// Token: 0x170014DB RID: 5339
	// (get) Token: 0x0600DDC4 RID: 56772 RVA: 0x00417A54 File Offset: 0x00415C54
	// (set) Token: 0x0600DDC5 RID: 56773 RVA: 0x00417A5C File Offset: 0x00415C5C
	public override string event_id { get; set; } = "1702";

	// Token: 0x04007D80 RID: 32128
	public int i_popup_type;

	// Token: 0x04007D81 RID: 32129
	public bool b_if_storage_alert;

	// Token: 0x04007D82 RID: 32130
	public int i_required_space;

	// Token: 0x04007D83 RID: 32131
	public int i_remaining_space;
}
