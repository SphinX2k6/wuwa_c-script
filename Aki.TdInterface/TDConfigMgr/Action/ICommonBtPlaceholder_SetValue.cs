using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001907 RID: 6407
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtPlaceholder_SetValue
	{
		// Token: 0x0400560A RID: 22026
		public int Id;

		// Token: 0x0400560B RID: 22027
		public string Name;

		// Token: 0x0400560C RID: 22028
		public ICommonBtOverrideTaskInfoBase Value;

		// Token: 0x0400560D RID: 22029
		public List<int> RefTaskIds;
	}
}
