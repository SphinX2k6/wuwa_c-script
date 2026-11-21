using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007011 RID: 28689
	public class IInfrastructureItemDeliveryTypeT
	{
		// Token: 0x1700D215 RID: 53781
		// (get) Token: 0x06031B60 RID: 203616 RVA: 0x006BB3BA File Offset: 0x006B95BA
		// (set) Token: 0x06031B61 RID: 203617 RVA: 0x006BB3C2 File Offset: 0x006B95C2
		public EInfrastructureItemDeliveryType Type { get; set; }

		// Token: 0x06031B62 RID: 203618 RVA: 0x006BB3CB File Offset: 0x006B95CB
		public IInfrastructureItemDeliveryTypeT()
		{
			this.Type = EInfrastructureItemDeliveryType.Observatory;
		}
	}
}
