using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005630 RID: 22064
	public class INpcPerformBubbleT
	{
		// Token: 0x1700A349 RID: 41801
		// (get) Token: 0x06024A29 RID: 150057 RVA: 0x0050DCBF File Offset: 0x0050BEBF
		// (set) Token: 0x06024A2A RID: 150058 RVA: 0x0050DCC7 File Offset: 0x0050BEC7
		public IBubbleIndexT Bubble { get; set; }

		// Token: 0x1700A34A RID: 41802
		// (get) Token: 0x06024A2B RID: 150059 RVA: 0x0050DCD0 File Offset: 0x0050BED0
		// (set) Token: 0x06024A2C RID: 150060 RVA: 0x0050DCD8 File Offset: 0x0050BED8
		public int Rate { get; set; }

		// Token: 0x06024A2D RID: 150061 RVA: 0x0050DCE1 File Offset: 0x0050BEE1
		public INpcPerformBubbleT()
		{
			this.Bubble = null;
			this.Rate = 0;
		}
	}
}
