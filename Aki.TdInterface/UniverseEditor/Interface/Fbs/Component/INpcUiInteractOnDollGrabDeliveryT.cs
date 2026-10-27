using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005672 RID: 22130
	public class INpcUiInteractOnDollGrabDeliveryT
	{
		// Token: 0x1700A425 RID: 42021
		// (get) Token: 0x06024D73 RID: 150899 RVA: 0x005157FB File Offset: 0x005139FB
		// (set) Token: 0x06024D74 RID: 150900 RVA: 0x00515803 File Offset: 0x00513A03
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A426 RID: 42022
		// (get) Token: 0x06024D75 RID: 150901 RVA: 0x0051580C File Offset: 0x00513A0C
		// (set) Token: 0x06024D76 RID: 150902 RVA: 0x00515814 File Offset: 0x00513A14
		public IOnDollGrabDeliveryPerformT OnFirstAchievementPerform { get; set; }

		// Token: 0x1700A427 RID: 42023
		// (get) Token: 0x06024D77 RID: 150903 RVA: 0x0051581D File Offset: 0x00513A1D
		// (set) Token: 0x06024D78 RID: 150904 RVA: 0x00515825 File Offset: 0x00513A25
		public IOnDollGrabDeliveryPerformT OnSubsequentAchievementPerform { get; set; }

		// Token: 0x1700A428 RID: 42024
		// (get) Token: 0x06024D79 RID: 150905 RVA: 0x0051582E File Offset: 0x00513A2E
		// (set) Token: 0x06024D7A RID: 150906 RVA: 0x00515836 File Offset: 0x00513A36
		public IOnDollGrabDeliveryPerformT OnNeverAchievementPerform { get; set; }

		// Token: 0x1700A429 RID: 42025
		// (get) Token: 0x06024D7B RID: 150907 RVA: 0x0051583F File Offset: 0x00513A3F
		// (set) Token: 0x06024D7C RID: 150908 RVA: 0x00515847 File Offset: 0x00513A47
		public IOnDollGrabDeliveryPerformT OnAlreadyAchievementPerform { get; set; }

		// Token: 0x06024D7D RID: 150909 RVA: 0x00515850 File Offset: 0x00513A50
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
