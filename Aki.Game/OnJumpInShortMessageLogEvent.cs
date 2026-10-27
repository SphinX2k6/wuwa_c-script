using System;
using System.Runtime.CompilerServices;

// Token: 0x02002146 RID: 8518
[NullableContext(1)]
[Nullable(0)]
public class OnJumpInShortMessageLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EB RID: 5355
	// (get) Token: 0x06010A0C RID: 68108 RVA: 0x0040BE57 File Offset: 0x0040A057
	// (set) Token: 0x06010A0D RID: 68109 RVA: 0x0040BE5F File Offset: 0x0040A05F
	public override string event_id { get; set; } = "1817";

	// Token: 0x04007D99 RID: 32153
	public int i_id;

	// Token: 0x04007D9A RID: 32154
	public int i_type;

	// Token: 0x04007D9B RID: 32155
	public int i_role_id;

	// Token: 0x04007D9C RID: 32156
	public long l_received_time;

	// Token: 0x04007D9D RID: 32157
	public int i_trigger_type;

	// Token: 0x04007D9E RID: 32158
	public int i_config_id;
}
