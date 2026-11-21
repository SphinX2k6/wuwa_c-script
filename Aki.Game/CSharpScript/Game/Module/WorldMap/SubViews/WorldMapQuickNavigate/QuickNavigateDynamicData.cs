using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x02003701 RID: 14081
	public class QuickNavigateDynamicData
	{
		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x06024A89 RID: 150153 RVA: 0x00A59A4C File Offset: 0x00A57C4C
		// (set) Token: 0x06024A8A RID: 150154 RVA: 0x00A59A54 File Offset: 0x00A57C54
		public EQuickNavigateItemType ItemType { get; set; }

		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x06024A8B RID: 150155 RVA: 0x00A59A5D File Offset: 0x00A57C5D
		// (set) Token: 0x06024A8C RID: 150156 RVA: 0x00A59A65 File Offset: 0x00A57C65
		public int CountryId { get; set; }

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x06024A8D RID: 150157 RVA: 0x00A59A6E File Offset: 0x00A57C6E
		// (set) Token: 0x06024A8E RID: 150158 RVA: 0x00A59A76 File Offset: 0x00A57C76
		public int StateId { get; set; }

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x06024A8F RID: 150159 RVA: 0x00A59A7F File Offset: 0x00A57C7F
		// (set) Token: 0x06024A90 RID: 150160 RVA: 0x00A59A87 File Offset: 0x00A57C87
		public int AreaId { get; set; }

		// Token: 0x17004B6D RID: 19309
		// (get) Token: 0x06024A91 RID: 150161 RVA: 0x00A59A90 File Offset: 0x00A57C90
		// (set) Token: 0x06024A92 RID: 150162 RVA: 0x00A59A98 File Offset: 0x00A57C98
		public int Index { get; set; }

		// Token: 0x17004B6E RID: 19310
		// (get) Token: 0x06024A93 RID: 150163 RVA: 0x00A59AA1 File Offset: 0x00A57CA1
		// (set) Token: 0x06024A94 RID: 150164 RVA: 0x00A59AA9 File Offset: 0x00A57CA9
		public bool IsSelected { get; set; }

		// Token: 0x17004B6F RID: 19311
		// (get) Token: 0x06024A95 RID: 150165 RVA: 0x00A59AB2 File Offset: 0x00A57CB2
		// (set) Token: 0x06024A96 RID: 150166 RVA: 0x00A59ABA File Offset: 0x00A57CBA
		public ERefreshNavigateType RefreshType { get; set; }

		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x06024A97 RID: 150167 RVA: 0x00A59AC3 File Offset: 0x00A57CC3
		// (set) Token: 0x06024A98 RID: 150168 RVA: 0x00A59ACB File Offset: 0x00A57CCB
		public bool HasState { get; set; } = true;

		// Token: 0x17004B71 RID: 19313
		// (get) Token: 0x06024A99 RID: 150169 RVA: 0x00A59AD4 File Offset: 0x00A57CD4
		// (set) Token: 0x06024A9A RID: 150170 RVA: 0x00A59ADC File Offset: 0x00A57CDC
		public bool IsExpand { get; set; }
	}
}
