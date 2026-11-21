using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050B0 RID: 20656
	public class ICompareSeasonAndWeatherT
	{
		// Token: 0x170093FD RID: 37885
		// (get) Token: 0x0602057F RID: 132479 RVA: 0x0047AC66 File Offset: 0x00478E66
		// (set) Token: 0x06020580 RID: 132480 RVA: 0x0047AC6E File Offset: 0x00478E6E
		public ECondition Type { get; set; }

		// Token: 0x170093FE RID: 37886
		// (get) Token: 0x06020581 RID: 132481 RVA: 0x0047AC77 File Offset: 0x00478E77
		// (set) Token: 0x06020582 RID: 132482 RVA: 0x0047AC7F File Offset: 0x00478E7F
		public ECompare Compare { get; set; }

		// Token: 0x170093FF RID: 37887
		// (get) Token: 0x06020583 RID: 132483 RVA: 0x0047AC88 File Offset: 0x00478E88
		// (set) Token: 0x06020584 RID: 132484 RVA: 0x0047AC90 File Offset: 0x00478E90
		public int Season { get; set; }

		// Token: 0x17009400 RID: 37888
		// (get) Token: 0x06020585 RID: 132485 RVA: 0x0047AC99 File Offset: 0x00478E99
		// (set) Token: 0x06020586 RID: 132486 RVA: 0x0047ACA1 File Offset: 0x00478EA1
		public int Weather { get; set; }

		// Token: 0x17009401 RID: 37889
		// (get) Token: 0x06020587 RID: 132487 RVA: 0x0047ACAA File Offset: 0x00478EAA
		// (set) Token: 0x06020588 RID: 132488 RVA: 0x0047ACB2 File Offset: 0x00478EB2
		public byte NullMask { get; set; }

		// Token: 0x06020589 RID: 132489 RVA: 0x0047ACBB File Offset: 0x00478EBB
		public ICompareSeasonAndWeatherT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Season = 0;
			this.Weather = 0;
			this.NullMask = 0;
		}
	}
}
