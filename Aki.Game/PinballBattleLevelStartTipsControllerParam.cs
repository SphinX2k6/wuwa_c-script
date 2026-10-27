using System;
using System.Runtime.CompilerServices;

// Token: 0x02001425 RID: 5157
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleLevelStartTipsControllerParam : IPinballBattleLevelStartTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000C95 RID: 3221
	// (get) Token: 0x06009172 RID: 37234 RVA: 0x001F2E33 File Offset: 0x001F1033
	// (set) Token: 0x06009173 RID: 37235 RVA: 0x001F2E3B File Offset: 0x001F103B
	public int CurWave { get; set; }

	// Token: 0x17000C96 RID: 3222
	// (get) Token: 0x06009174 RID: 37236 RVA: 0x001F2E44 File Offset: 0x001F1044
	// (set) Token: 0x06009175 RID: 37237 RVA: 0x001F2E4C File Offset: 0x001F104C
	public int MaxWave { get; set; }

	// Token: 0x17000C97 RID: 3223
	// (get) Token: 0x06009176 RID: 37238 RVA: 0x001F2E55 File Offset: 0x001F1055
	// (set) Token: 0x06009177 RID: 37239 RVA: 0x001F2E5D File Offset: 0x001F105D
	public Action CloseCallback { get; set; }

	// Token: 0x17000C98 RID: 3224
	// (get) Token: 0x06009178 RID: 37240 RVA: 0x001F2E66 File Offset: 0x001F1066
	// (set) Token: 0x06009179 RID: 37241 RVA: 0x001F2E6E File Offset: 0x001F106E
	public bool? AddMask { get; set; }

	// Token: 0x17000C99 RID: 3225
	// (get) Token: 0x0600917A RID: 37242 RVA: 0x001F2E77 File Offset: 0x001F1077
	// (set) Token: 0x0600917B RID: 37243 RVA: 0x001F2E7F File Offset: 0x001F107F
	public int? CloseTime { get; set; }

	// Token: 0x17000C9A RID: 3226
	// (get) Token: 0x0600917C RID: 37244 RVA: 0x001F2E88 File Offset: 0x001F1088
	// (set) Token: 0x0600917D RID: 37245 RVA: 0x001F2E90 File Offset: 0x001F1090
	public bool? MoveToBehind { get; set; }
}
