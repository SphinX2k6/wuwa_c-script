using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA8 RID: 16296
	public class IPlotHandBookItemT
	{
		// Token: 0x170071C9 RID: 29129
		// (get) Token: 0x060174A6 RID: 95398 RVA: 0x0035BB17 File Offset: 0x00359D17
		// (set) Token: 0x060174A7 RID: 95399 RVA: 0x0035BB1F File Offset: 0x00359D1F
		public int Id { get; set; }

		// Token: 0x170071CA RID: 29130
		// (get) Token: 0x060174A8 RID: 95400 RVA: 0x0035BB28 File Offset: 0x00359D28
		// (set) Token: 0x060174A9 RID: 95401 RVA: 0x0035BB30 File Offset: 0x00359D30
		public List<IPlotHandBookNodeT> Nodes { get; set; }

		// Token: 0x060174AA RID: 95402 RVA: 0x0035BB39 File Offset: 0x00359D39
		public IPlotHandBookItemT()
		{
			this.Id = 0;
			this.Nodes = null;
		}
	}
}
