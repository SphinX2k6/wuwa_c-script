using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C9 RID: 6345
	public class HonamiStoryActivateSafeEvacuation : ActionParams
	{
		// Token: 0x06008515 RID: 34069 RVA: 0x0013D574 File Offset: 0x0013B774
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

		// Token: 0x04005497 RID: 21655
		[Nullable(2)]
		protected new HonamiStoryActivateSafeEvacuation FbInstance;
	}
}
