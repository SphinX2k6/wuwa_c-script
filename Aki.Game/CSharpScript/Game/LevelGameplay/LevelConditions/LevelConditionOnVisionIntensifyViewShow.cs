using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DC2 RID: 24002
	public class LevelConditionOnVisionIntensifyViewShow : LevelConditionBase
	{
		// Token: 0x0603A644 RID: 239172 RVA: 0x0107DBAF File Offset: 0x0107BDAF
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
