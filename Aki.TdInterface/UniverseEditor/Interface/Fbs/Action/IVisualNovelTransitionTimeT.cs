using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E01 RID: 32257
	public class IVisualNovelTransitionTimeT
	{
		// Token: 0x1700F19D RID: 61853
		// (get) Token: 0x0603A4AF RID: 238767 RVA: 0x007DAA0D File Offset: 0x007D8C0D
		// (set) Token: 0x0603A4B0 RID: 238768 RVA: 0x007DAA15 File Offset: 0x007D8C15
		public EVisualNovelTransitionType Type { get; set; }

		// Token: 0x1700F19E RID: 61854
		// (get) Token: 0x0603A4B1 RID: 238769 RVA: 0x007DAA1E File Offset: 0x007D8C1E
		// (set) Token: 0x0603A4B2 RID: 238770 RVA: 0x007DAA26 File Offset: 0x007D8C26
		public IVisualNovelDateT EndDate { get; set; }

		// Token: 0x1700F19F RID: 61855
		// (get) Token: 0x0603A4B3 RID: 238771 RVA: 0x007DAA2F File Offset: 0x007D8C2F
		// (set) Token: 0x0603A4B4 RID: 238772 RVA: 0x007DAA37 File Offset: 0x007D8C37
		public int EndPeriodId { get; set; }

		// Token: 0x1700F1A0 RID: 61856
		// (get) Token: 0x0603A4B5 RID: 238773 RVA: 0x007DAA40 File Offset: 0x007D8C40
		// (set) Token: 0x0603A4B6 RID: 238774 RVA: 0x007DAA48 File Offset: 0x007D8C48
		public bool IsFullScreen { get; set; }

		// Token: 0x1700F1A1 RID: 61857
		// (get) Token: 0x0603A4B7 RID: 238775 RVA: 0x007DAA51 File Offset: 0x007D8C51
		// (set) Token: 0x0603A4B8 RID: 238776 RVA: 0x007DAA59 File Offset: 0x007D8C59
		public byte NullMask { get; set; }

		// Token: 0x0603A4B9 RID: 238777 RVA: 0x007DAA62 File Offset: 0x007D8C62
		public IVisualNovelTransitionTimeT()
		{
			this.Type = EVisualNovelTransitionType.Location;
			this.EndDate = null;
			this.EndPeriodId = 0;
			this.IsFullScreen = false;
			this.NullMask = 0;
		}
	}
}
