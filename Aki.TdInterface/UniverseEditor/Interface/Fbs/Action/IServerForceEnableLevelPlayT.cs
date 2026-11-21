using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007751 RID: 30545
	public class IServerForceEnableLevelPlayT
	{
		// Token: 0x1700DFE8 RID: 57320
		// (get) Token: 0x060359BC RID: 219580 RVA: 0x0072F771 File Offset: 0x0072D971
		// (set) Token: 0x060359BD RID: 219581 RVA: 0x0072F779 File Offset: 0x0072D979
		public List<IEnableLevelPlayConfigT> Configs { get; set; }

		// Token: 0x060359BE RID: 219582 RVA: 0x0072F782 File Offset: 0x0072D982
		public IServerForceEnableLevelPlayT()
		{
			this.Configs = null;
		}
	}
}
