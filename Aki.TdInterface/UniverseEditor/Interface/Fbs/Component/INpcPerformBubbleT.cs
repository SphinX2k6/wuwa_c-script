using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCE RID: 23502
	public class INpcPerformBubbleT
	{
		// Token: 0x1700ABD1 RID: 43985
		// (get) Token: 0x06026C3C RID: 158780 RVA: 0x0054E37F File Offset: 0x0054C57F
		// (set) Token: 0x06026C3D RID: 158781 RVA: 0x0054E387 File Offset: 0x0054C587
		public IBubbleIndexT Bubble { get; set; }

		// Token: 0x1700ABD2 RID: 43986
		// (get) Token: 0x06026C3E RID: 158782 RVA: 0x0054E390 File Offset: 0x0054C590
		// (set) Token: 0x06026C3F RID: 158783 RVA: 0x0054E398 File Offset: 0x0054C598
		public int Rate { get; set; }

		// Token: 0x06026C40 RID: 158784 RVA: 0x0054E3A1 File Offset: 0x0054C5A1
		public INpcPerformBubbleT()
		{
			this.Bubble = null;
			this.Rate = 0;
		}
	}
}
