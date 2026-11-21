using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007927 RID: 31015
	public class ISlopeSlidePerformStartT
	{
		// Token: 0x1700E38B RID: 58251
		// (get) Token: 0x060369F0 RID: 223728 RVA: 0x0074F4B3 File Offset: 0x0074D6B3
		// (set) Token: 0x060369F1 RID: 223729 RVA: 0x0074F4BB File Offset: 0x0074D6BB
		public ESlidePerformType Type { get; set; }

		// Token: 0x1700E38C RID: 58252
		// (get) Token: 0x060369F2 RID: 223730 RVA: 0x0074F4C4 File Offset: 0x0074D6C4
		// (set) Token: 0x060369F3 RID: 223731 RVA: 0x0074F4CC File Offset: 0x0074D6CC
		public string SlopeSlidePerformDaPath { get; set; }

		// Token: 0x060369F4 RID: 223732 RVA: 0x0074F4D5 File Offset: 0x0074D6D5
		public ISlopeSlidePerformStartT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
			this.SlopeSlidePerformDaPath = null;
		}
	}
}
