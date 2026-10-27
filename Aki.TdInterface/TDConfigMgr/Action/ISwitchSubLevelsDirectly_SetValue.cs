using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F0A RID: 7946
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchSubLevelsDirectly_SetValue
	{
		// Token: 0x04006500 RID: 25856
		public ESwitchSubLevelsType Type;

		// Token: 0x04006501 RID: 25857
		public List<string> LoadLevels;

		// Token: 0x04006502 RID: 25858
		public List<string> UnloadLevels;

		// Token: 0x04006503 RID: 25859
		public int? TeleportEntityId;

		// Token: 0x04006504 RID: 25860
		public bool? IsWaitForSwitchComplete;
	}
}
