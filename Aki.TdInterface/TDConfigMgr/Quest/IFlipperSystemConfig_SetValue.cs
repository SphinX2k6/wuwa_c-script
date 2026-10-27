using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F96 RID: 3990
	public class IFlipperSystemConfig_SetValue
	{
		// Token: 0x040035B0 RID: 13744
		public EEnableSystemType Type;

		// Token: 0x040035B1 RID: 13745
		[Nullable(1)]
		public List<IFlipperSystemVar> Vars;
	}
}
