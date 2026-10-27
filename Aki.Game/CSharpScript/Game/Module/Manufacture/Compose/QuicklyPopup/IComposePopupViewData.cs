using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x02005680 RID: 22144
	[NullableContext(2)]
	public interface IComposePopupViewData
	{
		// Token: 0x17008772 RID: 34674
		// (get) Token: 0x0603859A RID: 230810
		// (set) Token: 0x0603859B RID: 230811
		[Nullable(1)]
		List<ISelectedData> SelectedItemList { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17008773 RID: 34675
		// (get) Token: 0x0603859C RID: 230812
		// (set) Token: 0x0603859D RID: 230813
		Action BeforeCompose { get; set; }

		// Token: 0x17008774 RID: 34676
		// (get) Token: 0x0603859E RID: 230814
		// (set) Token: 0x0603859F RID: 230815
		Action ClickConfirm { get; set; }

		// Token: 0x17008775 RID: 34677
		// (get) Token: 0x060385A0 RID: 230816
		// (set) Token: 0x060385A1 RID: 230817
		EUiViewName? BelongView { get; set; }
	}
}
