using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EA RID: 30186
	public class IVisualNovelTransitionPerformanceConfigBaseT
	{
		// Token: 0x1700E551 RID: 58705
		// (get) Token: 0x06036FCA RID: 225226 RVA: 0x0077612A File Offset: 0x0077432A
		// (set) Token: 0x06036FCB RID: 225227 RVA: 0x00776132 File Offset: 0x00774332
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x06036FCC RID: 225228 RVA: 0x0077613B File Offset: 0x0077433B
		public IVisualNovelTransitionPerformanceConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}
