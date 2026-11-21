using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200450F RID: 17679
	public class IRoleTowerConditionStepBaseT
	{
		// Token: 0x17007B0A RID: 31498
		// (get) Token: 0x06019963 RID: 104803 RVA: 0x003A5816 File Offset: 0x003A3A16
		// (set) Token: 0x06019964 RID: 104804 RVA: 0x003A581E File Offset: 0x003A3A1E
		public ERoleTowerConditionStep Type { get; set; }

		// Token: 0x06019965 RID: 104805 RVA: 0x003A5827 File Offset: 0x003A3A27
		public IRoleTowerConditionStepBaseT()
		{
			this.Type = ERoleTowerConditionStep.Prepare;
		}
	}
}
