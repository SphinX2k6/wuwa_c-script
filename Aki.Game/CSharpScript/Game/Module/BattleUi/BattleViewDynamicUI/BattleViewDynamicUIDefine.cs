using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;

namespace CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI
{
	// Token: 0x02004E40 RID: 20032
	public static class BattleViewDynamicUIDefine
	{
		// Token: 0x0401AB8C RID: 109452
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
