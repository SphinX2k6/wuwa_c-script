using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116E RID: 4462
	public class IPhotographCondition_SetValue
	{
		// Token: 0x04003B6C RID: 15212
		public string TidTip;

		// Token: 0x04003B6D RID: 15213
		public IPhotographTarget Target;

		// Token: 0x04003B6E RID: 15214
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IPhotographSubTarget> SubTargets;

		// Token: 0x04003B6F RID: 15215
		[Nullable(2)]
		public string EdTidTip;
	}
}
