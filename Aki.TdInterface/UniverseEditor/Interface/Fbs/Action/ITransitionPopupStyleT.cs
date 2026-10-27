using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744F RID: 29775
	public class ITransitionPopupStyleT
	{
		// Token: 0x1700E20F RID: 57871
		// (get) Token: 0x06036189 RID: 221577 RVA: 0x0075B4F2 File Offset: 0x007596F2
		// (set) Token: 0x0603618A RID: 221578 RVA: 0x0075B4FA File Offset: 0x007596FA
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x0603618B RID: 221579 RVA: 0x0075B503 File Offset: 0x00759703
		public ITransitionPopupStyleT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
		}
	}
}
