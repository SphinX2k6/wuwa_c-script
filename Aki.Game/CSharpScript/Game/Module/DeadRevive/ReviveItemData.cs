using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005AC9 RID: 23241
	[NullableContext(1)]
	[Nullable(0)]
	public class ReviveItemData
	{
		// Token: 0x0603ADCA RID: 241098 RVA: 0x00E07FA8 File Offset: 0x00E061A8
		public ReviveItemData(int playerId, IReadOnlyList<int> itemIdMap, int choseId)
		{
			this.PlayerId = playerId;
			this.ItemIdList = itemIdMap;
			this.ChoseId = choseId;
		}

		// Token: 0x0401EB79 RID: 125817
		public int PlayerId;

		// Token: 0x0401EB7A RID: 125818
		public int ChoseId;

		// Token: 0x0401EB7B RID: 125819
		public IReadOnlyList<int> ItemIdList;
	}
}
