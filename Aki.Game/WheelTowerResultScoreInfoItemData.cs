using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;

// Token: 0x020015B1 RID: 5553
[NullableContext(1)]
[Nullable(0)]
internal class WheelTowerResultScoreInfoItemData
{
	// Token: 0x17000D7A RID: 3450
	// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x0022401D File Offset: 0x0022221D
	// (set) Token: 0x06009DB7 RID: 40375 RVA: 0x00224025 File Offset: 0x00222225
	public string Desc { get; set; } = string.Empty;

	// Token: 0x17000D7B RID: 3451
	// (get) Token: 0x06009DB8 RID: 40376 RVA: 0x0022402E File Offset: 0x0022222E
	// (set) Token: 0x06009DB9 RID: 40377 RVA: 0x00224036 File Offset: 0x00222236
	public string Score { get; set; } = string.Empty;

	// Token: 0x17000D7C RID: 3452
	// (get) Token: 0x06009DBA RID: 40378 RVA: 0x0022403F File Offset: 0x0022223F
	// (set) Token: 0x06009DBB RID: 40379 RVA: 0x00224047 File Offset: 0x00222247
	public EScoreLevel ScoreLevel { get; set; }
}
