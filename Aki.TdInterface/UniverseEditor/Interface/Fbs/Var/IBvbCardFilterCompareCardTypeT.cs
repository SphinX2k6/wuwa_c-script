using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E18 RID: 15896
	public class IBvbCardFilterCompareCardTypeT
	{
		// Token: 0x17006B5A RID: 27482
		// (get) Token: 0x060155F6 RID: 87542 RVA: 0x00316408 File Offset: 0x00314608
		// (set) Token: 0x060155F7 RID: 87543 RVA: 0x00316410 File Offset: 0x00314610
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006B5B RID: 27483
		// (get) Token: 0x060155F8 RID: 87544 RVA: 0x00316419 File Offset: 0x00314619
		// (set) Token: 0x060155F9 RID: 87545 RVA: 0x00316421 File Offset: 0x00314621
		public int CardType { get; set; }

		// Token: 0x060155FA RID: 87546 RVA: 0x0031642A File Offset: 0x0031462A
		public IBvbCardFilterCompareCardTypeT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.CardType = 0;
		}
	}
}
