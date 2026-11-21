using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200093F RID: 2367
[NullableContext(1)]
[Nullable(0)]
public static class ActivityRegressHelper
{
	// Token: 0x0600688B RID: 26763 RVA: 0x0020AED4 File Offset: 0x002090D4
	[NullableContext(0)]
	public static void RefreshItemGrid([Nullable(1)] SmallItemGrid itemGrid, ItemInfo itemInfo, int itemCount, [TupleElementNames(new string[]
	{
		"lockVisible",
		"receivableVisible",
		"receivedVisible"
	})] ValueTuple<bool, bool, bool> state)
	{
		int id = itemInfo.Id;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(id));
		bool item = state.Item1;
		bool item2 = state.Item2;
		bool item3 = state.Item3;
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo value = RoleConfig.Instance.GetRoleConfig(id).Value;
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = itemInfo,
				ElementId = new int?(value.ElementId),
				ItemConfigId = new int?(id),
				BottomText = itemCount.ToString(),
				QualityId = new int?(value.QualityId),
				IsLockVisible = new bool?(item),
				IsReceivableVisible = new bool?(item2),
				IsReceivedVisible = new bool?(item3),
				IsRedDotVisible = new bool?(item2)
			};
			itemGrid.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.PhantomItem)
		{
			PropSmallItemGrid parameters2 = new PropSmallItemGrid
			{
				Data = itemInfo,
				ItemConfigId = new int?(id),
				BottomText = itemCount.ToString(),
				IsLockVisible = new bool?(item),
				IsReceivableVisible = new bool?(item2),
				IsReceivedVisible = new bool?(item3),
				IsRedDotVisible = new bool?(item2)
			};
			itemGrid.Apply<PropSmallItemGrid>(parameters2);
			return;
		}
		PhantomSmallItemGrid parameters3 = new PhantomSmallItemGrid
		{
			Data = itemInfo,
			ItemConfigId = new int?(id),
			BottomText = itemCount.ToString(),
			IsLockVisible = new bool?(item),
			IsReceivableVisible = new bool?(item2),
			IsReceivedVisible = new bool?(item3),
			IsRedDotVisible = new bool?(item2)
		};
		itemGrid.Apply<PhantomSmallItemGrid>(parameters3);
	}

	// Token: 0x0600688C RID: 26764 RVA: 0x0020B08C File Offset: 0x0020928C
	public static void RefreshItemGridByData(SmallItemGrid itemGrid, IRegressRewardItemInfo data)
	{
		ItemInfo? itemInfo = data.ItemInfo;
		int itemCount = data.ItemCount;
		bool item = data.RewardState == ERegressRewardState.UnReach;
		bool item2 = data.RewardState == ERegressRewardState.Reached;
		bool item3 = data.RewardState == ERegressRewardState.Claim;
		ActivityRegressHelper.RefreshItemGrid(itemGrid, itemInfo.Value, itemCount, new ValueTuple<bool, bool, bool>(item, item2, item3));
	}

	// Token: 0x0600688D RID: 26765 RVA: 0x0020B0E2 File Offset: 0x002092E2
	public static void ReportRecallLog1023(EReportLogEventType eventType)
	{
		ActivityRegressHelper.ReportLog("1023", eventType, 0);
	}

	// Token: 0x0600688E RID: 26766 RVA: 0x0020B0F0 File Offset: 0x002092F0
	public static void ReportRecallLog1024(EReportLogEventType eventType, int questId = 0)
	{
		ActivityRegressHelper.ReportLog("1024", eventType, questId);
	}

	// Token: 0x0600688F RID: 26767 RVA: 0x0020B100 File Offset: 0x00209300
	private static void ReportLog(string eventId, EReportLogEventType eventType, int questId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		ActivityRecallLogData logData = new ActivityRecallLogData
		{
			event_id = eventId,
			i_activity_id = activityData.Id,
			i_activity_type = (int)activityData.Type,
			i_time_left = (int)activityData.GetActivityOpenTimeLeft(),
			i_type = (int)eventType,
			i_quest_id = questId,
			i_grade_id = (int)ActivityRegressModel.Instance.Grade
		};
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x06006890 RID: 26768 RVA: 0x0020B173 File Offset: 0x00209373
	public static void ReportRecallLog1023New(EReportLogEventNewType eventType)
	{
		ActivityRegressHelper.ReportLogNew("1023", eventType, 0, 0);
	}

	// Token: 0x06006891 RID: 26769 RVA: 0x0020B182 File Offset: 0x00209382
	public static void ReportRecallLog1024New(EReportLogEventNewType eventType, int questId = 0, int doubleDropType = 0)
	{
		ActivityRegressHelper.ReportLogNew("1024", eventType, questId, doubleDropType);
	}

	// Token: 0x06006892 RID: 26770 RVA: 0x0020B194 File Offset: 0x00209394
	private static void ReportLogNew(string eventId, EReportLogEventNewType eventType, int questId = 0, int doubleDropType = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		ActivityRecallLogData logData = new ActivityRecallLogData
		{
			event_id = eventId,
			i_activity_id = activityData.Id,
			i_activity_type = (int)activityData.Type,
			i_time_left = (int)activityData.GetActivityOpenTimeLeft(),
			i_type = (int)eventType,
			i_quest_id = questId,
			i_grade_id = (int)ActivityRegressModel.Instance.Grade,
			i_id = doubleDropType
		};
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x06006893 RID: 26771 RVA: 0x0020B20E File Offset: 0x0020940E
	public static void ReportRegressLog1060()
	{
		ActivityRegressHelper.ReportRegressLog("1060", 0);
	}

	// Token: 0x06006894 RID: 26772 RVA: 0x0020B21B File Offset: 0x0020941B
	public static void ReportRegressLog1061(int questionnaireId)
	{
		ActivityRegressHelper.ReportRegressLog("1061", questionnaireId);
	}

	// Token: 0x06006895 RID: 26773 RVA: 0x0020B228 File Offset: 0x00209428
	private static void ReportRegressLog(string eventId, int questionnaireId = 0)
	{
		ActivityRegressLogData logData = new ActivityRegressLogData
		{
			event_id = eventId,
			i_activity_id = ActivityRegressModel.Instance.ActivityId,
			i_grade_id = (int)ActivityRegressModel.Instance.Grade,
			i_question_id = questionnaireId
		};
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x06006896 RID: 26774 RVA: 0x0020B274 File Offset: 0x00209474
	public static Area? GetMinExploreAreaInfo()
	{
		Dictionary<int, bool> allUnlockedAreas = MapModel.Instance.GetAllUnlockedAreas();
		if (allUnlockedAreas == null || allUnlockedAreas.Count <= 0)
		{
			return null;
		}
		List<ExploreAreaData> list = new List<ExploreAreaData>();
		foreach (KeyValuePair<int, bool> keyValuePair in allUnlockedAreas)
		{
			int key = keyValuePair.Key;
			ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(key);
			if (exploreAreaData != null)
			{
				list.Add(exploreAreaData);
			}
		}
		list.Sort((ExploreAreaData openAreaDataA, ExploreAreaData openAreaDataB) => openAreaDataA.GetProgress().CompareTo(openAreaDataB.GetProgress()));
		if (list.Count <= 0)
		{
			return null;
		}
		Area? result = null;
		foreach (ExploreAreaData exploreAreaData2 in list)
		{
			int areaId = exploreAreaData2.AreaId;
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
			if (areaInfo != null && areaInfo.Value.DeliveryMarkId != 0)
			{
				int deliveryMarkId = areaInfo.Value.DeliveryMarkId;
				MapMark value = MapConfig.Instance.GetConfigMark(deliveryMarkId).Value;
				if (MapModel.Instance.CheckFogUnlocked(value.FogHide, null))
				{
					result = areaInfo;
					break;
				}
			}
		}
		return result;
	}
}
