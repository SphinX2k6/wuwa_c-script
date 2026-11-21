using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAE RID: 28590
	public class IHideSpecificEntitiesT
	{
		// Token: 0x1700D163 RID: 53603
		// (get) Token: 0x060317FB RID: 202747 RVA: 0x006B5891 File Offset: 0x006B3A91
		// (set) Token: 0x060317FC RID: 202748 RVA: 0x006B5899 File Offset: 0x006B3A99
		public List<int> EntityIds { get; set; }

		// Token: 0x060317FD RID: 202749 RVA: 0x006B58A2 File Offset: 0x006B3AA2
		public IHideSpecificEntitiesT()
		{
			this.EntityIds = null;
		}
	}
}
