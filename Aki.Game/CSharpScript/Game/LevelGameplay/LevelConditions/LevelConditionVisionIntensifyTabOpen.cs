using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D9E RID: 28062
	public class LevelConditionVisionIntensifyTabOpen : LevelConditionBase
	{
		// Token: 0x060447F8 RID: 280568 RVA: 0x010E4966 File Offset: 0x010E2B66
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
