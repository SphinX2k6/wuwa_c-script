using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D94 RID: 28052
	public class LevelConditionCheckTrapDefenseRogueUnlock : LevelConditionBase
	{
		// Token: 0x060447E4 RID: 280548 RVA: 0x010E4673 File Offset: 0x010E2873
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return TrapDefenseModel.Instance.RougeModeData.CanEnterRougeMode();
		}
	}
}
