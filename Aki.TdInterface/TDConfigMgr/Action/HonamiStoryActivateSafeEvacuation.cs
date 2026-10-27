using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001748 RID: 5960
	public class HonamiStoryActivateSafeEvacuation : ActionParams
	{
		// Token: 0x06007E25 RID: 32293 RVA: 0x0012E314 File Offset: 0x0012C514
		[NullableContext(1)]
		public static HonamiStoryActivateSafeEvacuation Create([Nullable(2)] HonamiStoryActivateSafeEvacuation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryActivateSafeEvacuation
			{
				FbInstance = instance
			};
		}

		// Token: 0x04005061 RID: 20577
		[Nullable(2)]
		protected new HonamiStoryActivateSafeEvacuation FbInstance;
	}
}
