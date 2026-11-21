using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200085E RID: 2142
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewcomerJourneyTaskItem : GridProxyAbstract<NewcomerJourneyTaskData>
{
	// Token: 0x060060EE RID: 24814 RVA: 0x001EF164 File Offset: 0x001ED364
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickGoButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickGetButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060060EF RID: 24815 RVA: 0x001EF338 File Offset: 0x001ED538
	private void OnClickGoButton()
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.TaskData.Status == ConditionTaskState.ConditionTaskRunning)
		{
			this.HandleJump();
		}
	}

	// Token: 0x060060F0 RID: 24816 RVA: 0x001EF360 File Offset: 0x001ED560
	private void OnClickGetButton()
	{
		if (this.Data == null || this.ActivityData == null)
		{
			return;
		}
		if (this.Data.TaskData.Status == ConditionTaskState.ConditionTaskFinish)
		{
			List<NewcomerJourneyTaskData> chapterTaskList = this.ActivityData.GetChapterTaskList(this.Data.ChapterId);
			List<int> list = new List<int>();
			foreach (NewcomerJourneyTaskData newcomerJourneyTaskData in chapterTaskList)
			{
				if (newcomerJourneyTaskData.TaskData.Status == ConditionTaskState.ConditionTaskFinish)
				{
					list.Add(newcomerJourneyTaskData.TaskData.Id);
				}
			}
			if (list.Count > 0)
			{
				ActivityNewcomerJourneyController.Instance.GetTaskReward(this.ActivityData.Id, list);
			}
		}
	}

	// Token: 0x060060F1 RID: 24817 RVA: 0x001EF42C File Offset: 0x001ED62C
	public void SetActivityData(ActivityNewcomerJourneyData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x060060F2 RID: 24818 RVA: 0x001EF435 File Offset: 0x001ED635
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
	}

	// Token: 0x060060F3 RID: 24819 RVA: 0x001EF458 File Offset: 0x001ED658
	private ActivitySmallItemGrid InitGridItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x060060F4 RID: 24820 RVA: 0x001EF460 File Offset: 0x001ED660
	public override void Refresh(NewcomerJourneyTaskData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		AdventureTaskV2 value = this.Data.Config.Value;
		ConditionTaskState status = this.Data.TaskData.Status;
		bool uiactive = status == ConditionTaskState.ConditionTaskRunning;
		bool uiactive2 = status == ConditionTaskState.ConditionTaskFinish;
		bool flag = status == ConditionTaskState.ConditionTaskTaken;
		ConditionTask taskData = this.Data.TaskData;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.TaskText, new <>z__ReadOnlyArray<object>(new object[]
		{
			(taskData != null) ? new int?(taskData.Current) : null,
			(taskData != null) ? new int?(taskData.Target) : null
		}));
		this.RefreshReward(value.DropId, flag);
		base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive2);
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(9).SetUIActive(value.TaskType == 2);
		string taskBgTexturePathByType = this.GetTaskBgTexturePathByType(value.TaskType);
		this.RefreshTaskBgTexture(taskBgTexturePathByType);
	}

	// Token: 0x060060F5 RID: 24821 RVA: 0x001EF59C File Offset: 0x001ED79C
	private void RefreshReward(int dropId, bool hasClaimed)
	{
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		List<IItemGridData> list = new List<IItemGridData>();
		foreach (TItem item in dropPackagePreviewItemList)
		{
			ItemGridData item2 = new ItemGridData
			{
				Item = item,
				HasClaimed = hasClaimed
			};
			list.Add(item2);
		}
		this.RewardScrollView.RefreshByData(list, null, false);
	}

	// Token: 0x060060F6 RID: 24822 RVA: 0x001EF61C File Offset: 0x001ED81C
	private void HandleJump()
	{
		NewcomerJourneyTaskData data = this.Data;
		if (data == null || data.Config == null || this.Data.Config.Value.JumpToLength <= 0)
		{
			return;
		}
		int? num = null;
		string text = null;
		int jumpToLength = this.Data.Config.Value.JumpToLength;
		for (int i = 0; i < jumpToLength; i++)
		{
			DicIntString? dicIntString = this.Data.Config.Value.JumpTo(i);
			if (dicIntString != null)
			{
				num = new int?(dicIntString.Value.Key);
				text = dicIntString.Value.Value;
			}
		}
		if (num == null || string.IsNullOrEmpty(text))
		{
			return;
		}
		switch (num.Value)
		{
		case 1:
			UiManager.Instance.OpenView(EUiViewName.QuestView, int.Parse(text), null);
			return;
		case 2:
			this.JumpToMapByMarkId(int.Parse(text));
			return;
		case 3:
			if (text == EUiViewName.RoleRootView)
			{
				RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, null, null, null);
				return;
			}
			UiManager.Instance.OpenView((EUiViewName)text, null, null);
			return;
		case 4:
		{
			EUiTabViewName value = new EUiTabViewName(text);
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, new List<int>(), new EUiTabViewName?(value), null);
			return;
		}
		case 5:
		{
			CalabashRootViewData param = new CalabashRootViewData
			{
				TabViewName = new EUiTabViewName(text),
				Param = null
			};
			UiManager.Instance.OpenView(EUiViewName.CalabashRootView, param, null);
			return;
		}
		case 6:
		case 7:
		case 8:
			break;
		case 9:
			this.ProcessDisposableChallengeTabOpen(int.Parse(text));
			return;
		case 10:
			this.JumpToExploreAreaDetailView(int.Parse(text));
			return;
		case 11:
			this.JumpToMissionByType(int.Parse(text));
			return;
		case 12:
			this.JumpToNearestLockedTeleport((EMarkType)int.Parse(text));
			return;
		case 13:
			SkipTaskManager.RunByConfigId(int.Parse(text), null);
			break;
		default:
			return;
		}
	}

	// Token: 0x060060F7 RID: 24823 RVA: 0x001EF830 File Offset: 0x001EDA30
	private void JumpToExploreAreaDetailView(int exploreType)
	{
		int worldMapLevelOneAreaId = MapUtil.GetWorldMapLevelOneAreaId();
		ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(worldMapLevelOneAreaId);
		if (exploreAreaData == null)
		{
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, false, null, null);
			return;
		}
		int num = exploreType;
		ExploreAreaItemData exploreAreaItemData = exploreAreaData.GetExploreAreaItemData((EExploreType)exploreType);
		if (exploreAreaItemData == null || !exploreAreaItemData.IsUnlocked() || exploreAreaItemData.IsCompleted())
		{
			num = 1;
		}
		SkipTaskManager.Run(ESkipName.SkipToExploreAreaDetailView, new object[]
		{
			worldMapLevelOneAreaId,
			num
		});
	}

	// Token: 0x060060F8 RID: 24824 RVA: 0x001EF8A0 File Offset: 0x001EDAA0
	private void JumpToMissionByType(int questType)
	{
		foreach (QuestType questType2 in QuestNewConfig.Instance.GetQuesTypesByMainType(questType))
		{
			List<global::Quest> questsByType = QuestNewModel.Instance.GetQuestsByType(questType2.Id);
			if (questsByType.Count > 0)
			{
				questsByType.Sort(new Comparison<global::Quest>(QuestNewModel.Instance.SortQuestInView));
				UiManager.Instance.OpenView(EUiViewName.QuestView, questsByType[0].Id, null);
				return;
			}
		}
		if (this.NoQuestDescMap.ContainsKey(questType))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId(this.NoQuestDescMap[questType], Array.Empty<object>());
		}
	}

	// Token: 0x060060F9 RID: 24825 RVA: 0x001EF968 File Offset: 0x001EDB68
	private void JumpToMapByMarkId(int markId)
	{
		MapConfig instance = MapConfig.Instance;
		MapMark? mapMark = (instance != null) ? instance.GetConfigMark(markId) : null;
		if (mapMark == null)
		{
			return;
		}
		WorldMapViewOpenParams data = new WorldMapViewOpenParams
		{
			MarkType = (EMarkType)mapMark.Value.ObjectType,
			MarkId = new int?(mapMark.Value.MarkId),
			OpenFogId = new int?(0)
		};
		WorldMapController.Instance.OpenView(EOpenMapType.Mouse, false, data, null);
	}

	// Token: 0x060060FA RID: 24826 RVA: 0x001EF9EC File Offset: 0x001EDBEC
	private void JumpToNearestLockedTeleport(EMarkType markType)
	{
		if (markType != EMarkType.BigTeleport && markType != EMarkType.SmallTeleport)
		{
			return;
		}
		global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
		if (playerLocation == null)
		{
			return;
		}
		Dictionary<int, MapMark> configMarkMap = MapConfig.Instance.GetConfigMarkMap();
		double num = double.MaxValue;
		int num2 = -1;
		foreach (MapMark mapMark in configMarkMap.Values)
		{
			if (mapMark.ObjectType == (int)markType && MapModel.Instance.IsTeleportLocked(mapMark.MarkId))
			{
				global::Vector vector = global::Vector.Create();
				MapUtil.GetConfigPosition(mapMark.EntityConfigId, vector, mapMark.RelativeDungeonId, true);
				double num3 = global::Vector.DistSquared(playerLocation, vector);
				if (num > num3)
				{
					num = num3;
					num2 = mapMark.MarkId;
				}
			}
		}
		if (num2 == -1)
		{
			return;
		}
		this.JumpToMapByMarkId(num2);
	}

	// Token: 0x060060FB RID: 24827 RVA: 0x001EFAC8 File Offset: 0x001EDCC8
	private void ProcessDisposableChallengeTabOpen(int jumpParam)
	{
		if (AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow((EDungeonType)jumpParam))
		{
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DisposableChallengeView), new int?(jumpParam), null, null);
			return;
		}
		SecondaryGuideData? secondaryGuideData;
		int num = (AdventureGuideConfig.Instance.GetSecondaryGuideDataConf(jumpParam) != null) ? secondaryGuideData.GetValueOrDefault().ConditionGroupId : 0;
		if (num <= 0)
		{
			GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
			return;
		}
		ConditionGroup? config = ConfigConditionGroupById.GetConfig(num, true);
		string text = (config != null) ? config.GetValueOrDefault().HintText : null;
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = ConfigMultiTextLang.GetLocalTextNew(text, null) ?? "";
			GenericPromptController.Instance.ShowPromptByCode("UnlockCondition", new object[]
			{
				text2
			});
			return;
		}
		GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
	}

	// Token: 0x060060FC RID: 24828 RVA: 0x001EFBC0 File Offset: 0x001EDDC0
	private string GetTaskBgTexturePathByType(int type)
	{
		string resourceId = (type == 2) ? "T_TaskBgB" : "T_TaskBg";
		return UiResourceConfig.Instance.GetResourcePath(resourceId) ?? "";
	}

	// Token: 0x060060FD RID: 24829 RVA: 0x001EFBF4 File Offset: 0x001EDDF4
	private void RefreshTaskBgTexture(string path)
	{
		UUITexture texture = base.GetTexture(8);
		if (texture == null)
		{
			return;
		}
		base.SetTextureByPath(path, texture, null, null);
	}

	// Token: 0x04003F5A RID: 16218
	private const string NEWCOMER_JOURNEY_TASK_BG = "T_TaskBg";

	// Token: 0x04003F5B RID: 16219
	private const string NEWCOMER_JOURNEY_TASK_BG_B = "T_TaskBgB";

	// Token: 0x04003F5C RID: 16220
	[Nullable(2)]
	private NewcomerJourneyTaskData Data;

	// Token: 0x04003F5D RID: 16221
	[Nullable(2)]
	private ActivityNewcomerJourneyData ActivityData;

	// Token: 0x04003F5E RID: 16222
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x04003F5F RID: 16223
	private readonly Dictionary<int, string> NoQuestDescMap = new Dictionary<int, string>
	{
		{
			1,
			"NewPlayer_Adventure_009"
		},
		{
			9,
			"NewPlayer_Adventure_010"
		},
		{
			3,
			"NewPlayer_Adventure_011"
		}
	};

	// Token: 0x02006BA1 RID: 27553
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023627 RID: 144935
		public const int Button = 0;

		// Token: 0x04023628 RID: 144936
		public const int RedDotItem = 1;

		// Token: 0x04023629 RID: 144937
		public const int TaskNameText = 2;

		// Token: 0x0402362A RID: 144938
		public const int GoBtn = 3;

		// Token: 0x0402362B RID: 144939
		public const int GetBtn = 4;

		// Token: 0x0402362C RID: 144940
		public const int FinishItem = 5;

		// Token: 0x0402362D RID: 144941
		public const int RewardLayout = 6;

		// Token: 0x0402362E RID: 144942
		public const int RewardItem = 7;

		// Token: 0x0402362F RID: 144943
		public const int TaskBg = 8;

		// Token: 0x04023630 RID: 144944
		public const int SpecialTag = 9;

		// Token: 0x04023631 RID: 144945
		public const int TagText = 10;
	}
}
