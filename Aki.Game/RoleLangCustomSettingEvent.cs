using System;
using System.Runtime.CompilerServices;

// Token: 0x0200216E RID: 8558
[NullableContext(1)]
[Nullable(0)]
public class RoleLangCustomSettingEvent : PlayerCommonLogData
{
	// Token: 0x17001510 RID: 5392
	// (get) Token: 0x06010A7E RID: 68222 RVA: 0x0040C468 File Offset: 0x0040A668
	// (set) Token: 0x06010A7F RID: 68223 RVA: 0x0040C470 File Offset: 0x0040A670
	public override string event_id { get; set; } = "1927";

	// Token: 0x04007E61 RID: 32353
	public int i_language;

	// Token: 0x04007E62 RID: 32354
	public int i_cover;

	// Token: 0x04007E63 RID: 32355
	public int i_way;
}
