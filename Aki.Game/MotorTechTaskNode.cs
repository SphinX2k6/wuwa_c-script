using System;
using System.Runtime.CompilerServices;

// Token: 0x02002259 RID: 8793
[NullableContext(1)]
[Nullable(0)]
public class MotorTechTaskNode
{
	// Token: 0x170015D1 RID: 5585
	// (get) Token: 0x0601125A RID: 70234 RVA: 0x0042E2A1 File Offset: 0x0042C4A1
	// (set) Token: 0x0601125B RID: 70235 RVA: 0x0042E2A9 File Offset: 0x0042C4A9
	public int TaskId { get; set; }

	// Token: 0x170015D2 RID: 5586
	// (get) Token: 0x0601125C RID: 70236 RVA: 0x0042E2B2 File Offset: 0x0042C4B2
	// (set) Token: 0x0601125D RID: 70237 RVA: 0x0042E2BA File Offset: 0x0042C4BA
	public int TreeType { get; set; }

	// Token: 0x170015D3 RID: 5587
	// (get) Token: 0x0601125E RID: 70238 RVA: 0x0042E2C3 File Offset: 0x0042C4C3
	// (set) Token: 0x0601125F RID: 70239 RVA: 0x0042E2CB File Offset: 0x0042C4CB
	public EMotorTechTaskType Type { get; set; }

	// Token: 0x170015D4 RID: 5588
	// (get) Token: 0x06011260 RID: 70240 RVA: 0x0042E2D4 File Offset: 0x0042C4D4
	// (set) Token: 0x06011261 RID: 70241 RVA: 0x0042E2DC File Offset: 0x0042C4DC
	public long StartTime { get; set; }

	// Token: 0x170015D5 RID: 5589
	// (get) Token: 0x06011262 RID: 70242 RVA: 0x0042E2E5 File Offset: 0x0042C4E5
	// (set) Token: 0x06011263 RID: 70243 RVA: 0x0042E2ED File Offset: 0x0042C4ED
	public long EndTime { get; set; }

	// Token: 0x170015D6 RID: 5590
	// (get) Token: 0x06011264 RID: 70244 RVA: 0x0042E2F6 File Offset: 0x0042C4F6
	// (set) Token: 0x06011265 RID: 70245 RVA: 0x0042E2FE File Offset: 0x0042C4FE
	public MotorTechTaskProcess ProcessInfo { get; set; } = new MotorTechTaskProcess();

	// Token: 0x170015D7 RID: 5591
	// (get) Token: 0x06011266 RID: 70246 RVA: 0x0042E307 File Offset: 0x0042C507
	// (set) Token: 0x06011267 RID: 70247 RVA: 0x0042E30F File Offset: 0x0042C50F
	public MotorTechTaskReward RewardInfo { get; set; } = new MotorTechTaskReward();
}
