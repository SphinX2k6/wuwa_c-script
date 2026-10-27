using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200174B RID: 5963
	public class HonamiStoryInteractPickUp : ActionParams
	{
		// Token: 0x06007E31 RID: 32305 RVA: 0x0012E42B File Offset: 0x0012C62B
		[NullableContext(1)]
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

		// Token: 0x04005066 RID: 20582
		[Nullable(2)]
		protected new HonamiStoryInteractPickUp FbInstance;
	}
}
