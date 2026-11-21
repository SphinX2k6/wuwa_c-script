using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7D RID: 28029
	public class IExecBattleActionTypeT
	{
		// Token: 0x1700CDA3 RID: 52643
		// (get) Token: 0x060305EC RID: 198124 RVA: 0x00692B06 File Offset: 0x00690D06
		// (set) Token: 0x060305ED RID: 198125 RVA: 0x00692B0E File Offset: 0x00690D0E
		public EExecBattleActionType Type { get; set; }

		// Token: 0x060305EE RID: 198126 RVA: 0x00692B17 File Offset: 0x00690D17
		public IExecBattleActionTypeT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
		}
	}
}
