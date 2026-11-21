using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C35 RID: 19509
	public class IEntityPrefabConfigT
	{
		// Token: 0x17008A54 RID: 35412
		// (get) Token: 0x0601DE40 RID: 122432 RVA: 0x00431005 File Offset: 0x0042F205
		// (set) Token: 0x0601DE41 RID: 122433 RVA: 0x0043100D File Offset: 0x0042F20D
		public List<IEntityPrefabT> Prefabs { get; set; }

		// Token: 0x0601DE42 RID: 122434 RVA: 0x00431016 File Offset: 0x0042F216
		public IEntityPrefabConfigT()
		{
			this.Prefabs = null;
		}
	}
}
