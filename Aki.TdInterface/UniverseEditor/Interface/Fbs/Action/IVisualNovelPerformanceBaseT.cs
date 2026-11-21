using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D95 RID: 32149
	public class IVisualNovelPerformanceBaseT
	{
		// Token: 0x1700F085 RID: 61573
		// (get) Token: 0x0603A0A0 RID: 237728 RVA: 0x007D2ED6 File Offset: 0x007D10D6
		// (set) Token: 0x0603A0A1 RID: 237729 RVA: 0x007D2EDE File Offset: 0x007D10DE
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F086 RID: 61574
		// (get) Token: 0x0603A0A2 RID: 237730 RVA: 0x007D2EE7 File Offset: 0x007D10E7
		// (set) Token: 0x0603A0A3 RID: 237731 RVA: 0x007D2EEF File Offset: 0x007D10EF
		public float StartTime { get; set; }

		// Token: 0x1700F087 RID: 61575
		// (get) Token: 0x0603A0A4 RID: 237732 RVA: 0x007D2EF8 File Offset: 0x007D10F8
		// (set) Token: 0x0603A0A5 RID: 237733 RVA: 0x007D2F00 File Offset: 0x007D1100
		public byte NullMask { get; set; }

		// Token: 0x0603A0A6 RID: 237734 RVA: 0x007D2F09 File Offset: 0x007D1109
		public IVisualNovelPerformanceBaseT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.NullMask = 0;
		}
	}
}
