using System;
using System.Runtime.CompilerServices;

// Token: 0x0200150D RID: 5389
[NullableContext(1)]
[Nullable(0)]
public class KingShipFailViewData : IKingShipFailViewData
{
	// Token: 0x170013F3 RID: 5107
	// (get) Token: 0x0600D798 RID: 55192 RVA: 0x003FF2D6 File Offset: 0x003FD4D6
	// (set) Token: 0x0600D799 RID: 55193 RVA: 0x003FF2DE File Offset: 0x003FD4DE
	public int CardId { get; set; }

	// Token: 0x170013F4 RID: 5108
	// (get) Token: 0x0600D79A RID: 55194 RVA: 0x003FF2E7 File Offset: 0x003FD4E7
	// (set) Token: 0x0600D79B RID: 55195 RVA: 0x003FF2EF File Offset: 0x003FD4EF
	public Action OnCloseCallBack { get; set; }
}
