using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004596 RID: 17814
	public class ISurvivorsRougeConditionStepBaseT
	{
		// Token: 0x17007C95 RID: 31893
		// (get) Token: 0x06019FBC RID: 106428 RVA: 0x003B48F6 File Offset: 0x003B2AF6
		// (set) Token: 0x06019FBD RID: 106429 RVA: 0x003B48FE File Offset: 0x003B2AFE
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06019FBE RID: 106430 RVA: 0x003B4907 File Offset: 0x003B2B07
		public ISurvivorsRougeConditionStepBaseT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
