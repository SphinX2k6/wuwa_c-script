using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007149 RID: 29001
	public class ISlideRailEndTypeT
	{
		// Token: 0x1700D77A RID: 55162
		// (get) Token: 0x060336A0 RID: 210592 RVA: 0x006EDA2A File Offset: 0x006EBC2A
		// (set) Token: 0x060336A1 RID: 210593 RVA: 0x006EDA32 File Offset: 0x006EBC32
		public ESlideRailEndType Type { get; set; }

		// Token: 0x060336A2 RID: 210594 RVA: 0x006EDA3B File Offset: 0x006EBC3B
		public ISlideRailEndTypeT()
		{
			this.Type = ESlideRailEndType.Player;
		}
	}
}
