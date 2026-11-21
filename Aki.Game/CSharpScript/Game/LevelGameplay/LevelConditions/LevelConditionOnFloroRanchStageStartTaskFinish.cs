using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA4 RID: 24228
	public class LevelConditionOnFloroRanchStageStartTaskFinish : LevelConditionBase
	{
		// Token: 0x0603A852 RID: 239698 RVA: 0x0108AFA6 File Offset: 0x010891A6
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
