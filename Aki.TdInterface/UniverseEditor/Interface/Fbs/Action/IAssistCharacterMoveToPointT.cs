using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006198 RID: 24984
	public class IAssistCharacterMoveToPointT
	{
		// Token: 0x1700BA3E RID: 47678
		// (get) Token: 0x0602B090 RID: 176272 RVA: 0x005EF97D File Offset: 0x005EDB7D
		// (set) Token: 0x0602B091 RID: 176273 RVA: 0x005EF985 File Offset: 0x005EDB85
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700BA3F RID: 47679
		// (get) Token: 0x0602B092 RID: 176274 RVA: 0x005EF98E File Offset: 0x005EDB8E
		// (set) Token: 0x0602B093 RID: 176275 RVA: 0x005EF996 File Offset: 0x005EDB96
		public int AssistCharacterId { get; set; }

		// Token: 0x1700BA40 RID: 47680
		// (get) Token: 0x0602B094 RID: 176276 RVA: 0x005EF99F File Offset: 0x005EDB9F
		// (set) Token: 0x0602B095 RID: 176277 RVA: 0x005EF9A7 File Offset: 0x005EDBA7
		public TAssistCharacterMoveTypeUnion MoveType { get; set; }

		// Token: 0x0602B096 RID: 176278 RVA: 0x005EF9B0 File Offset: 0x005EDBB0
		public IAssistCharacterMoveToPointT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.AssistCharacterId = 0;
			this.MoveType = null;
		}
	}
}
