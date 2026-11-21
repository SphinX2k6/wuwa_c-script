using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024CD RID: 9421
	public class UnLimitPlayerOperation : ActionParams
	{
		// Token: 0x0600CCD8 RID: 52440 RVA: 0x001D2AF2 File Offset: 0x001D0CF2
		public static UnLimitPlayerOperation Create([Nullable(2)] UnLimitPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnLimitPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400795D RID: 31069
		[Nullable(2)]
		protected new UnLimitPlayerOperation FbInstance;
	}
}
