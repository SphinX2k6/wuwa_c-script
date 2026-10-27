using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E5 RID: 4325
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntityGroup_SetValue
	{
		// Token: 0x04003AD3 RID: 15059
		public int Index;

		// Token: 0x04003AD4 RID: 15060
		public string Source;

		// Token: 0x04003AD5 RID: 15061
		public int LevelId;

		// Token: 0x04003AD6 RID: 15062
		public List<int> Entities;
	}
}
