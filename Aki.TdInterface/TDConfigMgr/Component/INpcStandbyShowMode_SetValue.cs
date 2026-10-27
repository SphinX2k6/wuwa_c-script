using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000581 RID: 1409
	public class INpcStandbyShowMode_SetValue
	{
		// Token: 0x0400148F RID: 5263
		public ENpcStandbyShowMode Type;

		// Token: 0x04001490 RID: 5264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INpcLookAtConfig> LookAtConfigs;
	}
}
