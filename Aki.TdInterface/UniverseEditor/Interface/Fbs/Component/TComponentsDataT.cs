using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF8 RID: 23544
	public class TComponentsDataT
	{
		// Token: 0x1700B1D4 RID: 45524
		// (get) Token: 0x06028651 RID: 165457 RVA: 0x0058F97D File Offset: 0x0058DB7D
		// (set) Token: 0x06028652 RID: 165458 RVA: 0x0058F985 File Offset: 0x0058DB85
		public List<TComponentDataT> Items { get; set; }

		// Token: 0x06028653 RID: 165459 RVA: 0x0058F98E File Offset: 0x0058DB8E
		public TComponentsDataT()
		{
			this.Items = null;
		}
	}
}
