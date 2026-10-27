using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005782 RID: 22402
	public class IProbabilityRefreshGroupT
	{
		// Token: 0x1700A719 RID: 42777
		// (get) Token: 0x060258E7 RID: 153831 RVA: 0x0052E474 File Offset: 0x0052C674
		// (set) Token: 0x060258E8 RID: 153832 RVA: 0x0052E47C File Offset: 0x0052C67C
		public string CheckOccupation { get; set; }

		// Token: 0x1700A71A RID: 42778
		// (get) Token: 0x060258E9 RID: 153833 RVA: 0x0052E485 File Offset: 0x0052C685
		// (set) Token: 0x060258EA RID: 153834 RVA: 0x0052E48D File Offset: 0x0052C68D
		public List<IProbabilityRefreshItemT> RefreshItems { get; set; }

		// Token: 0x060258EB RID: 153835 RVA: 0x0052E496 File Offset: 0x0052C696
		public IProbabilityRefreshGroupT()
		{
			this.CheckOccupation = null;
			this.RefreshItems = null;
		}
	}
}
