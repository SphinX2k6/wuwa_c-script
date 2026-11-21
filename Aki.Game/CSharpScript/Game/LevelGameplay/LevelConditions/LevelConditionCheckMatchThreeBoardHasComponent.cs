using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E3C RID: 24124
	public class LevelConditionCheckMatchThreeBoardHasComponent : LevelConditionBase
	{
		// Token: 0x0603A776 RID: 239478 RVA: 0x01087280 File Offset: 0x01085480
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ComponentType");
			if (limitParams == null)
			{
				return false;
			}
			MatchThreePresenter currentPresenter = MatchThreeController.Instance.CurrentPresenter;
			int componentType;
			return currentPresenter != null && (int.TryParse(limitParams, out componentType) && currentPresenter.Board.HasPieceWithComponentType((EPieceComponentType)componentType));
		}
	}
}
