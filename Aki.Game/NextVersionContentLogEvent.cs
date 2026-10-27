using System;
using System.Runtime.CompilerServices;

// Token: 0x02002164 RID: 8548
[NullableContext(1)]
[Nullable(0)]
public class NextVersionContentLogEvent : PlayerCommonLogData
{
	// Token: 0x17001506 RID: 5382
	// (get) Token: 0x06010A60 RID: 68192 RVA: 0x0040C2EA File Offset: 0x0040A4EA
	// (set) Token: 0x06010A61 RID: 68193 RVA: 0x0040C2F2 File Offset: 0x0040A4F2
	public override string event_id { get; set; } = "1813";

	// Token: 0x04007E39 RID: 32313
	public int i_activity_id;

	// Token: 0x04007E3A RID: 32314
	public int i_second_tab;

	// Token: 0x04007E3B RID: 32315
	public int i_third_tab;
}
