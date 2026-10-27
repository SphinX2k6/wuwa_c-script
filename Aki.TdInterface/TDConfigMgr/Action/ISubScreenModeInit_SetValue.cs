using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE0 RID: 7904
	public class ISubScreenModeInit_SetValue
	{
		// Token: 0x040064AB RID: 25771
		public ESubScreenOperationType Type;

		// Token: 0x040064AC RID: 25772
		[Nullable(1)]
		public List<ISubScreenInitData> InitConfigs;
	}
}
