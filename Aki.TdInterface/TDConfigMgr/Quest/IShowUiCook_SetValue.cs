using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200113B RID: 4411
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCook_SetValue
	{
		// Token: 0x04003C38 RID: 15416
		public EShowUiType Type;

		// Token: 0x04003C39 RID: 15417
		public List<int> EntityIds;

		// Token: 0x04003C3A RID: 15418
		public List<int> ProductIds;
	}
}
