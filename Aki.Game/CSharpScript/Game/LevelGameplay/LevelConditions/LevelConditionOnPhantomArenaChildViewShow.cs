using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EF1 RID: 24305
	public class LevelConditionOnPhantomArenaChildViewShow : LevelConditionBase
	{
		// Token: 0x0603A8EE RID: 239854 RVA: 0x0108CF58 File Offset: 0x0108B158
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ViewName");
			string b = (string)eventArgs[0];
			return limitParams == b;
		}
	}
}
