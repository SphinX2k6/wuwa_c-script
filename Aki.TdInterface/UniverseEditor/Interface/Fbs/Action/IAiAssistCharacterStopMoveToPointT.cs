using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E2 RID: 26594
	public class IAiAssistCharacterStopMoveToPointT
	{
		// Token: 0x1700C383 RID: 50051
		// (get) Token: 0x0602D6CB RID: 186059 RVA: 0x00638868 File Offset: 0x00636A68
		// (set) Token: 0x0602D6CC RID: 186060 RVA: 0x00638870 File Offset: 0x00636A70
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700C384 RID: 50052
		// (get) Token: 0x0602D6CD RID: 186061 RVA: 0x00638879 File Offset: 0x00636A79
		// (set) Token: 0x0602D6CE RID: 186062 RVA: 0x00638881 File Offset: 0x00636A81
		public int AssistCharacterId { get; set; }

		// Token: 0x0602D6CF RID: 186063 RVA: 0x0063888A File Offset: 0x00636A8A
		public IAiAssistCharacterStopMoveToPointT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.AssistCharacterId = 0;
		}
	}
}
