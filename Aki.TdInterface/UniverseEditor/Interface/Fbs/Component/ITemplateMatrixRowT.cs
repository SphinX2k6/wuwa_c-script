using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A59 RID: 23129
	public class ITemplateMatrixRowT
	{
		// Token: 0x1700AE10 RID: 44560
		// (get) Token: 0x060275A4 RID: 161188 RVA: 0x0056A64D File Offset: 0x0056884D
		// (set) Token: 0x060275A5 RID: 161189 RVA: 0x0056A655 File Offset: 0x00568855
		public List<ISpawnTemplateEntityConfigT> Items { get; set; }

		// Token: 0x060275A6 RID: 161190 RVA: 0x0056A65E File Offset: 0x0056885E
		public ITemplateMatrixRowT()
		{
			this.Items = null;
		}
	}
}
