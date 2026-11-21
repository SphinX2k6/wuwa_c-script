using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200459C RID: 17820
	public class ISurvivorsRougeConditionStepBattleT
	{
		// Token: 0x17007C9A RID: 31898
		// (get) Token: 0x06019FE6 RID: 106470 RVA: 0x003B4CFE File Offset: 0x003B2EFE
		// (set) Token: 0x06019FE7 RID: 106471 RVA: 0x003B4D06 File Offset: 0x003B2F06
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06019FE8 RID: 106472 RVA: 0x003B4D0F File Offset: 0x003B2F0F
		public ISurvivorsRougeConditionStepBattleT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
