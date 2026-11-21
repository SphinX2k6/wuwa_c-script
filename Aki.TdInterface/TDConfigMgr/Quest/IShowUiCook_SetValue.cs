using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001269 RID: 4713
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCook_SetValue
	{
		// Token: 0x04003F86 RID: 16262
		public EShowUiType Type;

		// Token: 0x04003F87 RID: 16263
		public List<int> EntityIds;

		// Token: 0x04003F88 RID: 16264
		public List<int> ProductIds;
	}
}
