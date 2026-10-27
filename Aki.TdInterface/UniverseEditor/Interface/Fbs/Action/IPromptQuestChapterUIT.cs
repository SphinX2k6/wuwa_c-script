using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC3 RID: 28099
	public class IPromptQuestChapterUIT
	{
		// Token: 0x1700D189 RID: 53641
		// (get) Token: 0x06031A31 RID: 203313 RVA: 0x006B993E File Offset: 0x006B7B3E
		// (set) Token: 0x06031A32 RID: 203314 RVA: 0x006B9946 File Offset: 0x006B7B46
		public EQuestChapterState ChapterState { get; set; }

		// Token: 0x1700D18A RID: 53642
		// (get) Token: 0x06031A33 RID: 203315 RVA: 0x006B994F File Offset: 0x006B7B4F
		// (set) Token: 0x06031A34 RID: 203316 RVA: 0x006B9957 File Offset: 0x006B7B57
		public int QuestId { get; set; }

		// Token: 0x1700D18B RID: 53643
		// (get) Token: 0x06031A35 RID: 203317 RVA: 0x006B9960 File Offset: 0x006B7B60
		// (set) Token: 0x06031A36 RID: 203318 RVA: 0x006B9968 File Offset: 0x006B7B68
		public byte NullMask { get; set; }

		// Token: 0x06031A37 RID: 203319 RVA: 0x006B9971 File Offset: 0x006B7B71
		public IPromptQuestChapterUIT()
		{
			this.ChapterState = EQuestChapterState.Start;
			this.QuestId = 0;
			this.NullMask = 0;
		}
	}
}
