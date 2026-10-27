using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001560 RID: 5472
	public class DestroyFishingBoat : ActionParams
	{
		// Token: 0x06007B9B RID: 31643 RVA: 0x00129BDC File Offset: 0x00127DDC
		[NullableContext(1)]
		public static DestroyFishingBoat Create([Nullable(2)] DestroyFishingBoat instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyFishingBoat
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400472E RID: 18222
		[Nullable(2)]
		protected new DestroyFishingBoat FbInstance;
	}
}
