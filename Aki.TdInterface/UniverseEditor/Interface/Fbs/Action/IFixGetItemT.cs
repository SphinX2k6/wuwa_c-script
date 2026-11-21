using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E58 RID: 28248
	public class IFixGetItemT
	{
		// Token: 0x1700CF0C RID: 53004
		// (get) Token: 0x06030CC4 RID: 199876 RVA: 0x0069F469 File Offset: 0x0069D669
		// (set) Token: 0x06030CC5 RID: 199877 RVA: 0x0069F471 File Offset: 0x0069D671
		public List<IItemDataT> Items { get; set; }

		// Token: 0x06030CC6 RID: 199878 RVA: 0x0069F47A File Offset: 0x0069D67A
		public IFixGetItemT()
		{
			this.Items = null;
		}
	}
}
