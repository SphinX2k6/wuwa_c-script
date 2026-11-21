using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E0F RID: 24079
	public class LevelConditionCheckFishingRoleTechViewOpen : LevelConditionBase
	{
		// Token: 0x0603A714 RID: 239380 RVA: 0x010854EF File Offset: 0x010836EF
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
