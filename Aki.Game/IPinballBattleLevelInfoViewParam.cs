using System;
using System.Runtime.CompilerServices;

// Token: 0x02001414 RID: 5140
[NullableContext(1)]
public interface IPinballBattleLevelInfoViewParam
{
	// Token: 0x17000C65 RID: 3173
	// (get) Token: 0x06009109 RID: 37129
	// (set) Token: 0x0600910A RID: 37130
	int LevelId { get; set; }

	// Token: 0x17000C66 RID: 3174
	// (get) Token: 0x0600910B RID: 37131
	// (set) Token: 0x0600910C RID: 37132
	EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000C67 RID: 3175
	// (get) Token: 0x0600910D RID: 37133
	// (set) Token: 0x0600910E RID: 37134
	int Score { get; set; }

	// Token: 0x17000C68 RID: 3176
	// (get) Token: 0x0600910F RID: 37135
	// (set) Token: 0x06009110 RID: 37136
	int[] StarInfo { get; set; }
}
