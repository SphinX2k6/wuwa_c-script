using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561B RID: 22043
	public class INpcBumpShowT
	{
		// Token: 0x1700A31A RID: 41754
		// (get) Token: 0x06024959 RID: 149849 RVA: 0x0050C341 File Offset: 0x0050A541
		// (set) Token: 0x0602495A RID: 149850 RVA: 0x0050C349 File Offset: 0x0050A549
		public INpcPerformBubbleT BumpBubble { get; set; }

		// Token: 0x0602495B RID: 149851 RVA: 0x0050C352 File Offset: 0x0050A552
		public INpcBumpShowT()
		{
			this.BumpBubble = null;
		}
	}
}
