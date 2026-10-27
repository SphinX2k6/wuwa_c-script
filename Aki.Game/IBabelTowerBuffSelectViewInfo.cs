using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001130 RID: 4400
[NullableContext(1)]
public interface IBabelTowerBuffSelectViewInfo
{
	// Token: 0x170009CF RID: 2511
	// (get) Token: 0x06007371 RID: 29553
	// (set) Token: 0x06007372 RID: 29554
	int LevelId { get; set; }

	// Token: 0x170009D0 RID: 2512
	// (get) Token: 0x06007373 RID: 29555
	// (set) Token: 0x06007374 RID: 29556
	int MaxSelectBuffCount { get; set; }

	// Token: 0x170009D1 RID: 2513
	// (get) Token: 0x06007375 RID: 29557
	// (set) Token: 0x06007376 RID: 29558
	List<int> CurrentSelectBuffList { get; set; }

	// Token: 0x170009D2 RID: 2514
	// (get) Token: 0x06007377 RID: 29559
	// (set) Token: 0x06007378 RID: 29560
	int ShowBuffId { get; set; }

	// Token: 0x170009D3 RID: 2515
	// (get) Token: 0x06007379 RID: 29561
	// (set) Token: 0x0600737A RID: 29562
	List<IBabelTowerBuffInfo> AllBuffList { get; set; }

	// Token: 0x170009D4 RID: 2516
	// (get) Token: 0x0600737B RID: 29563
	// (set) Token: 0x0600737C RID: 29564
	Action<List<int>> OnConfirmCallBack { get; set; }
}
