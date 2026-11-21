using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C8E RID: 11406
	public class IInfrastructureItemDeliveryObservatory : IInfrastructureItemDeliveryType
	{
		// Token: 0x0600FA75 RID: 64117 RVA: 0x00245363 File Offset: 0x00243563
		public static IInfrastructureItemDeliveryObservatory Create(IInfrastructureItemDeliveryObservatory? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryObservatory
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E07 RID: 19975
		// (get) Token: 0x0600FA76 RID: 64118 RVA: 0x00245382 File Offset: 0x00243582
		public override EInfrastructureItemDeliveryType Type
		{
			get
			{
				return (EInfrastructureItemDeliveryType)this.Instance.Type;
			}
		}

		// Token: 0x17004E08 RID: 19976
		// (get) Token: 0x0600FA77 RID: 64119 RVA: 0x0024538F File Offset: 0x0024358F
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040088D4 RID: 35028
		private IInfrastructureItemDeliveryObservatory Instance;
	}
}
