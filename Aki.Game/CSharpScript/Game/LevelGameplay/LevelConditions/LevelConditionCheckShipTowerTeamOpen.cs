using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CEA RID: 27882
	public class LevelConditionCheckShipTowerTeamOpen : LevelConditionBase
	{
		// Token: 0x06044670 RID: 280176 RVA: 0x010DF015 File Offset: 0x010DD215
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
