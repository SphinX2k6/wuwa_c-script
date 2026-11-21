using System;
using System.Runtime.CompilerServices;

// Token: 0x0200163A RID: 5690
[NullableContext(1)]
[Nullable(0)]
public class TetrisGameTriggerLogEvent : PlayerCommonLogData
{
	// Token: 0x17001532 RID: 5426
	// (get) Token: 0x0600DECD RID: 57037 RVA: 0x004189EA File Offset: 0x00416BEA
	// (set) Token: 0x0600DECE RID: 57038 RVA: 0x004189F2 File Offset: 0x00416BF2
	public override string event_id { get; set; } = "1850";

	// Token: 0x04007F43 RID: 32579
	public int i_config_id;
}
