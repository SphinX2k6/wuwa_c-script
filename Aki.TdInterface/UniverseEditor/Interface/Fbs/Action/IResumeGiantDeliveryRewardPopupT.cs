using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007646 RID: 30278
	public class IResumeGiantDeliveryRewardPopupT
	{
		// Token: 0x1700DE60 RID: 56928
		// (get) Token: 0x06035211 RID: 217617 RVA: 0x0072243E File Offset: 0x0072063E
		// (set) Token: 0x06035212 RID: 217618 RVA: 0x00722446 File Offset: 0x00720646
		public ESystemType Type { get; set; }

		// Token: 0x06035213 RID: 217619 RVA: 0x0072244F File Offset: 0x0072064F
		public IResumeGiantDeliveryRewardPopupT()
		{
			this.Type = ESystemType.Shop;
		}
	}
}
