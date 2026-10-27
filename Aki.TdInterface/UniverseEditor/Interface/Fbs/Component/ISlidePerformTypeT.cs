using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005930 RID: 22832
	public class ISlidePerformTypeT
	{
		// Token: 0x1700AB5A RID: 43866
		// (get) Token: 0x06026A12 RID: 158226 RVA: 0x005521BA File Offset: 0x005503BA
		// (set) Token: 0x06026A13 RID: 158227 RVA: 0x005521C2 File Offset: 0x005503C2
		public ESlidePerformType Type { get; set; }

		// Token: 0x06026A14 RID: 158228 RVA: 0x005521CB File Offset: 0x005503CB
		public ISlidePerformTypeT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
		}
	}
}
