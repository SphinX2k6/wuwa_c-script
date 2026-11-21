using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C42 RID: 31810
	public class ITransitionPopupStyleT
	{
		// Token: 0x1700EE2C RID: 60972
		// (get) Token: 0x06039572 RID: 234866 RVA: 0x007BE21E File Offset: 0x007BC41E
		// (set) Token: 0x06039573 RID: 234867 RVA: 0x007BE226 File Offset: 0x007BC426
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x06039574 RID: 234868 RVA: 0x007BE22F File Offset: 0x007BC42F
		public ITransitionPopupStyleT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
		}
	}
}
