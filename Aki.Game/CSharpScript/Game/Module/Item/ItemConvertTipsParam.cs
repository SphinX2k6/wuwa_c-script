using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047FF RID: 18431
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemConvertTipsParam
	{
		// Token: 0x04018A60 RID: 100960
		public TItem? BeforeItemData;

		// Token: 0x04018A61 RID: 100961
		public TItem? AfterItemData;

		// Token: 0x04018A62 RID: 100962
		public string ShowText = "";

		// Token: 0x04018A63 RID: 100963
		public Action OnCancelCallBack = delegate()
		{
		};

		// Token: 0x04018A64 RID: 100964
		public Action OnConfirmCallBack = delegate()
		{
		};
	}
}
