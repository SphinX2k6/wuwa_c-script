using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D50 RID: 27984
	public class LevelConditionCheckMapRogueEventDetailShow : LevelConditionBase
	{
		// Token: 0x06044746 RID: 280390 RVA: 0x010E2481 File Offset: 0x010E0681
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs != null && eventArgs.Length != 0)
			{
				this.IsShow = Convert.ToBoolean(eventArgs[0]);
			}
			return this.IsShow;
		}

		// Token: 0x040239D7 RID: 145879
		private bool IsShow;
	}
}
