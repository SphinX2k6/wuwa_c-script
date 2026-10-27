using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200080C RID: 2060
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoLevelData_SetValue
	{
		// Token: 0x04001D95 RID: 7573
		public string Key;

		// Token: 0x04001D96 RID: 7574
		public List<IWuWaGoGridData> GridDatas;

		// Token: 0x04001D97 RID: 7575
		public List<IWuWaGoRoleInfo> RoleInfos;
	}
}
