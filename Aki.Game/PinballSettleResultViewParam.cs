using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020008D1 RID: 2257
[NullableContext(1)]
[Nullable(0)]
public class PinballSettleResultViewParam : IPinballSettleResultViewParam
{
	// Token: 0x17000C92 RID: 3218
	// (get) Token: 0x060064B9 RID: 25785 RVA: 0x001FB6BB File Offset: 0x001F98BB
	// (set) Token: 0x060064BA RID: 25786 RVA: 0x001FB6C3 File Offset: 0x001F98C3
	public int LevelId { get; set; }

	// Token: 0x17000C93 RID: 3219
	// (get) Token: 0x060064BB RID: 25787 RVA: 0x001FB6CC File Offset: 0x001F98CC
	// (set) Token: 0x060064BC RID: 25788 RVA: 0x001FB6D4 File Offset: 0x001F98D4
	public EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000C94 RID: 3220
	// (get) Token: 0x060064BD RID: 25789 RVA: 0x001FB6DD File Offset: 0x001F98DD
	// (set) Token: 0x060064BE RID: 25790 RVA: 0x001FB6E5 File Offset: 0x001F98E5
	public bool IsWin { get; set; }

	// Token: 0x17000C95 RID: 3221
	// (get) Token: 0x060064BF RID: 25791 RVA: 0x001FB6EE File Offset: 0x001F98EE
	// (set) Token: 0x060064C0 RID: 25792 RVA: 0x001FB6F6 File Offset: 0x001F98F6
	public int MostValuablePlayerRoleId { get; set; }

	// Token: 0x17000C96 RID: 3222
	// (get) Token: 0x060064C1 RID: 25793 RVA: 0x001FB6FF File Offset: 0x001F98FF
	// (set) Token: 0x060064C2 RID: 25794 RVA: 0x001FB707 File Offset: 0x001F9907
	public Dictionary<int, float> Roles { get; set; } = new Dictionary<int, float>();

	// Token: 0x17000C97 RID: 3223
	// (get) Token: 0x060064C3 RID: 25795 RVA: 0x001FB710 File Offset: 0x001F9910
	// (set) Token: 0x060064C4 RID: 25796 RVA: 0x001FB718 File Offset: 0x001F9918
	public bool[] StarInfo { get; set; } = Array.Empty<bool>();

	// Token: 0x17000C98 RID: 3224
	// (get) Token: 0x060064C5 RID: 25797 RVA: 0x001FB721 File Offset: 0x001F9921
	// (set) Token: 0x060064C6 RID: 25798 RVA: 0x001FB729 File Offset: 0x001F9929
	public int Score { get; set; }

	// Token: 0x17000C99 RID: 3225
	// (get) Token: 0x060064C7 RID: 25799 RVA: 0x001FB732 File Offset: 0x001F9932
	// (set) Token: 0x060064C8 RID: 25800 RVA: 0x001FB73A File Offset: 0x001F993A
	public bool IsFirstPass { get; set; }
}
