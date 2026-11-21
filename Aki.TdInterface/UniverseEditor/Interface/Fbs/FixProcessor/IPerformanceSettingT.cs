using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BD5 RID: 19413
	public class IPerformanceSettingT
	{
		// Token: 0x1700896A RID: 35178
		// (get) Token: 0x0601DA4C RID: 121420 RVA: 0x004291CC File Offset: 0x004273CC
		// (set) Token: 0x0601DA4D RID: 121421 RVA: 0x004291D4 File Offset: 0x004273D4
		public string Author { get; set; }

		// Token: 0x1700896B RID: 35179
		// (get) Token: 0x0601DA4E RID: 121422 RVA: 0x004291DD File Offset: 0x004273DD
		// (set) Token: 0x0601DA4F RID: 121423 RVA: 0x004291E5 File Offset: 0x004273E5
		public string Note { get; set; }

		// Token: 0x1700896C RID: 35180
		// (get) Token: 0x0601DA50 RID: 121424 RVA: 0x004291EE File Offset: 0x004273EE
		// (set) Token: 0x0601DA51 RID: 121425 RVA: 0x004291F6 File Offset: 0x004273F6
		public bool EnableOptimize { get; set; }

		// Token: 0x1700896D RID: 35181
		// (get) Token: 0x0601DA52 RID: 121426 RVA: 0x004291FF File Offset: 0x004273FF
		// (set) Token: 0x0601DA53 RID: 121427 RVA: 0x00429207 File Offset: 0x00427407
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700896E RID: 35182
		// (get) Token: 0x0601DA54 RID: 121428 RVA: 0x00429210 File Offset: 0x00427410
		// (set) Token: 0x0601DA55 RID: 121429 RVA: 0x00429218 File Offset: 0x00427418
		public IHighPerformanceModeT Mode { get; set; }

		// Token: 0x0601DA56 RID: 121430 RVA: 0x00429221 File Offset: 0x00427421
		public IPerformanceSettingT()
		{
			this.Author = null;
			this.Note = null;
			this.EnableOptimize = false;
			this.RangeEntities = null;
			this.Mode = null;
		}
	}
}
