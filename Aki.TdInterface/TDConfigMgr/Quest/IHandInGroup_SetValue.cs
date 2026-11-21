using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D6 RID: 4310
	public class IHandInGroup_SetValue
	{
		// Token: 0x04003926 RID: 14630
		public EHandInItemType HandInType;

		// Token: 0x04003927 RID: 14631
		public List<int> ItemIds;

		// Token: 0x04003928 RID: 14632
		public int Count;

		// Token: 0x04003929 RID: 14633
		public int Slot;

		// Token: 0x0400392A RID: 14634
		[Nullable(2)]
		public IHandInItemRange ChoiceRange;
	}
}
