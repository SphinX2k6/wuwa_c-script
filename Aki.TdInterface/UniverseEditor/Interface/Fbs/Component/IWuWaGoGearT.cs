using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C1 RID: 25025
	public class IWuWaGoGearT
	{
		// Token: 0x1700BA99 RID: 47769
		// (get) Token: 0x0602A8C5 RID: 174277 RVA: 0x005CD71B File Offset: 0x005CB91B
		// (set) Token: 0x0602A8C6 RID: 174278 RVA: 0x005CD723 File Offset: 0x005CB923
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BA9A RID: 47770
		// (get) Token: 0x0602A8C7 RID: 174279 RVA: 0x005CD72C File Offset: 0x005CB92C
		// (set) Token: 0x0602A8C8 RID: 174280 RVA: 0x005CD734 File Offset: 0x005CB934
		public List<int> GridEntityIds { get; set; }

		// Token: 0x0602A8C9 RID: 174281 RVA: 0x005CD73D File Offset: 0x005CB93D
		public IWuWaGoGearT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.GridEntityIds = null;
		}
	}
}
