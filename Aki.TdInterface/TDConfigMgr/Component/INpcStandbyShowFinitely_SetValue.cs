using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057B RID: 1403
	public class INpcStandbyShowFinitely_SetValue
	{
		// Token: 0x0400146D RID: 5229
		public ENpcStandbyShowMode Type;

		// Token: 0x0400146E RID: 5230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INpcLookAtConfig> LookAtConfigs;

		// Token: 0x0400146F RID: 5231
		public ENpcStandbyShowFinitelyPlayMode PlayMode;

		// Token: 0x04001470 RID: 5232
		[Nullable(1)]
		public List<INpcStandbyShowFinitelyInfo> Montages;
	}
}
