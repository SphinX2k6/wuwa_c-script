using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003AE RID: 942
	public class IExtraAiAlert_SetValue
	{
		// Token: 0x04000F39 RID: 3897
		public int? MoveAlert;

		// Token: 0x04000F3A RID: 3898
		public int? StopAlert;

		// Token: 0x04000F3B RID: 3899
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IStateAlert> SelfStateAlert;
	}
}
