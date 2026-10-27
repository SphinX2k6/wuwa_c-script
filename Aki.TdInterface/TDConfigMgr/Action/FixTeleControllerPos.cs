using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200172E RID: 5934
	public class FixTeleControllerPos : ActionParams
	{
		// Token: 0x06007DA3 RID: 32163 RVA: 0x0012D4E7 File Offset: 0x0012B6E7
		[NullableContext(1)]
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

		// Token: 0x04005026 RID: 20518
		[Nullable(2)]
		protected new FixTeleControllerPos FbInstance;
	}
}
