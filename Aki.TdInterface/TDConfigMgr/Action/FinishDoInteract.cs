using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001720 RID: 5920
	public class FinishDoInteract : ActionParams
	{
		// Token: 0x06007D67 RID: 32103 RVA: 0x0012CE9F File Offset: 0x0012B09F
		[NullableContext(1)]
		public static FinishDoInteract Create([Nullable(2)] FinishDoInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishDoInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400500B RID: 20491
		[Nullable(2)]
		protected new FinishDoInteract FbInstance;
	}
}
