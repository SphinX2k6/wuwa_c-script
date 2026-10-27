using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4B RID: 7499
	public class IPreloadMp4s_SetValue
	{
		// Token: 0x040060E7 RID: 24807
		public EPreloadObjectType Type;

		// Token: 0x040060E8 RID: 24808
		[Nullable(1)]
		public List<string> Mp4s;
	}
}
