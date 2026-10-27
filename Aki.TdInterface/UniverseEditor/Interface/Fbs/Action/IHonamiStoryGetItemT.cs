using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006925 RID: 26917
	public class IHonamiStoryGetItemT
	{
		// Token: 0x1700C7B3 RID: 51123
		// (get) Token: 0x0602EFDD RID: 192477 RVA: 0x00668363 File Offset: 0x00666563
		// (set) Token: 0x0602EFDE RID: 192478 RVA: 0x0066836B File Offset: 0x0066656B
		public int ActivityId { get; set; }

		// Token: 0x1700C7B4 RID: 51124
		// (get) Token: 0x0602EFDF RID: 192479 RVA: 0x00668374 File Offset: 0x00666574
		// (set) Token: 0x0602EFE0 RID: 192480 RVA: 0x0066837C File Offset: 0x0066657C
		public List<int> ItemId { get; set; }

		// Token: 0x0602EFE1 RID: 192481 RVA: 0x00668385 File Offset: 0x00666585
		public IHonamiStoryGetItemT()
		{
			this.ActivityId = 0;
			this.ItemId = null;
		}
	}
}
