using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C45 RID: 27717
	public class LevelConditionAlwaysTrue : LevelConditionBase
	{
		// Token: 0x060444E4 RID: 279780 RVA: 0x010D3B13 File Offset: 0x010D1D13
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
