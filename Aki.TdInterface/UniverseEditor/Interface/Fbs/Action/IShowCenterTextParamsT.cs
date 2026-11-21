using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A6 RID: 30886
	public class IShowCenterTextParamsT
	{
		// Token: 0x1700E287 RID: 57991
		// (get) Token: 0x0603657D RID: 222589 RVA: 0x00746C59 File Offset: 0x00744E59
		// (set) Token: 0x0603657E RID: 222590 RVA: 0x00746C61 File Offset: 0x00744E61
		public float TotalTime { get; set; }

		// Token: 0x1700E288 RID: 57992
		// (get) Token: 0x0603657F RID: 222591 RVA: 0x00746C6A File Offset: 0x00744E6A
		// (set) Token: 0x06036580 RID: 222592 RVA: 0x00746C72 File Offset: 0x00744E72
		public ITextStyleT TextStyle { get; set; }

		// Token: 0x1700E289 RID: 57993
		// (get) Token: 0x06036581 RID: 222593 RVA: 0x00746C7B File Offset: 0x00744E7B
		// (set) Token: 0x06036582 RID: 222594 RVA: 0x00746C83 File Offset: 0x00744E83
		public string BgImageId { get; set; }

		// Token: 0x1700E28A RID: 57994
		// (get) Token: 0x06036583 RID: 222595 RVA: 0x00746C8C File Offset: 0x00744E8C
		// (set) Token: 0x06036584 RID: 222596 RVA: 0x00746C94 File Offset: 0x00744E94
		public bool IsMulLine { get; set; }

		// Token: 0x1700E28B RID: 57995
		// (get) Token: 0x06036585 RID: 222597 RVA: 0x00746C9D File Offset: 0x00744E9D
		// (set) Token: 0x06036586 RID: 222598 RVA: 0x00746CA5 File Offset: 0x00744EA5
		public bool IsManualNext { get; set; }

		// Token: 0x1700E28C RID: 57996
		// (get) Token: 0x06036587 RID: 222599 RVA: 0x00746CAE File Offset: 0x00744EAE
		// (set) Token: 0x06036588 RID: 222600 RVA: 0x00746CB6 File Offset: 0x00744EB6
		public bool IsCancelAutoLine { get; set; }

		// Token: 0x1700E28D RID: 57997
		// (get) Token: 0x06036589 RID: 222601 RVA: 0x00746CBF File Offset: 0x00744EBF
		// (set) Token: 0x0603658A RID: 222602 RVA: 0x00746CC7 File Offset: 0x00744EC7
		public byte NullMask { get; set; }

		// Token: 0x0603658B RID: 222603 RVA: 0x00746CD0 File Offset: 0x00744ED0
		public IShowCenterTextParamsT()
		{
			this.TotalTime = 0f;
			this.TextStyle = null;
			this.BgImageId = null;
			this.IsMulLine = false;
			this.IsManualNext = false;
			this.IsCancelAutoLine = false;
			this.NullMask = 0;
		}
	}
}
