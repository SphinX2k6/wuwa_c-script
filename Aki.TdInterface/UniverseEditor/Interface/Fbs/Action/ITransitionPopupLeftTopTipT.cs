using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744C RID: 29772
	public class ITransitionPopupLeftTopTipT
	{
		// Token: 0x1700E20A RID: 57866
		// (get) Token: 0x06036173 RID: 221555 RVA: 0x0075B334 File Offset: 0x00759534
		// (set) Token: 0x06036174 RID: 221556 RVA: 0x0075B33C File Offset: 0x0075953C
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x1700E20B RID: 57867
		// (get) Token: 0x06036175 RID: 221557 RVA: 0x0075B345 File Offset: 0x00759545
		// (set) Token: 0x06036176 RID: 221558 RVA: 0x0075B34D File Offset: 0x0075954D
		public string TitleText { get; set; }

		// Token: 0x1700E20C RID: 57868
		// (get) Token: 0x06036177 RID: 221559 RVA: 0x0075B356 File Offset: 0x00759556
		// (set) Token: 0x06036178 RID: 221560 RVA: 0x0075B35E File Offset: 0x0075955E
		public string ContentText { get; set; }

		// Token: 0x06036179 RID: 221561 RVA: 0x0075B367 File Offset: 0x00759567
		public ITransitionPopupLeftTopTipT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
			this.TitleText = null;
			this.ContentText = null;
		}
	}
}
