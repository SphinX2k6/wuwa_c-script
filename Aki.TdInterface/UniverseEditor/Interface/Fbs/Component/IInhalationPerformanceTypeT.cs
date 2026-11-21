using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005988 RID: 22920
	public class IInhalationPerformanceTypeT
	{
		// Token: 0x1700A67B RID: 42619
		// (get) Token: 0x060255DD RID: 153053 RVA: 0x00520C92 File Offset: 0x0051EE92
		// (set) Token: 0x060255DE RID: 153054 RVA: 0x00520C9A File Offset: 0x0051EE9A
		public EInhalationPerformanceType Type { get; set; }

		// Token: 0x060255DF RID: 153055 RVA: 0x00520CA3 File Offset: 0x0051EEA3
		public IInhalationPerformanceTypeT()
		{
			this.Type = EInhalationPerformanceType.Role;
		}
	}
}
