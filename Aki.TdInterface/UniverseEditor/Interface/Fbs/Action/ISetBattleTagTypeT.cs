using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC4 RID: 28612
	public class ISetBattleTagTypeT
	{
		// Token: 0x1700D472 RID: 54386
		// (get) Token: 0x06032932 RID: 207154 RVA: 0x006D31BA File Offset: 0x006D13BA
		// (set) Token: 0x06032933 RID: 207155 RVA: 0x006D31C2 File Offset: 0x006D13C2
		public ESetBattleTagType Type { get; set; }

		// Token: 0x06032934 RID: 207156 RVA: 0x006D31CB File Offset: 0x006D13CB
		public ISetBattleTagTypeT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
