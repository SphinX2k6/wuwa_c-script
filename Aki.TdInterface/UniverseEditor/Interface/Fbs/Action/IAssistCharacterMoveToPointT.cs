using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006803 RID: 26627
	public class IAssistCharacterMoveToPointT
	{
		// Token: 0x1700C3BC RID: 50108
		// (get) Token: 0x0602D7C1 RID: 186305 RVA: 0x0063A1F1 File Offset: 0x006383F1
		// (set) Token: 0x0602D7C2 RID: 186306 RVA: 0x0063A1F9 File Offset: 0x006383F9
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700C3BD RID: 50109
		// (get) Token: 0x0602D7C3 RID: 186307 RVA: 0x0063A202 File Offset: 0x00638402
		// (set) Token: 0x0602D7C4 RID: 186308 RVA: 0x0063A20A File Offset: 0x0063840A
		public int AssistCharacterId { get; set; }

		// Token: 0x1700C3BE RID: 50110
		// (get) Token: 0x0602D7C5 RID: 186309 RVA: 0x0063A213 File Offset: 0x00638413
		// (set) Token: 0x0602D7C6 RID: 186310 RVA: 0x0063A21B File Offset: 0x0063841B
		public TAssistCharacterMoveTypeUnion MoveType { get; set; }

		// Token: 0x0602D7C7 RID: 186311 RVA: 0x0063A224 File Offset: 0x00638424
		public IAssistCharacterMoveToPointT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.AssistCharacterId = 0;
			this.MoveType = null;
		}
	}
}
