using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F15 RID: 7957
	public class ITalkAkEvent
	{
		// Token: 0x0600AA28 RID: 43560 RVA: 0x0017F4B0 File Offset: 0x0017D6B0
		[NullableContext(1)]
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

		// Token: 0x0400651D RID: 25885
		[Nullable(2)]
		protected ITalkAkEvent FbInstance;
	}
}
