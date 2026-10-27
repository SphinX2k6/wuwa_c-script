using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001557 RID: 5463
	public class DangoAbyssGotoNextFloor : ActionParams
	{
		// Token: 0x06007B7B RID: 31611 RVA: 0x001298B5 File Offset: 0x00127AB5
		[NullableContext(1)]
		public static DangoAbyssGotoNextFloor Create([Nullable(2)] DangoAbyssGotoNextFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssGotoNextFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400471F RID: 18207
		[Nullable(2)]
		protected new DangoAbyssGotoNextFloor FbInstance;
	}
}
