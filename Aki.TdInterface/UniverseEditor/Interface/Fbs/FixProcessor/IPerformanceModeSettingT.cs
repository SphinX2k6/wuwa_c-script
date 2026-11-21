using System;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BCF RID: 19407
	public class IPerformanceModeSettingT
	{
		// Token: 0x17008961 RID: 35169
		// (get) Token: 0x0601DA1A RID: 121370 RVA: 0x00428BC2 File Offset: 0x00426DC2
		// (set) Token: 0x0601DA1B RID: 121371 RVA: 0x00428BCA File Offset: 0x00426DCA
		public EPerformanceMode Type { get; set; }

		// Token: 0x0601DA1C RID: 121372 RVA: 0x00428BD3 File Offset: 0x00426DD3
		public IPerformanceModeSettingT()
		{
			this.Type = EPerformanceMode.High;
		}
	}
}
