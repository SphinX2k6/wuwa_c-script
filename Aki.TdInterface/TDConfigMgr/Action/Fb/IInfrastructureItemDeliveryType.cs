using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C8D RID: 11405
	public class IInfrastructureItemDeliveryType
	{
		// Token: 0x0600FA72 RID: 64114 RVA: 0x0024532F File Offset: 0x0024352F
		public static IInfrastructureItemDeliveryType Create(IInfrastructureItemDeliveryType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x0600FA73 RID: 64115 RVA: 0x0024534E File Offset: 0x0024354E
		public virtual EInfrastructureItemDeliveryType Type
		{
			get
			{
				return (EInfrastructureItemDeliveryType)this.Instance.Type;
			}
		}

		// Token: 0x040088D3 RID: 35027
		private IInfrastructureItemDeliveryType Instance;
	}
}
