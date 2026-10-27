using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A7 RID: 24999
	public class IAssistCharacterStopMoveToPointT
	{
		// Token: 0x1700BA55 RID: 47701
		// (get) Token: 0x0602B0F8 RID: 176376 RVA: 0x005F03B0 File Offset: 0x005EE5B0
		// (set) Token: 0x0602B0F9 RID: 176377 RVA: 0x005F03B8 File Offset: 0x005EE5B8
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700BA56 RID: 47702
		// (get) Token: 0x0602B0FA RID: 176378 RVA: 0x005F03C1 File Offset: 0x005EE5C1
		// (set) Token: 0x0602B0FB RID: 176379 RVA: 0x005F03C9 File Offset: 0x005EE5C9
		public int AssistCharacterId { get; set; }

		// Token: 0x0602B0FC RID: 176380 RVA: 0x005F03D2 File Offset: 0x005EE5D2
		public IAssistCharacterStopMoveToPointT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.AssistCharacterId = 0;
		}
	}
}
