using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D4 RID: 18132
	public class IVisionSystemQuestDoIdentifyT
	{
		// Token: 0x17007EF8 RID: 32504
		// (get) Token: 0x0601AA6E RID: 109166 RVA: 0x003C9F5A File Offset: 0x003C815A
		// (set) Token: 0x0601AA6F RID: 109167 RVA: 0x003C9F62 File Offset: 0x003C8162
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x0601AA70 RID: 109168 RVA: 0x003C9F6B File Offset: 0x003C816B
		public IVisionSystemQuestDoIdentifyT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
		}
	}
}
