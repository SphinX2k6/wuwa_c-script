using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006901 RID: 26881
	public class IHideSpecifyEntityT
	{
		// Token: 0x1700C769 RID: 51049
		// (get) Token: 0x0602EE65 RID: 192101 RVA: 0x006659DB File Offset: 0x00663BDB
		// (set) Token: 0x0602EE66 RID: 192102 RVA: 0x006659E3 File Offset: 0x00663BE3
		public EHideType Type { get; set; }

		// Token: 0x1700C76A RID: 51050
		// (get) Token: 0x0602EE67 RID: 192103 RVA: 0x006659EC File Offset: 0x00663BEC
		// (set) Token: 0x0602EE68 RID: 192104 RVA: 0x006659F4 File Offset: 0x00663BF4
		public List<int> EntityIds { get; set; }

		// Token: 0x0602EE69 RID: 192105 RVA: 0x006659FD File Offset: 0x00663BFD
		public IHideSpecifyEntityT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.EntityIds = null;
		}
	}
}
