using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CB3 RID: 27827
	public class LevelConditionCheckIsHasRecommendRecActivity : LevelConditionBase
	{
		// Token: 0x060445F9 RID: 280057 RVA: 0x010DC641 File Offset: 0x010DA841
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return ActivityModel.Instance.IsHasShowingRecommendRecActivity();
		}
	}
}
