using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x02005827 RID: 22567
	public class ItemTipsParam : UiPopViewData
	{
		// Token: 0x0401DFC4 RID: 122820
		public int ItemId;

		// Token: 0x0401DFC5 RID: 122821
		public int ItemUid;

		// Token: 0x0401DFC6 RID: 122822
		[Nullable(2)]
		public object ExtraParam;

		// Token: 0x0401DFC7 RID: 122823
		public bool CanSkip = true;
	}
}
