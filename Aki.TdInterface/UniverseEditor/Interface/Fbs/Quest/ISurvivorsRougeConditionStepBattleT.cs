using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004158 RID: 16728
	public class ISurvivorsRougeConditionStepBattleT
	{
		// Token: 0x1700768B RID: 30347
		// (get) Token: 0x0601891E RID: 100638 RVA: 0x0038A742 File Offset: 0x00388942
		// (set) Token: 0x0601891F RID: 100639 RVA: 0x0038A74A File Offset: 0x0038894A
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06018920 RID: 100640 RVA: 0x0038A753 File Offset: 0x00388953
		public ISurvivorsRougeConditionStepBattleT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
