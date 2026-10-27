using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CCF RID: 27855
	public class LevelConditionCheckPhantomMaxLevel : LevelConditionBase
	{
		// Token: 0x06044638 RID: 280120 RVA: 0x010DDA2C File Offset: 0x010DBC2C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return PhantomBattleController.Instance.CheckHasPhantomMaxLevel();
		}
	}
}
