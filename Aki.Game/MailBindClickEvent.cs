using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F9 RID: 8441
[NullableContext(1)]
[Nullable(0)]
public class MailBindClickEvent : PlayerCommonLogData
{
	// Token: 0x1700149F RID: 5279
	// (get) Token: 0x06010927 RID: 67879 RVA: 0x0040B0E7 File Offset: 0x004092E7
	// (set) Token: 0x06010928 RID: 67880 RVA: 0x0040B0EF File Offset: 0x004092EF
	public override string event_id { get; set; } = "1051";

	// Token: 0x04007C4D RID: 31821
	public int i_language;

	// Token: 0x04007C4E RID: 31822
	public int i_if_binded;
}
