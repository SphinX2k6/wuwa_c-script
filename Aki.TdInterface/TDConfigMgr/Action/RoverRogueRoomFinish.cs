using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DF RID: 9183
	public class RoverRogueRoomFinish : ActionParams
	{
		// Token: 0x0600C802 RID: 51202 RVA: 0x001C992A File Offset: 0x001C7B2A
		public static RoverRogueRoomFinish Create([Nullable(2)] RoverRogueRoomFinish instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoverRogueRoomFinish
			{
				FbInstance = instance
			};
		}

		// Token: 0x040076C0 RID: 30400
		[Nullable(2)]
		protected new RoverRogueRoomFinish FbInstance;
	}
}
