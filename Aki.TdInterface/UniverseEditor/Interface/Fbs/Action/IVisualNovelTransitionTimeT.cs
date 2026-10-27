using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F3 RID: 30195
	public class IVisualNovelTransitionTimeT
	{
		// Token: 0x1700E55F RID: 58719
		// (get) Token: 0x0603700A RID: 225290 RVA: 0x00776911 File Offset: 0x00774B11
		// (set) Token: 0x0603700B RID: 225291 RVA: 0x00776919 File Offset: 0x00774B19
		public EVisualNovelTransitionType Type { get; set; }

		// Token: 0x1700E560 RID: 58720
		// (get) Token: 0x0603700C RID: 225292 RVA: 0x00776922 File Offset: 0x00774B22
		// (set) Token: 0x0603700D RID: 225293 RVA: 0x0077692A File Offset: 0x00774B2A
		public IVisualNovelDateT EndDate { get; set; }

		// Token: 0x1700E561 RID: 58721
		// (get) Token: 0x0603700E RID: 225294 RVA: 0x00776933 File Offset: 0x00774B33
		// (set) Token: 0x0603700F RID: 225295 RVA: 0x0077693B File Offset: 0x00774B3B
		public int EndPeriodId { get; set; }

		// Token: 0x1700E562 RID: 58722
		// (get) Token: 0x06037010 RID: 225296 RVA: 0x00776944 File Offset: 0x00774B44
		// (set) Token: 0x06037011 RID: 225297 RVA: 0x0077694C File Offset: 0x00774B4C
		public bool IsFullScreen { get; set; }

		// Token: 0x1700E563 RID: 58723
		// (get) Token: 0x06037012 RID: 225298 RVA: 0x00776955 File Offset: 0x00774B55
		// (set) Token: 0x06037013 RID: 225299 RVA: 0x0077695D File Offset: 0x00774B5D
		public byte NullMask { get; set; }

		// Token: 0x06037014 RID: 225300 RVA: 0x00776966 File Offset: 0x00774B66
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
