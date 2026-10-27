using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0A RID: 27658
	public class IOpenInfrastructureItemDeliveryWithReturnT
	{
		// Token: 0x1700CDB3 RID: 52659
		// (get) Token: 0x06030A22 RID: 199202 RVA: 0x0069A1E5 File Offset: 0x006983E5
		// (set) Token: 0x06030A23 RID: 199203 RVA: 0x0069A1ED File Offset: 0x006983ED
		public ESystemType Type { get; set; }

		// Token: 0x1700CDB4 RID: 52660
		// (get) Token: 0x06030A24 RID: 199204 RVA: 0x0069A1F6 File Offset: 0x006983F6
		// (set) Token: 0x06030A25 RID: 199205 RVA: 0x0069A1FE File Offset: 0x006983FE
		public TInfrastructureItemDeliveryOptionUnion DeliveryType { get; set; }

		// Token: 0x1700CDB5 RID: 52661
		// (get) Token: 0x06030A26 RID: 199206 RVA: 0x0069A207 File Offset: 0x00698407
		// (set) Token: 0x06030A27 RID: 199207 RVA: 0x0069A20F File Offset: 0x0069840F
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030A28 RID: 199208 RVA: 0x0069A218 File Offset: 0x00698418
		public IOpenInfrastructureItemDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.DeliveryType = null;
			this.ReturnVar = null;
		}
	}
}
