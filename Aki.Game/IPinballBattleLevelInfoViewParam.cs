using System;
using System.Runtime.CompilerServices;

// Token: 0x020008C8 RID: 2248
[NullableContext(1)]
public interface IPinballBattleLevelInfoViewParam
{
	// Token: 0x17000C85 RID: 3205
	// (get) Token: 0x0600649E RID: 25758
	// (set) Token: 0x0600649F RID: 25759
	int LevelId { get; set; }

	// Token: 0x17000C86 RID: 3206
	// (get) Token: 0x060064A0 RID: 25760
	// (set) Token: 0x060064A1 RID: 25761
	EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000C87 RID: 3207
	// (get) Token: 0x060064A2 RID: 25762
	// (set) Token: 0x060064A3 RID: 25763
	int Score { get; set; }

	// Token: 0x17000C88 RID: 3208
	// (get) Token: 0x060064A4 RID: 25764
	// (set) Token: 0x060064A5 RID: 25765
	int[] StarInfo { get; set; }
}
