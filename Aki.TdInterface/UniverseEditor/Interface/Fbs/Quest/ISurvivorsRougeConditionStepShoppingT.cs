using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045AE RID: 17838
	public class ISurvivorsRougeConditionStepShoppingT
	{
		// Token: 0x17007CAC RID: 31916
		// (get) Token: 0x0601A052 RID: 106578 RVA: 0x003B55CE File Offset: 0x003B37CE
		// (set) Token: 0x0601A053 RID: 106579 RVA: 0x003B55D6 File Offset: 0x003B37D6
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x0601A054 RID: 106580 RVA: 0x003B55DF File Offset: 0x003B37DF
		public ISurvivorsRougeConditionStepShoppingT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
