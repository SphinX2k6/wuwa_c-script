using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B5 RID: 6325
	public class GetItem_SetValue
	{
		// Token: 0x0400546A RID: 21610
		public List<IItemData> Items;

		// Token: 0x0400546B RID: 21611
		public EItemGetUiType? UiType;

		// Token: 0x0400546C RID: 21612
		[Nullable(2)]
		public IItemGetUiConfigSpecialQuest UiConfig;
	}
}
