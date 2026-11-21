using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D1F RID: 11551
	public class IDestroySummonedEntitiesType
	{
		// Token: 0x0600FC90 RID: 64656 RVA: 0x0024859E File Offset: 0x0024679E
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

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x0600FC91 RID: 64657 RVA: 0x002485BD File Offset: 0x002467BD
		public virtual ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004F01 RID: 20225
		// (get) Token: 0x0600FC92 RID: 64658 RVA: 0x002485CA File Offset: 0x002467CA
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x040089EB RID: 35307
		private IDestroySummonedEntitiesType Instance;
	}
}
