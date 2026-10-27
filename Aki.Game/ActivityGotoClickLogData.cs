using System;
using System.Runtime.CompilerServices;

// Token: 0x0200217A RID: 8570
[NullableContext(1)]
[Nullable(0)]
public class ActivityGotoClickLogData : PlayerCommonLogData
{
	// Token: 0x17001519 RID: 5401
	// (get) Token: 0x06010A9C RID: 68252 RVA: 0x0040C645 File Offset: 0x0040A845
	// (set) Token: 0x06010A9D RID: 68253 RVA: 0x0040C64D File Offset: 0x0040A84D
	public override string event_id { get; set; } = "1938";

	// Token: 0x04007E9A RID: 32410
	public int i_activity_id;

	// Token: 0x04007E9B RID: 32411
	public int i_type;

	// Token: 0x04007E9C RID: 32412
	public int i_scene;
}
