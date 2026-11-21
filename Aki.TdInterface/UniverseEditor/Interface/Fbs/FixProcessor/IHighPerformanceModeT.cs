using System;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC9 RID: 19401
	public class IHighPerformanceModeT
	{
		// Token: 0x1700895B RID: 35163
		// (get) Token: 0x0601D9F0 RID: 121328 RVA: 0x0042872E File Offset: 0x0042692E
		// (set) Token: 0x0601D9F1 RID: 121329 RVA: 0x00428736 File Offset: 0x00426936
		public EPerformanceMode Type { get; set; }

		// Token: 0x0601D9F2 RID: 121330 RVA: 0x0042873F File Offset: 0x0042693F
		public IHighPerformanceModeT()
		{
			this.Type = EPerformanceMode.High;
		}
	}
}
