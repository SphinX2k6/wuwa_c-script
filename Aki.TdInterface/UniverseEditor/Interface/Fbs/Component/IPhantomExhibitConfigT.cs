using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D32 RID: 23858
	public class IPhantomExhibitConfigT
	{
		// Token: 0x1700AF6C RID: 44908
		// (get) Token: 0x06027AA2 RID: 162466 RVA: 0x0056D31F File Offset: 0x0056B51F
		// (set) Token: 0x06027AA3 RID: 162467 RVA: 0x0056D327 File Offset: 0x0056B527
		public EExhibitItemType Type { get; set; }

		// Token: 0x1700AF6D RID: 44909
		// (get) Token: 0x06027AA4 RID: 162468 RVA: 0x0056D330 File Offset: 0x0056B530
		// (set) Token: 0x06027AA5 RID: 162469 RVA: 0x0056D338 File Offset: 0x0056B538
		public EPhantomExhibitSizeType PhantomSize { get; set; }

		// Token: 0x1700AF6E RID: 44910
		// (get) Token: 0x06027AA6 RID: 162470 RVA: 0x0056D341 File Offset: 0x0056B541
		// (set) Token: 0x06027AA7 RID: 162471 RVA: 0x0056D349 File Offset: 0x0056B549
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700AF6F RID: 44911
		// (get) Token: 0x06027AA8 RID: 162472 RVA: 0x0056D352 File Offset: 0x0056B552
		// (set) Token: 0x06027AA9 RID: 162473 RVA: 0x0056D35A File Offset: 0x0056B55A
		public IExhibitEffectT ActiveEffect { get; set; }

		// Token: 0x06027AAA RID: 162474 RVA: 0x0056D363 File Offset: 0x0056B563
		public IPhantomExhibitConfigT()
		{
			this.Type = EExhibitItemType.Phantom;
			this.PhantomSize = EPhantomExhibitSizeType.Small;
			this.Offset = null;
			this.ActiveEffect = null;
		}
	}
}
