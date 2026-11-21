using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA9 RID: 23721
	public class IPasserbyNpcRandomGroupT
	{
		// Token: 0x1700AE41 RID: 44609
		// (get) Token: 0x060275B5 RID: 161205 RVA: 0x00563381 File Offset: 0x00561581
		// (set) Token: 0x060275B6 RID: 161206 RVA: 0x00563389 File Offset: 0x00561589
		public int Weight { get; set; }

		// Token: 0x1700AE42 RID: 44610
		// (get) Token: 0x060275B7 RID: 161207 RVA: 0x00563392 File Offset: 0x00561592
		// (set) Token: 0x060275B8 RID: 161208 RVA: 0x0056339A File Offset: 0x0056159A
		public int NpcCount { get; set; }

		// Token: 0x1700AE43 RID: 44611
		// (get) Token: 0x060275B9 RID: 161209 RVA: 0x005633A3 File Offset: 0x005615A3
		// (set) Token: 0x060275BA RID: 161210 RVA: 0x005633AB File Offset: 0x005615AB
		public List<IPasserbyNpcStandPosT> StandPositions { get; set; }

		// Token: 0x060275BB RID: 161211 RVA: 0x005633B4 File Offset: 0x005615B4
		public IPasserbyNpcRandomGroupT()
		{
			this.Weight = 0;
			this.NpcCount = 0;
			this.StandPositions = null;
		}
	}
}
