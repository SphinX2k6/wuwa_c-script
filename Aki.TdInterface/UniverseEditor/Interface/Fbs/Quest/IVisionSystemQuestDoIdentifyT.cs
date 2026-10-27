using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004278 RID: 17016
	public class IVisionSystemQuestDoIdentifyT
	{
		// Token: 0x170078C7 RID: 30919
		// (get) Token: 0x06019302 RID: 103170 RVA: 0x0039E882 File Offset: 0x0039CA82
		// (set) Token: 0x06019303 RID: 103171 RVA: 0x0039E88A File Offset: 0x0039CA8A
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x06019304 RID: 103172 RVA: 0x0039E893 File Offset: 0x0039CA93
		public IVisionSystemQuestDoIdentifyT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
		}
	}
}
