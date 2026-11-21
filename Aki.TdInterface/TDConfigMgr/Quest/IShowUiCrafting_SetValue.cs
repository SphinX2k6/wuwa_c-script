using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126B RID: 4715
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCrafting_SetValue
	{
		// Token: 0x04003F8B RID: 16267
		public EShowUiType Type;

		// Token: 0x04003F8C RID: 16268
		public List<int> EntityIds;

		// Token: 0x04003F8D RID: 16269
		public List<int> ProductIds;
	}
}
