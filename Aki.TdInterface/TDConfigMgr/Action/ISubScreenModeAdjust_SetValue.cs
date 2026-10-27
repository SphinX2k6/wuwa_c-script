using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EDA RID: 7898
	public class ISubScreenModeAdjust_SetValue
	{
		// Token: 0x0400649E RID: 25758
		public ESubScreenOperationType Type;

		// Token: 0x0400649F RID: 25759
		[Nullable(1)]
		public List<ISetSubScreenData> AdjustConfigs;
	}
}
