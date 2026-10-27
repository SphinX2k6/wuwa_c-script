using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001515 RID: 5397
	public class CollectSunSpirit : ActionParams
	{
		// Token: 0x06007A9C RID: 31388 RVA: 0x00124A38 File Offset: 0x00122C38
		[NullableContext(1)]
		public static CollectSunSpirit Create([Nullable(2)] CollectSunSpirit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CollectSunSpirit
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004700 RID: 18176
		[Nullable(2)]
		protected new CollectSunSpirit FbInstance;
	}
}
