using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC2 RID: 32194
	public class IVisualNovelPerformanceTransitionT
	{
		// Token: 0x1700F132 RID: 61746
		// (get) Token: 0x0603A2DF RID: 238303 RVA: 0x007D7C67 File Offset: 0x007D5E67
		// (set) Token: 0x0603A2E0 RID: 238304 RVA: 0x007D7C6F File Offset: 0x007D5E6F
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F133 RID: 61747
		// (get) Token: 0x0603A2E1 RID: 238305 RVA: 0x007D7C78 File Offset: 0x007D5E78
		// (set) Token: 0x0603A2E2 RID: 238306 RVA: 0x007D7C80 File Offset: 0x007D5E80
		public float StartTime { get; set; }

		// Token: 0x1700F134 RID: 61748
		// (get) Token: 0x0603A2E3 RID: 238307 RVA: 0x007D7C89 File Offset: 0x007D5E89
		// (set) Token: 0x0603A2E4 RID: 238308 RVA: 0x007D7C91 File Offset: 0x007D5E91
		public IVisualNovelTransitionPerformanceSolarSchoolT TransitionPerformanceConfig { get; set; }

		// Token: 0x1700F135 RID: 61749
		// (get) Token: 0x0603A2E5 RID: 238309 RVA: 0x007D7C9A File Offset: 0x007D5E9A
		// (set) Token: 0x0603A2E6 RID: 238310 RVA: 0x007D7CA2 File Offset: 0x007D5EA2
		public byte NullMask { get; set; }

		// Token: 0x0603A2E7 RID: 238311 RVA: 0x007D7CAB File Offset: 0x007D5EAB
		public IVisualNovelPerformanceTransitionT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.TransitionPerformanceConfig = null;
			this.NullMask = 0;
		}
	}
}
