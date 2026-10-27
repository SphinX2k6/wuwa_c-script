using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AD RID: 28845
	public class ISetWayOccupancyStateT
	{
		// Token: 0x1700D646 RID: 54854
		// (get) Token: 0x06033147 RID: 209223 RVA: 0x006E3ADF File Offset: 0x006E1CDF
		// (set) Token: 0x06033148 RID: 209224 RVA: 0x006E3AE7 File Offset: 0x006E1CE7
		public bool Occupy { get; set; }

		// Token: 0x1700D647 RID: 54855
		// (get) Token: 0x06033149 RID: 209225 RVA: 0x006E3AF0 File Offset: 0x006E1CF0
		// (set) Token: 0x0603314A RID: 209226 RVA: 0x006E3AF8 File Offset: 0x006E1CF8
		public List<int> TargetWay { get; set; }

		// Token: 0x0603314B RID: 209227 RVA: 0x006E3B01 File Offset: 0x006E1D01
		public ISetWayOccupancyStateT()
		{
			this.Occupy = false;
			this.TargetWay = null;
		}
	}
}
