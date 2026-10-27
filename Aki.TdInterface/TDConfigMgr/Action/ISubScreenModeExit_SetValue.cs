using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EDE RID: 7902
	public class ISubScreenModeExit_SetValue
	{
		// Token: 0x040064A7 RID: 25767
		public ESubScreenOperationType Type;

		// Token: 0x040064A8 RID: 25768
		[Nullable(1)]
		public List<ISetSubScreenData> ExitConfigs;
	}
}
