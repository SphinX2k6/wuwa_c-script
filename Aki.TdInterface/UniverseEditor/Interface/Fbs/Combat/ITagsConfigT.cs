using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EF4 RID: 24308
	public class ITagsConfigT
	{
		// Token: 0x1700B5BB RID: 46523
		// (get) Token: 0x06029C00 RID: 171008 RVA: 0x005BAAB1 File Offset: 0x005B8CB1
		// (set) Token: 0x06029C01 RID: 171009 RVA: 0x005BAAB9 File Offset: 0x005B8CB9
		public List<ITagConfigT> Tags { get; set; }

		// Token: 0x06029C02 RID: 171010 RVA: 0x005BAAC2 File Offset: 0x005B8CC2
		public ITagsConfigT()
		{
			this.Tags = null;
		}
	}
}
