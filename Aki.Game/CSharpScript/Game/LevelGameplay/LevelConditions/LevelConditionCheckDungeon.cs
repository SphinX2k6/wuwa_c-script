using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DEC RID: 24044
	public class LevelConditionCheckDungeon : LevelConditionBase
	{
		// Token: 0x0603A6C8 RID: 239304 RVA: 0x01083004 File Offset: 0x01081204
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Id");
			if (limitParams == null)
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			return int.Parse(limitParams) == instanceId;
		}
	}
}
