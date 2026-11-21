using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F18 RID: 24344
	public class LevelConditionCheckTrapDefenseTalentUnlock : LevelConditionBase
	{
		// Token: 0x0603A952 RID: 239954 RVA: 0x0108E968 File Offset: 0x0108CB68
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData;
			return int.TryParse(inConditionInfo.GetLimitParams("TalentId"), out num) && num != 0 && TrapDefenseModel.Instance.TalentTreeData.NodeIdMap.TryGetValue(num, out trapDefenseTalentTreeNodeData) && trapDefenseTalentTreeNodeData.IsUnlock;
		}
	}
}
