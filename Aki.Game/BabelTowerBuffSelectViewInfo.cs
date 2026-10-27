using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001131 RID: 4401
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerBuffSelectViewInfo : IBabelTowerBuffSelectViewInfo
{
	// Token: 0x170009D5 RID: 2517
	// (get) Token: 0x0600737D RID: 29565 RVA: 0x0017B9F2 File Offset: 0x00179BF2
	// (set) Token: 0x0600737E RID: 29566 RVA: 0x0017B9FA File Offset: 0x00179BFA
	public int LevelId { get; set; }

	// Token: 0x170009D6 RID: 2518
	// (get) Token: 0x0600737F RID: 29567 RVA: 0x0017BA03 File Offset: 0x00179C03
	// (set) Token: 0x06007380 RID: 29568 RVA: 0x0017BA0B File Offset: 0x00179C0B
	public int MaxSelectBuffCount { get; set; }

	// Token: 0x170009D7 RID: 2519
	// (get) Token: 0x06007381 RID: 29569 RVA: 0x0017BA14 File Offset: 0x00179C14
	// (set) Token: 0x06007382 RID: 29570 RVA: 0x0017BA1C File Offset: 0x00179C1C
	public List<int> CurrentSelectBuffList { get; set; }

	// Token: 0x170009D8 RID: 2520
	// (get) Token: 0x06007383 RID: 29571 RVA: 0x0017BA25 File Offset: 0x00179C25
	// (set) Token: 0x06007384 RID: 29572 RVA: 0x0017BA2D File Offset: 0x00179C2D
	public int ShowBuffId { get; set; }

	// Token: 0x170009D9 RID: 2521
	// (get) Token: 0x06007385 RID: 29573 RVA: 0x0017BA36 File Offset: 0x00179C36
	// (set) Token: 0x06007386 RID: 29574 RVA: 0x0017BA3E File Offset: 0x00179C3E
	public List<IBabelTowerBuffInfo> AllBuffList { get; set; }

	// Token: 0x170009DA RID: 2522
	// (get) Token: 0x06007387 RID: 29575 RVA: 0x0017BA47 File Offset: 0x00179C47
	// (set) Token: 0x06007388 RID: 29576 RVA: 0x0017BA4F File Offset: 0x00179C4F
	public Action<List<int>> OnConfirmCallBack { get; set; }
}
