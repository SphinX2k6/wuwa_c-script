using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006815 RID: 26645
	public class IAssistCharacterStopMoveToPointT
	{
		// Token: 0x1700C3D8 RID: 50136
		// (get) Token: 0x0602D83F RID: 186431 RVA: 0x0063AE24 File Offset: 0x00639024
		// (set) Token: 0x0602D840 RID: 186432 RVA: 0x0063AE2C File Offset: 0x0063902C
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700C3D9 RID: 50137
		// (get) Token: 0x0602D841 RID: 186433 RVA: 0x0063AE35 File Offset: 0x00639035
		// (set) Token: 0x0602D842 RID: 186434 RVA: 0x0063AE3D File Offset: 0x0063903D
		public int AssistCharacterId { get; set; }

		// Token: 0x0602D843 RID: 186435 RVA: 0x0063AE46 File Offset: 0x00639046
		public IAssistCharacterStopMoveToPointT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.AssistCharacterId = 0;
		}
	}
}
