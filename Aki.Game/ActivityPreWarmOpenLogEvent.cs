using System;
using System.Runtime.CompilerServices;

// Token: 0x02002135 RID: 8501
[NullableContext(1)]
[Nullable(0)]
public class ActivityPreWarmOpenLogEvent : PlayerCommonLogData
{
	// Token: 0x170014DB RID: 5339
	// (get) Token: 0x060109DB RID: 68059 RVA: 0x0040BB75 File Offset: 0x00409D75
	// (set) Token: 0x060109DC RID: 68060 RVA: 0x0040BB7D File Offset: 0x00409D7D
	public override string event_id { get; set; } = "1811";

	// Token: 0x04007D46 RID: 32070
	public int i_activity_id;

	// Token: 0x04007D47 RID: 32071
	public int i_chapter_id;
}
