using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596A RID: 22890
	public class IIgnoreEntityIdsCollisionT
	{
		// Token: 0x1700A650 RID: 42576
		// (get) Token: 0x060254FB RID: 152827 RVA: 0x0051F2F9 File Offset: 0x0051D4F9
		// (set) Token: 0x060254FC RID: 152828 RVA: 0x0051F301 File Offset: 0x0051D501
		public List<int> EntityIds { get; set; }

		// Token: 0x060254FD RID: 152829 RVA: 0x0051F30A File Offset: 0x0051D50A
		public IIgnoreEntityIdsCollisionT()
		{
			this.EntityIds = null;
		}
	}
}
