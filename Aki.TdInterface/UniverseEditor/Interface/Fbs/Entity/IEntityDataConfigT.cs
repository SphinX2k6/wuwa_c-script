using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C0E RID: 19470
	public class IEntityDataConfigT
	{
		// Token: 0x170089FB RID: 35323
		// (get) Token: 0x0601DC9E RID: 122014 RVA: 0x0042DC8D File Offset: 0x0042BE8D
		// (set) Token: 0x0601DC9F RID: 122015 RVA: 0x0042DC95 File Offset: 0x0042BE95
		public List<IEntityTemplateT> EntityDatas { get; set; }

		// Token: 0x0601DCA0 RID: 122016 RVA: 0x0042DC9E File Offset: 0x0042BE9E
		public IEntityDataConfigT()
		{
			this.EntityDatas = null;
		}
	}
}
