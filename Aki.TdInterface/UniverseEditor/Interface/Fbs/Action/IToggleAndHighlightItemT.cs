using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F5 RID: 29685
	public class IToggleAndHighlightItemT
	{
		// Token: 0x1700E175 RID: 57717
		// (get) Token: 0x06035ECF RID: 220879 RVA: 0x00756B26 File Offset: 0x00754D26
		// (set) Token: 0x06035ED0 RID: 220880 RVA: 0x00756B2E File Offset: 0x00754D2E
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700E176 RID: 57718
		// (get) Token: 0x06035ED1 RID: 220881 RVA: 0x00756B37 File Offset: 0x00754D37
		// (set) Token: 0x06035ED2 RID: 220882 RVA: 0x00756B3F File Offset: 0x00754D3F
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700E177 RID: 57719
		// (get) Token: 0x06035ED3 RID: 220883 RVA: 0x00756B48 File Offset: 0x00754D48
		// (set) Token: 0x06035ED4 RID: 220884 RVA: 0x00756B50 File Offset: 0x00754D50
		public int ItemId { get; set; }

		// Token: 0x1700E178 RID: 57720
		// (get) Token: 0x06035ED5 RID: 220885 RVA: 0x00756B59 File Offset: 0x00754D59
		// (set) Token: 0x06035ED6 RID: 220886 RVA: 0x00756B61 File Offset: 0x00754D61
		public int SkillType { get; set; }

		// Token: 0x1700E179 RID: 57721
		// (get) Token: 0x06035ED7 RID: 220887 RVA: 0x00756B6A File Offset: 0x00754D6A
		// (set) Token: 0x06035ED8 RID: 220888 RVA: 0x00756B72 File Offset: 0x00754D72
		public bool IsShowTips { get; set; }

		// Token: 0x1700E17A RID: 57722
		// (get) Token: 0x06035ED9 RID: 220889 RVA: 0x00756B7B File Offset: 0x00754D7B
		// (set) Token: 0x06035EDA RID: 220890 RVA: 0x00756B83 File Offset: 0x00754D83
		public bool IsSwitchBack { get; set; }

		// Token: 0x1700E17B RID: 57723
		// (get) Token: 0x06035EDB RID: 220891 RVA: 0x00756B8C File Offset: 0x00754D8C
		// (set) Token: 0x06035EDC RID: 220892 RVA: 0x00756B94 File Offset: 0x00754D94
		public byte NullMask { get; set; }

		// Token: 0x06035EDD RID: 220893 RVA: 0x00756B9D File Offset: 0x00754D9D
		public IToggleAndHighlightItemT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.ItemId = 0;
			this.SkillType = 0;
			this.IsShowTips = false;
			this.IsSwitchBack = false;
			this.NullMask = 0;
		}
	}
}
