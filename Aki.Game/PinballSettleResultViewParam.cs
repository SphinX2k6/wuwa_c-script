using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200141D RID: 5149
[NullableContext(1)]
[Nullable(0)]
public class PinballSettleResultViewParam : IPinballSettleResultViewParam
{
	// Token: 0x17000C72 RID: 3186
	// (get) Token: 0x06009124 RID: 37156 RVA: 0x001F2B7F File Offset: 0x001F0D7F
	// (set) Token: 0x06009125 RID: 37157 RVA: 0x001F2B87 File Offset: 0x001F0D87
	public int LevelId { get; set; }

	// Token: 0x17000C73 RID: 3187
	// (get) Token: 0x06009126 RID: 37158 RVA: 0x001F2B90 File Offset: 0x001F0D90
	// (set) Token: 0x06009127 RID: 37159 RVA: 0x001F2B98 File Offset: 0x001F0D98
	public EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000C74 RID: 3188
	// (get) Token: 0x06009128 RID: 37160 RVA: 0x001F2BA1 File Offset: 0x001F0DA1
	// (set) Token: 0x06009129 RID: 37161 RVA: 0x001F2BA9 File Offset: 0x001F0DA9
	public bool IsWin { get; set; }

	// Token: 0x17000C75 RID: 3189
	// (get) Token: 0x0600912A RID: 37162 RVA: 0x001F2BB2 File Offset: 0x001F0DB2
	// (set) Token: 0x0600912B RID: 37163 RVA: 0x001F2BBA File Offset: 0x001F0DBA
	public int MostValuablePlayerRoleId { get; set; }

	// Token: 0x17000C76 RID: 3190
	// (get) Token: 0x0600912C RID: 37164 RVA: 0x001F2BC3 File Offset: 0x001F0DC3
	// (set) Token: 0x0600912D RID: 37165 RVA: 0x001F2BCB File Offset: 0x001F0DCB
	public Dictionary<int, float> Roles { get; set; } = new Dictionary<int, float>();

	// Token: 0x17000C77 RID: 3191
	// (get) Token: 0x0600912E RID: 37166 RVA: 0x001F2BD4 File Offset: 0x001F0DD4
	// (set) Token: 0x0600912F RID: 37167 RVA: 0x001F2BDC File Offset: 0x001F0DDC
	public bool[] StarInfo { get; set; } = Array.Empty<bool>();

	// Token: 0x17000C78 RID: 3192
	// (get) Token: 0x06009130 RID: 37168 RVA: 0x001F2BE5 File Offset: 0x001F0DE5
	// (set) Token: 0x06009131 RID: 37169 RVA: 0x001F2BED File Offset: 0x001F0DED
	public int Score { get; set; }

	// Token: 0x17000C79 RID: 3193
	// (get) Token: 0x06009132 RID: 37170 RVA: 0x001F2BF6 File Offset: 0x001F0DF6
	// (set) Token: 0x06009133 RID: 37171 RVA: 0x001F2BFE File Offset: 0x001F0DFE
	public bool IsFirstPass { get; set; }
}
