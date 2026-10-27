using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A25 RID: 18981
	internal class TrapDefenseBuildingDevelopDataDefine
	{
		// Token: 0x0401A578 RID: 107896
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ETrapDefensePlacementType, string> placementAttrIcon = new Dictionary<ETrapDefensePlacementType, string>
		{
			{
				ETrapDefensePlacementType.Ceil,
				"/Game/Aki/UI/UIResources/Common/Image/IconAttribute/T_RogueSkill_ArrowUp_UI.T_RogueSkill_ArrowUp_UI"
			},
			{
				ETrapDefensePlacementType.Wall,
				"/Game/Aki/UI/UIResources/Common/Image/IconAttribute/T_RogueSkill_ArrowFull_UI.T_RogueSkill_ArrowFull_UI"
			},
			{
				ETrapDefensePlacementType.Floor,
				"/Game/Aki/UI/UIResources/Common/Image/IconAttribute/T_RogueSkill_ArrowDown_UI.T_RogueSkill_ArrowDown_UI"
			}
		};
	}
}
