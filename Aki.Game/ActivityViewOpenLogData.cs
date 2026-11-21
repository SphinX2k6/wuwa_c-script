using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B5 RID: 5557
[NullableContext(1)]
[Nullable(0)]
public class ActivityViewOpenLogData : PlayerCommonLogData
{
	// Token: 0x170014B3 RID: 5299
	// (get) Token: 0x0600DD4A RID: 56650 RVA: 0x00417416 File Offset: 0x00415616
	// (set) Token: 0x0600DD4B RID: 56651 RVA: 0x0041741E File Offset: 0x0041561E
	public override string event_id { get; set; } = "1019";

	// Token: 0x04007CF2 RID: 31986
	public int i_open_way;
}
