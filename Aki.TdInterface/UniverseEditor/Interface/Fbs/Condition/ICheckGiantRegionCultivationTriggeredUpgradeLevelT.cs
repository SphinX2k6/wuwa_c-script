using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A37 RID: 18999
	public class ICheckGiantRegionCultivationTriggeredUpgradeLevelT
	{
		// Token: 0x1700898D RID: 35213
		// (get) Token: 0x0601DBEA RID: 121834 RVA: 0x0042EE95 File Offset: 0x0042D095
		// (set) Token: 0x0601DBEB RID: 121835 RVA: 0x0042EE9D File Offset: 0x0042D09D
		public ECondition Type { get; set; }

		// Token: 0x1700898E RID: 35214
		// (get) Token: 0x0601DBEC RID: 121836 RVA: 0x0042EEA6 File Offset: 0x0042D0A6
		// (set) Token: 0x0601DBED RID: 121837 RVA: 0x0042EEAE File Offset: 0x0042D0AE
		public EGiantEcoType EcoType { get; set; }

		// Token: 0x1700898F RID: 35215
		// (get) Token: 0x0601DBEE RID: 121838 RVA: 0x0042EEB7 File Offset: 0x0042D0B7
		// (set) Token: 0x0601DBEF RID: 121839 RVA: 0x0042EEBF File Offset: 0x0042D0BF
		public List<int> Levels { get; set; }

		// Token: 0x0601DBF0 RID: 121840 RVA: 0x0042EEC8 File Offset: 0x0042D0C8
		public ICheckGiantRegionCultivationTriggeredUpgradeLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.EcoType = EGiantEcoType.Fire;
			this.Levels = null;
		}
	}
}
