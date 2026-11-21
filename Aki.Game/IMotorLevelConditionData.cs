using System;
using System.Runtime.CompilerServices;

// Token: 0x02001732 RID: 5938
[NullableContext(1)]
public interface IMotorLevelConditionData
{
	// Token: 0x170015EF RID: 5615
	// (get) Token: 0x0600E6BA RID: 59066
	// (set) Token: 0x0600E6BB RID: 59067
	int ConditionId { get; set; }

	// Token: 0x170015F0 RID: 5616
	// (get) Token: 0x0600E6BC RID: 59068
	// (set) Token: 0x0600E6BD RID: 59069
	string ConditionTextId { get; set; }

	// Token: 0x170015F1 RID: 5617
	// (get) Token: 0x0600E6BE RID: 59070
	// (set) Token: 0x0600E6BF RID: 59071
	bool IsFinished { get; set; }

	// Token: 0x170015F2 RID: 5618
	// (get) Token: 0x0600E6C0 RID: 59072
	// (set) Token: 0x0600E6C1 RID: 59073
	int AccessId { get; set; }

	// Token: 0x170015F3 RID: 5619
	// (get) Token: 0x0600E6C2 RID: 59074
	// (set) Token: 0x0600E6C3 RID: 59075
	int AccessType { get; set; }

	// Token: 0x170015F4 RID: 5620
	// (get) Token: 0x0600E6C4 RID: 59076
	// (set) Token: 0x0600E6C5 RID: 59077
	int RecommendQuestId { get; set; }
}
