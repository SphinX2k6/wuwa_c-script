using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C44 RID: 27716
	public class LevelConditionAlwaysFalse : LevelConditionBase
	{
		// Token: 0x060444E2 RID: 279778 RVA: 0x010D3B08 File Offset: 0x010D1D08
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return false;
		}
	}
}
