using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x02004657 RID: 18007
	[NullableContext(2)]
	[Nullable(0)]
	public class ComposePopupViewData : IComposePopupViewData
	{
		// Token: 0x17005B3D RID: 23357
		// (get) Token: 0x0602D49F RID: 185503 RVA: 0x00CAEA6A File Offset: 0x00CACC6A
		// (set) Token: 0x0602D4A0 RID: 185504 RVA: 0x00CAEA72 File Offset: 0x00CACC72
		[Nullable(1)]
		public List<ISelectedData> SelectedItemList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<ISelectedData>();

		// Token: 0x17005B3E RID: 23358
		// (get) Token: 0x0602D4A1 RID: 185505 RVA: 0x00CAEA7B File Offset: 0x00CACC7B
		// (set) Token: 0x0602D4A2 RID: 185506 RVA: 0x00CAEA83 File Offset: 0x00CACC83
		public Action BeforeCompose { get; set; }

		// Token: 0x17005B3F RID: 23359
		// (get) Token: 0x0602D4A3 RID: 185507 RVA: 0x00CAEA8C File Offset: 0x00CACC8C
		// (set) Token: 0x0602D4A4 RID: 185508 RVA: 0x00CAEA94 File Offset: 0x00CACC94
		public Action ClickConfirm { get; set; }

		// Token: 0x17005B40 RID: 23360
		// (get) Token: 0x0602D4A5 RID: 185509 RVA: 0x00CAEA9D File Offset: 0x00CACC9D
		// (set) Token: 0x0602D4A6 RID: 185510 RVA: 0x00CAEAA5 File Offset: 0x00CACCA5
		public EUiViewName? BelongView { get; set; }
	}
}
