using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8C RID: 23180
	public class ITimePatrolSplinePointT
	{
		// Token: 0x1700AE9A RID: 44698
		// (get) Token: 0x060277CD RID: 161741 RVA: 0x0056EF9B File Offset: 0x0056D19B
		// (set) Token: 0x060277CE RID: 161742 RVA: 0x0056EFA3 File Offset: 0x0056D1A3
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700AE9B RID: 44699
		// (get) Token: 0x060277CF RID: 161743 RVA: 0x0056EFAC File Offset: 0x0056D1AC
		// (set) Token: 0x060277D0 RID: 161744 RVA: 0x0056EFB4 File Offset: 0x0056D1B4
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700AE9C RID: 44700
		// (get) Token: 0x060277D1 RID: 161745 RVA: 0x0056EFBD File Offset: 0x0056D1BD
		// (set) Token: 0x060277D2 RID: 161746 RVA: 0x0056EFC5 File Offset: 0x0056D1C5
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700AE9D RID: 44701
		// (get) Token: 0x060277D3 RID: 161747 RVA: 0x0056EFCE File Offset: 0x0056D1CE
		// (set) Token: 0x060277D4 RID: 161748 RVA: 0x0056EFD6 File Offset: 0x0056D1D6
		public ESplineLine LineType { get; set; }

		// Token: 0x1700AE9E RID: 44702
		// (get) Token: 0x060277D5 RID: 161749 RVA: 0x0056EFDF File Offset: 0x0056D1DF
		// (set) Token: 0x060277D6 RID: 161750 RVA: 0x0056EFE7 File Offset: 0x0056D1E7
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700AE9F RID: 44703
		// (get) Token: 0x060277D7 RID: 161751 RVA: 0x0056EFF0 File Offset: 0x0056D1F0
		// (set) Token: 0x060277D8 RID: 161752 RVA: 0x0056EFF8 File Offset: 0x0056D1F8
		public int Hours { get; set; }

		// Token: 0x1700AEA0 RID: 44704
		// (get) Token: 0x060277D9 RID: 161753 RVA: 0x0056F001 File Offset: 0x0056D201
		// (set) Token: 0x060277DA RID: 161754 RVA: 0x0056F009 File Offset: 0x0056D209
		public int Minutes { get; set; }

		// Token: 0x1700AEA1 RID: 44705
		// (get) Token: 0x060277DB RID: 161755 RVA: 0x0056F012 File Offset: 0x0056D212
		// (set) Token: 0x060277DC RID: 161756 RVA: 0x0056F01A File Offset: 0x0056D21A
		public int Second { get; set; }

		// Token: 0x1700AEA2 RID: 44706
		// (get) Token: 0x060277DD RID: 161757 RVA: 0x0056F023 File Offset: 0x0056D223
		// (set) Token: 0x060277DE RID: 161758 RVA: 0x0056F02B File Offset: 0x0056D22B
		public byte NullMask { get; set; }

		// Token: 0x060277DF RID: 161759 RVA: 0x0056F034 File Offset: 0x0056D234
		public ITimePatrolSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.Hours = 0;
			this.Minutes = 0;
			this.Second = 0;
			this.NullMask = 0;
		}
	}
}
