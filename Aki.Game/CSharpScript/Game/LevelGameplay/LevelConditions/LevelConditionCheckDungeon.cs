using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C72 RID: 27762
	public class LevelConditionCheckDungeon : LevelConditionBase
	{
		// Token: 0x0604456E RID: 279918 RVA: 0x010D9060 File Offset: 0x010D7260
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
