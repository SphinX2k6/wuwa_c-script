using System;
using System.Runtime.CompilerServices;

// Token: 0x02001733 RID: 5939
[NullableContext(1)]
[Nullable(0)]
public class MotorLevelConditionData : IMotorLevelConditionData
{
	// Token: 0x170015F5 RID: 5621
	// (get) Token: 0x0600E6C6 RID: 59078 RVA: 0x0043ACD8 File Offset: 0x00438ED8
	// (set) Token: 0x0600E6C7 RID: 59079 RVA: 0x0043ACE0 File Offset: 0x00438EE0
	public int ConditionId { get; set; }

	// Token: 0x170015F6 RID: 5622
	// (get) Token: 0x0600E6C8 RID: 59080 RVA: 0x0043ACE9 File Offset: 0x00438EE9
	// (set) Token: 0x0600E6C9 RID: 59081 RVA: 0x0043ACF1 File Offset: 0x00438EF1
	public string ConditionTextId { get; set; }

	// Token: 0x170015F7 RID: 5623
	// (get) Token: 0x0600E6CA RID: 59082 RVA: 0x0043ACFA File Offset: 0x00438EFA
	// (set) Token: 0x0600E6CB RID: 59083 RVA: 0x0043AD02 File Offset: 0x00438F02
	public bool IsFinished { get; set; }

	// Token: 0x170015F8 RID: 5624
	// (get) Token: 0x0600E6CC RID: 59084 RVA: 0x0043AD0B File Offset: 0x00438F0B
	// (set) Token: 0x0600E6CD RID: 59085 RVA: 0x0043AD13 File Offset: 0x00438F13
	public int AccessId { get; set; }

	// Token: 0x170015F9 RID: 5625
	// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x0043AD1C File Offset: 0x00438F1C
	// (set) Token: 0x0600E6CF RID: 59087 RVA: 0x0043AD24 File Offset: 0x00438F24
	public int AccessType { get; set; }

	// Token: 0x170015FA RID: 5626
	// (get) Token: 0x0600E6D0 RID: 59088 RVA: 0x0043AD2D File Offset: 0x00438F2D
	// (set) Token: 0x0600E6D1 RID: 59089 RVA: 0x0043AD35 File Offset: 0x00438F35
	public int RecommendQuestId { get; set; }
}
