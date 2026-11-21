using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045AB RID: 17835
	public class ISurvivorsRougeConditionStepPrepareT
	{
		// Token: 0x17007CA9 RID: 31913
		// (get) Token: 0x0601A040 RID: 106560 RVA: 0x003B5456 File Offset: 0x003B3656
		// (set) Token: 0x0601A041 RID: 106561 RVA: 0x003B545E File Offset: 0x003B365E
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x0601A042 RID: 106562 RVA: 0x003B5467 File Offset: 0x003B3667
		public ISurvivorsRougeConditionStepPrepareT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
