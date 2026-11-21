using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D89 RID: 23945
	public class IProbabilityRefreshGroupT
	{
		// Token: 0x1700B03D RID: 45117
		// (get) Token: 0x06027E07 RID: 163335 RVA: 0x00574600 File Offset: 0x00572800
		// (set) Token: 0x06027E08 RID: 163336 RVA: 0x00574608 File Offset: 0x00572808
		public string CheckOccupation { get; set; }

		// Token: 0x1700B03E RID: 45118
		// (get) Token: 0x06027E09 RID: 163337 RVA: 0x00574611 File Offset: 0x00572811
		// (set) Token: 0x06027E0A RID: 163338 RVA: 0x00574619 File Offset: 0x00572819
		public List<IProbabilityRefreshItemT> RefreshItems { get; set; }

		// Token: 0x06027E0B RID: 163339 RVA: 0x00574622 File Offset: 0x00572822
		public IProbabilityRefreshGroupT()
		{
			this.CheckOccupation = null;
			this.RefreshItems = null;
		}
	}
}
