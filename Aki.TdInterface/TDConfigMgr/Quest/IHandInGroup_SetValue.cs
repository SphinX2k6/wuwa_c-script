using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FAC RID: 4012
	public class IHandInGroup_SetValue
	{
		// Token: 0x040035F4 RID: 13812
		public EHandInItemType HandInType;

		// Token: 0x040035F5 RID: 13813
		[Nullable(1)]
		public List<int> ItemIds;

		// Token: 0x040035F6 RID: 13814
		public int Count;

		// Token: 0x040035F7 RID: 13815
		public int Slot;

		// Token: 0x040035F8 RID: 13816
		[Nullable(2)]
		public IHandInItemRange ChoiceRange;
	}
}
