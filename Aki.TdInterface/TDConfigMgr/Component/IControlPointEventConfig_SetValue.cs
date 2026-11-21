using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C9 RID: 713
	public class IControlPointEventConfig_SetValue
	{
		// Token: 0x04000C5C RID: 3164
		public int Index;

		// Token: 0x04000C5D RID: 3165
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> LeftInEventActions;

		// Token: 0x04000C5E RID: 3166
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> LeftOutEventActions;

		// Token: 0x04000C5F RID: 3167
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> RightInEventActions;

		// Token: 0x04000C60 RID: 3168
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> RightOutEventActions;
	}
}
