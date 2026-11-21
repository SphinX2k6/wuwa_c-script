using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD0 RID: 23760
	public class IPasserbyNpcSplineMoveT
	{
		// Token: 0x1700AE98 RID: 44696
		// (get) Token: 0x06027711 RID: 161553 RVA: 0x00565FCB File Offset: 0x005641CB
		// (set) Token: 0x06027712 RID: 161554 RVA: 0x00565FD3 File Offset: 0x005641D3
		public EPasserbyNpcMoveType Type { get; set; }

		// Token: 0x1700AE99 RID: 44697
		// (get) Token: 0x06027713 RID: 161555 RVA: 0x00565FDC File Offset: 0x005641DC
		// (set) Token: 0x06027714 RID: 161556 RVA: 0x00565FE4 File Offset: 0x005641E4
		public List<IPasserbyNpcSplineT> Routes { get; set; }

		// Token: 0x06027715 RID: 161557 RVA: 0x00565FED File Offset: 0x005641ED
		public IPasserbyNpcSplineMoveT()
		{
			this.Type = EPasserbyNpcMoveType.Spline;
			this.Routes = null;
		}
	}
}
