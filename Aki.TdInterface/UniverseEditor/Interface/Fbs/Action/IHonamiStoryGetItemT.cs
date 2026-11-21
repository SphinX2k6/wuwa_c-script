using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD8 RID: 28632
	public class IHonamiStoryGetItemT
	{
		// Token: 0x1700D1B6 RID: 53686
		// (get) Token: 0x060319AD RID: 203181 RVA: 0x006B884B File Offset: 0x006B6A4B
		// (set) Token: 0x060319AE RID: 203182 RVA: 0x006B8853 File Offset: 0x006B6A53
		public int ActivityId { get; set; }

		// Token: 0x1700D1B7 RID: 53687
		// (get) Token: 0x060319AF RID: 203183 RVA: 0x006B885C File Offset: 0x006B6A5C
		// (set) Token: 0x060319B0 RID: 203184 RVA: 0x006B8864 File Offset: 0x006B6A64
		public List<int> ItemId { get; set; }

		// Token: 0x060319B1 RID: 203185 RVA: 0x006B886D File Offset: 0x006B6A6D
		public IHonamiStoryGetItemT()
		{
			this.ActivityId = 0;
			this.ItemId = null;
		}
	}
}
