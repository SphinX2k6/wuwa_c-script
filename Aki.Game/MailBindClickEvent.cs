using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D1 RID: 5585
[NullableContext(1)]
[Nullable(0)]
public class MailBindClickEvent : PlayerCommonLogData
{
	// Token: 0x170014CD RID: 5325
	// (get) Token: 0x0600DD9A RID: 56730 RVA: 0x0041781B File Offset: 0x00415A1B
	// (set) Token: 0x0600DD9B RID: 56731 RVA: 0x00417823 File Offset: 0x00415A23
	public override string event_id { get; set; } = "1051";

	// Token: 0x04007D4F RID: 32079
	public int i_language;

	// Token: 0x04007D50 RID: 32080
	public int i_if_binded;
}
