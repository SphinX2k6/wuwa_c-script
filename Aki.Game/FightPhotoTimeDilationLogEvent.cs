using System;
using System.Runtime.CompilerServices;

// Token: 0x0200212E RID: 8494
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTimeDilationLogEvent : PlayerCommonLogData
{
	// Token: 0x170014D4 RID: 5332
	// (get) Token: 0x060109C6 RID: 68038 RVA: 0x0040BA63 File Offset: 0x00409C63
	// (set) Token: 0x060109C7 RID: 68039 RVA: 0x0040BA6B File Offset: 0x00409C6B
	public override string event_id { get; set; } = "1804";

	// Token: 0x04007D30 RID: 32048
	public int inst_id;

	// Token: 0x04007D31 RID: 32049
	public int inst_diff;

	// Token: 0x04007D32 RID: 32050
	public string trace_id = "";
}
