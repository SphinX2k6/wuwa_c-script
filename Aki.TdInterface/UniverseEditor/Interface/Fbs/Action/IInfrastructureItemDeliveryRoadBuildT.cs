using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695B RID: 26971
	public class IInfrastructureItemDeliveryRoadBuildT
	{
		// Token: 0x1700C80E RID: 51214
		// (get) Token: 0x0602F17C RID: 192892 RVA: 0x0066AD34 File Offset: 0x00668F34
		// (set) Token: 0x0602F17D RID: 192893 RVA: 0x0066AD3C File Offset: 0x00668F3C
		public EInfrastructureItemDeliveryType Type { get; set; }

		// Token: 0x1700C80F RID: 51215
		// (get) Token: 0x0602F17E RID: 192894 RVA: 0x0066AD45 File Offset: 0x00668F45
		// (set) Token: 0x0602F17F RID: 192895 RVA: 0x0066AD4D File Offset: 0x00668F4D
		public int Id { get; set; }

		// Token: 0x0602F180 RID: 192896 RVA: 0x0066AD56 File Offset: 0x00668F56
		public IInfrastructureItemDeliveryRoadBuildT()
		{
			this.Type = EInfrastructureItemDeliveryType.Observatory;
			this.Id = 0;
		}
	}
}
