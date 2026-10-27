using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004628 RID: 17960
	public class IAcceptQuestT
	{
		// Token: 0x17007F7A RID: 32634
		// (get) Token: 0x0601B335 RID: 111413 RVA: 0x003DF99C File Offset: 0x003DDB9C
		// (set) Token: 0x0601B336 RID: 111414 RVA: 0x003DF9A4 File Offset: 0x003DDBA4
		public EGmCommand Type { get; set; }

		// Token: 0x17007F7B RID: 32635
		// (get) Token: 0x0601B337 RID: 111415 RVA: 0x003DF9AD File Offset: 0x003DDBAD
		// (set) Token: 0x0601B338 RID: 111416 RVA: 0x003DF9B5 File Offset: 0x003DDBB5
		public int QuestId { get; set; }

		// Token: 0x0601B339 RID: 111417 RVA: 0x003DF9BE File Offset: 0x003DDBBE
		public IAcceptQuestT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.QuestId = 0;
		}
	}
}
