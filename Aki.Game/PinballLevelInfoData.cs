using System;
using System.Runtime.CompilerServices;

// Token: 0x020013F4 RID: 5108
[NullableContext(2)]
[Nullable(0)]
public class PinballLevelInfoData : IPinballLevelInfoData
{
	// Token: 0x17000C1E RID: 3102
	// (get) Token: 0x06009059 RID: 36953 RVA: 0x001F29C7 File Offset: 0x001F0BC7
	// (set) Token: 0x0600905A RID: 36954 RVA: 0x001F29CF File Offset: 0x001F0BCF
	public int LevelId { get; set; }

	// Token: 0x17000C1F RID: 3103
	// (get) Token: 0x0600905B RID: 36955 RVA: 0x001F29D8 File Offset: 0x001F0BD8
	// (set) Token: 0x0600905C RID: 36956 RVA: 0x001F29E0 File Offset: 0x001F0BE0
	public int RealLevelId { get; set; }

	// Token: 0x17000C20 RID: 3104
	// (get) Token: 0x0600905D RID: 36957 RVA: 0x001F29E9 File Offset: 0x001F0BE9
	// (set) Token: 0x0600905E RID: 36958 RVA: 0x001F29F1 File Offset: 0x001F0BF1
	public int[] LevelStarConditionIds { get; set; }

	// Token: 0x17000C21 RID: 3105
	// (get) Token: 0x0600905F RID: 36959 RVA: 0x001F29FA File Offset: 0x001F0BFA
	// (set) Token: 0x06009060 RID: 36960 RVA: 0x001F2A02 File Offset: 0x001F0C02
	public int? LevelScore { get; set; }

	// Token: 0x17000C22 RID: 3106
	// (get) Token: 0x06009061 RID: 36961 RVA: 0x001F2A0B File Offset: 0x001F0C0B
	// (set) Token: 0x06009062 RID: 36962 RVA: 0x001F2A13 File Offset: 0x001F0C13
	public bool? LevelLock { get; set; }

	// Token: 0x17000C23 RID: 3107
	// (get) Token: 0x06009063 RID: 36963 RVA: 0x001F2A1C File Offset: 0x001F0C1C
	// (set) Token: 0x06009064 RID: 36964 RVA: 0x001F2A24 File Offset: 0x001F0C24
	public string LevelLockTexts { get; set; }

	// Token: 0x17000C24 RID: 3108
	// (get) Token: 0x06009065 RID: 36965 RVA: 0x001F2A2D File Offset: 0x001F0C2D
	// (set) Token: 0x06009066 RID: 36966 RVA: 0x001F2A35 File Offset: 0x001F0C35
	public bool? ShowDesc { get; set; }

	// Token: 0x17000C25 RID: 3109
	// (get) Token: 0x06009067 RID: 36967 RVA: 0x001F2A3E File Offset: 0x001F0C3E
	// (set) Token: 0x06009068 RID: 36968 RVA: 0x001F2A46 File Offset: 0x001F0C46
	public bool? ShowStar { get; set; }

	// Token: 0x17000C26 RID: 3110
	// (get) Token: 0x06009069 RID: 36969 RVA: 0x001F2A4F File Offset: 0x001F0C4F
	// (set) Token: 0x0600906A RID: 36970 RVA: 0x001F2A57 File Offset: 0x001F0C57
	public bool? ShowScore { get; set; }

	// Token: 0x17000C27 RID: 3111
	// (get) Token: 0x0600906B RID: 36971 RVA: 0x001F2A60 File Offset: 0x001F0C60
	// (set) Token: 0x0600906C RID: 36972 RVA: 0x001F2A68 File Offset: 0x001F0C68
	public bool? ShowReward { get; set; }

	// Token: 0x17000C28 RID: 3112
	// (get) Token: 0x0600906D RID: 36973 RVA: 0x001F2A71 File Offset: 0x001F0C71
	// (set) Token: 0x0600906E RID: 36974 RVA: 0x001F2A79 File Offset: 0x001F0C79
	public int? RewardDropId { get; set; }

	// Token: 0x17000C29 RID: 3113
	// (get) Token: 0x0600906F RID: 36975 RVA: 0x001F2A82 File Offset: 0x001F0C82
	// (set) Token: 0x06009070 RID: 36976 RVA: 0x001F2A8A File Offset: 0x001F0C8A
	public bool? RewardReceived { get; set; }

	// Token: 0x17000C2A RID: 3114
	// (get) Token: 0x06009071 RID: 36977 RVA: 0x001F2A93 File Offset: 0x001F0C93
	// (set) Token: 0x06009072 RID: 36978 RVA: 0x001F2A9B File Offset: 0x001F0C9B
	public string RewardClearTitle { get; set; }
}
