using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700B RID: 28683
	public class IInfrastructureItemDeliveryObservatoryT
	{
		// Token: 0x1700D20C RID: 53772
		// (get) Token: 0x06031B36 RID: 203574 RVA: 0x006BB01C File Offset: 0x006B921C
		// (set) Token: 0x06031B37 RID: 203575 RVA: 0x006BB024 File Offset: 0x006B9224
		public EInfrastructureItemDeliveryType Type { get; set; }

		// Token: 0x1700D20D RID: 53773
		// (get) Token: 0x06031B38 RID: 203576 RVA: 0x006BB02D File Offset: 0x006B922D
		// (set) Token: 0x06031B39 RID: 203577 RVA: 0x006BB035 File Offset: 0x006B9235
		public int Id { get; set; }

		// Token: 0x06031B3A RID: 203578 RVA: 0x006BB03E File Offset: 0x006B923E
		public IInfrastructureItemDeliveryObservatoryT()
		{
			this.Type = EInfrastructureItemDeliveryType.Observatory;
			this.Id = 0;
		}
	}
}
