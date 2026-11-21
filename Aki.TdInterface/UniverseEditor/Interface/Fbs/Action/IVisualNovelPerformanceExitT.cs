using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA4 RID: 32164
	public class IVisualNovelPerformanceExitT
	{
		// Token: 0x1700F0BD RID: 61629
		// (get) Token: 0x0603A16E RID: 237934 RVA: 0x007D4BE5 File Offset: 0x007D2DE5
		// (set) Token: 0x0603A16F RID: 237935 RVA: 0x007D4BED File Offset: 0x007D2DED
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0BE RID: 61630
		// (get) Token: 0x0603A170 RID: 237936 RVA: 0x007D4BF6 File Offset: 0x007D2DF6
		// (set) Token: 0x0603A171 RID: 237937 RVA: 0x007D4BFE File Offset: 0x007D2DFE
		public float StartTime { get; set; }

		// Token: 0x1700F0BF RID: 61631
		// (get) Token: 0x0603A172 RID: 237938 RVA: 0x007D4C07 File Offset: 0x007D2E07
		// (set) Token: 0x0603A173 RID: 237939 RVA: 0x007D4C0F File Offset: 0x007D2E0F
		public int WhoId { get; set; }

		// Token: 0x1700F0C0 RID: 61632
		// (get) Token: 0x0603A174 RID: 237940 RVA: 0x007D4C18 File Offset: 0x007D2E18
		// (set) Token: 0x0603A175 RID: 237941 RVA: 0x007D4C20 File Offset: 0x007D2E20
		public bool AllExit { get; set; }

		// Token: 0x1700F0C1 RID: 61633
		// (get) Token: 0x0603A176 RID: 237942 RVA: 0x007D4C29 File Offset: 0x007D2E29
		// (set) Token: 0x0603A177 RID: 237943 RVA: 0x007D4C31 File Offset: 0x007D2E31
		public float FadeOutTime { get; set; }

		// Token: 0x1700F0C2 RID: 61634
		// (get) Token: 0x0603A178 RID: 237944 RVA: 0x007D4C3A File Offset: 0x007D2E3A
		// (set) Token: 0x0603A179 RID: 237945 RVA: 0x007D4C42 File Offset: 0x007D2E42
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700F0C3 RID: 61635
		// (get) Token: 0x0603A17A RID: 237946 RVA: 0x007D4C4B File Offset: 0x007D2E4B
		// (set) Token: 0x0603A17B RID: 237947 RVA: 0x007D4C53 File Offset: 0x007D2E53
		public byte NullMask { get; set; }

		// Token: 0x0603A17C RID: 237948 RVA: 0x007D4C5C File Offset: 0x007D2E5C
		public IVisualNovelPerformanceExitT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.AllExit = false;
			this.FadeOutTime = 0f;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
