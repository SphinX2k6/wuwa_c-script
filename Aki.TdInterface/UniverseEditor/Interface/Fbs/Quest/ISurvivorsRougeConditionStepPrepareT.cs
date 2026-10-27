using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004167 RID: 16743
	public class ISurvivorsRougeConditionStepPrepareT
	{
		// Token: 0x1700769A RID: 30362
		// (get) Token: 0x06018978 RID: 100728 RVA: 0x0038AE9A File Offset: 0x0038909A
		// (set) Token: 0x06018979 RID: 100729 RVA: 0x0038AEA2 File Offset: 0x003890A2
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x0601897A RID: 100730 RVA: 0x0038AEAB File Offset: 0x003890AB
		public ISurvivorsRougeConditionStepPrepareT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
