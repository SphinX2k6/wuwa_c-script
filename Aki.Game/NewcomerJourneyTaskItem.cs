using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x020013AA RID: 5034
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewcomerJourneyTaskItem : GridProxyAbstract<NewcomerJourneyTaskData>
{
	// Token: 0x06008D58 RID: 36184 RVA: 0x001E6530 File Offset: 0x001E4730
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

	// Token: 0x06008D59 RID: 36185 RVA: 0x001E6704 File Offset: 0x001E4904
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

	// Token: 0x06008D5A RID: 36186 RVA: 0x001E672C File Offset: 0x001E492C
	private void OnClickGetButton()
	{
		if (this.Data == null || this.ActivityData == null)
		{
			return;
		}
		if (this.Data.TaskData.Status == ConditionTaskState.ConditionTaskFinish)
		{
			List<int> list = (from task in this.ActivityData.GetChapterTaskList(this.Data.ChapterId)
			where task.TaskData.Status == ConditionTaskState.ConditionTaskFinish
			select task.TaskData.Id).ToList<int>();
			if (list.Count > 0)
			{
				ActivityNewcomerJourneyController.Instance.GetTaskReward(this.ActivityData.Id, list);
			}
		}
	}

	// Token: 0x06008D5B RID: 36187 RVA: 0x001E67E5 File Offset: 0x001E49E5
	public void SetActivityData(ActivityNewcomerJourneyData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x06008D5C RID: 36188 RVA: 0x001E67EE File Offset: 0x001E49EE
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
	}

	// Token: 0x06008D5D RID: 36189 RVA: 0x001E6811 File Offset: 0x001E4A11
	private ActivitySmallItemGrid InitGridItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x06008D5E RID: 36190 RVA: 0x001E6818 File Offset: 0x001E4A18
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

	// Token: 0x06008D5F RID: 36191 RVA: 0x001E6954 File Offset: 0x001E4B54
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

	// Token: 0x06008D60 RID: 36192 RVA: 0x001E69D4 File Offset: 0x001E4BD4
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

	// Token: 0x06008D61 RID: 36193 RVA: 0x001E6BE8 File Offset: 0x001E4DE8
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

	// Token: 0x06008D62 RID: 36194 RVA: 0x001E6C58 File Offset: 0x001E4E58
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

	// Token: 0x06008D63 RID: 36195 RVA: 0x001E6D20 File Offset: 0x001E4F20
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

	// Token: 0x06008D64 RID: 36196 RVA: 0x001E6DA4 File Offset: 0x001E4FA4
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
				MapUtil.GetConfigPosition(mapMark.EntityConfigId, vector, mapMark.RelativeDungeonId);
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

	// Token: 0x06008D65 RID: 36197 RVA: 0x001E6E80 File Offset: 0x001E5080
	private void ProcessDisposableChallengeTabOpen(int jumpParam)
	{
		if (AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow((EDungeonType)jumpParam))
		{
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DisposableChallengeView), new int?(jumpParam), null);
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

	// Token: 0x06008D66 RID: 36198 RVA: 0x001E6F70 File Offset: 0x001E5170
	private string GetTaskBgTexturePathByType(int type)
	{
		string resourceId = (type == 2) ? "T_TaskBgB" : "T_TaskBg";
		return UiResourceConfig.Instance.GetResourcePath(resourceId) ?? "";
	}

	// Token: 0x06008D67 RID: 36199 RVA: 0x001E6FA4 File Offset: 0x001E51A4
	private void RefreshTaskBgTexture(string path)
	{
		UUITexture texture = base.GetTexture(8);
		if (texture == null)
		{
			return;
		}
		base.SetTextureByPath(path, texture, null, null);
	}

	// Token: 0x04003EC2 RID: 16066
	private const string NEWCOMER_JOURNEY_TASK_BG = "T_TaskBg";

	// Token: 0x04003EC3 RID: 16067
	private const string NEWCOMER_JOURNEY_TASK_BG_B = "T_TaskBgB";

	// Token: 0x04003EC4 RID: 16068
	[Nullable(2)]
	private NewcomerJourneyTaskData Data;

	// Token: 0x04003EC5 RID: 16069
	[Nullable(2)]
	private ActivityNewcomerJourneyData ActivityData;

	// Token: 0x04003EC6 RID: 16070
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x04003EC7 RID: 16071
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

	// Token: 0x02007A1A RID: 31258
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028307 RID: 164615
		public const int Button = 0;

		// Token: 0x04028308 RID: 164616
		public const int RedDotItem = 1;

		// Token: 0x04028309 RID: 164617
		public const int TaskNameText = 2;

		// Token: 0x0402830A RID: 164618
		public const int GoBtn = 3;

		// Token: 0x0402830B RID: 164619
		public const int GetBtn = 4;

		// Token: 0x0402830C RID: 164620
		public const int FinishItem = 5;

		// Token: 0x0402830D RID: 164621
		public const int RewardLayout = 6;

		// Token: 0x0402830E RID: 164622
		public const int RewardItem = 7;

		// Token: 0x0402830F RID: 164623
		public const int TaskBg = 8;

		// Token: 0x04028310 RID: 164624
		public const int SpecialTag = 9;

		// Token: 0x04028311 RID: 164625
		public const int TagText = 10;
	}
}
