using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC2 RID: 23490
	public class IWuWaGoLevelCenterT
	{
		// Token: 0x1700B179 RID: 45433
		// (get) Token: 0x060283B9 RID: 164793 RVA: 0x005871A2 File Offset: 0x005853A2
		// (set) Token: 0x060283BA RID: 164794 RVA: 0x005871AA File Offset: 0x005853AA
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B17A RID: 45434
		// (get) Token: 0x060283BB RID: 164795 RVA: 0x005871B3 File Offset: 0x005853B3
		// (set) Token: 0x060283BC RID: 164796 RVA: 0x005871BB File Offset: 0x005853BB
		public string LevelKey { get; set; }

		// Token: 0x1700B17B RID: 45435
		// (get) Token: 0x060283BD RID: 164797 RVA: 0x005871C4 File Offset: 0x005853C4
		// (set) Token: 0x060283BE RID: 164798 RVA: 0x005871CC File Offset: 0x005853CC
		public List<int> LevelEntityIds { get; set; }

		// Token: 0x060283BF RID: 164799 RVA: 0x005871D5 File Offset: 0x005853D5
		public IWuWaGoLevelCenterT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LevelKey = null;
			this.LevelEntityIds = null;
		}
	}
}
