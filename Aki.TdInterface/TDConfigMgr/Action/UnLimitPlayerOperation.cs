using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002260 RID: 8800
	public class UnLimitPlayerOperation : ActionParams
	{
		// Token: 0x0600C112 RID: 49426 RVA: 0x001BB36E File Offset: 0x001B956E
		[NullableContext(1)]
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

		// Token: 0x04007310 RID: 29456
		[Nullable(2)]
		protected new UnLimitPlayerOperation FbInstance;
	}
}
