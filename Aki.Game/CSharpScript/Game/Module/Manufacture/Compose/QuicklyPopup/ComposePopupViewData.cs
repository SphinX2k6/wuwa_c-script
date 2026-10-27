using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x02005681 RID: 22145
	[NullableContext(2)]
	[Nullable(0)]
	public class ComposePopupViewData : IComposePopupViewData
	{
		// Token: 0x17008776 RID: 34678
		// (get) Token: 0x060385A2 RID: 230818 RVA: 0x00D6091A File Offset: 0x00D5EB1A
		// (set) Token: 0x060385A3 RID: 230819 RVA: 0x00D60922 File Offset: 0x00D5EB22
		[Nullable(1)]
		public List<ISelectedData> SelectedItemList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<ISelectedData>();

		// Token: 0x17008777 RID: 34679
		// (get) Token: 0x060385A4 RID: 230820 RVA: 0x00D6092B File Offset: 0x00D5EB2B
		// (set) Token: 0x060385A5 RID: 230821 RVA: 0x00D60933 File Offset: 0x00D5EB33
		public Action BeforeCompose { get; set; }

		// Token: 0x17008778 RID: 34680
		// (get) Token: 0x060385A6 RID: 230822 RVA: 0x00D6093C File Offset: 0x00D5EB3C
		// (set) Token: 0x060385A7 RID: 230823 RVA: 0x00D60944 File Offset: 0x00D5EB44
		public Action ClickConfirm { get; set; }

		// Token: 0x17008779 RID: 34681
		// (get) Token: 0x060385A8 RID: 230824 RVA: 0x00D6094D File Offset: 0x00D5EB4D
		// (set) Token: 0x060385A9 RID: 230825 RVA: 0x00D60955 File Offset: 0x00D5EB55
		public EUiViewName? BelongView { get; set; }
	}
}
