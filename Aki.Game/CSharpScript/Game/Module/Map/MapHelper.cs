using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.RecallQuest.Model;

namespace CSharpScript.Game.Module.Map
{
	// Token: 0x02004468 RID: 17512
	[NullableContext(1)]
	[Nullable(0)]
	public static class MapHelper
	{
		// Token: 0x0602C2CC RID: 180940 RVA: 0x00C67768 File Offset: 0x00C65968
		public static bool IsRecallContextMismatched(int markId)
		{
			MapMark? mapMark;
			bool flag = MapConfig.Instance.GetConfigMark(markId) != null && mapMark.GetValueOrDefault().MarkFuncType == 1;
			return RecallQuestModel.Instance.IsInRecallInstance() != flag;
		}

		// Token: 0x0602C2CD RID: 180941 RVA: 0x00C677B0 File Offset: 0x00C659B0
		public static void CheckAndShowCrossMapTips(int markId, EMarkType markType, int? areaId, global::Vector worldPosition)
		{
			int markMapConfigId = MapModel.Instance.GetMarkMapConfigId(markId, markType);
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (MapUtil.IsDungeonDiffWorld(markMapConfigId, instanceId).GetValueOrDefault())
			{
				if (areaId != null && areaId.Value > 0)
				{
					string levelOneAreaNameLocalTextId = MapHelper.GetLevelOneAreaNameLocalTextId(areaId.Value);
					if (!string.IsNullOrEmpty(levelOneAreaNameLocalTextId))
					{
						string areaLocalName = AreaConfig.Instance.GetAreaLocalName(levelOneAreaNameLocalTextId);
						ScrollingTipsController.Instance.ShowTipsByTextId("CrossMapMainTips", new object[]
						{
							areaLocalName
						});
						return;
					}
				}
				string mapNameByInstanceId = MapUtil.GetMapNameByInstanceId(markMapConfigId, worldPosition);
				ScrollingTipsController.Instance.ShowTipsByTextId("CrossMapMainTips", new object[]
				{
					mapNameByInstanceId
				});
			}
		}

		// Token: 0x0602C2CE RID: 180942 RVA: 0x00C6785C File Offset: 0x00C65A5C
		public static string GetLevelOneAreaNameLocalTextId(int areaId)
		{
			int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(areaId);
			int areaId2 = (levelOneAreaId != 0) ? levelOneAreaId : areaId;
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId2);
			return ((areaInfo != null) ? areaInfo.GetValueOrDefault().Title : null) ?? "";
		}

		// Token: 0x0602C2CF RID: 180943 RVA: 0x00C678B0 File Offset: 0x00C65AB0
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public unsafe static ValueTuple<bool, int, int, string, string> GetDoubleRestAndMaxTimes(ConfigMarkItem markItem)
		{
			if (markItem.MarkConfig.Value.RelativeSubType == 1)
			{
				ActivityDoubleRewardController instance = ActivityDoubleRewardController.Instance;
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int index = 0;
				*span[index] = 3;
				ActivityDoubleRewardData dungeonUpActivity = instance.GetDungeonUpActivity(list, false);
				bool flag = dungeonUpActivity != null;
				int num2 = 0;
				int item = 0;
				if (dungeonUpActivity != null)
				{
					ValueTuple<string, int, int> numTxtAndParam = dungeonUpActivity.GetNumTxtAndParam();
					num2 = numTxtAndParam.Item2;
					item = numTxtAndParam.Item3;
				}
				if (flag)
				{
					return new ValueTuple<bool, int, int, string, string>(flag, num2, item, (num2 > 0) ? "Reward_doubling_time" : "Reward_doubling_end", "Double_reward_tips_02");
				}
			}
			int num3 = markItem.MarkConfig.Value.RelativeId;
			num3 = ((num3 != 0) ? num3 : InstanceDungeonEntranceConfig.Instance.GetEntranceIdByMarkId(markItem.MarkConfigId));
			if (ActivityRegressModel.Instance.DungeonHasDoubleDropTimes(num3, EDungeonType.Boss) || ActivityRegressModel.Instance.LevelPlayHasDoubleDropTimes(num3, EDungeonType.Boss))
			{
				return ActivityRegressModel.Instance.GetDetectionDoubleDropTuple(EDungeonType.Boss);
			}
			if (ActivityRegressModel.Instance.DungeonHasDoubleDropTimes(num3, EDungeonType.Weekly) || ActivityRegressModel.Instance.LevelPlayHasDoubleDropTimes(num3, EDungeonType.Weekly))
			{
				return ActivityRegressModel.Instance.GetDetectionDoubleDropTuple(EDungeonType.Weekly);
			}
			return new ValueTuple<bool, int, int, string, string>(false, 0, 0, "", "");
		}
	}
}
