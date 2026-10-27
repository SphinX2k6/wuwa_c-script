using System;
using System.Runtime.CompilerServices;

// Token: 0x020020EC RID: 8428
[NullableContext(1)]
[Nullable(0)]
public class OnClickGachaScrollLogEvent : PlayerCommonLogData
{
	// Token: 0x17001492 RID: 5266
	// (get) Token: 0x06010900 RID: 67840 RVA: 0x0040AF13 File Offset: 0x00409113
	// (set) Token: 0x06010901 RID: 67841 RVA: 0x0040AF1B File Offset: 0x0040911B
	public override string event_id { get; set; } = "1822";

	// Token: 0x04007C26 RID: 31782
	public int i_gacha_id;
}
