using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC2 RID: 28354
	public class IResumeGiantDeliveryRewardPopupT
	{
		// Token: 0x1700D309 RID: 54025
		// (get) Token: 0x060321D1 RID: 205265 RVA: 0x006C670A File Offset: 0x006C490A
		// (set) Token: 0x060321D2 RID: 205266 RVA: 0x006C6712 File Offset: 0x006C4912
		public ESystemType Type { get; set; }

		// Token: 0x060321D3 RID: 205267 RVA: 0x006C671B File Offset: 0x006C491B
		public IResumeGiantDeliveryRewardPopupT()
		{
			this.Type = ESystemType.Shop;
		}
	}
}
