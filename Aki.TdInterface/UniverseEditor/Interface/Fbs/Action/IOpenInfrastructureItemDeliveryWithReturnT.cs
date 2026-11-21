using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736E RID: 29550
	public class IOpenInfrastructureItemDeliveryWithReturnT
	{
		// Token: 0x1700D8C1 RID: 55489
		// (get) Token: 0x06033942 RID: 211266 RVA: 0x006F3B79 File Offset: 0x006F1D79
		// (set) Token: 0x06033943 RID: 211267 RVA: 0x006F3B81 File Offset: 0x006F1D81
		public ESystemType Type { get; set; }

		// Token: 0x1700D8C2 RID: 55490
		// (get) Token: 0x06033944 RID: 211268 RVA: 0x006F3B8A File Offset: 0x006F1D8A
		// (set) Token: 0x06033945 RID: 211269 RVA: 0x006F3B92 File Offset: 0x006F1D92
		public TInfrastructureItemDeliveryOptionUnion DeliveryType { get; set; }

		// Token: 0x1700D8C3 RID: 55491
		// (get) Token: 0x06033946 RID: 211270 RVA: 0x006F3B9B File Offset: 0x006F1D9B
		// (set) Token: 0x06033947 RID: 211271 RVA: 0x006F3BA3 File Offset: 0x006F1DA3
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06033948 RID: 211272 RVA: 0x006F3BAC File Offset: 0x006F1DAC
		public IOpenInfrastructureItemDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.DeliveryType = null;
			this.ReturnVar = null;
		}
	}
}
