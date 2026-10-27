using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E64 RID: 15972
	public class IFlipperConditionStepFightT
	{
		// Token: 0x17006EBC RID: 28348
		// (get) Token: 0x060167C6 RID: 92102 RVA: 0x0034015E File Offset: 0x0033E35E
		// (set) Token: 0x060167C7 RID: 92103 RVA: 0x00340166 File Offset: 0x0033E366
		public EFlipperConditionStep Type { get; set; }

		// Token: 0x060167C8 RID: 92104 RVA: 0x0034016F File Offset: 0x0033E36F
		public IFlipperConditionStepFightT()
		{
			this.Type = EFlipperConditionStep.Fight;
		}
	}
}
