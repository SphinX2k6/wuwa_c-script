using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020036FC RID: 14076
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigateIconItemData : INavigateIconItemData
	{
		// Token: 0x17004B64 RID: 19300
		// (get) Token: 0x06024A7A RID: 150138 RVA: 0x00A598BC File Offset: 0x00A57ABC
		// (set) Token: 0x06024A7B RID: 150139 RVA: 0x00A598C4 File Offset: 0x00A57AC4
		public int Id { get; set; }

		// Token: 0x17004B65 RID: 19301
		// (get) Token: 0x06024A7C RID: 150140 RVA: 0x00A598CD File Offset: 0x00A57ACD
		// (set) Token: 0x06024A7D RID: 150141 RVA: 0x00A598D5 File Offset: 0x00A57AD5
		public string IconId { get; set; }

		// Token: 0x17004B66 RID: 19302
		// (get) Token: 0x06024A7E RID: 150142 RVA: 0x00A598DE File Offset: 0x00A57ADE
		// (set) Token: 0x06024A7F RID: 150143 RVA: 0x00A598E6 File Offset: 0x00A57AE6
		public string IconPath { get; set; }

		// Token: 0x17004B67 RID: 19303
		// (get) Token: 0x06024A80 RID: 150144 RVA: 0x00A598EF File Offset: 0x00A57AEF
		// (set) Token: 0x06024A81 RID: 150145 RVA: 0x00A598F7 File Offset: 0x00A57AF7
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Action<int, MarkItem> ClickCallback { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x17004B68 RID: 19304
		// (get) Token: 0x06024A82 RID: 150146 RVA: 0x00A59900 File Offset: 0x00A57B00
		// (set) Token: 0x06024A83 RID: 150147 RVA: 0x00A59908 File Offset: 0x00A57B08
		public MarkItem MarkItem { get; set; }
	}
}
