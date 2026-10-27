using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005624 RID: 22052
	public class INpcHitShowT
	{
		// Token: 0x1700A329 RID: 41769
		// (get) Token: 0x060249A7 RID: 149927 RVA: 0x0050CC29 File Offset: 0x0050AE29
		// (set) Token: 0x060249A8 RID: 149928 RVA: 0x0050CC31 File Offset: 0x0050AE31
		public string HitMontage { get; set; }

		// Token: 0x1700A32A RID: 41770
		// (get) Token: 0x060249A9 RID: 149929 RVA: 0x0050CC3A File Offset: 0x0050AE3A
		// (set) Token: 0x060249AA RID: 149930 RVA: 0x0050CC42 File Offset: 0x0050AE42
		public IBubbleIndexT HitBubble { get; set; }

		// Token: 0x1700A32B RID: 41771
		// (get) Token: 0x060249AB RID: 149931 RVA: 0x0050CC4B File Offset: 0x0050AE4B
		// (set) Token: 0x060249AC RID: 149932 RVA: 0x0050CC53 File Offset: 0x0050AE53
		public int BubbleRate { get; set; }

		// Token: 0x060249AD RID: 149933 RVA: 0x0050CC5C File Offset: 0x0050AE5C
		public INpcHitShowT()
		{
			this.HitMontage = null;
			this.HitBubble = null;
			this.BubbleRate = 0;
		}
	}
}
