using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A8 RID: 17832
	public class ISurvivorsRougeConditionStepEndT
	{
		// Token: 0x17007CA6 RID: 31910
		// (get) Token: 0x0601A02E RID: 106542 RVA: 0x003B52DE File Offset: 0x003B34DE
		// (set) Token: 0x0601A02F RID: 106543 RVA: 0x003B52E6 File Offset: 0x003B34E6
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x0601A030 RID: 106544 RVA: 0x003B52EF File Offset: 0x003B34EF
		public ISurvivorsRougeConditionStepEndT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
