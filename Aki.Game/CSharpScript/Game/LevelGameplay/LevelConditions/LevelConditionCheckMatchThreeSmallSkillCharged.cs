using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E3E RID: 24126
	public class LevelConditionCheckMatchThreeSmallSkillCharged : LevelConditionBase
	{
		// Token: 0x0603A77A RID: 239482 RVA: 0x0108733C File Offset: 0x0108553C
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
