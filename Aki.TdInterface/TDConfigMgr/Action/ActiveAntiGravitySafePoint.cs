using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001488 RID: 5256
	public class ActiveAntiGravitySafePoint : ActionParams
	{
		// Token: 0x06007796 RID: 30614 RVA: 0x0011F0D4 File Offset: 0x0011D2D4
		[NullableContext(1)]
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

		// Token: 0x0400458F RID: 17807
		[Nullable(2)]
		protected new ActiveAntiGravitySafePoint FbInstance;
	}
}
