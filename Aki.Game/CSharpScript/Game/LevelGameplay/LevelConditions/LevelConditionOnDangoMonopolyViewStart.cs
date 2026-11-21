using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E96 RID: 24214
	public class LevelConditionOnDangoMonopolyViewStart : LevelConditionBase
	{
		// Token: 0x0603A836 RID: 239670 RVA: 0x0108AC0D File Offset: 0x01088E0D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
