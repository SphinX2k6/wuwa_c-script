using System;
using System.Runtime.CompilerServices;

// Token: 0x02001606 RID: 5638
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTimeDilationLogEvent : PlayerCommonLogData
{
	// Token: 0x17001502 RID: 5378
	// (get) Token: 0x0600DE39 RID: 56889 RVA: 0x004181AB File Offset: 0x004163AB
	// (set) Token: 0x0600DE3A RID: 56890 RVA: 0x004181B3 File Offset: 0x004163B3
	public override string event_id { get; set; } = "1804";

	// Token: 0x04007E40 RID: 32320
	public int inst_id;

	// Token: 0x04007E41 RID: 32321
	public int inst_diff;

	// Token: 0x04007E42 RID: 32322
	public string trace_id = "";
}
