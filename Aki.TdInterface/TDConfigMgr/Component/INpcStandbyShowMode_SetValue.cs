using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EA RID: 1514
	public class INpcStandbyShowMode_SetValue
	{
		// Token: 0x040015FD RID: 5629
		public ENpcStandbyShowMode Type;

		// Token: 0x040015FE RID: 5630
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<INpcLookAtConfig> LookAtConfigs;
	}
}
