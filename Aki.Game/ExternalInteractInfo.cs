using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001FA9 RID: 8105
[NullableContext(1)]
[Nullable(0)]
public class ExternalInteractInfo
{
	// Token: 0x1700134D RID: 4941
	// (get) Token: 0x0600FBEC RID: 64492 RVA: 0x003D10F7 File Offset: 0x003CF2F7
	// (set) Token: 0x0600FBED RID: 64493 RVA: 0x003D10FF File Offset: 0x003CF2FF
	public string Text { get; set; }

	// Token: 0x1700134E RID: 4942
	// (get) Token: 0x0600FBEE RID: 64494 RVA: 0x003D1108 File Offset: 0x003CF308
	// (set) Token: 0x0600FBEF RID: 64495 RVA: 0x003D1110 File Offset: 0x003CF310
	public EInteractIcon IconType { get; set; }

	// Token: 0x1700134F RID: 4943
	// (get) Token: 0x0600FBF0 RID: 64496 RVA: 0x003D1119 File Offset: 0x003CF319
	// (set) Token: 0x0600FBF1 RID: 64497 RVA: 0x003D1121 File Offset: 0x003CF321
	public Action Callback { get; set; }
}
