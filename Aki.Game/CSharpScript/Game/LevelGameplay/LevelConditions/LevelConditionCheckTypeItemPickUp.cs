using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CFB RID: 27899
	public class LevelConditionCheckTypeItemPickUp : LevelConditionBase
	{
		// Token: 0x06044699 RID: 280217 RVA: 0x010DFD00 File Offset: 0x010DDF00
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
