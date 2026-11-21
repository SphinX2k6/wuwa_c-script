using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF8 RID: 32248
	public class IVisualNovelTransitionPerformanceConfigBaseT
	{
		// Token: 0x1700F18F RID: 61839
		// (get) Token: 0x0603A46F RID: 238703 RVA: 0x007DA226 File Offset: 0x007D8426
		// (set) Token: 0x0603A470 RID: 238704 RVA: 0x007DA22E File Offset: 0x007D842E
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x0603A471 RID: 238705 RVA: 0x007DA237 File Offset: 0x007D8437
		public IVisualNovelTransitionPerformanceConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}
