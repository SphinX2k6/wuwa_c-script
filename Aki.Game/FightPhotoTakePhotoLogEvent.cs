using System;
using System.Runtime.CompilerServices;

// Token: 0x0200212D RID: 8493
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTakePhotoLogEvent : PlayerCommonLogData
{
	// Token: 0x170014D3 RID: 5331
	// (get) Token: 0x060109C3 RID: 68035 RVA: 0x0040BA34 File Offset: 0x00409C34
	// (set) Token: 0x060109C4 RID: 68036 RVA: 0x0040BA3C File Offset: 0x00409C3C
	public override string event_id { get; set; } = "1803";

	// Token: 0x04007D29 RID: 32041
	public int inst_id;

	// Token: 0x04007D2A RID: 32042
	public int inst_diff;

	// Token: 0x04007D2B RID: 32043
	public string trace_id = "";

	// Token: 0x04007D2C RID: 32044
	public int filter_id;

	// Token: 0x04007D2D RID: 32045
	public int photo_num;

	// Token: 0x04007D2E RID: 32046
	public int photo_status;
}
