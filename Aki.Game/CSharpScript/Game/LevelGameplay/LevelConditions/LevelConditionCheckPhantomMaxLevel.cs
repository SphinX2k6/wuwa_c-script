using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E49 RID: 24137
	public class LevelConditionCheckPhantomMaxLevel : LevelConditionBase
	{
		// Token: 0x0603A792 RID: 239506 RVA: 0x01087A80 File Offset: 0x01085C80
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return PhantomBattleController.Instance.CheckHasPhantomMaxLevel();
		}
	}
}
