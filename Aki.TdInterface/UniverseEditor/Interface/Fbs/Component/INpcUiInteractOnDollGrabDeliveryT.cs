using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C13 RID: 23571
	public class INpcUiInteractOnDollGrabDeliveryT
	{
		// Token: 0x1700ACB4 RID: 44212
		// (get) Token: 0x06026FAC RID: 159660 RVA: 0x00556397 File Offset: 0x00554597
		// (set) Token: 0x06026FAD RID: 159661 RVA: 0x0055639F File Offset: 0x0055459F
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700ACB5 RID: 44213
		// (get) Token: 0x06026FAE RID: 159662 RVA: 0x005563A8 File Offset: 0x005545A8
		// (set) Token: 0x06026FAF RID: 159663 RVA: 0x005563B0 File Offset: 0x005545B0
		public IOnDollGrabDeliveryPerformT OnFirstAchievementPerform { get; set; }

		// Token: 0x1700ACB6 RID: 44214
		// (get) Token: 0x06026FB0 RID: 159664 RVA: 0x005563B9 File Offset: 0x005545B9
		// (set) Token: 0x06026FB1 RID: 159665 RVA: 0x005563C1 File Offset: 0x005545C1
		public IOnDollGrabDeliveryPerformT OnSubsequentAchievementPerform { get; set; }

		// Token: 0x1700ACB7 RID: 44215
		// (get) Token: 0x06026FB2 RID: 159666 RVA: 0x005563CA File Offset: 0x005545CA
		// (set) Token: 0x06026FB3 RID: 159667 RVA: 0x005563D2 File Offset: 0x005545D2
		public IOnDollGrabDeliveryPerformT OnNeverAchievementPerform { get; set; }

		// Token: 0x1700ACB8 RID: 44216
		// (get) Token: 0x06026FB4 RID: 159668 RVA: 0x005563DB File Offset: 0x005545DB
		// (set) Token: 0x06026FB5 RID: 159669 RVA: 0x005563E3 File Offset: 0x005545E3
		public IOnDollGrabDeliveryPerformT OnAlreadyAchievementPerform { get; set; }

		// Token: 0x06026FB6 RID: 159670 RVA: 0x005563EC File Offset: 0x005545EC
		public INpcUiInteractOnDollGrabDeliveryT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.OnFirstAchievementPerform = null;
			this.OnSubsequentAchievementPerform = null;
			this.OnNeverAchievementPerform = null;
			this.OnAlreadyAchievementPerform = null;
		}
	}
}
