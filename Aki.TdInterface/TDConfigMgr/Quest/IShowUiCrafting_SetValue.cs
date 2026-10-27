using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200113D RID: 4413
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCrafting_SetValue
	{
		// Token: 0x04003C3D RID: 15421
		public EShowUiType Type;

		// Token: 0x04003C3E RID: 15422
		public List<int> EntityIds;

		// Token: 0x04003C3F RID: 15423
		public List<int> ProductIds;
	}
}
