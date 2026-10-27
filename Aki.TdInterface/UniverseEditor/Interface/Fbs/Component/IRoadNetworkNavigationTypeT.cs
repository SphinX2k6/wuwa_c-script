using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005871 RID: 22641
	public class IRoadNetworkNavigationTypeT
	{
		// Token: 0x1700A960 RID: 43360
		// (get) Token: 0x06026276 RID: 156278 RVA: 0x00542CEA File Offset: 0x00540EEA
		// (set) Token: 0x06026277 RID: 156279 RVA: 0x00542CF2 File Offset: 0x00540EF2
		public ERoadNetworkNavigationType Type { get; set; }

		// Token: 0x06026278 RID: 156280 RVA: 0x00542CFB File Offset: 0x00540EFB
		public IRoadNetworkNavigationTypeT()
		{
			this.Type = ERoadNetworkNavigationType.Traffic;
		}
	}
}
