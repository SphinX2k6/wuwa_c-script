using System;
using System.Runtime.CompilerServices;

// Token: 0x02002162 RID: 8546
[NullableContext(1)]
[Nullable(0)]
public class TetrisGameTriggerLogEvent : PlayerCommonLogData
{
	// Token: 0x17001504 RID: 5380
	// (get) Token: 0x06010A5A RID: 68186 RVA: 0x0040C2A2 File Offset: 0x0040A4A2
	// (set) Token: 0x06010A5B RID: 68187 RVA: 0x0040C2AA File Offset: 0x0040A4AA
	public override string event_id { get; set; } = "1850";

	// Token: 0x04007E33 RID: 32307
	public int i_config_id;
}
