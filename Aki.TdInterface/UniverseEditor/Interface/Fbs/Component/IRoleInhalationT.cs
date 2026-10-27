using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005877 RID: 22647
	public class IRoleInhalationT
	{
		// Token: 0x1700A965 RID: 43365
		// (get) Token: 0x06026294 RID: 156308 RVA: 0x00542F5E File Offset: 0x0054115E
		// (set) Token: 0x06026295 RID: 156309 RVA: 0x00542F66 File Offset: 0x00541166
		public EInhalationPerformanceType Type { get; set; }

		// Token: 0x06026296 RID: 156310 RVA: 0x00542F6F File Offset: 0x0054116F
		public IRoleInhalationT()
		{
			this.Type = EInhalationPerformanceType.Role;
		}
	}
}
