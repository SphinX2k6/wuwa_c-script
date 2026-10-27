using System;
using System.Runtime.CompilerServices;

// Token: 0x0200142E RID: 5166
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleLevelInfoViewParam : IPinballBattleLevelInfoViewParam
{
	// Token: 0x17000CBD RID: 3261
	// (get) Token: 0x060091CB RID: 37323 RVA: 0x001F3123 File Offset: 0x001F1323
	// (set) Token: 0x060091CC RID: 37324 RVA: 0x001F312B File Offset: 0x001F132B
	public int LevelId { get; set; }

	// Token: 0x17000CBE RID: 3262
	// (get) Token: 0x060091CD RID: 37325 RVA: 0x001F3134 File Offset: 0x001F1334
	// (set) Token: 0x060091CE RID: 37326 RVA: 0x001F313C File Offset: 0x001F133C
	public EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000CBF RID: 3263
	// (get) Token: 0x060091CF RID: 37327 RVA: 0x001F3145 File Offset: 0x001F1345
	// (set) Token: 0x060091D0 RID: 37328 RVA: 0x001F314D File Offset: 0x001F134D
	public int Score { get; set; }

	// Token: 0x17000CC0 RID: 3264
	// (get) Token: 0x060091D1 RID: 37329 RVA: 0x001F3156 File Offset: 0x001F1356
	// (set) Token: 0x060091D2 RID: 37330 RVA: 0x001F315E File Offset: 0x001F135E
	public int[] StarInfo { get; set; }
}
