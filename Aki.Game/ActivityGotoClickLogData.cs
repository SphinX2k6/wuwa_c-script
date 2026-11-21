using System;
using System.Runtime.CompilerServices;

// Token: 0x02001652 RID: 5714
[NullableContext(1)]
[Nullable(0)]
public class ActivityGotoClickLogData : PlayerCommonLogData
{
	// Token: 0x17001547 RID: 5447
	// (get) Token: 0x0600DF0F RID: 57103 RVA: 0x00418D8D File Offset: 0x00416F8D
	// (set) Token: 0x0600DF10 RID: 57104 RVA: 0x00418D95 File Offset: 0x00416F95
	public override string event_id { get; set; } = "1938";

	// Token: 0x04007FAA RID: 32682
	public int i_activity_id;

	// Token: 0x04007FAB RID: 32683
	public int i_type;

	// Token: 0x04007FAC RID: 32684
	public int i_scene;
}
