using System;
using System.Runtime.CompilerServices;

// Token: 0x020008E2 RID: 2274
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleLevelInfoViewParam : IPinballBattleLevelInfoViewParam
{
	// Token: 0x17000CDD RID: 3293
	// (get) Token: 0x06006560 RID: 25952 RVA: 0x001FBC5F File Offset: 0x001F9E5F
	// (set) Token: 0x06006561 RID: 25953 RVA: 0x001FBC67 File Offset: 0x001F9E67
	public int LevelId { get; set; }

	// Token: 0x17000CDE RID: 3294
	// (get) Token: 0x06006562 RID: 25954 RVA: 0x001FBC70 File Offset: 0x001F9E70
	// (set) Token: 0x06006563 RID: 25955 RVA: 0x001FBC78 File Offset: 0x001F9E78
	public EPinballLevelShowType LevelType { get; set; }

	// Token: 0x17000CDF RID: 3295
	// (get) Token: 0x06006564 RID: 25956 RVA: 0x001FBC81 File Offset: 0x001F9E81
	// (set) Token: 0x06006565 RID: 25957 RVA: 0x001FBC89 File Offset: 0x001F9E89
	public int Score { get; set; }

	// Token: 0x17000CE0 RID: 3296
	// (get) Token: 0x06006566 RID: 25958 RVA: 0x001FBC92 File Offset: 0x001F9E92
	// (set) Token: 0x06006567 RID: 25959 RVA: 0x001FBC9A File Offset: 0x001F9E9A
	public int[] StarInfo { get; set; }
}
