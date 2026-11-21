using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x02004656 RID: 18006
	[NullableContext(2)]
	public interface IComposePopupViewData
	{
		// Token: 0x17005B39 RID: 23353
		// (get) Token: 0x0602D497 RID: 185495
		// (set) Token: 0x0602D498 RID: 185496
		[Nullable(1)]
		List<ISelectedData> SelectedItemList { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005B3A RID: 23354
		// (get) Token: 0x0602D499 RID: 185497
		// (set) Token: 0x0602D49A RID: 185498
		Action BeforeCompose { get; set; }

		// Token: 0x17005B3B RID: 23355
		// (get) Token: 0x0602D49B RID: 185499
		// (set) Token: 0x0602D49C RID: 185500
		Action ClickConfirm { get; set; }

		// Token: 0x17005B3C RID: 23356
		// (get) Token: 0x0602D49D RID: 185501
		// (set) Token: 0x0602D49E RID: 185502
		EUiViewName? BelongView { get; set; }
	}
}
