using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FD RID: 27133
	public class ILifePointMaxStepRewardRuleItemT
	{
		// Token: 0x1700C955 RID: 51541
		// (get) Token: 0x0602F7B1 RID: 194481 RVA: 0x006776F8 File Offset: 0x006758F8
		// (set) Token: 0x0602F7B2 RID: 194482 RVA: 0x00677700 File Offset: 0x00675900
		public int PaintCount { get; set; }

		// Token: 0x1700C956 RID: 51542
		// (get) Token: 0x0602F7B3 RID: 194483 RVA: 0x00677709 File Offset: 0x00675909
		// (set) Token: 0x0602F7B4 RID: 194484 RVA: 0x00677711 File Offset: 0x00675911
		public int AddStep { get; set; }

		// Token: 0x0602F7B5 RID: 194485 RVA: 0x0067771A File Offset: 0x0067591A
		public ILifePointMaxStepRewardRuleItemT()
		{
			this.PaintCount = 0;
			this.AddStep = 0;
		}
	}
}
