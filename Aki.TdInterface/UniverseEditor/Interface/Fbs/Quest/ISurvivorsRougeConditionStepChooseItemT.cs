using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415E RID: 16734
	public class ISurvivorsRougeConditionStepChooseItemT
	{
		// Token: 0x17007691 RID: 30353
		// (get) Token: 0x06018942 RID: 100674 RVA: 0x0038AA32 File Offset: 0x00388C32
		// (set) Token: 0x06018943 RID: 100675 RVA: 0x0038AA3A File Offset: 0x00388C3A
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06018944 RID: 100676 RVA: 0x0038AA43 File Offset: 0x00388C43
		public ISurvivorsRougeConditionStepChooseItemT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
