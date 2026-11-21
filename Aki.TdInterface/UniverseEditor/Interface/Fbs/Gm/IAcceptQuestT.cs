using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A90 RID: 19088
	public class IAcceptQuestT
	{
		// Token: 0x170085BB RID: 34235
		// (get) Token: 0x0601CB0A RID: 117514 RVA: 0x0040BC38 File Offset: 0x00409E38
		// (set) Token: 0x0601CB0B RID: 117515 RVA: 0x0040BC40 File Offset: 0x00409E40
		public EGmCommand Type { get; set; }

		// Token: 0x170085BC RID: 34236
		// (get) Token: 0x0601CB0C RID: 117516 RVA: 0x0040BC49 File Offset: 0x00409E49
		// (set) Token: 0x0601CB0D RID: 117517 RVA: 0x0040BC51 File Offset: 0x00409E51
		public int QuestId { get; set; }

		// Token: 0x0601CB0E RID: 117518 RVA: 0x0040BC5A File Offset: 0x00409E5A
		public IAcceptQuestT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.QuestId = 0;
		}
	}
}
