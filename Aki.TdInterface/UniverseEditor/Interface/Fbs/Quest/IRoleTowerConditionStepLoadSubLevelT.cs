using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004518 RID: 17688
	public class IRoleTowerConditionStepLoadSubLevelT
	{
		// Token: 0x17007B12 RID: 31506
		// (get) Token: 0x0601999B RID: 104859 RVA: 0x003A5D16 File Offset: 0x003A3F16
		// (set) Token: 0x0601999C RID: 104860 RVA: 0x003A5D1E File Offset: 0x003A3F1E
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x0601999D RID: 104861 RVA: 0x003A5D27 File Offset: 0x003A3F27
		public IRoleTowerConditionStepLoadSubLevelT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
