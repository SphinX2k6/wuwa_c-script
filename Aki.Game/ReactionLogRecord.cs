using System;
using System.Runtime.CompilerServices;

// Token: 0x020020BE RID: 8382
[NullableContext(1)]
[Nullable(0)]
public class ReactionLogRecord : PlayerCommonLogData
{
	// Token: 0x17001469 RID: 5225
	// (get) Token: 0x0601087B RID: 67707 RVA: 0x0040A24E File Offset: 0x0040844E
	// (set) Token: 0x0601087C RID: 67708 RVA: 0x0040A256 File Offset: 0x00408456
	public override string event_id { get; set; } = "102703";

	// Token: 0x04007ACD RID: 31437
	public string s_battle_id = "";

	// Token: 0x04007ACE RID: 31438
	public string s_reports = "";
}
