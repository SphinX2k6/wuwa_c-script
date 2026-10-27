using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426F RID: 17007
	public class IVisionSystemQuestBaseT
	{
		// Token: 0x170078BB RID: 30907
		// (get) Token: 0x060192C1 RID: 103105 RVA: 0x0039E08E File Offset: 0x0039C28E
		// (set) Token: 0x060192C2 RID: 103106 RVA: 0x0039E096 File Offset: 0x0039C296
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x060192C3 RID: 103107 RVA: 0x0039E09F File Offset: 0x0039C29F
		public IVisionSystemQuestBaseT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
		}
	}
}
