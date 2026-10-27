using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C80 RID: 27776
	public class LevelConditionCheckEntityConfigId : LevelConditionBase
	{
		// Token: 0x0604458E RID: 279950 RVA: 0x010D9E4C File Offset: 0x010D804C
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
