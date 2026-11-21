using System;
using System.Runtime.CompilerServices;

// Token: 0x020008A8 RID: 2216
[NullableContext(2)]
[Nullable(0)]
public class PinballLevelInfoData : IPinballLevelInfoData
{
	// Token: 0x17000C3E RID: 3134
	// (get) Token: 0x060063EE RID: 25582 RVA: 0x001FB503 File Offset: 0x001F9703
	// (set) Token: 0x060063EF RID: 25583 RVA: 0x001FB50B File Offset: 0x001F970B
	public int LevelId { get; set; }

	// Token: 0x17000C3F RID: 3135
	// (get) Token: 0x060063F0 RID: 25584 RVA: 0x001FB514 File Offset: 0x001F9714
	// (set) Token: 0x060063F1 RID: 25585 RVA: 0x001FB51C File Offset: 0x001F971C
	public int RealLevelId { get; set; }

	// Token: 0x17000C40 RID: 3136
	// (get) Token: 0x060063F2 RID: 25586 RVA: 0x001FB525 File Offset: 0x001F9725
	// (set) Token: 0x060063F3 RID: 25587 RVA: 0x001FB52D File Offset: 0x001F972D
	public int[] LevelStarConditionIds { get; set; }

	// Token: 0x17000C41 RID: 3137
	// (get) Token: 0x060063F4 RID: 25588 RVA: 0x001FB536 File Offset: 0x001F9736
	// (set) Token: 0x060063F5 RID: 25589 RVA: 0x001FB53E File Offset: 0x001F973E
	public int? LevelScore { get; set; }

	// Token: 0x17000C42 RID: 3138
	// (get) Token: 0x060063F6 RID: 25590 RVA: 0x001FB547 File Offset: 0x001F9747
	// (set) Token: 0x060063F7 RID: 25591 RVA: 0x001FB54F File Offset: 0x001F974F
	public bool? LevelLock { get; set; }

	// Token: 0x17000C43 RID: 3139
	// (get) Token: 0x060063F8 RID: 25592 RVA: 0x001FB558 File Offset: 0x001F9758
	// (set) Token: 0x060063F9 RID: 25593 RVA: 0x001FB560 File Offset: 0x001F9760
	public string LevelLockTexts { get; set; }

	// Token: 0x17000C44 RID: 3140
	// (get) Token: 0x060063FA RID: 25594 RVA: 0x001FB569 File Offset: 0x001F9769
	// (set) Token: 0x060063FB RID: 25595 RVA: 0x001FB571 File Offset: 0x001F9771
	public bool? ShowDesc { get; set; }

	// Token: 0x17000C45 RID: 3141
	// (get) Token: 0x060063FC RID: 25596 RVA: 0x001FB57A File Offset: 0x001F977A
	// (set) Token: 0x060063FD RID: 25597 RVA: 0x001FB582 File Offset: 0x001F9782
	public bool? ShowStar { get; set; }

	// Token: 0x17000C46 RID: 3142
	// (get) Token: 0x060063FE RID: 25598 RVA: 0x001FB58B File Offset: 0x001F978B
	// (set) Token: 0x060063FF RID: 25599 RVA: 0x001FB593 File Offset: 0x001F9793
	public bool? ShowScore { get; set; }

	// Token: 0x17000C47 RID: 3143
	// (get) Token: 0x06006400 RID: 25600 RVA: 0x001FB59C File Offset: 0x001F979C
	// (set) Token: 0x06006401 RID: 25601 RVA: 0x001FB5A4 File Offset: 0x001F97A4
	public bool? ShowReward { get; set; }

	// Token: 0x17000C48 RID: 3144
	// (get) Token: 0x06006402 RID: 25602 RVA: 0x001FB5AD File Offset: 0x001F97AD
	// (set) Token: 0x06006403 RID: 25603 RVA: 0x001FB5B5 File Offset: 0x001F97B5
	public int? RewardDropId { get; set; }

	// Token: 0x17000C49 RID: 3145
	// (get) Token: 0x06006404 RID: 25604 RVA: 0x001FB5BE File Offset: 0x001F97BE
	// (set) Token: 0x06006405 RID: 25605 RVA: 0x001FB5C6 File Offset: 0x001F97C6
	public bool? RewardReceived { get; set; }

	// Token: 0x17000C4A RID: 3146
	// (get) Token: 0x06006406 RID: 25606 RVA: 0x001FB5CF File Offset: 0x001F97CF
	// (set) Token: 0x06006407 RID: 25607 RVA: 0x001FB5D7 File Offset: 0x001F97D7
	public string RewardClearTitle { get; set; }
}
