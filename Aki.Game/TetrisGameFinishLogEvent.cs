using System;
using System.Runtime.CompilerServices;

// Token: 0x0200163B RID: 5691
[NullableContext(1)]
[Nullable(0)]
public class TetrisGameFinishLogEvent : PlayerCommonLogData
{
	// Token: 0x17001533 RID: 5427
	// (get) Token: 0x0600DED0 RID: 57040 RVA: 0x00418A0E File Offset: 0x00416C0E
	// (set) Token: 0x0600DED1 RID: 57041 RVA: 0x00418A16 File Offset: 0x00416C16
	public override string event_id { get; set; } = "1853";

	// Token: 0x04007F45 RID: 32581
	public int i_config_id;

	// Token: 0x04007F46 RID: 32582
	public int i_result_type;

	// Token: 0x04007F47 RID: 32583
	public int i_score;
}
