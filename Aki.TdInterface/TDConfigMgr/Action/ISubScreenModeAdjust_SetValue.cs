using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002113 RID: 8467
	public class ISubScreenModeAdjust_SetValue
	{
		// Token: 0x04006A8D RID: 27277
		public ESubScreenOperationType Type;

		// Token: 0x04006A8E RID: 27278
		public List<ISetSubScreenData> AdjustConfigs;
	}
}
