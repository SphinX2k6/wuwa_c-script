using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAB RID: 23467
	public class IWuWaGoGearT
	{
		// Token: 0x1700B151 RID: 45393
		// (get) Token: 0x06028301 RID: 164609 RVA: 0x00585C8B File Offset: 0x00583E8B
		// (set) Token: 0x06028302 RID: 164610 RVA: 0x00585C93 File Offset: 0x00583E93
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B152 RID: 45394
		// (get) Token: 0x06028303 RID: 164611 RVA: 0x00585C9C File Offset: 0x00583E9C
		// (set) Token: 0x06028304 RID: 164612 RVA: 0x00585CA4 File Offset: 0x00583EA4
		public List<int> GridEntityIds { get; set; }

		// Token: 0x06028305 RID: 164613 RVA: 0x00585CAD File Offset: 0x00583EAD
		public IWuWaGoGearT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.GridEntityIds = null;
		}
	}
}
