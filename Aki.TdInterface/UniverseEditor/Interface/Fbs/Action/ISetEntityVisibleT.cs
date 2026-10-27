using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FEA RID: 28650
	public class ISetEntityVisibleT
	{
		// Token: 0x1700D4BF RID: 54463
		// (get) Token: 0x06032A92 RID: 207506 RVA: 0x006D5A8F File Offset: 0x006D3C8F
		// (set) Token: 0x06032A93 RID: 207507 RVA: 0x006D5A97 File Offset: 0x006D3C97
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D4C0 RID: 54464
		// (get) Token: 0x06032A94 RID: 207508 RVA: 0x006D5AA0 File Offset: 0x006D3CA0
		// (set) Token: 0x06032A95 RID: 207509 RVA: 0x006D5AA8 File Offset: 0x006D3CA8
		public bool Visible { get; set; }

		// Token: 0x1700D4C1 RID: 54465
		// (get) Token: 0x06032A96 RID: 207510 RVA: 0x006D5AB1 File Offset: 0x006D3CB1
		// (set) Token: 0x06032A97 RID: 207511 RVA: 0x006D5AB9 File Offset: 0x006D3CB9
		public bool PerformDestroy { get; set; }

		// Token: 0x1700D4C2 RID: 54466
		// (get) Token: 0x06032A98 RID: 207512 RVA: 0x006D5AC2 File Offset: 0x006D3CC2
		// (set) Token: 0x06032A99 RID: 207513 RVA: 0x006D5ACA File Offset: 0x006D3CCA
		public byte NullMask { get; set; }

		// Token: 0x06032A9A RID: 207514 RVA: 0x006D5AD3 File Offset: 0x006D3CD3
		public ISetEntityVisibleT()
		{
			this.EntityIds = null;
			this.Visible = false;
			this.PerformDestroy = false;
			this.NullMask = 0;
		}
	}
}
