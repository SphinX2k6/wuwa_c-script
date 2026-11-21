using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E7E RID: 24190
	public class IRoadNetworkNavigationTypeT
	{
		// Token: 0x1700B290 RID: 45712
		// (get) Token: 0x060287D8 RID: 165848 RVA: 0x00589836 File Offset: 0x00587A36
		// (set) Token: 0x060287D9 RID: 165849 RVA: 0x0058983E File Offset: 0x00587A3E
		public ERoadNetworkNavigationType Type { get; set; }

		// Token: 0x060287DA RID: 165850 RVA: 0x00589847 File Offset: 0x00587A47
		public IRoadNetworkNavigationTypeT()
		{
			this.Type = ERoadNetworkNavigationType.Traffic;
		}
	}
}
