using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDE RID: 28638
	public class ISetEntityClientVisibleT
	{
		// Token: 0x1700D49F RID: 54431
		// (get) Token: 0x06032A10 RID: 207376 RVA: 0x006D4B4B File Offset: 0x006D2D4B
		// (set) Token: 0x06032A11 RID: 207377 RVA: 0x006D4B53 File Offset: 0x006D2D53
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D4A0 RID: 54432
		// (get) Token: 0x06032A12 RID: 207378 RVA: 0x006D4B5C File Offset: 0x006D2D5C
		// (set) Token: 0x06032A13 RID: 207379 RVA: 0x006D4B64 File Offset: 0x006D2D64
		public bool Visible { get; set; }

		// Token: 0x06032A14 RID: 207380 RVA: 0x006D4B6D File Offset: 0x006D2D6D
		public ISetEntityClientVisibleT()
		{
			this.EntityIds = null;
			this.Visible = false;
		}
	}
}
