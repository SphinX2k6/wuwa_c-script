using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DFE RID: 32254
	public class IVisualNovelTransitionPerformanceSolarSchoolT
	{
		// Token: 0x1700F195 RID: 61845
		// (get) Token: 0x0603A493 RID: 238739 RVA: 0x007DA647 File Offset: 0x007D8847
		// (set) Token: 0x0603A494 RID: 238740 RVA: 0x007DA64F File Offset: 0x007D884F
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x1700F196 RID: 61846
		// (get) Token: 0x0603A495 RID: 238741 RVA: 0x007DA658 File Offset: 0x007D8858
		// (set) Token: 0x0603A496 RID: 238742 RVA: 0x007DA660 File Offset: 0x007D8860
		public TVisualNovelTransitionConfigUnion TransitionConfig { get; set; }

		// Token: 0x0603A497 RID: 238743 RVA: 0x007DA669 File Offset: 0x007D8869
		public IVisualNovelTransitionPerformanceSolarSchoolT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
			this.TransitionConfig = null;
		}
	}
}
