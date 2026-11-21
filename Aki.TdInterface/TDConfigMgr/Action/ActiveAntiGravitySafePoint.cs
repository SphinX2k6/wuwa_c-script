using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E1 RID: 5601
	public class ActiveAntiGravitySafePoint : ActionParams
	{
		// Token: 0x06007E63 RID: 32355 RVA: 0x0012DD20 File Offset: 0x0012BF20
		public static ActiveAntiGravitySafePoint Create([Nullable(2)] ActiveAntiGravitySafePoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActiveAntiGravitySafePoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400492A RID: 18730
		[Nullable(2)]
		protected new ActiveAntiGravitySafePoint FbInstance;
	}
}
