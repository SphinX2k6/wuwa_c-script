using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB9 RID: 23481
	public class INpcBumpShowT
	{
		// Token: 0x1700ABA2 RID: 43938
		// (get) Token: 0x06026B69 RID: 158569 RVA: 0x0054C959 File Offset: 0x0054AB59
		// (set) Token: 0x06026B6A RID: 158570 RVA: 0x0054C961 File Offset: 0x0054AB61
		public INpcPerformBubbleT BumpBubble { get; set; }

		// Token: 0x06026B6B RID: 158571 RVA: 0x0054C96A File Offset: 0x0054AB6A
		public INpcBumpShowT()
		{
			this.BumpBubble = null;
		}
	}
}
