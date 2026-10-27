using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A32 RID: 10802
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroySummonedEntitiesType
	{
		// Token: 0x0600EDF8 RID: 60920 RVA: 0x0022ABEA File Offset: 0x00228DEA
		public static IDestroySummonedEntitiesType Create(IDestroySummonedEntitiesType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroySummonedEntitiesType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B56 RID: 19286
		// (get) Token: 0x0600EDF9 RID: 60921 RVA: 0x0022AC09 File Offset: 0x00228E09
		public virtual ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004B57 RID: 19287
		// (get) Token: 0x0600EDFA RID: 60922 RVA: 0x0022AC16 File Offset: 0x00228E16
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x040082F8 RID: 33528
		private IDestroySummonedEntitiesType Instance;
	}
}
