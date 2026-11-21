using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E2D RID: 24109
	public class LevelConditionCheckIsHasRecommendRecActivity : LevelConditionBase
	{
		// Token: 0x0603A753 RID: 239443 RVA: 0x010865ED File Offset: 0x010847ED
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return ActivityModel.Instance.IsHasShowingRecommendRecActivity();
		}
	}
}
