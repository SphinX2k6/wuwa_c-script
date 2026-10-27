using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C85 RID: 7301
	public class InterludeActions_SetValue
	{
		// Token: 0x04005EEF RID: 24303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> InterludeActionList;

		// Token: 0x04005EF0 RID: 24304
		[Nullable(2)]
		public List<int> DestroyEntityIds;

		// Token: 0x04005EF1 RID: 24305
		public bool IsFadeIn;

		// Token: 0x04005EF2 RID: 24306
		public bool IsFadeOut;
	}
}
