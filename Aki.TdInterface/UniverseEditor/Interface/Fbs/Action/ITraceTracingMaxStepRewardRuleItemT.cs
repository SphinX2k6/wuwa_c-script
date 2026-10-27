using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007431 RID: 29745
	public class ITraceTracingMaxStepRewardRuleItemT
	{
		// Token: 0x1700E1DC RID: 57820
		// (get) Token: 0x060360A4 RID: 221348 RVA: 0x00759C00 File Offset: 0x00757E00
		// (set) Token: 0x060360A5 RID: 221349 RVA: 0x00759C08 File Offset: 0x00757E08
		public int RestartCount { get; set; }

		// Token: 0x1700E1DD RID: 57821
		// (get) Token: 0x060360A6 RID: 221350 RVA: 0x00759C11 File Offset: 0x00757E11
		// (set) Token: 0x060360A7 RID: 221351 RVA: 0x00759C19 File Offset: 0x00757E19
		public int AddStep { get; set; }

		// Token: 0x060360A8 RID: 221352 RVA: 0x00759C22 File Offset: 0x00757E22
		public ITraceTracingMaxStepRewardRuleItemT()
		{
			this.RestartCount = 0;
			this.AddStep = 0;
		}
	}
}
