using System;
using System.Runtime.CompilerServices;

// Token: 0x0200203A RID: 8250
[NullableContext(1)]
[Nullable(0)]
public class KingShipFailViewData : IKingShipFailViewData
{
	// Token: 0x170013C6 RID: 5062
	// (get) Token: 0x06010330 RID: 66352 RVA: 0x003F2CDE File Offset: 0x003F0EDE
	// (set) Token: 0x06010331 RID: 66353 RVA: 0x003F2CE6 File Offset: 0x003F0EE6
	public int CardId { get; set; }

	// Token: 0x170013C7 RID: 5063
	// (get) Token: 0x06010332 RID: 66354 RVA: 0x003F2CEF File Offset: 0x003F0EEF
	// (set) Token: 0x06010333 RID: 66355 RVA: 0x003F2CF7 File Offset: 0x003F0EF7
	public Action OnCloseCallBack { get; set; }
}
