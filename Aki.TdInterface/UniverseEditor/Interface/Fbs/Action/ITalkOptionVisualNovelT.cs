using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007356 RID: 29526
	public class ITalkOptionVisualNovelT
	{
		// Token: 0x1700E03A RID: 57402
		// (get) Token: 0x06035972 RID: 219506 RVA: 0x0074C9C7 File Offset: 0x0074ABC7
		// (set) Token: 0x06035973 RID: 219507 RVA: 0x0074C9CF File Offset: 0x0074ABCF
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x1700E03B RID: 57403
		// (get) Token: 0x06035974 RID: 219508 RVA: 0x0074C9D8 File Offset: 0x0074ABD8
		// (set) Token: 0x06035975 RID: 219509 RVA: 0x0074C9E0 File Offset: 0x0074ABE0
		public int PlotOptionId { get; set; }

		// Token: 0x1700E03C RID: 57404
		// (get) Token: 0x06035976 RID: 219510 RVA: 0x0074C9E9 File Offset: 0x0074ABE9
		// (set) Token: 0x06035977 RID: 219511 RVA: 0x0074C9F1 File Offset: 0x0074ABF1
		public List<TVisualNovelPerformanceUnion> OptionPerformances { get; set; }

		// Token: 0x1700E03D RID: 57405
		// (get) Token: 0x06035978 RID: 219512 RVA: 0x0074C9FA File Offset: 0x0074ABFA
		// (set) Token: 0x06035979 RID: 219513 RVA: 0x0074CA02 File Offset: 0x0074AC02
		public byte NullMask { get; set; }

		// Token: 0x0603597A RID: 219514 RVA: 0x0074CA0B File Offset: 0x0074AC0B
		public ITalkOptionVisualNovelT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
			this.PlotOptionId = 0;
			this.OptionPerformances = null;
			this.NullMask = 0;
		}
	}
}
