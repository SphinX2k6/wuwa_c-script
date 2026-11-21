using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A5 RID: 17829
	public class ISurvivorsRougeConditionStepChooseWeaponT
	{
		// Token: 0x17007CA3 RID: 31907
		// (get) Token: 0x0601A01C RID: 106524 RVA: 0x003B5166 File Offset: 0x003B3366
		// (set) Token: 0x0601A01D RID: 106525 RVA: 0x003B516E File Offset: 0x003B336E
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x0601A01E RID: 106526 RVA: 0x003B5177 File Offset: 0x003B3377
		public ISurvivorsRougeConditionStepChooseWeaponT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
