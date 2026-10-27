using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x02005828 RID: 22568
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemConvertTipsParam
	{
		// Token: 0x0401DFC8 RID: 122824
		public TItem? BeforeItemData;

		// Token: 0x0401DFC9 RID: 122825
		public TItem? AfterItemData;

		// Token: 0x0401DFCA RID: 122826
		public string ShowText = "";

		// Token: 0x0401DFCB RID: 122827
		public Action OnCancelCallBack = delegate()
		{
		};

		// Token: 0x0401DFCC RID: 122828
		public Action OnConfirmCallBack = delegate()
		{
		};
	}
}
