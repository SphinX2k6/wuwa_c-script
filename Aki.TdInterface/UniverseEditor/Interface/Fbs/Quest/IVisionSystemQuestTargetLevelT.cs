using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427E RID: 17022
	public class IVisionSystemQuestTargetLevelT
	{
		// Token: 0x170078D0 RID: 30928
		// (get) Token: 0x0601932C RID: 103212 RVA: 0x0039EC5C File Offset: 0x0039CE5C
		// (set) Token: 0x0601932D RID: 103213 RVA: 0x0039EC64 File Offset: 0x0039CE64
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x170078D1 RID: 30929
		// (get) Token: 0x0601932E RID: 103214 RVA: 0x0039EC6D File Offset: 0x0039CE6D
		// (set) Token: 0x0601932F RID: 103215 RVA: 0x0039EC75 File Offset: 0x0039CE75
		public int TargetLevel { get; set; }

		// Token: 0x06019330 RID: 103216 RVA: 0x0039EC7E File Offset: 0x0039CE7E
		public IVisionSystemQuestTargetLevelT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
			this.TargetLevel = 0;
		}
	}
}
