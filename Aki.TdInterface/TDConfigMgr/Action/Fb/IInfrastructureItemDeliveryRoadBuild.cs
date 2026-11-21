using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C8F RID: 11407
	public class IInfrastructureItemDeliveryRoadBuild : IInfrastructureItemDeliveryType
	{
		// Token: 0x0600FA79 RID: 64121 RVA: 0x002453A4 File Offset: 0x002435A4
		public static IInfrastructureItemDeliveryRoadBuild Create(IInfrastructureItemDeliveryRoadBuild? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryRoadBuild
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E09 RID: 19977
		// (get) Token: 0x0600FA7A RID: 64122 RVA: 0x002453C3 File Offset: 0x002435C3
		public override EInfrastructureItemDeliveryType Type
		{
			get
			{
				return (EInfrastructureItemDeliveryType)this.Instance.Type;
			}
		}

		// Token: 0x17004E0A RID: 19978
		// (get) Token: 0x0600FA7B RID: 64123 RVA: 0x002453D0 File Offset: 0x002435D0
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040088D5 RID: 35029
		private IInfrastructureItemDeliveryRoadBuild Instance;
	}
}
