using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C24 RID: 31780
	public class ITraceTracingMaxStepRewardRuleItemT
	{
		// Token: 0x1700EDF9 RID: 60921
		// (get) Token: 0x0603948D RID: 234637 RVA: 0x007BC92C File Offset: 0x007BAB2C
		// (set) Token: 0x0603948E RID: 234638 RVA: 0x007BC934 File Offset: 0x007BAB34
		public int RestartCount { get; set; }

		// Token: 0x1700EDFA RID: 60922
		// (get) Token: 0x0603948F RID: 234639 RVA: 0x007BC93D File Offset: 0x007BAB3D
		// (set) Token: 0x06039490 RID: 234640 RVA: 0x007BC945 File Offset: 0x007BAB45
		public int AddStep { get; set; }

		// Token: 0x06039491 RID: 234641 RVA: 0x007BC94E File Offset: 0x007BAB4E
		public ITraceTracingMaxStepRewardRuleItemT()
		{
			this.RestartCount = 0;
			this.AddStep = 0;
		}
	}
}
