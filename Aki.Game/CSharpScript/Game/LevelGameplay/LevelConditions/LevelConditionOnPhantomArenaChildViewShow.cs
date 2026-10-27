using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D72 RID: 28018
	public class LevelConditionOnPhantomArenaChildViewShow : LevelConditionBase
	{
		// Token: 0x0604478A RID: 280458 RVA: 0x010E2D74 File Offset: 0x010E0F74
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ViewName");
			string b = (string)eventArgs[0];
			return limitParams == b;
		}
	}
}
