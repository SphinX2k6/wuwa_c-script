using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E82 RID: 24194
	public class LevelConditionOnCiacconaChapterFirstStart : LevelConditionBase
	{
		// Token: 0x0603A80D RID: 239629 RVA: 0x0108A1B6 File Offset: 0x010883B6
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
