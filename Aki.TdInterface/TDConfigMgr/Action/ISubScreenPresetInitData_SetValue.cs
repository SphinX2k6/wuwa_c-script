using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE2 RID: 7906
	public class ISubScreenPresetInitData_SetValue
	{
		// Token: 0x040064AF RID: 25775
		public ESubScreenInitDataType Type;

		// Token: 0x040064B0 RID: 25776
		[Nullable(1)]
		public string SubScreenKey;

		// Token: 0x040064B1 RID: 25777
		public ESubScreenInitPreset AnchorType;
	}
}
