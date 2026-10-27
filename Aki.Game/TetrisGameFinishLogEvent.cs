using System;
using System.Runtime.CompilerServices;

// Token: 0x02002163 RID: 8547
[NullableContext(1)]
[Nullable(0)]
public class TetrisGameFinishLogEvent : PlayerCommonLogData
{
	// Token: 0x17001505 RID: 5381
	// (get) Token: 0x06010A5D RID: 68189 RVA: 0x0040C2C6 File Offset: 0x0040A4C6
	// (set) Token: 0x06010A5E RID: 68190 RVA: 0x0040C2CE File Offset: 0x0040A4CE
	public override string event_id { get; set; } = "1853";

	// Token: 0x04007E35 RID: 32309
	public int i_config_id;

	// Token: 0x04007E36 RID: 32310
	public int i_result_type;

	// Token: 0x04007E37 RID: 32311
	public int i_score;
}
