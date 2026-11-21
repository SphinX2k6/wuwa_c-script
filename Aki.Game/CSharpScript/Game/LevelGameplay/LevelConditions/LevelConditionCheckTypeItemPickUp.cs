using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E78 RID: 24184
	public class LevelConditionCheckTypeItemPickUp : LevelConditionBase
	{
		// Token: 0x0603A7F9 RID: 239609 RVA: 0x01089E8C File Offset: 0x0108808C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Type");
			if (limitParams == null)
			{
				return false;
			}
			int num = int.Parse(limitParams);
			return ItemConfig.Instance.GetConfig((int)eventArgs[0]).Value.MainTypeId == num;
		}
	}
}
