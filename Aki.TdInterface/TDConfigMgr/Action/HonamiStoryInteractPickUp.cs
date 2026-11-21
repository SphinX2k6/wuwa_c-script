using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018CC RID: 6348
	public class HonamiStoryInteractPickUp : ActionParams
	{
		// Token: 0x06008521 RID: 34081 RVA: 0x0013D68B File Offset: 0x0013B88B
		public static HonamiStoryInteractPickUp Create([Nullable(2)] HonamiStoryInteractPickUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryInteractPickUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400549C RID: 21660
		[Nullable(2)]
		protected new HonamiStoryInteractPickUp FbInstance;
	}
}
