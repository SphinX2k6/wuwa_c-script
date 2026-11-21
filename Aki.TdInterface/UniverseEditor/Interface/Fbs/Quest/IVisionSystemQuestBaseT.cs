using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046CB RID: 18123
	public class IVisionSystemQuestBaseT
	{
		// Token: 0x17007EEC RID: 32492
		// (get) Token: 0x0601AA2D RID: 109101 RVA: 0x003C9766 File Offset: 0x003C7966
		// (set) Token: 0x0601AA2E RID: 109102 RVA: 0x003C976E File Offset: 0x003C796E
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x0601AA2F RID: 109103 RVA: 0x003C9777 File Offset: 0x003C7977
		public IVisionSystemQuestBaseT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
		}
	}
}
