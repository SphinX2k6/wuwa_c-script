using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E5E RID: 15966
	public class IFlipperConditionStepBaseT
	{
		// Token: 0x17006EB7 RID: 28343
		// (get) Token: 0x060167A8 RID: 92072 RVA: 0x0033FEEA File Offset: 0x0033E0EA
		// (set) Token: 0x060167A9 RID: 92073 RVA: 0x0033FEF2 File Offset: 0x0033E0F2
		public EFlipperConditionStep Type { get; set; }

		// Token: 0x060167AA RID: 92074 RVA: 0x0033FEFB File Offset: 0x0033E0FB
		public IFlipperConditionStepBaseT()
		{
			this.Type = EFlipperConditionStep.Fight;
		}
	}
}
