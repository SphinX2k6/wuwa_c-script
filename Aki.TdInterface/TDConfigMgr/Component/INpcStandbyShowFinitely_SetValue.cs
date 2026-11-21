using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E4 RID: 1508
	public class INpcStandbyShowFinitely_SetValue
	{
		// Token: 0x040015DB RID: 5595
		public ENpcStandbyShowMode Type;

		// Token: 0x040015DC RID: 5596
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<INpcLookAtConfig> LookAtConfigs;

		// Token: 0x040015DD RID: 5597
		public ENpcStandbyShowFinitelyPlayMode PlayMode;

		// Token: 0x040015DE RID: 5598
		public List<INpcStandbyShowFinitelyInfo> Montages;
	}
}
