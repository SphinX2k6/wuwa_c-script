using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF7 RID: 20215
	public class ICheckGameplayTagConditionT
	{
		// Token: 0x1700905A RID: 36954
		// (get) Token: 0x0601F64F RID: 128591 RVA: 0x0045F983 File Offset: 0x0045DB83
		// (set) Token: 0x0601F650 RID: 128592 RVA: 0x0045F98B File Offset: 0x0045DB8B
		public ECondition Type { get; set; }

		// Token: 0x1700905B RID: 36955
		// (get) Token: 0x0601F651 RID: 128593 RVA: 0x0045F994 File Offset: 0x0045DB94
		// (set) Token: 0x0601F652 RID: 128594 RVA: 0x0045F99C File Offset: 0x0045DB9C
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700905C RID: 36956
		// (get) Token: 0x0601F653 RID: 128595 RVA: 0x0045F9A5 File Offset: 0x0045DBA5
		// (set) Token: 0x0601F654 RID: 128596 RVA: 0x0045F9AD File Offset: 0x0045DBAD
		public string GameplayTag { get; set; }

		// Token: 0x1700905D RID: 36957
		// (get) Token: 0x0601F655 RID: 128597 RVA: 0x0045F9B6 File Offset: 0x0045DBB6
		// (set) Token: 0x0601F656 RID: 128598 RVA: 0x0045F9BE File Offset: 0x0045DBBE
		public ECompare Compare { get; set; }

		// Token: 0x0601F657 RID: 128599 RVA: 0x0045F9C7 File Offset: 0x0045DBC7
		public ICheckGameplayTagConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.GameplayTag = null;
			this.Compare = ECompare.Eq;
		}
	}
}
