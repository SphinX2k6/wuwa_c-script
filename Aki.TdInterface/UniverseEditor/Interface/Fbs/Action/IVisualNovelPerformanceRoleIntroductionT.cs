using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB6 RID: 32182
	public class IVisualNovelPerformanceRoleIntroductionT
	{
		// Token: 0x1700F108 RID: 61704
		// (get) Token: 0x0603A259 RID: 238169 RVA: 0x007D6C1F File Offset: 0x007D4E1F
		// (set) Token: 0x0603A25A RID: 238170 RVA: 0x007D6C27 File Offset: 0x007D4E27
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F109 RID: 61705
		// (get) Token: 0x0603A25B RID: 238171 RVA: 0x007D6C30 File Offset: 0x007D4E30
		// (set) Token: 0x0603A25C RID: 238172 RVA: 0x007D6C38 File Offset: 0x007D4E38
		public float StartTime { get; set; }

		// Token: 0x1700F10A RID: 61706
		// (get) Token: 0x0603A25D RID: 238173 RVA: 0x007D6C41 File Offset: 0x007D4E41
		// (set) Token: 0x0603A25E RID: 238174 RVA: 0x007D6C49 File Offset: 0x007D4E49
		public IVisualNovelRoleIntroductionSolarSchoolT RoleIntroductionConfig { get; set; }

		// Token: 0x1700F10B RID: 61707
		// (get) Token: 0x0603A25F RID: 238175 RVA: 0x007D6C52 File Offset: 0x007D4E52
		// (set) Token: 0x0603A260 RID: 238176 RVA: 0x007D6C5A File Offset: 0x007D4E5A
		public byte NullMask { get; set; }

		// Token: 0x0603A261 RID: 238177 RVA: 0x007D6C63 File Offset: 0x007D4E63
		public IVisualNovelPerformanceRoleIntroductionT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.RoleIntroductionConfig = null;
			this.NullMask = 0;
		}
	}
}
