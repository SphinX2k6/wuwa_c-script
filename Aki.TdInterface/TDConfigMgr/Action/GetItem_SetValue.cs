using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001736 RID: 5942
	public class GetItem_SetValue
	{
		// Token: 0x04005037 RID: 20535
		[Nullable(1)]
		public List<IItemData> Items;

		// Token: 0x04005038 RID: 20536
		public EItemGetUiType? UiType;

		// Token: 0x04005039 RID: 20537
		[Nullable(2)]
		public IItemGetUiConfigSpecialQuest UiConfig;
	}
}
