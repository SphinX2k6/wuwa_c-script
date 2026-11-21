using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EED RID: 24301
	public class LevelConditionOnCardDetailShowWithFactor : LevelConditionBase
	{
		// Token: 0x0603A8E6 RID: 239846 RVA: 0x0108CE4E File Offset: 0x0108B04E
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
