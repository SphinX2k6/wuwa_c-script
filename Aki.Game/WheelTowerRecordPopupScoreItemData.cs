using System;
using System.Runtime.CompilerServices;

// Token: 0x0200162B RID: 5675
[NullableContext(1)]
[Nullable(0)]
internal class WheelTowerRecordPopupScoreItemData
{
	// Token: 0x17000D85 RID: 3461
	// (get) Token: 0x06009FA8 RID: 40872 RVA: 0x00231378 File Offset: 0x0022F578
	// (set) Token: 0x06009FA9 RID: 40873 RVA: 0x00231380 File Offset: 0x0022F580
	public string Title { get; set; } = string.Empty;

	// Token: 0x17000D86 RID: 3462
	// (get) Token: 0x06009FAA RID: 40874 RVA: 0x00231389 File Offset: 0x0022F589
	// (set) Token: 0x06009FAB RID: 40875 RVA: 0x00231391 File Offset: 0x0022F591
	public int ScoreOld { get; set; }

	// Token: 0x17000D87 RID: 3463
	// (get) Token: 0x06009FAC RID: 40876 RVA: 0x0023139A File Offset: 0x0022F59A
	// (set) Token: 0x06009FAD RID: 40877 RVA: 0x002313A2 File Offset: 0x0022F5A2
	public int ScoreNew { get; set; }

	// Token: 0x17000D88 RID: 3464
	// (get) Token: 0x06009FAE RID: 40878 RVA: 0x002313AB File Offset: 0x0022F5AB
	// (set) Token: 0x06009FAF RID: 40879 RVA: 0x002313B3 File Offset: 0x0022F5B3
	public bool NeedScoreIcon { get; set; }
}
