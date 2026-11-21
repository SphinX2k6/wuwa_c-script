using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700E RID: 28686
	public class IInfrastructureItemDeliveryRoadBuildT
	{
		// Token: 0x1700D211 RID: 53777
		// (get) Token: 0x06031B4C RID: 203596 RVA: 0x006BB21C File Offset: 0x006B941C
		// (set) Token: 0x06031B4D RID: 203597 RVA: 0x006BB224 File Offset: 0x006B9424
		public EInfrastructureItemDeliveryType Type { get; set; }

		// Token: 0x1700D212 RID: 53778
		// (get) Token: 0x06031B4E RID: 203598 RVA: 0x006BB22D File Offset: 0x006B942D
		// (set) Token: 0x06031B4F RID: 203599 RVA: 0x006BB235 File Offset: 0x006B9435
		public int Id { get; set; }

		// Token: 0x06031B50 RID: 203600 RVA: 0x006BB23E File Offset: 0x006B943E
		public IInfrastructureItemDeliveryRoadBuildT()
		{
			this.Type = EInfrastructureItemDeliveryType.Observatory;
			this.Id = 0;
		}
	}
}
