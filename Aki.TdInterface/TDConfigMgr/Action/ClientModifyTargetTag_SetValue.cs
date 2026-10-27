using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001500 RID: 5376
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientModifyTargetTag_SetValue
	{
		// Token: 0x040046CF RID: 18127
		public bool IsAddTag;

		// Token: 0x040046D0 RID: 18128
		public IClientModifyTarget Target;

		// Token: 0x040046D1 RID: 18129
		public List<string> PerformanceTag;
	}
}
