using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006958 RID: 26968
	public class IInfrastructureItemDeliveryObservatoryT
	{
		// Token: 0x1700C809 RID: 51209
		// (get) Token: 0x0602F166 RID: 192870 RVA: 0x0066AB34 File Offset: 0x00668D34
		// (set) Token: 0x0602F167 RID: 192871 RVA: 0x0066AB3C File Offset: 0x00668D3C
		public EInfrastructureItemDeliveryType Type { get; set; }

		// Token: 0x1700C80A RID: 51210
		// (get) Token: 0x0602F168 RID: 192872 RVA: 0x0066AB45 File Offset: 0x00668D45
		// (set) Token: 0x0602F169 RID: 192873 RVA: 0x0066AB4D File Offset: 0x00668D4D
		public int Id { get; set; }

		// Token: 0x0602F16A RID: 192874 RVA: 0x0066AB56 File Offset: 0x00668D56
		public IInfrastructureItemDeliveryObservatoryT()
		{
			this.Type = EInfrastructureItemDeliveryType.Observatory;
			this.Id = 0;
		}
	}
}
