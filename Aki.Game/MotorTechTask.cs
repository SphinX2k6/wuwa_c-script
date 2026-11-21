using System;
using System.Runtime.CompilerServices;

// Token: 0x0200173B RID: 5947
[NullableContext(1)]
[Nullable(0)]
public class MotorTechTask
{
	// Token: 0x17001606 RID: 5638
	// (get) Token: 0x0600E6EB RID: 59115 RVA: 0x0043AE0B File Offset: 0x0043900B
	// (set) Token: 0x0600E6EC RID: 59116 RVA: 0x0043AE13 File Offset: 0x00439013
	public MotorTechTaskNode[] TaskList { get; set; } = new MotorTechTaskNode[0];

	// Token: 0x17001607 RID: 5639
	// (get) Token: 0x0600E6ED RID: 59117 RVA: 0x0043AE1C File Offset: 0x0043901C
	// (set) Token: 0x0600E6EE RID: 59118 RVA: 0x0043AE24 File Offset: 0x00439024
	public int RewardedCount { get; set; }
}
