using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D99 RID: 28057
	public class LevelConditionCheckTrapDefenseTalentUnlock : LevelConditionBase
	{
		// Token: 0x060447EE RID: 280558 RVA: 0x010E4740 File Offset: 0x010E2940
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData;
			return int.TryParse(inConditionInfo.GetLimitParams("TalentId"), out num) && num != 0 && TrapDefenseModel.Instance.TalentTreeData.NodeIdMap.TryGetValue(num, out trapDefenseTalentTreeNodeData) && trapDefenseTalentTreeNodeData.IsUnlock;
		}
	}
}
