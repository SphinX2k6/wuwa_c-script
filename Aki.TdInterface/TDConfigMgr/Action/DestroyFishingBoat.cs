using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016BE RID: 5822
	public class DestroyFishingBoat : ActionParams
	{
		// Token: 0x06008279 RID: 33401 RVA: 0x00138C88 File Offset: 0x00136E88
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

		// Token: 0x04004ACE RID: 19150
		[Nullable(2)]
		protected new DestroyFishingBoat FbInstance;
	}
}
