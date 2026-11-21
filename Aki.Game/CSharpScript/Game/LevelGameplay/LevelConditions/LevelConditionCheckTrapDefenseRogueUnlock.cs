using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F13 RID: 24339
	public class LevelConditionCheckTrapDefenseRogueUnlock : LevelConditionBase
	{
		// Token: 0x0603A948 RID: 239944 RVA: 0x0108E89B File Offset: 0x0108CA9B
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return TrapDefenseModel.Instance.RougeModeData.CanEnterRougeMode();
		}
	}
}
