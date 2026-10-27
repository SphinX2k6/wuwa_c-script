using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A6 RID: 18342
	public class IEntityDataConfigT
	{
		// Token: 0x170083BA RID: 33722
		// (get) Token: 0x0601C4C9 RID: 115913 RVA: 0x004019F1 File Offset: 0x003FFBF1
		// (set) Token: 0x0601C4CA RID: 115914 RVA: 0x004019F9 File Offset: 0x003FFBF9
		public List<IEntityTemplateT> EntityDatas { get; set; }

		// Token: 0x0601C4CB RID: 115915 RVA: 0x00401A02 File Offset: 0x003FFC02
		public IEntityDataConfigT()
		{
			this.EntityDatas = null;
		}
	}
}
