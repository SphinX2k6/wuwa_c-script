using System;
using System.Runtime.CompilerServices;

// Token: 0x02002107 RID: 8455
[NullableContext(1)]
[Nullable(0)]
public class DownloadVideoResNotEnoughSpaceLogData : CommonLogData
{
	// Token: 0x170014AD RID: 5293
	// (get) Token: 0x06010951 RID: 67921 RVA: 0x0040B320 File Offset: 0x00409520
	// (set) Token: 0x06010952 RID: 67922 RVA: 0x0040B328 File Offset: 0x00409528
	public override string event_id { get; set; } = "1702";

	// Token: 0x04007C7E RID: 31870
	public int i_popup_type;

	// Token: 0x04007C7F RID: 31871
	public bool b_if_storage_alert;

	// Token: 0x04007C80 RID: 31872
	public int i_required_space;

	// Token: 0x04007C81 RID: 31873
	public int i_remaining_space;
}
