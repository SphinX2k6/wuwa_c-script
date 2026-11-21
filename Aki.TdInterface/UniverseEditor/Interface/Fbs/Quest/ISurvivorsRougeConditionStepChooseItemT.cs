using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A2 RID: 17826
	public class ISurvivorsRougeConditionStepChooseItemT
	{
		// Token: 0x17007CA0 RID: 31904
		// (get) Token: 0x0601A00A RID: 106506 RVA: 0x003B4FEE File Offset: 0x003B31EE
		// (set) Token: 0x0601A00B RID: 106507 RVA: 0x003B4FF6 File Offset: 0x003B31F6
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x0601A00C RID: 106508 RVA: 0x003B4FFF File Offset: 0x003B31FF
		public ISurvivorsRougeConditionStepChooseItemT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
