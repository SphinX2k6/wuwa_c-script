using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E43 RID: 15939
	public class IFinishRhythmSpaceshipConditionT
	{
		// Token: 0x17006E4F RID: 28239
		// (get) Token: 0x060165E4 RID: 91620 RVA: 0x0033ACA9 File Offset: 0x00338EA9
		// (set) Token: 0x060165E5 RID: 91621 RVA: 0x0033ACB1 File Offset: 0x00338EB1
		public EChildQuest Type { get; set; }

		// Token: 0x17006E50 RID: 28240
		// (get) Token: 0x060165E6 RID: 91622 RVA: 0x0033ACBA File Offset: 0x00338EBA
		// (set) Token: 0x060165E7 RID: 91623 RVA: 0x0033ACC2 File Offset: 0x00338EC2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E51 RID: 28241
		// (get) Token: 0x060165E8 RID: 91624 RVA: 0x0033ACCB File Offset: 0x00338ECB
		// (set) Token: 0x060165E9 RID: 91625 RVA: 0x0033ACD3 File Offset: 0x00338ED3
		public IRhythmSpaceshipConditionStepInteractT Step { get; set; }

		// Token: 0x060165EA RID: 91626 RVA: 0x0033ACDC File Offset: 0x00338EDC
		public IFinishRhythmSpaceshipConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
		}
	}
}
