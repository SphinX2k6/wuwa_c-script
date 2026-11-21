using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F15 RID: 24341
	public class LevelConditionOnTrapDefenseBuildingDevelopPreviewBtnShow : LevelConditionBase
	{
		// Token: 0x0603A94C RID: 239948 RVA: 0x0108E907 File Offset: 0x0108CB07
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
