using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A0 RID: 6304
	public class FinishState : ActionParams
	{
		// Token: 0x0600844F RID: 33871 RVA: 0x0013C022 File Offset: 0x0013A222
		public static FinishState Create([Nullable(2)] FinishState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400543E RID: 21566
		[Nullable(2)]
		protected new FinishState FbInstance;
	}
}
