using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B99 RID: 19353
	public class ICompareEntitySelfStateConditionT
	{
		// Token: 0x17008C71 RID: 35953
		// (get) Token: 0x0601E826 RID: 124966 RVA: 0x004451B5 File Offset: 0x004433B5
		// (set) Token: 0x0601E827 RID: 124967 RVA: 0x004451BD File Offset: 0x004433BD
		public ECondition Type { get; set; }

		// Token: 0x17008C72 RID: 35954
		// (get) Token: 0x0601E828 RID: 124968 RVA: 0x004451C6 File Offset: 0x004433C6
		// (set) Token: 0x0601E829 RID: 124969 RVA: 0x004451CE File Offset: 0x004433CE
		public string State { get; set; }

		// Token: 0x17008C73 RID: 35955
		// (get) Token: 0x0601E82A RID: 124970 RVA: 0x004451D7 File Offset: 0x004433D7
		// (set) Token: 0x0601E82B RID: 124971 RVA: 0x004451DF File Offset: 0x004433DF
		public ECompare Compare { get; set; }

		// Token: 0x0601E82C RID: 124972 RVA: 0x004451E8 File Offset: 0x004433E8
		public ICompareEntitySelfStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.State = null;
			this.Compare = ECompare.Eq;
		}
	}
}
