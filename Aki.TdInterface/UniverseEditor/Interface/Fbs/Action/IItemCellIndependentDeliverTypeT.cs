using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B5 RID: 27061
	public class IItemCellIndependentDeliverTypeT
	{
		// Token: 0x1700C8BD RID: 51389
		// (get) Token: 0x0602F495 RID: 193685 RVA: 0x00670C77 File Offset: 0x0066EE77
		// (set) Token: 0x0602F496 RID: 193686 RVA: 0x00670C7F File Offset: 0x0066EE7F
		public EDeliverType Type { get; set; }

		// Token: 0x1700C8BE RID: 51390
		// (get) Token: 0x0602F497 RID: 193687 RVA: 0x00670C88 File Offset: 0x0066EE88
		// (set) Token: 0x0602F498 RID: 193688 RVA: 0x00670C90 File Offset: 0x0066EE90
		public List<IDeliverItemT> DeliverItem { get; set; }

		// Token: 0x0602F499 RID: 193689 RVA: 0x00670C99 File Offset: 0x0066EE99
		public IItemCellIndependentDeliverTypeT()
		{
			this.Type = EDeliverType.ItemIdCellIndependent;
			this.DeliverItem = null;
		}
	}
}
