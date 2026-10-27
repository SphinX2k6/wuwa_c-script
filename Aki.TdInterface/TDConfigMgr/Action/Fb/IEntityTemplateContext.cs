using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024EB RID: 9451
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityTemplateContext : IVarContext
	{
		// Token: 0x0600D2FC RID: 54012 RVA: 0x001F4B00 File Offset: 0x001F2D00
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

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0600D2FD RID: 54013 RVA: 0x001F4B1F File Offset: 0x001F2D1F
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x001F4B2C File Offset: 0x001F2D2C
		public virtual string Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040073B5 RID: 29621
		private IEntityTemplateContext Instance;
	}
}
