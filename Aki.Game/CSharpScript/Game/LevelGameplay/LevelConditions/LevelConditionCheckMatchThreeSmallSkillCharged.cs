using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CC4 RID: 27844
	public class LevelConditionCheckMatchThreeSmallSkillCharged : LevelConditionBase
	{
		// Token: 0x06044620 RID: 280096 RVA: 0x010DD2E8 File Offset: 0x010DB4E8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			MatchThreePresenter currentPresenter = MatchThreeController.Instance.CurrentPresenter;
			if (currentPresenter == null)
			{
				return false;
			}
			IReadOnlyList<SkillPointDisplayData> readOnlyList = currentPresenter.CollectSkillPoints();
			return readOnlyList.Count != 0 && readOnlyList[0].Charged;
		}
	}
}
