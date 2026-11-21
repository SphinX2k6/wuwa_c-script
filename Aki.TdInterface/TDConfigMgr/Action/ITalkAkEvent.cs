using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214E RID: 8526
	public class ITalkAkEvent
	{
		// Token: 0x0600B4FA RID: 46330 RVA: 0x001954A8 File Offset: 0x001936A8
		public static ITalkAkEvent Create([Nullable(2)] ITalkAkEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkAkEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x04006B0C RID: 27404
		[Nullable(2)]
		protected ITalkAkEvent FbInstance;
	}
}
