using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC2 RID: 23490
	public class INpcHitShowT
	{
		// Token: 0x1700ABB1 RID: 43953
		// (get) Token: 0x06026BB7 RID: 158647 RVA: 0x0054D241 File Offset: 0x0054B441
		// (set) Token: 0x06026BB8 RID: 158648 RVA: 0x0054D249 File Offset: 0x0054B449
		public string HitMontage { get; set; }

		// Token: 0x1700ABB2 RID: 43954
		// (get) Token: 0x06026BB9 RID: 158649 RVA: 0x0054D252 File Offset: 0x0054B452
		// (set) Token: 0x06026BBA RID: 158650 RVA: 0x0054D25A File Offset: 0x0054B45A
		public IBubbleIndexT HitBubble { get; set; }

		// Token: 0x1700ABB3 RID: 43955
		// (get) Token: 0x06026BBB RID: 158651 RVA: 0x0054D263 File Offset: 0x0054B463
		// (set) Token: 0x06026BBC RID: 158652 RVA: 0x0054D26B File Offset: 0x0054B46B
		public int BubbleRate { get; set; }

		// Token: 0x06026BBD RID: 158653 RVA: 0x0054D274 File Offset: 0x0054B474
		public INpcHitShowT()
		{
			this.HitMontage = null;
			this.HitBubble = null;
			this.BubbleRate = 0;
		}
	}
}
