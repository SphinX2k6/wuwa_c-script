using System;
using System.Runtime.CompilerServices;

// Token: 0x020020DE RID: 8414
[NullableContext(1)]
[Nullable(0)]
public class ActivityViewOpenLogData : PlayerCommonLogData
{
	// Token: 0x17001486 RID: 5254
	// (get) Token: 0x060108DA RID: 67802 RVA: 0x0040AD06 File Offset: 0x00408F06
	// (set) Token: 0x060108DB RID: 67803 RVA: 0x0040AD0E File Offset: 0x00408F0E
	public override string event_id { get; set; } = "1019";

	// Token: 0x04007BF3 RID: 31731
	public int i_open_way;
}
