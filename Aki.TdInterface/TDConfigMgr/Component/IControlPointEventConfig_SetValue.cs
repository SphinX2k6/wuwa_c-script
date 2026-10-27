using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000286 RID: 646
	public class IControlPointEventConfig_SetValue
	{
		// Token: 0x04000B7B RID: 2939
		public int Index;

		// Token: 0x04000B7C RID: 2940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> LeftInEventActions;

		// Token: 0x04000B7D RID: 2941
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> LeftOutEventActions;

		// Token: 0x04000B7E RID: 2942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> RightInEventActions;

		// Token: 0x04000B7F RID: 2943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> RightOutEventActions;
	}
}
