using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EC0 RID: 24256
	public class LevelConditionOnKingShipFirstAttrShow : LevelConditionBase
	{
		// Token: 0x0603A88C RID: 239756 RVA: 0x0108C270 File Offset: 0x0108A470
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num = (int)eventArgs[0];
			bool flag = (bool)eventArgs[1];
			return num == 1 && flag;
		}
	}
}
