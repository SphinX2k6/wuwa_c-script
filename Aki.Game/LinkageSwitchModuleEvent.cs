using System;
using System.Runtime.CompilerServices;

// Token: 0x020020FE RID: 8446
[NullableContext(1)]
[Nullable(0)]
public class LinkageSwitchModuleEvent : PlayerCommonLogData
{
	// Token: 0x170014A4 RID: 5284
	// (get) Token: 0x06010936 RID: 67894 RVA: 0x0040B1B1 File Offset: 0x004093B1
	// (set) Token: 0x06010937 RID: 67895 RVA: 0x0040B1B9 File Offset: 0x004093B9
	public override string event_id { get; set; } = "1058";

	// Token: 0x04007C60 RID: 31840
	public int i_activity_id;

	// Token: 0x04007C61 RID: 31841
	public int i_activity_type;

	// Token: 0x04007C62 RID: 31842
	public int i_id;

	// Token: 0x04007C63 RID: 31843
	public int i_if_finish;
}
