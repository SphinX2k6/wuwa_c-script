using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695E RID: 26974
	public class IInfrastructureItemDeliveryTypeT
	{
		// Token: 0x1700C812 RID: 51218
		// (get) Token: 0x0602F190 RID: 192912 RVA: 0x0066AED2 File Offset: 0x006690D2
		// (set) Token: 0x0602F191 RID: 192913 RVA: 0x0066AEDA File Offset: 0x006690DA
		public EInfrastructureItemDeliveryType Type { get; set; }

		// Token: 0x0602F192 RID: 192914 RVA: 0x0066AEE3 File Offset: 0x006690E3
		public IInfrastructureItemDeliveryTypeT()
		{
			this.Type = EInfrastructureItemDeliveryType.Observatory;
		}
	}
}
