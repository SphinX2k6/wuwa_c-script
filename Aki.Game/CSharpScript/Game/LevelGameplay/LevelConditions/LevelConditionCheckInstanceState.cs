using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CAE RID: 27822
	public class LevelConditionCheckInstanceState : LevelConditionBase
	{
		// Token: 0x060445ED RID: 280045 RVA: 0x010DC398 File Offset: 0x010DA598
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("InstanceId");
			if (limitParams == null)
			{
				return false;
			}
			int instanceId = int.Parse(limitParams);
			string limitParams2 = inConditionInfo.GetLimitParams("State");
			int num = (limitParams2 != null) ? int.Parse(limitParams2) : 0;
			if (num != 1)
			{
				return num == 2 && !InstanceDungeonEntranceModel.Instance.CheckInstanceFinished(instanceId);
			}
			return InstanceDungeonEntranceModel.Instance.CheckInstanceFinished(instanceId);
		}
	}
}
