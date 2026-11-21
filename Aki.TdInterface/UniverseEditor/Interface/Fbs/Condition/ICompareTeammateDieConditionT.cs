using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050B3 RID: 20659
	public class ICompareTeammateDieConditionT
	{
		// Token: 0x17009406 RID: 37894
		// (get) Token: 0x0602059D RID: 132509 RVA: 0x0047AF46 File Offset: 0x00479146
		// (set) Token: 0x0602059E RID: 132510 RVA: 0x0047AF4E File Offset: 0x0047914E
		public ECondition Type { get; set; }

		// Token: 0x17009407 RID: 37895
		// (get) Token: 0x0602059F RID: 132511 RVA: 0x0047AF57 File Offset: 0x00479157
		// (set) Token: 0x060205A0 RID: 132512 RVA: 0x0047AF5F File Offset: 0x0047915F
		public ECompare Compare { get; set; }

		// Token: 0x17009408 RID: 37896
		// (get) Token: 0x060205A1 RID: 132513 RVA: 0x0047AF68 File Offset: 0x00479168
		// (set) Token: 0x060205A2 RID: 132514 RVA: 0x0047AF70 File Offset: 0x00479170
		public int DieCount { get; set; }

		// Token: 0x060205A3 RID: 132515 RVA: 0x0047AF79 File Offset: 0x00479179
		public ICompareTeammateDieConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.DieCount = 0;
		}
	}
}
