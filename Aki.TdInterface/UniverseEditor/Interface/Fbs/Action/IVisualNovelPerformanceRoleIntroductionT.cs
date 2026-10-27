using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BD RID: 30141
	public class IVisualNovelPerformanceRoleIntroductionT
	{
		// Token: 0x1700E4DD RID: 58589
		// (get) Token: 0x06036E2C RID: 224812 RVA: 0x0077358F File Offset: 0x0077178F
		// (set) Token: 0x06036E2D RID: 224813 RVA: 0x00773597 File Offset: 0x00771797
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4DE RID: 58590
		// (get) Token: 0x06036E2E RID: 224814 RVA: 0x007735A0 File Offset: 0x007717A0
		// (set) Token: 0x06036E2F RID: 224815 RVA: 0x007735A8 File Offset: 0x007717A8
		public float StartTime { get; set; }

		// Token: 0x1700E4DF RID: 58591
		// (get) Token: 0x06036E30 RID: 224816 RVA: 0x007735B1 File Offset: 0x007717B1
		// (set) Token: 0x06036E31 RID: 224817 RVA: 0x007735B9 File Offset: 0x007717B9
		public IVisualNovelRoleIntroductionSolarSchoolT RoleIntroductionConfig { get; set; }

		// Token: 0x1700E4E0 RID: 58592
		// (get) Token: 0x06036E32 RID: 224818 RVA: 0x007735C2 File Offset: 0x007717C2
		// (set) Token: 0x06036E33 RID: 224819 RVA: 0x007735CA File Offset: 0x007717CA
		public byte NullMask { get; set; }

		// Token: 0x06036E34 RID: 224820 RVA: 0x007735D3 File Offset: 0x007717D3
		public IVisualNovelPerformanceRoleIntroductionT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.RoleIntroductionConfig = null;
			this.NullMask = 0;
		}
	}
}
