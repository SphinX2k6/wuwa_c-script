using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E48 RID: 24136
	public class LevelConditionCheckPhantomLevel : LevelConditionBase
	{
		// Token: 0x0603A790 RID: 239504 RVA: 0x01087A20 File Offset: 0x01085C20
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ItemId");
			string limitParams2 = inConditionInfo.GetLimitParams("Level");
			int itemId = (limitParams != null) ? int.Parse(limitParams) : 0;
			int level = (limitParams2 != null) ? int.Parse(limitParams2) : 0;
			return PhantomBattleController.Instance.CheckPhantomLevelSatisfied(itemId, level);
		}
	}
}
