using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals
{
	// Token: 0x02006525 RID: 25893
	public static class LevelGoalsProvider
	{
		// Token: 0x06040EE3 RID: 265955 RVA: 0x00FBBD70 File Offset: 0x00FB9F70
		[NullableContext(1)]
		public unsafe static IReadOnlyList<LevelGoal> GetLevelGoals(int level)
		{
			List<LevelGoal> list = new List<LevelGoal>();
			MatchThreeGameplay? gameplayConfig = MatchThreeConfig.Instance.GetGameplayConfig(level);
			if (gameplayConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "关卡目标缺失: MatchThreeGameplay";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", level);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return list;
			}
			MatchThreeGameplay value = gameplayConfig.Value;
			for (int i = 0; i < value.GoalLength; i++)
			{
				int num = value.Goal(i);
				MatchThreeGoal? goalConfig = MatchThreeConfig.Instance.GetGoalConfig(num);
				if (goalConfig == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.MatchThree;
					ELogAuthor author2 = ELogAuthor.CB;
					string message2 = "关卡目标缺失: MatchThreeGoal";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", num);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					MatchThreeGoal value2 = goalConfig.Value;
					int[] paramsArray = value2.GetParamsArray();
					EGoalCondType condType = (EGoalCondType)value2.CondType;
					switch (condType)
					{
					case EGoalCondType.Score:
						list.Add(new ReachScoreGoal(paramsArray));
						break;
					case EGoalCondType.ClearCharger:
						list.Add(new ClearTypeCountGoal(condType, EPieceType.Charger, paramsArray));
						break;
					case EGoalCondType.ClearHourglass:
						list.Add(new ClearTypeCountGoal(condType, EPieceType.Hourglass, paramsArray));
						break;
					default:
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.MatchThree;
						ELogAuthor author3 = ELogAuthor.CB;
						string message3 = "未知关卡目标类型 CondType";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CondType", value2.CondType);
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						break;
					}
					}
				}
			}
			return list;
		}
	}
}
