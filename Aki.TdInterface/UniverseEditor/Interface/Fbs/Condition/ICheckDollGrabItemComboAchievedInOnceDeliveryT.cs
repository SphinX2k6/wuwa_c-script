using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049CB RID: 18891
	public class ICheckDollGrabItemComboAchievedInOnceDeliveryT
	{
		// Token: 0x17008898 RID: 34968
		// (get) Token: 0x0601D7F6 RID: 120822 RVA: 0x00427798 File Offset: 0x00425998
		// (set) Token: 0x0601D7F7 RID: 120823 RVA: 0x004277A0 File Offset: 0x004259A0
		public ECondition Type { get; set; }

		// Token: 0x17008899 RID: 34969
		// (get) Token: 0x0601D7F8 RID: 120824 RVA: 0x004277A9 File Offset: 0x004259A9
		// (set) Token: 0x0601D7F9 RID: 120825 RVA: 0x004277B1 File Offset: 0x004259B1
		public int ShowcaseEntityId { get; set; }

		// Token: 0x0601D7FA RID: 120826 RVA: 0x004277BA File Offset: 0x004259BA
		public ICheckDollGrabItemComboAchievedInOnceDeliveryT()
		{
			this.Type = ECondition.CompareVar;
			this.ShowcaseEntityId = 0;
		}
	}
}
