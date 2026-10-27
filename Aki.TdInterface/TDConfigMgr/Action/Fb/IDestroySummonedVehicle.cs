using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A33 RID: 10803
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroySummonedVehicle : IDestroySummonedEntitiesType
	{
		// Token: 0x0600EDFC RID: 60924 RVA: 0x0022AC2B File Offset: 0x00228E2B
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

		// Token: 0x17004B58 RID: 19288
		// (get) Token: 0x0600EDFD RID: 60925 RVA: 0x0022AC4A File Offset: 0x00228E4A
		public override ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004B59 RID: 19289
		// (get) Token: 0x0600EDFE RID: 60926 RVA: 0x0022AC57 File Offset: 0x00228E57
		public override string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x040082F9 RID: 33529
		private IDestroySummonedVehicle Instance;
	}
}
