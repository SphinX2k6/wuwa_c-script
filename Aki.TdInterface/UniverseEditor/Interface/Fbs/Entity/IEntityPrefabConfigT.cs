using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047CD RID: 18381
	public class IEntityPrefabConfigT
	{
		// Token: 0x17008413 RID: 33811
		// (get) Token: 0x0601C66B RID: 116331 RVA: 0x00404D69 File Offset: 0x00402F69
		// (set) Token: 0x0601C66C RID: 116332 RVA: 0x00404D71 File Offset: 0x00402F71
		public List<IEntityPrefabT> Prefabs { get; set; }

		// Token: 0x0601C66D RID: 116333 RVA: 0x00404D7A File Offset: 0x00402F7A
		public IEntityPrefabConfigT()
		{
			this.Prefabs = null;
		}
	}
}
