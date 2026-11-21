using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004515 RID: 17685
	public class IRoleTowerConditionStepBattleT
	{
		// Token: 0x17007B0F RID: 31503
		// (get) Token: 0x06019989 RID: 104841 RVA: 0x003A5B9E File Offset: 0x003A3D9E
		// (set) Token: 0x0601998A RID: 104842 RVA: 0x003A5BA6 File Offset: 0x003A3DA6
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x0601998B RID: 104843 RVA: 0x003A5BAF File Offset: 0x003A3DAF
		public IRoleTowerConditionStepBattleT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
