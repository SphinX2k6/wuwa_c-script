using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DFA RID: 24058
	public class LevelConditionCheckEntityConfigId : LevelConditionBase
	{
		// Token: 0x0603A6E8 RID: 239336 RVA: 0x01083DF0 File Offset: 0x01081FF0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0 || inTrigger == null)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ConfigId");
			if (limitParams == null)
			{
				return false;
			}
			int num = int.Parse(limitParams);
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(inTrigger, true);
			if (entityByActor == null)
			{
				return false;
			}
			CreatureDataComponent component = entityByActor.Entity.GetComponent<CreatureDataComponent>();
			return component != null && component.GetPbDataId() == num;
		}
	}
}
