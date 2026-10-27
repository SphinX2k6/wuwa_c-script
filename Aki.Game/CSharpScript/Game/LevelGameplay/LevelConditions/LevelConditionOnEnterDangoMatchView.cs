using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D13 RID: 27923
	public class LevelConditionOnEnterDangoMatchView : LevelConditionBase
	{
		// Token: 0x060446CA RID: 280266 RVA: 0x010E0939 File Offset: 0x010DEB39
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
