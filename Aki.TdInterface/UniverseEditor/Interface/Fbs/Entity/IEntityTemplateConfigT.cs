using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D9 RID: 18393
	public class IEntityTemplateConfigT
	{
		// Token: 0x17008439 RID: 33849
		// (get) Token: 0x0601C707 RID: 116487 RVA: 0x004062F9 File Offset: 0x004044F9
		// (set) Token: 0x0601C708 RID: 116488 RVA: 0x00406301 File Offset: 0x00404501
		public List<IEntityTemplateT> Templates { get; set; }

		// Token: 0x0601C709 RID: 116489 RVA: 0x0040630A File Offset: 0x0040450A
		public IEntityTemplateConfigT()
		{
			this.Templates = null;
		}
	}
}
