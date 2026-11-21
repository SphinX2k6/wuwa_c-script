using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005E5 RID: 1509
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerBuffSelectViewInfo : IBabelTowerBuffSelectViewInfo
{
	// Token: 0x170009F5 RID: 2549
	// (get) Token: 0x06004714 RID: 18196 RVA: 0x00184540 File Offset: 0x00182740
	// (set) Token: 0x06004715 RID: 18197 RVA: 0x00184548 File Offset: 0x00182748
	public int LevelId { get; set; }

	// Token: 0x170009F6 RID: 2550
	// (get) Token: 0x06004716 RID: 18198 RVA: 0x00184551 File Offset: 0x00182751
	// (set) Token: 0x06004717 RID: 18199 RVA: 0x00184559 File Offset: 0x00182759
	public int MaxSelectBuffCount { get; set; }

	// Token: 0x170009F7 RID: 2551
	// (get) Token: 0x06004718 RID: 18200 RVA: 0x00184562 File Offset: 0x00182762
	// (set) Token: 0x06004719 RID: 18201 RVA: 0x0018456A File Offset: 0x0018276A
	public List<int> CurrentSelectBuffList { get; set; }

	// Token: 0x170009F8 RID: 2552
	// (get) Token: 0x0600471A RID: 18202 RVA: 0x00184573 File Offset: 0x00182773
	// (set) Token: 0x0600471B RID: 18203 RVA: 0x0018457B File Offset: 0x0018277B
	public int ShowBuffId { get; set; }

	// Token: 0x170009F9 RID: 2553
	// (get) Token: 0x0600471C RID: 18204 RVA: 0x00184584 File Offset: 0x00182784
	// (set) Token: 0x0600471D RID: 18205 RVA: 0x0018458C File Offset: 0x0018278C
	public List<IBabelTowerBuffInfo> AllBuffList { get; set; }

	// Token: 0x170009FA RID: 2554
	// (get) Token: 0x0600471E RID: 18206 RVA: 0x00184595 File Offset: 0x00182795
	// (set) Token: 0x0600471F RID: 18207 RVA: 0x0018459D File Offset: 0x0018279D
	public Action<List<int>> OnConfirmCallBack { get; set; }
}
