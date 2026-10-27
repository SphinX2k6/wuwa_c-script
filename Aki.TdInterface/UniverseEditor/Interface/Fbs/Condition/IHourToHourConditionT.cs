using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C44 RID: 19524
	public class IHourToHourConditionT
	{
		// Token: 0x17008DD8 RID: 36312
		// (get) Token: 0x0601EF2D RID: 126765 RVA: 0x00454626 File Offset: 0x00452826
		// (set) Token: 0x0601EF2E RID: 126766 RVA: 0x0045462E File Offset: 0x0045282E
		public ECondition Type { get; set; }

		// Token: 0x17008DD9 RID: 36313
		// (get) Token: 0x0601EF2F RID: 126767 RVA: 0x00454637 File Offset: 0x00452837
		// (set) Token: 0x0601EF30 RID: 126768 RVA: 0x0045463F File Offset: 0x0045283F
		public IHourT Start { get; set; }

		// Token: 0x17008DDA RID: 36314
		// (get) Token: 0x0601EF31 RID: 126769 RVA: 0x00454648 File Offset: 0x00452848
		// (set) Token: 0x0601EF32 RID: 126770 RVA: 0x00454650 File Offset: 0x00452850
		public IHourT End { get; set; }

		// Token: 0x17008DDB RID: 36315
		// (get) Token: 0x0601EF33 RID: 126771 RVA: 0x00454659 File Offset: 0x00452859
		// (set) Token: 0x0601EF34 RID: 126772 RVA: 0x00454661 File Offset: 0x00452861
		public ECompare Compare { get; set; }

		// Token: 0x0601EF35 RID: 126773 RVA: 0x0045466A File Offset: 0x0045286A
		public IHourToHourConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Start = null;
			this.End = null;
			this.Compare = ECompare.Eq;
		}
	}
}
