using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AA RID: 9386
	public class TetrisTriggerDelayFall : ActionParams
	{
		// Token: 0x0600CC2C RID: 52268 RVA: 0x001D17F0 File Offset: 0x001CF9F0
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

		// Token: 0x04007906 RID: 30982
		[Nullable(2)]
		protected new TetrisTriggerDelayFall FbInstance;
	}
}
