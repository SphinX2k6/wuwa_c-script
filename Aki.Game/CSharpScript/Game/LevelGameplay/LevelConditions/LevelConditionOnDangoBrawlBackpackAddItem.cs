using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D55 RID: 27989
	public class LevelConditionOnDangoBrawlBackpackAddItem : LevelConditionBase
	{
		// Token: 0x06044750 RID: 280400 RVA: 0x010E259C File Offset: 0x010E079C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs.Length == 0)
			{
				return false;
			}
			object obj = eventArgs[0];
			return obj is EDangoBrawlModifyType && (EDangoBrawlModifyType)obj == EDangoBrawlModifyType.Add;
		}
	}
}
