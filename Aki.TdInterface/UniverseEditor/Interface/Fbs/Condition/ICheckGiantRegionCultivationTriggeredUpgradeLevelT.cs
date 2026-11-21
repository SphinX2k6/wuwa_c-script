using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EFA RID: 20218
	public class ICheckGiantRegionCultivationTriggeredUpgradeLevelT
	{
		// Token: 0x17009062 RID: 36962
		// (get) Token: 0x0601F673 RID: 128627 RVA: 0x0045FD8D File Offset: 0x0045DF8D
		// (set) Token: 0x0601F674 RID: 128628 RVA: 0x0045FD95 File Offset: 0x0045DF95
		public ECondition Type { get; set; }

		// Token: 0x17009063 RID: 36963
		// (get) Token: 0x0601F675 RID: 128629 RVA: 0x0045FD9E File Offset: 0x0045DF9E
		// (set) Token: 0x0601F676 RID: 128630 RVA: 0x0045FDA6 File Offset: 0x0045DFA6
		public EGiantEcoType EcoType { get; set; }

		// Token: 0x17009064 RID: 36964
		// (get) Token: 0x0601F677 RID: 128631 RVA: 0x0045FDAF File Offset: 0x0045DFAF
		// (set) Token: 0x0601F678 RID: 128632 RVA: 0x0045FDB7 File Offset: 0x0045DFB7
		public List<int> Levels { get; set; }

		// Token: 0x0601F679 RID: 128633 RVA: 0x0045FDC0 File Offset: 0x0045DFC0
		public ICheckGiantRegionCultivationTriggeredUpgradeLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.EcoType = EGiantEcoType.Fire;
			this.Levels = null;
		}
	}
}
