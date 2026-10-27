using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FD RID: 26365
	public class IExecBattleActionTypeT
	{
		// Token: 0x1700C3ED RID: 50157
		// (get) Token: 0x0602DDAD RID: 187821 RVA: 0x006454E2 File Offset: 0x006436E2
		// (set) Token: 0x0602DDAE RID: 187822 RVA: 0x006454EA File Offset: 0x006436EA
		public EExecBattleActionType Type { get; set; }

		// Token: 0x0602DDAF RID: 187823 RVA: 0x006454F3 File Offset: 0x006436F3
		public IExecBattleActionTypeT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
		}
	}
}
