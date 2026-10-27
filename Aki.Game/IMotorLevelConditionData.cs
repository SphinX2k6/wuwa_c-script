using System;
using System.Runtime.CompilerServices;

// Token: 0x0200224E RID: 8782
[NullableContext(1)]
public interface IMotorLevelConditionData
{
	// Token: 0x170015B8 RID: 5560
	// (get) Token: 0x06011224 RID: 70180
	// (set) Token: 0x06011225 RID: 70181
	int ConditionId { get; set; }

	// Token: 0x170015B9 RID: 5561
	// (get) Token: 0x06011226 RID: 70182
	// (set) Token: 0x06011227 RID: 70183
	string ConditionTextId { get; set; }

	// Token: 0x170015BA RID: 5562
	// (get) Token: 0x06011228 RID: 70184
	// (set) Token: 0x06011229 RID: 70185
	bool IsFinished { get; set; }

	// Token: 0x170015BB RID: 5563
	// (get) Token: 0x0601122A RID: 70186
	// (set) Token: 0x0601122B RID: 70187
	int AccessId { get; set; }

	// Token: 0x170015BC RID: 5564
	// (get) Token: 0x0601122C RID: 70188
	// (set) Token: 0x0601122D RID: 70189
	int AccessType { get; set; }

	// Token: 0x170015BD RID: 5565
	// (get) Token: 0x0601122E RID: 70190
	// (set) Token: 0x0601122F RID: 70191
	int RecommendQuestId { get; set; }
}
