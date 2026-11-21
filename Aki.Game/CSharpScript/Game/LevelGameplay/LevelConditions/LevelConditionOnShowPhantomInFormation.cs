using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE4 RID: 24292
	public class LevelConditionOnShowPhantomInFormation : LevelConditionBase
	{
		// Token: 0x0603A8D4 RID: 239828 RVA: 0x0108CC3D File Offset: 0x0108AE3D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
