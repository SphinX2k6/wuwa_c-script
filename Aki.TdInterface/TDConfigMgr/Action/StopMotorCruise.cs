using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221F RID: 8735
	public class StopMotorCruise : ActionParams
	{
		// Token: 0x0600BFC4 RID: 49092 RVA: 0x001B8D45 File Offset: 0x001B6F45
		[NullableContext(1)]
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

		// Token: 0x0400725D RID: 29277
		[Nullable(2)]
		protected new StopMotorCruise FbInstance;
	}
}
