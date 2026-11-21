using System;
using System.Runtime.CompilerServices;

// Token: 0x0200173D RID: 5949
[NullableContext(1)]
[Nullable(0)]
public class MotorTechTaskNode
{
	// Token: 0x17001608 RID: 5640
	// (get) Token: 0x0600E6F0 RID: 59120 RVA: 0x0043AE41 File Offset: 0x00439041
	// (set) Token: 0x0600E6F1 RID: 59121 RVA: 0x0043AE49 File Offset: 0x00439049
	public int TaskId { get; set; }

	// Token: 0x17001609 RID: 5641
	// (get) Token: 0x0600E6F2 RID: 59122 RVA: 0x0043AE52 File Offset: 0x00439052
	// (set) Token: 0x0600E6F3 RID: 59123 RVA: 0x0043AE5A File Offset: 0x0043905A
	public int TreeType { get; set; }

	// Token: 0x1700160A RID: 5642
	// (get) Token: 0x0600E6F4 RID: 59124 RVA: 0x0043AE63 File Offset: 0x00439063
	// (set) Token: 0x0600E6F5 RID: 59125 RVA: 0x0043AE6B File Offset: 0x0043906B
	public EMotorTechTaskType Type { get; set; }

	// Token: 0x1700160B RID: 5643
	// (get) Token: 0x0600E6F6 RID: 59126 RVA: 0x0043AE74 File Offset: 0x00439074
	// (set) Token: 0x0600E6F7 RID: 59127 RVA: 0x0043AE7C File Offset: 0x0043907C
	public long StartTime { get; set; }

	// Token: 0x1700160C RID: 5644
	// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x0043AE85 File Offset: 0x00439085
	// (set) Token: 0x0600E6F9 RID: 59129 RVA: 0x0043AE8D File Offset: 0x0043908D
	public long EndTime { get; set; }

	// Token: 0x1700160D RID: 5645
	// (get) Token: 0x0600E6FA RID: 59130 RVA: 0x0043AE96 File Offset: 0x00439096
	// (set) Token: 0x0600E6FB RID: 59131 RVA: 0x0043AE9E File Offset: 0x0043909E
	public MotorTechTaskProcess ProcessInfo { get; set; } = new MotorTechTaskProcess();

	// Token: 0x1700160E RID: 5646
	// (get) Token: 0x0600E6FC RID: 59132 RVA: 0x0043AEA7 File Offset: 0x004390A7
	// (set) Token: 0x0600E6FD RID: 59133 RVA: 0x0043AEAF File Offset: 0x004390AF
	public MotorTechTaskReward RewardInfo { get; set; } = new MotorTechTaskReward();
}
