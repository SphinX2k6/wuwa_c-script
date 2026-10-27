using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D9F RID: 28063
	public class LevelConditionOnWorldMapGravityBtnShow : LevelConditionBase
	{
		// Token: 0x060447FA RID: 280570 RVA: 0x010E4971 File Offset: 0x010E2B71
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
