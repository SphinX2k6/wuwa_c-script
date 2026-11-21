using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005E4 RID: 1508
[NullableContext(1)]
public interface IBabelTowerBuffSelectViewInfo
{
	// Token: 0x170009EF RID: 2543
	// (get) Token: 0x06004708 RID: 18184
	// (set) Token: 0x06004709 RID: 18185
	int LevelId { get; set; }

	// Token: 0x170009F0 RID: 2544
	// (get) Token: 0x0600470A RID: 18186
	// (set) Token: 0x0600470B RID: 18187
	int MaxSelectBuffCount { get; set; }

	// Token: 0x170009F1 RID: 2545
	// (get) Token: 0x0600470C RID: 18188
	// (set) Token: 0x0600470D RID: 18189
	List<int> CurrentSelectBuffList { get; set; }

	// Token: 0x170009F2 RID: 2546
	// (get) Token: 0x0600470E RID: 18190
	// (set) Token: 0x0600470F RID: 18191
	int ShowBuffId { get; set; }

	// Token: 0x170009F3 RID: 2547
	// (get) Token: 0x06004710 RID: 18192
	// (set) Token: 0x06004711 RID: 18193
	List<IBabelTowerBuffInfo> AllBuffList { get; set; }

	// Token: 0x170009F4 RID: 2548
	// (get) Token: 0x06004712 RID: 18194
	// (set) Token: 0x06004713 RID: 18195
	Action<List<int>> OnConfirmCallBack { get; set; }
}
