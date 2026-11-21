using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016B1 RID: 5809
	public class DangoAbyssActivatePortal : ActionParams
	{
		// Token: 0x0600824B RID: 33355 RVA: 0x0013882B File Offset: 0x00136A2B
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

		// Token: 0x04004AB9 RID: 19129
		[Nullable(2)]
		protected new DangoAbyssActivatePortal FbInstance;
	}
}
