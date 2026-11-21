using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D20 RID: 11552
	public class IDestroySummonedVehicle : IDestroySummonedEntitiesType
	{
		// Token: 0x0600FC94 RID: 64660 RVA: 0x002485DF File Offset: 0x002467DF
		public static IDestroySummonedVehicle Create(IDestroySummonedVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroySummonedVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F02 RID: 20226
		// (get) Token: 0x0600FC95 RID: 64661 RVA: 0x002485FE File Offset: 0x002467FE
		public override ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004F03 RID: 20227
		// (get) Token: 0x0600FC96 RID: 64662 RVA: 0x0024860B File Offset: 0x0024680B
		public override string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x040089EC RID: 35308
		private IDestroySummonedVehicle Instance;
	}
}
