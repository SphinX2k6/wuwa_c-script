using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200217E RID: 8574
	public class RoverRogueRoomFinish : ActionParams
	{
		// Token: 0x0600BC74 RID: 48244 RVA: 0x001B2776 File Offset: 0x001B0976
		[NullableContext(1)]
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

		// Token: 0x0400708B RID: 28811
		[Nullable(2)]
		protected new RoverRogueRoomFinish FbInstance;
	}
}
