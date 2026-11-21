using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Giant;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E17 RID: 24087
	public class LevelConditionCheckGiantCanChangeMood : LevelConditionBase
	{
		// Token: 0x0603A726 RID: 239398 RVA: 0x01085983 File Offset: 0x01083B83
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return GiantModel.Instance.CanChangeMood();
		}
	}
}
