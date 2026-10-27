using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024C5 RID: 9413
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityActionContext : IActionContextType
	{
		// Token: 0x0600D258 RID: 53848 RVA: 0x001F379B File Offset: 0x001F199B
		public static IEntityActionContext Create(IEntityActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0600D259 RID: 53849 RVA: 0x001F37BA File Offset: 0x001F19BA
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x0400736D RID: 29549
		private IEntityActionContext Instance;
	}
}
