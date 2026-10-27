using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200079D RID: 1949
	public class ITrampleRayDetection
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x0006EFF7 File Offset: 0x0006D1F7
		[NullableContext(1)]
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

		// Token: 0x04001C40 RID: 7232
		[Nullable(2)]
		protected ITrampleRayDetection FbInstance;
	}
}
