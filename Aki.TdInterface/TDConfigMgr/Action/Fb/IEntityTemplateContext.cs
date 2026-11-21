using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002790 RID: 10128
	public class IEntityTemplateContext : IVarContext
	{
		// Token: 0x0600E052 RID: 57426 RVA: 0x00210398 File Offset: 0x0020E598
		public static IEntityTemplateContext Create(IEntityTemplateContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityTemplateContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0600E053 RID: 57427 RVA: 0x002103B7 File Offset: 0x0020E5B7
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x0600E054 RID: 57428 RVA: 0x002103C4 File Offset: 0x0020E5C4
		public virtual string Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007A02 RID: 31234
		private IEntityTemplateContext Instance;
	}
}
