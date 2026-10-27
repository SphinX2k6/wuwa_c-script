using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005402 RID: 21506
	public class IInhalationPerformanceTypeT
	{
		// Token: 0x17009E41 RID: 40513
		// (get) Token: 0x06023525 RID: 144677 RVA: 0x004E3C66 File Offset: 0x004E1E66
		// (set) Token: 0x06023526 RID: 144678 RVA: 0x004E3C6E File Offset: 0x004E1E6E
		public EInhalationPerformanceType Type { get; set; }

		// Token: 0x06023527 RID: 144679 RVA: 0x004E3C77 File Offset: 0x004E1E77
		public IInhalationPerformanceTypeT()
		{
			this.Type = EInhalationPerformanceType.Role;
		}
	}
}
