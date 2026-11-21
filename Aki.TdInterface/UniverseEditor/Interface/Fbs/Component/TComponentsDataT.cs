using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006217 RID: 25111
	public class TComponentsDataT
	{
		// Token: 0x1700BB22 RID: 47906
		// (get) Token: 0x0602AC41 RID: 175169 RVA: 0x005D78C5 File Offset: 0x005D5AC5
		// (set) Token: 0x0602AC42 RID: 175170 RVA: 0x005D78CD File Offset: 0x005D5ACD
		public List<TComponentDataT> Items { get; set; }

		// Token: 0x0602AC43 RID: 175171 RVA: 0x005D78D6 File Offset: 0x005D5AD6
		public TComponentsDataT()
		{
			this.Items = null;
		}
	}
}
