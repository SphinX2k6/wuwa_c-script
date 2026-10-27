using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E7 RID: 9447
	public class IVarContext
	{
		// Token: 0x0600D2EC RID: 53996 RVA: 0x001F49D2 File Offset: 0x001F2BD2
		[NullableContext(1)]
		public static IVarContext Create(IVarContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVarContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0600D2ED RID: 53997 RVA: 0x001F49F1 File Offset: 0x001F2BF1
		public virtual EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x040073B1 RID: 29617
		private IVarContext Instance;
	}
}
