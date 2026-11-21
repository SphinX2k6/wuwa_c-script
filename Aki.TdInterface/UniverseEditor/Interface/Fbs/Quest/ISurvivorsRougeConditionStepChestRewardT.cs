using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200459F RID: 17823
	public class ISurvivorsRougeConditionStepChestRewardT
	{
		// Token: 0x17007C9D RID: 31901
		// (get) Token: 0x06019FF8 RID: 106488 RVA: 0x003B4E76 File Offset: 0x003B3076
		// (set) Token: 0x06019FF9 RID: 106489 RVA: 0x003B4E7E File Offset: 0x003B307E
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06019FFA RID: 106490 RVA: 0x003B4E87 File Offset: 0x003B3087
		public ISurvivorsRougeConditionStepChestRewardT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
