using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E9C RID: 24220
	public class LevelConditionCheckFightPhotoLevelFinished : LevelConditionBase
	{
		// Token: 0x0603A842 RID: 239682 RVA: 0x0108AD90 File Offset: 0x01088F90
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("LevelId");
			int num;
			if (limitParams == null || !int.TryParse(limitParams, out num))
			{
				num = 0;
			}
			FightPhotoActivityData activityData = FightPhotoController.Instance.GetActivityData();
			if (activityData == null)
			{
				return false;
			}
			foreach (FightPhotoLevelGroupData fightPhotoLevelGroupData in activityData.GetLevelGroupDataList())
			{
				foreach (FightPhotoLevelData fightPhotoLevelData in fightPhotoLevelGroupData.LevelDataList)
				{
					if (fightPhotoLevelData.LevelId == num)
					{
						return fightPhotoLevelData.IsFinished;
					}
				}
			}
			return false;
		}
	}
}
