using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D1B RID: 27931
	public class LevelConditionOnDangoMonopolyCameraFocusOnMainDango : LevelConditionBase
	{
		// Token: 0x060446DA RID: 280282 RVA: 0x010E0AA1 File Offset: 0x010DECA1
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
