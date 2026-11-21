using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C3F RID: 31807
	public class ITransitionPopupLeftTopTipT
	{
		// Token: 0x1700EE27 RID: 60967
		// (get) Token: 0x0603955C RID: 234844 RVA: 0x007BE060 File Offset: 0x007BC260
		// (set) Token: 0x0603955D RID: 234845 RVA: 0x007BE068 File Offset: 0x007BC268
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x1700EE28 RID: 60968
		// (get) Token: 0x0603955E RID: 234846 RVA: 0x007BE071 File Offset: 0x007BC271
		// (set) Token: 0x0603955F RID: 234847 RVA: 0x007BE079 File Offset: 0x007BC279
		public string TitleText { get; set; }

		// Token: 0x1700EE29 RID: 60969
		// (get) Token: 0x06039560 RID: 234848 RVA: 0x007BE082 File Offset: 0x007BC282
		// (set) Token: 0x06039561 RID: 234849 RVA: 0x007BE08A File Offset: 0x007BC28A
		public string ContentText { get; set; }

		// Token: 0x06039562 RID: 234850 RVA: 0x007BE093 File Offset: 0x007BC293
		public ITransitionPopupLeftTopTipT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
			this.TitleText = null;
			this.ContentText = null;
		}
	}
}
