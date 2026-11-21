using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200083E RID: 2110
	public class ITrampleRayDetection
	{
		// Token: 0x06002D6E RID: 11630 RVA: 0x0007629F File Offset: 0x0007449F
		public static ITrampleRayDetection Create([Nullable(2)] ITrampleRayDetection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrampleRayDetection
			{
				FbInstance = instance
			};
		}

		// Token: 0x04001E49 RID: 7753
		[Nullable(2)]
		protected ITrampleRayDetection FbInstance;
	}
}
