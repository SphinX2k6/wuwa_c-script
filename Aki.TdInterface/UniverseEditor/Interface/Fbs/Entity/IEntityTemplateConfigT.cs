using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C41 RID: 19521
	public class IEntityTemplateConfigT
	{
		// Token: 0x17008A84 RID: 35460
		// (get) Token: 0x0601DF04 RID: 122628 RVA: 0x00432C49 File Offset: 0x00430E49
		// (set) Token: 0x0601DF05 RID: 122629 RVA: 0x00432C51 File Offset: 0x00430E51
		public List<IEntityTemplateT> Templates { get; set; }

		// Token: 0x0601DF06 RID: 122630 RVA: 0x00432C5A File Offset: 0x00430E5A
		public IEntityTemplateConfigT()
		{
			this.Templates = null;
		}
	}
}
