using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F19 RID: 24345
	public class IShowcaseDeliveryRewardT
	{
		// Token: 0x1700B414 RID: 46100
		// (get) Token: 0x06028DDA RID: 167386 RVA: 0x00595868 File Offset: 0x00593A68
		// (set) Token: 0x06028DDB RID: 167387 RVA: 0x00595870 File Offset: 0x00593A70
		public int AchievedDollCount { get; set; }

		// Token: 0x1700B415 RID: 46101
		// (get) Token: 0x06028DDC RID: 167388 RVA: 0x00595879 File Offset: 0x00593A79
		// (set) Token: 0x06028DDD RID: 167389 RVA: 0x00595881 File Offset: 0x00593A81
		public int DropId { get; set; }

		// Token: 0x06028DDE RID: 167390 RVA: 0x0059588A File Offset: 0x00593A8A
		public IShowcaseDeliveryRewardT()
		{
			this.AchievedDollCount = 0;
			this.DropId = 0;
		}
	}
}
