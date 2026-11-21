using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018AB RID: 6315
	public class FixTeleControllerPos : ActionParams
	{
		// Token: 0x06008481 RID: 33921 RVA: 0x0013C593 File Offset: 0x0013A793
		public static FixTeleControllerPos Create([Nullable(2)] FixTeleControllerPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixTeleControllerPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x04005455 RID: 21589
		[Nullable(2)]
		protected new FixTeleControllerPos FbInstance;
	}
}
