using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DA RID: 28890
	public class IShowCenterTextParamsT
	{
		// Token: 0x1700D6A4 RID: 54948
		// (get) Token: 0x060332DB RID: 209627 RVA: 0x006E664D File Offset: 0x006E484D
		// (set) Token: 0x060332DC RID: 209628 RVA: 0x006E6655 File Offset: 0x006E4855
		public float TotalTime { get; set; }

		// Token: 0x1700D6A5 RID: 54949
		// (get) Token: 0x060332DD RID: 209629 RVA: 0x006E665E File Offset: 0x006E485E
		// (set) Token: 0x060332DE RID: 209630 RVA: 0x006E6666 File Offset: 0x006E4866
		public ITextStyleT TextStyle { get; set; }

		// Token: 0x1700D6A6 RID: 54950
		// (get) Token: 0x060332DF RID: 209631 RVA: 0x006E666F File Offset: 0x006E486F
		// (set) Token: 0x060332E0 RID: 209632 RVA: 0x006E6677 File Offset: 0x006E4877
		public string BgImageId { get; set; }

		// Token: 0x1700D6A7 RID: 54951
		// (get) Token: 0x060332E1 RID: 209633 RVA: 0x006E6680 File Offset: 0x006E4880
		// (set) Token: 0x060332E2 RID: 209634 RVA: 0x006E6688 File Offset: 0x006E4888
		public bool IsMulLine { get; set; }

		// Token: 0x1700D6A8 RID: 54952
		// (get) Token: 0x060332E3 RID: 209635 RVA: 0x006E6691 File Offset: 0x006E4891
		// (set) Token: 0x060332E4 RID: 209636 RVA: 0x006E6699 File Offset: 0x006E4899
		public bool IsManualNext { get; set; }

		// Token: 0x1700D6A9 RID: 54953
		// (get) Token: 0x060332E5 RID: 209637 RVA: 0x006E66A2 File Offset: 0x006E48A2
		// (set) Token: 0x060332E6 RID: 209638 RVA: 0x006E66AA File Offset: 0x006E48AA
		public bool IsCancelAutoLine { get; set; }

		// Token: 0x1700D6AA RID: 54954
		// (get) Token: 0x060332E7 RID: 209639 RVA: 0x006E66B3 File Offset: 0x006E48B3
		// (set) Token: 0x060332E8 RID: 209640 RVA: 0x006E66BB File Offset: 0x006E48BB
		public byte NullMask { get; set; }

		// Token: 0x060332E9 RID: 209641 RVA: 0x006E66C4 File Offset: 0x006E48C4
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
