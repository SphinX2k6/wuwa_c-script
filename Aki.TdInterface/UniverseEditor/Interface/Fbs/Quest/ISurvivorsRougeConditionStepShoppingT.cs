using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416A RID: 16746
	public class ISurvivorsRougeConditionStepShoppingT
	{
		// Token: 0x1700769D RID: 30365
		// (get) Token: 0x0601898A RID: 100746 RVA: 0x0038B012 File Offset: 0x00389212
		// (set) Token: 0x0601898B RID: 100747 RVA: 0x0038B01A File Offset: 0x0038921A
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x0601898C RID: 100748 RVA: 0x0038B023 File Offset: 0x00389223
		public ISurvivorsRougeConditionStepShoppingT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
