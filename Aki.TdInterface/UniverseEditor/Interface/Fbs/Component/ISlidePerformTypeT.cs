using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F3D RID: 24381
	public class ISlidePerformTypeT
	{
		// Token: 0x1700B48E RID: 46222
		// (get) Token: 0x06028F7C RID: 167804 RVA: 0x00598E26 File Offset: 0x00597026
		// (set) Token: 0x06028F7D RID: 167805 RVA: 0x00598E2E File Offset: 0x0059702E
		public ESlidePerformType Type { get; set; }

		// Token: 0x06028F7E RID: 167806 RVA: 0x00598E37 File Offset: 0x00597037
		public ISlidePerformTypeT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
		}
	}
}
