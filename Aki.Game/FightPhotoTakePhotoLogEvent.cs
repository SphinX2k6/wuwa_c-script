using System;
using System.Runtime.CompilerServices;

// Token: 0x02001605 RID: 5637
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTakePhotoLogEvent : PlayerCommonLogData
{
	// Token: 0x17001501 RID: 5377
	// (get) Token: 0x0600DE36 RID: 56886 RVA: 0x0041817C File Offset: 0x0041637C
	// (set) Token: 0x0600DE37 RID: 56887 RVA: 0x00418184 File Offset: 0x00416384
	public override string event_id { get; set; } = "1803";

	// Token: 0x04007E39 RID: 32313
	public int inst_id;

	// Token: 0x04007E3A RID: 32314
	public int inst_diff;

	// Token: 0x04007E3B RID: 32315
	public string trace_id = "";

	// Token: 0x04007E3C RID: 32316
	public int filter_id;

	// Token: 0x04007E3D RID: 32317
	public int photo_num;

	// Token: 0x04007E3E RID: 32318
	public int photo_status;
}
