using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248A RID: 9354
	public class StopMotorCruise : ActionParams
	{
		// Token: 0x0600CB82 RID: 52098 RVA: 0x001D0411 File Offset: 0x001CE611
		public static StopMotorCruise Create([Nullable(2)] StopMotorCruise instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopMotorCruise
			{
				FbInstance = instance
			};
		}

		// Token: 0x040078A7 RID: 30887
		[Nullable(2)]
		protected new StopMotorCruise FbInstance;
	}
}
