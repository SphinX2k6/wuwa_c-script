using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;

namespace CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI
{
	// Token: 0x02005E5B RID: 24155
	public static class BattleViewDynamicUIDefine
	{
		// Token: 0x040200C5 RID: 131269
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EBattleViewDynamicUIType, BattleViewDynamicUIConfig> BattleViewDynamicUIConfigMap = new Dictionary<EBattleViewDynamicUIType, BattleViewDynamicUIConfig>
		{
			{
				EBattleViewDynamicUIType.RoverlikeBattleInfo,
				new BattleViewDynamicUIConfig
				{
					ResourceId = "UiView_RogueFightInfo",
					ChildType = EBattleViewChildType.CenterPanel,
					CreateUi = (() => new RoverlikeBattleInfoPanel())
				}
			}
		};
	}
}
