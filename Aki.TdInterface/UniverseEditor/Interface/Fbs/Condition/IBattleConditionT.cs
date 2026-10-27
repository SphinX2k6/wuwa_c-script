using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004977 RID: 18807
	public class IBattleConditionT
	{
		// Token: 0x170087D7 RID: 34775
		// (get) Token: 0x0601D510 RID: 120080 RVA: 0x004227E6 File Offset: 0x004209E6
		// (set) Token: 0x0601D511 RID: 120081 RVA: 0x004227EE File Offset: 0x004209EE
		public EBattleConditionType Type { get; set; }

		// Token: 0x0601D512 RID: 120082 RVA: 0x004227F7 File Offset: 0x004209F7
		public IBattleConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
		}
	}
}
