using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCommonRootView;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED1 RID: 24273
	public class LevelConditionOnCommonChildViewShowDone : LevelConditionBase
	{
		// Token: 0x0603A8AE RID: 239790 RVA: 0x0108C71A File Offset: 0x0108A91A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length != 0 && ((ECommonChildViewName)eventArgs[0]).ToEnumString() == inConditionInfo.GetLimitParams("ChildViewName");
		}
	}
}
