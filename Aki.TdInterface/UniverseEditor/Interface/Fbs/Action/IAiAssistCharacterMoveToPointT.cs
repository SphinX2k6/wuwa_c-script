using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DF RID: 26591
	public class IAiAssistCharacterMoveToPointT
	{
		// Token: 0x1700C37C RID: 50044
		// (get) Token: 0x0602D6B1 RID: 186033 RVA: 0x006385E7 File Offset: 0x006367E7
		// (set) Token: 0x0602D6B2 RID: 186034 RVA: 0x006385EF File Offset: 0x006367EF
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700C37D RID: 50045
		// (get) Token: 0x0602D6B3 RID: 186035 RVA: 0x006385F8 File Offset: 0x006367F8
		// (set) Token: 0x0602D6B4 RID: 186036 RVA: 0x00638600 File Offset: 0x00636800
		public int AssistCharacterId { get; set; }

		// Token: 0x1700C37E RID: 50046
		// (get) Token: 0x0602D6B5 RID: 186037 RVA: 0x00638609 File Offset: 0x00636809
		// (set) Token: 0x0602D6B6 RID: 186038 RVA: 0x00638611 File Offset: 0x00636811
		public TAssistCharacterMoveTypeUnion MoveType { get; set; }

		// Token: 0x1700C37F RID: 50047
		// (get) Token: 0x0602D6B7 RID: 186039 RVA: 0x0063861A File Offset: 0x0063681A
		// (set) Token: 0x0602D6B8 RID: 186040 RVA: 0x00638622 File Offset: 0x00636822
		public int Timeout { get; set; }

		// Token: 0x0602D6B9 RID: 186041 RVA: 0x0063862B File Offset: 0x0063682B
		public IAiAssistCharacterMoveToPointT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.AssistCharacterId = 0;
			this.MoveType = null;
			this.Timeout = 0;
		}
	}
}
