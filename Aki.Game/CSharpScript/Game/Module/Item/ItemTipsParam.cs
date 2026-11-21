using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047FE RID: 18430
	public class ItemTipsParam : UiPopViewData
	{
		// Token: 0x04018A5B RID: 100955
		public int ItemId;

		// Token: 0x04018A5C RID: 100956
		public int ItemUid;

		// Token: 0x04018A5D RID: 100957
		[Nullable(2)]
		public object ExtraParam;

		// Token: 0x04018A5E RID: 100958
		public bool CanSkip = true;

		// Token: 0x04018A5F RID: 100959
		public bool HideNum;
	}
}
