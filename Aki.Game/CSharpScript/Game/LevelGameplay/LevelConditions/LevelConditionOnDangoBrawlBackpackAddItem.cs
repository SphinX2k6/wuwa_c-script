using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED3 RID: 24275
	public class LevelConditionOnDangoBrawlBackpackAddItem : LevelConditionBase
	{
		// Token: 0x0603A8B2 RID: 239794 RVA: 0x0108C754 File Offset: 0x0108A954
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
