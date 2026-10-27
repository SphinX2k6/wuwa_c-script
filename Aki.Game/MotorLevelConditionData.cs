using System;
using System.Runtime.CompilerServices;

// Token: 0x0200224F RID: 8783
[NullableContext(1)]
[Nullable(0)]
public class MotorLevelConditionData : IMotorLevelConditionData
{
	// Token: 0x170015BE RID: 5566
	// (get) Token: 0x06011230 RID: 70192 RVA: 0x0042E138 File Offset: 0x0042C338
	// (set) Token: 0x06011231 RID: 70193 RVA: 0x0042E140 File Offset: 0x0042C340
	public int ConditionId { get; set; }

	// Token: 0x170015BF RID: 5567
	// (get) Token: 0x06011232 RID: 70194 RVA: 0x0042E149 File Offset: 0x0042C349
	// (set) Token: 0x06011233 RID: 70195 RVA: 0x0042E151 File Offset: 0x0042C351
	public string ConditionTextId { get; set; }

	// Token: 0x170015C0 RID: 5568
	// (get) Token: 0x06011234 RID: 70196 RVA: 0x0042E15A File Offset: 0x0042C35A
	// (set) Token: 0x06011235 RID: 70197 RVA: 0x0042E162 File Offset: 0x0042C362
	public bool IsFinished { get; set; }

	// Token: 0x170015C1 RID: 5569
	// (get) Token: 0x06011236 RID: 70198 RVA: 0x0042E16B File Offset: 0x0042C36B
	// (set) Token: 0x06011237 RID: 70199 RVA: 0x0042E173 File Offset: 0x0042C373
	public int AccessId { get; set; }

	// Token: 0x170015C2 RID: 5570
	// (get) Token: 0x06011238 RID: 70200 RVA: 0x0042E17C File Offset: 0x0042C37C
	// (set) Token: 0x06011239 RID: 70201 RVA: 0x0042E184 File Offset: 0x0042C384
	public int AccessType { get; set; }

	// Token: 0x170015C3 RID: 5571
	// (get) Token: 0x0601123A RID: 70202 RVA: 0x0042E18D File Offset: 0x0042C38D
	// (set) Token: 0x0601123B RID: 70203 RVA: 0x0042E195 File Offset: 0x0042C395
	public int RecommendQuestId { get; set; }
}
