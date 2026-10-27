using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D43 RID: 27971
	public class LevelConditionOnKingShipFirstAttrShow : LevelConditionBase
	{
		// Token: 0x0604472C RID: 280364 RVA: 0x010E20E4 File Offset: 0x010E02E4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num = (int)eventArgs[0];
			bool flag = (bool)eventArgs[1];
			return num == 1 && flag;
		}
	}
}
