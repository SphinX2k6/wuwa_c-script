using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E0 RID: 8416
[NullableContext(1)]
[Nullable(0)]
public class ActivityViewJumpClickLogData : PlayerCommonLogData
{
	// Token: 0x17001488 RID: 5256
	// (get) Token: 0x060108E0 RID: 67808 RVA: 0x0040AD4E File Offset: 0x00408F4E
	// (set) Token: 0x060108E1 RID: 67809 RVA: 0x0040AD56 File Offset: 0x00408F56
	public override string event_id { get; set; } = "1021";

	// Token: 0x04007BFB RID: 31739
	public int i_activity_id;

	// Token: 0x04007BFC RID: 31740
	public int i_activity_type;

	// Token: 0x04007BFD RID: 31741
	public int i_unlock;

	// Token: 0x04007BFE RID: 31742
	public int i_scene;
}
