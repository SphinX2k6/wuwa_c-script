using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004152 RID: 16722
	public class ISurvivorsRougeConditionStepBaseT
	{
		// Token: 0x17007686 RID: 30342
		// (get) Token: 0x060188F4 RID: 100596 RVA: 0x0038A33A File Offset: 0x0038853A
		// (set) Token: 0x060188F5 RID: 100597 RVA: 0x0038A342 File Offset: 0x00388542
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x060188F6 RID: 100598 RVA: 0x0038A34B File Offset: 0x0038854B
		public ISurvivorsRougeConditionStepBaseT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
