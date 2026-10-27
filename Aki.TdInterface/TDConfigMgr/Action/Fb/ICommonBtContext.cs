using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024ED RID: 9453
	public class ICommonBtContext : IVarContext
	{
		// Token: 0x0600D304 RID: 54020 RVA: 0x001F4B82 File Offset: 0x001F2D82
		[NullableContext(1)]
		public static ICommonBtContext Create(ICommonBtContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600D305 RID: 54021 RVA: 0x001F4BA1 File Offset: 0x001F2DA1
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0600D306 RID: 54022 RVA: 0x001F4BAE File Offset: 0x001F2DAE
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040073B7 RID: 29623
		private ICommonBtContext Instance;
	}
}
