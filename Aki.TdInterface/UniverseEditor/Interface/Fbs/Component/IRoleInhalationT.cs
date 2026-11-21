using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E84 RID: 24196
	public class IRoleInhalationT
	{
		// Token: 0x1700B295 RID: 45717
		// (get) Token: 0x060287F6 RID: 165878 RVA: 0x00589AAA File Offset: 0x00587CAA
		// (set) Token: 0x060287F7 RID: 165879 RVA: 0x00589AB2 File Offset: 0x00587CB2
		public EInhalationPerformanceType Type { get; set; }

		// Token: 0x060287F8 RID: 165880 RVA: 0x00589ABB File Offset: 0x00587CBB
		public IRoleInhalationT()
		{
			this.Type = EInhalationPerformanceType.Role;
		}
	}
}
