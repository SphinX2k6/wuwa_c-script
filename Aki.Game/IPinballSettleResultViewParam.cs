using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020008B5 RID: 2229
[NullableContext(1)]
public interface IPinballSettleResultViewParam
{
	// Token: 0x17000C5A RID: 3162
	// (get) Token: 0x0600642F RID: 25647
	// (set) Token: 0x06006430 RID: 25648
	int LevelId { get; set; }

	// Token: 0x17000C5B RID: 3163
	// (get) Token: 0x06006431 RID: 25649
	// (set) Token: 0x06006432 RID: 25650
	EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000C5C RID: 3164
	// (get) Token: 0x06006433 RID: 25651
	// (set) Token: 0x06006434 RID: 25652
	bool IsWin { get; set; }

	// Token: 0x17000C5D RID: 3165
	// (get) Token: 0x06006435 RID: 25653
	// (set) Token: 0x06006436 RID: 25654
	int MostValuablePlayerRoleId { get; set; }

	// Token: 0x17000C5E RID: 3166
	// (get) Token: 0x06006437 RID: 25655
	// (set) Token: 0x06006438 RID: 25656
	Dictionary<int, float> Roles { get; set; }

	// Token: 0x17000C5F RID: 3167
	// (get) Token: 0x06006439 RID: 25657
	// (set) Token: 0x0600643A RID: 25658
	bool[] StarInfo { get; set; }

	// Token: 0x17000C60 RID: 3168
	// (get) Token: 0x0600643B RID: 25659
	// (set) Token: 0x0600643C RID: 25660
	int Score { get; set; }

	// Token: 0x17000C61 RID: 3169
	// (get) Token: 0x0600643D RID: 25661
	// (set) Token: 0x0600643E RID: 25662
	bool IsFirstPass { get; set; }
}
