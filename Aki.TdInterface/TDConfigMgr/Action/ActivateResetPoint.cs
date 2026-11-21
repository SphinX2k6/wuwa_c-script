using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E0 RID: 5600
	public class ActivateResetPoint : ActionParams
	{
		// Token: 0x06007E61 RID: 32353 RVA: 0x0012DD05 File Offset: 0x0012BF05
		public static ActivateResetPoint Create([Nullable(2)] ActivateResetPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActivateResetPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004929 RID: 18729
		[Nullable(2)]
		protected new ActivateResetPoint FbInstance;
	}
}
