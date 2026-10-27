using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001555 RID: 5461
	public class DangoAbyssActivatePortal : ActionParams
	{
		// Token: 0x06007B77 RID: 31607 RVA: 0x0012987F File Offset: 0x00127A7F
		[NullableContext(1)]
		public static DangoAbyssActivatePortal Create([Nullable(2)] DangoAbyssActivatePortal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssActivatePortal
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400471D RID: 18205
		[Nullable(2)]
		protected new DangoAbyssActivatePortal FbInstance;
	}
}
