using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC6 RID: 19398
	public class ICompareTeammateDieConditionT
	{
		// Token: 0x17008CE2 RID: 36066
		// (get) Token: 0x0601E9CF RID: 125391 RVA: 0x0044803A File Offset: 0x0044623A
		// (set) Token: 0x0601E9D0 RID: 125392 RVA: 0x00448042 File Offset: 0x00446242
		public ECondition Type { get; set; }

		// Token: 0x17008CE3 RID: 36067
		// (get) Token: 0x0601E9D1 RID: 125393 RVA: 0x0044804B File Offset: 0x0044624B
		// (set) Token: 0x0601E9D2 RID: 125394 RVA: 0x00448053 File Offset: 0x00446253
		public ECompare Compare { get; set; }

		// Token: 0x17008CE4 RID: 36068
		// (get) Token: 0x0601E9D3 RID: 125395 RVA: 0x0044805C File Offset: 0x0044625C
		// (set) Token: 0x0601E9D4 RID: 125396 RVA: 0x00448064 File Offset: 0x00446264
		public int DieCount { get; set; }

		// Token: 0x0601E9D5 RID: 125397 RVA: 0x0044806D File Offset: 0x0044626D
		public ICompareTeammateDieConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.DieCount = 0;
		}
	}
}
