using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FB RID: 26875
	public class IHideSpecificEntitiesT
	{
		// Token: 0x1700C760 RID: 51040
		// (get) Token: 0x0602EE2B RID: 192043 RVA: 0x006653A9 File Offset: 0x006635A9
		// (set) Token: 0x0602EE2C RID: 192044 RVA: 0x006653B1 File Offset: 0x006635B1
		public List<int> EntityIds { get; set; }

		// Token: 0x0602EE2D RID: 192045 RVA: 0x006653BA File Offset: 0x006635BA
		public IHideSpecificEntitiesT()
		{
			this.EntityIds = null;
		}
	}
}
