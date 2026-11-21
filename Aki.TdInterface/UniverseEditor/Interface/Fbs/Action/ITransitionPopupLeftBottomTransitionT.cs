using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C3C RID: 31804
	public class ITransitionPopupLeftBottomTransitionT
	{
		// Token: 0x1700EE20 RID: 60960
		// (get) Token: 0x0603953E RID: 234814 RVA: 0x007BDD70 File Offset: 0x007BBF70
		// (set) Token: 0x0603953F RID: 234815 RVA: 0x007BDD78 File Offset: 0x007BBF78
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x1700EE21 RID: 60961
		// (get) Token: 0x06039540 RID: 234816 RVA: 0x007BDD81 File Offset: 0x007BBF81
		// (set) Token: 0x06039541 RID: 234817 RVA: 0x007BDD89 File Offset: 0x007BBF89
		public string TitleText { get; set; }

		// Token: 0x1700EE22 RID: 60962
		// (get) Token: 0x06039542 RID: 234818 RVA: 0x007BDD92 File Offset: 0x007BBF92
		// (set) Token: 0x06039543 RID: 234819 RVA: 0x007BDD9A File Offset: 0x007BBF9A
		public string ContentText { get; set; }

		// Token: 0x06039544 RID: 234820 RVA: 0x007BDDA3 File Offset: 0x007BBFA3
		public ITransitionPopupLeftBottomTransitionT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
			this.TitleText = null;
			this.ContentText = null;
		}
	}
}
