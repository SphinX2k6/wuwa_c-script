using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F1D RID: 24349
	public class LevelConditionVisionIntensifyTabOpen : LevelConditionBase
	{
		// Token: 0x0603A95C RID: 239964 RVA: 0x0108EB8E File Offset: 0x0108CD8E
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
