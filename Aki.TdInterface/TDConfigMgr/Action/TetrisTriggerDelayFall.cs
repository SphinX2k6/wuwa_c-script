using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200223F RID: 8767
	public class TetrisTriggerDelayFall : ActionParams
	{
		// Token: 0x0600C06E RID: 49262 RVA: 0x001BA124 File Offset: 0x001B8324
		[NullableContext(1)]
		public static TetrisTriggerDelayFall Create([Nullable(2)] TetrisTriggerDelayFall instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisTriggerDelayFall
			{
				FbInstance = instance
			};
		}

		// Token: 0x040072BC RID: 29372
		[Nullable(2)]
		protected new TetrisTriggerDelayFall FbInstance;
	}
}
