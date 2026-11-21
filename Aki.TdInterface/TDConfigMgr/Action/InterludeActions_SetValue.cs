using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8A RID: 7818
	public class InterludeActions_SetValue
	{
		// Token: 0x04006442 RID: 25666
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> InterludeActionList;

		// Token: 0x04006443 RID: 25667
		[Nullable(2)]
		public List<int> DestroyEntityIds;

		// Token: 0x04006444 RID: 25668
		public bool IsFadeIn;

		// Token: 0x04006445 RID: 25669
		public bool IsFadeOut;
	}
}
