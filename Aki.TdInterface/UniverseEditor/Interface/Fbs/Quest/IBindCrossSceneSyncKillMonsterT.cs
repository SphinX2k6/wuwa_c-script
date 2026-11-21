using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004146 RID: 16710
	public class IBindCrossSceneSyncKillMonsterT
	{
		// Token: 0x1700712F RID: 28975
		// (get) Token: 0x06016F5D RID: 94045 RVA: 0x00346A6D File Offset: 0x00344C6D
		// (set) Token: 0x06016F5E RID: 94046 RVA: 0x00346A75 File Offset: 0x00344C75
		public List<int> EntityBundleIds { get; set; }

		// Token: 0x06016F5F RID: 94047 RVA: 0x00346A7E File Offset: 0x00344C7E
		public IBindCrossSceneSyncKillMonsterT()
		{
			this.EntityBundleIds = null;
		}
	}
}
