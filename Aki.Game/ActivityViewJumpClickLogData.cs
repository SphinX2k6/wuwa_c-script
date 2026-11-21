using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B7 RID: 5559
[NullableContext(1)]
[Nullable(0)]
public class ActivityViewJumpClickLogData : PlayerCommonLogData
{
	// Token: 0x170014B5 RID: 5301
	// (get) Token: 0x0600DD50 RID: 56656 RVA: 0x0041745E File Offset: 0x0041565E
	// (set) Token: 0x0600DD51 RID: 56657 RVA: 0x00417466 File Offset: 0x00415666
	public override string event_id { get; set; } = "1021";

	// Token: 0x04007CFA RID: 31994
	public int i_activity_id;

	// Token: 0x04007CFB RID: 31995
	public int i_activity_type;

	// Token: 0x04007CFC RID: 31996
	public int i_unlock;

	// Token: 0x04007CFD RID: 31997
	public int i_scene;
}
