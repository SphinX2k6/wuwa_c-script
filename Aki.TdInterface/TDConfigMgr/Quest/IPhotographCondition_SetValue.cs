using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001040 RID: 4160
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographCondition_SetValue
	{
		// Token: 0x04003824 RID: 14372
		public string TidTip;

		// Token: 0x04003825 RID: 14373
		public IPhotographTarget Target;

		// Token: 0x04003826 RID: 14374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IPhotographSubTarget> SubTargets;

		// Token: 0x04003827 RID: 14375
		[Nullable(2)]
		public string EdTidTip;
	}
}
