using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AAA RID: 19114
	[NullableContext(1)]
	[Nullable(0)]
	public class ReviveItemData
	{
		// Token: 0x0602FD3C RID: 195900 RVA: 0x00D58C88 File Offset: 0x00D56E88
		public ReviveItemData(int playerId, IReadOnlyList<int> itemIdMap, int choseId)
		{
			this.PlayerId = playerId;
			this.ItemIdList = itemIdMap;
			this.ChoseId = choseId;
		}

		// Token: 0x04019635 RID: 103989
		public int PlayerId;

		// Token: 0x04019636 RID: 103990
		public int ChoseId;

		// Token: 0x04019637 RID: 103991
		public IReadOnlyList<int> ItemIdList;
	}
}
