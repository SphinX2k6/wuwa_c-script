using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA8 RID: 23208
	public class IMatchCastConfigT
	{
		// Token: 0x1700A91A RID: 43290
		// (get) Token: 0x060260BD RID: 155837 RVA: 0x00536A77 File Offset: 0x00534C77
		// (set) Token: 0x060260BE RID: 155838 RVA: 0x00536A7F File Offset: 0x00534C7F
		public int Time { get; set; }

		// Token: 0x1700A91B RID: 43291
		// (get) Token: 0x060260BF RID: 155839 RVA: 0x00536A88 File Offset: 0x00534C88
		// (set) Token: 0x060260C0 RID: 155840 RVA: 0x00536A90 File Offset: 0x00534C90
		public string Spline { get; set; }

		// Token: 0x1700A91C RID: 43292
		// (get) Token: 0x060260C1 RID: 155841 RVA: 0x00536A99 File Offset: 0x00534C99
		// (set) Token: 0x060260C2 RID: 155842 RVA: 0x00536AA1 File Offset: 0x00534CA1
		public List<IMatchSequenceT> MatchSequence { get; set; }

		// Token: 0x1700A91D RID: 43293
		// (get) Token: 0x060260C3 RID: 155843 RVA: 0x00536AAA File Offset: 0x00534CAA
		// (set) Token: 0x060260C4 RID: 155844 RVA: 0x00536AB2 File Offset: 0x00534CB2
		public string SpeedCurve { get; set; }

		// Token: 0x1700A91E RID: 43294
		// (get) Token: 0x060260C5 RID: 155845 RVA: 0x00536ABB File Offset: 0x00534CBB
		// (set) Token: 0x060260C6 RID: 155846 RVA: 0x00536AC3 File Offset: 0x00534CC3
		public byte NullMask { get; set; }

		// Token: 0x060260C7 RID: 155847 RVA: 0x00536ACC File Offset: 0x00534CCC
		public IMatchCastConfigT()
		{
			this.Time = 0;
			this.Spline = null;
			this.MatchSequence = null;
			this.SpeedCurve = null;
			this.NullMask = 0;
		}
	}
}
