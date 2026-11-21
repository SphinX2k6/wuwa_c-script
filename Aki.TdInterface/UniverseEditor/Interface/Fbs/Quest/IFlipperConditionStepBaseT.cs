using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004299 RID: 17049
	public class IFlipperConditionStepBaseT
	{
		// Token: 0x1700749B RID: 29851
		// (get) Token: 0x06017DCF RID: 97743 RVA: 0x00368A1A File Offset: 0x00366C1A
		// (set) Token: 0x06017DD0 RID: 97744 RVA: 0x00368A22 File Offset: 0x00366C22
		public EFlipperConditionStep Type { get; set; }

		// Token: 0x06017DD1 RID: 97745 RVA: 0x00368A2B File Offset: 0x00366C2B
		public IFlipperConditionStepBaseT()
		{
			this.Type = EFlipperConditionStep.Fight;
		}
	}
}
