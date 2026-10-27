using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C95 RID: 27797
	public class LevelConditionCheckFishingRoleTechViewOpen : LevelConditionBase
	{
		// Token: 0x060445BA RID: 279994 RVA: 0x010DB543 File Offset: 0x010D9743
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
