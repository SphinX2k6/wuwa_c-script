using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F79 RID: 8057
	public class ITalkOptionPreOption_SetValue
	{
		// Token: 0x04006B3B RID: 27451
		public ETalkOptionPreConditionType Type;

		// Token: 0x04006B3C RID: 27452
		[Nullable(1)]
		public List<int> PreOptions;
	}
}
