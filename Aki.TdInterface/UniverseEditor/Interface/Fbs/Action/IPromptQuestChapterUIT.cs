using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753E RID: 30014
	public class IPromptQuestChapterUIT
	{
		// Token: 0x1700DCD1 RID: 56529
		// (get) Token: 0x06034A2D RID: 215597 RVA: 0x00715026 File Offset: 0x00713226
		// (set) Token: 0x06034A2E RID: 215598 RVA: 0x0071502E File Offset: 0x0071322E
		public EQuestChapterState ChapterState { get; set; }

		// Token: 0x1700DCD2 RID: 56530
		// (get) Token: 0x06034A2F RID: 215599 RVA: 0x00715037 File Offset: 0x00713237
		// (set) Token: 0x06034A30 RID: 215600 RVA: 0x0071503F File Offset: 0x0071323F
		public int QuestId { get; set; }

		// Token: 0x1700DCD3 RID: 56531
		// (get) Token: 0x06034A31 RID: 215601 RVA: 0x00715048 File Offset: 0x00713248
		// (set) Token: 0x06034A32 RID: 215602 RVA: 0x00715050 File Offset: 0x00713250
		public byte NullMask { get; set; }

		// Token: 0x06034A33 RID: 215603 RVA: 0x00715059 File Offset: 0x00713259
		public IPromptQuestChapterUIT()
		{
			this.ChapterState = EQuestChapterState.Start;
			this.QuestId = 0;
			this.NullMask = 0;
		}
	}
}
