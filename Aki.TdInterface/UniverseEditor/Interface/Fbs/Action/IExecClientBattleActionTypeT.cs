using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006709 RID: 26377
	public class IExecClientBattleActionTypeT
	{
		// Token: 0x1700C3F8 RID: 50168
		// (get) Token: 0x0602DE0B RID: 187915 RVA: 0x006461A2 File Offset: 0x006443A2
		// (set) Token: 0x0602DE0C RID: 187916 RVA: 0x006461AA File Offset: 0x006443AA
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x0602DE0D RID: 187917 RVA: 0x006461B3 File Offset: 0x006443B3
		public IExecClientBattleActionTypeT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
		}
	}
}
