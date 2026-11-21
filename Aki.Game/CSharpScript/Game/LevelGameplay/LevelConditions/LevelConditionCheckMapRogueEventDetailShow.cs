using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ECD RID: 24269
	public class LevelConditionCheckMapRogueEventDetailShow : LevelConditionBase
	{
		// Token: 0x0603A8A6 RID: 239782 RVA: 0x0108C60D File Offset: 0x0108A80D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs != null && eventArgs.Length != 0)
			{
				this.IsShow = Convert.ToBoolean(eventArgs[0]);
			}
			return this.IsShow;
		}

		// Token: 0x0401EC79 RID: 126073
		private bool IsShow;
	}
}
