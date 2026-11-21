using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200077D RID: 1917
public class ActivitySubViewMapExplore : ActivitySubViewBase
{
	// Token: 0x060057D0 RID: 22480 RVA: 0x001CB050 File Offset: 0x001C9250
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUITexture)),
			new ValueTuple<int, Type>(16, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(12, new Action(this.OnBtnJump))
		};
	}

	// Token: 0x060057D1 RID: 22481 RVA: 0x001CB20A File Offset: 0x001C940A
	private void OnBtnJump()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (this.ExploreInfo == null)
			{
				return;
			}
			ExploreActivity value = this.ExploreInfo.Value;
			int recommendAreaListLength = value.RecommendAreaListLength;
			if (recommendAreaListLength == 0)
			{
				return;
			}
			ExploreAreaData jumpExploreInfo = this.GetJumpExploreInfo();
			if (jumpExploreInfo == null)
			{
				return;
			}
			int areaId = jumpExploreInfo.AreaId;
			if (!MapModel.Instance.CheckAreasUnlocked(areaId, true))
			{
				int num = -1;
				for (int i = 0; i < recommendAreaListLength; i++)
				{
					if (value.RecommendAreaList(i) == areaId)
					{
						num = i;
						break;
					}
				}
				if (num >= 0 && num < value.SourceListLength)
				{
					int num2 = value.SourceList(num);
					if (num2 != 0)
					{
						SkipTaskManager.RunByConfigId(num2, null);
						return;
					}
				}
			}
			List<ExploreAreaItemData> recommendExploreItemDataList = jumpExploreInfo.GetRecommendExploreItemDataList(false);
			ExploreAreaItemData exploreAreaItemData = null;
			if (recommendExploreItemDataList != null)
			{
				for (int j = 0; j < recommendExploreItemDataList.Count; j++)
				{
					if (!recommendExploreItemDataList[j].IsCompleted())
					{
						exploreAreaItemData = recommendExploreItemDataList[j];
						break;
					}
				}
			}
			SkipTaskManager.Run(ESkipName.SkipToExploreAreaDetailView, new object[]
			{
				areaId,
				(exploreAreaItemData != null) ? new EExploreType?(exploreAreaItemData.ExploreType) : null
			});
		});
	}

	// Token: 0x060057D2 RID: 22482 RVA: 0x001CB228 File Offset: 0x001C9428
	[NullableContext(2)]
	public ExploreAreaData GetJumpExploreInfo()
	{
		if (this.ExploreInfo == null)
		{
			return null;
		}
		ExploreActivity value = this.ExploreInfo.Value;
		int recommendAreaListLength = value.RecommendAreaListLength;
		if (recommendAreaListLength == 1)
		{
			return ExploreProgressModel.Instance.GetExploreAreaData(value.RecommendAreaList(0));
		}
		ExploreAreaData exploreAreaData = null;
		for (int i = 0; i < recommendAreaListLength; i++)
		{
			int areaId = value.RecommendAreaList(i);
			ExploreAreaData exploreAreaData2 = ExploreProgressModel.Instance.GetExploreAreaData(areaId);
			if (exploreAreaData2 != null && (exploreAreaData == null || exploreAreaData2.GetProgress() < exploreAreaData.GetProgress()))
			{
				exploreAreaData = exploreAreaData2;
			}
		}
		return exploreAreaData;
	}

	// Token: 0x060057D3 RID: 22483 RVA: 0x001CB2B0 File Offset: 0x001C94B0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewMapExplore.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMapExplore.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060057D4 RID: 22484 RVA: 0x001CB2F3 File Offset: 0x001C94F3
	[NullableContext(1)]
	private ActivitySubMapExploreItem CreateItem()
	{
		return new ActivitySubMapExploreItem
		{
			GetRewardCallBack = new Action<IActivitySubMapExploreItemData>(this.OnGetReward)
		};
	}

	// Token: 0x060057D5 RID: 22485 RVA: 0x001CB30C File Offset: 0x001C950C
	[NullableContext(1)]
	private void OnGetReward(IActivitySubMapExploreItemData data)
	{
		ActivityMapExploreController activityMapExploreController = ActivityManager.GetActivityController(this.ActivityBaseData.Type) as ActivityMapExploreController;
		if (activityMapExploreController != null)
		{
			activityMapExploreController.RequestGetReward(data.TaskId);
		}
	}

	// Token: 0x060057D6 RID: 22486 RVA: 0x001CB340 File Offset: 0x001C9540
	protected override void OnStart()
	{
		ActivityMapExploreData activityMapExploreData = this.ActivityBaseData as ActivityMapExploreData;
		if (activityMapExploreData != null && activityMapExploreData.IsFirstUnlockState(EActivityExploreFirstUnlockState.Set))
		{
			activityMapExploreData.SetFirstUnlockState(EActivityExploreFirstUnlockState.Done);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityMapExploreData.Id);
		}
	}

	// Token: 0x060057D7 RID: 22487 RVA: 0x001CB382 File Offset: 0x001C9582
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ActivityMapExploreStateUpdate, new Action(this.OnActivityMapExploreStateUpdate));
	}

	// Token: 0x060057D8 RID: 22488 RVA: 0x001CB3A0 File Offset: 0x001C95A0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ActivityMapExploreStateUpdate, new Action(this.OnActivityMapExploreStateUpdate));
	}

	// Token: 0x060057D9 RID: 22489 RVA: 0x001CB3C0 File Offset: 0x001C95C0
	protected override void OnRefreshView()
	{
		this.UpdateTaskList();
		ActivityMapExploreData activityMapExploreData = this.ActivityBaseData as ActivityMapExploreData;
		if (activityMapExploreData == null)
		{
			return;
		}
		this.ExploreInfo = ActivityMapExploreConfig.Instance.GetActivityInfo(activityMapExploreData.Id);
		if (this.ExploreInfo == null)
		{
			return;
		}
		ExploreActivity value = this.ExploreInfo.Value;
		string percentDesc = value.PercentDesc;
		string areaTitle = value.AreaTitle;
		bool flag = !string.IsNullOrEmpty(percentDesc) && !string.IsNullOrEmpty(areaTitle);
		UUIText text = base.GetText(0);
		UUIText text2 = base.GetText(1);
		UUIText text3 = base.GetText(2);
		if (flag)
		{
			int areaId = (value.RecommendAreaListLength > 0) ? value.RecommendAreaList(0) : 0;
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(percentDesc ?? "", percentDesc ?? "");
			text.SetText(multiTextByKey, true);
			ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(areaId);
			int value2 = (exploreAreaData != null) ? exploreAreaData.GetProgress() : 0;
			UUIText uuitext = text2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			LguiUtil.Instance.SetLocalTextNew(text3, areaTitle ?? "", Array.Empty<object>());
		}
		text.SetUIActive(flag);
		text2.SetUIActive(flag);
		text3.SetUIActive(flag);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.MainTitle ?? "", Array.Empty<object>());
		this.UpdateRemainTime();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.Desc ?? "", Array.Empty<object>());
		base.GetText(8).SetText(value.SumRewardNum.ToString(), true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), value.SumRewardDesc ?? "", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "Activity_Exploration_Go", Array.Empty<object>());
		this.UpdateUnlockedState();
		UUITexture texture = base.GetTexture(16);
		UUITexture texture2 = base.GetTexture(15);
		base.SetTextureShowUntilLoaded(value.Bg ?? "", texture, null);
		base.SetTextureShowUntilLoaded(value.Bg ?? "", texture2, null);
	}

	// Token: 0x060057DA RID: 22490 RVA: 0x001CB618 File Offset: 0x001C9818
	public void UpdateRemainTime()
	{
		if (this.ActivityBaseData == null)
		{
			return;
		}
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		UUIText text = base.GetText(4);
		text.SetText(item2, true);
		text.SetUIActive(item);
	}

	// Token: 0x060057DB RID: 22491 RVA: 0x001CB661 File Offset: 0x001C9861
	protected override void OnTimer(float gap)
	{
		this.UpdateRemainTime();
	}

	// Token: 0x060057DC RID: 22492 RVA: 0x001CB66C File Offset: 0x001C986C
	private void UpdateTaskList()
	{
		ActivityMapExploreData activityMapExploreData = this.ActivityBaseData as ActivityMapExploreData;
		if (activityMapExploreData == null)
		{
			return;
		}
		GenericScrollViewNew<ActivitySubMapExploreItem, IActivitySubMapExploreItemData> itemLayout = this.ItemLayout;
		if (itemLayout != null)
		{
			itemLayout.SelectGridProxy(-1, false);
		}
		GenericScrollViewNew<ActivitySubMapExploreItem, IActivitySubMapExploreItemData> itemLayout2 = this.ItemLayout;
		if (itemLayout2 == null)
		{
			return;
		}
		itemLayout2.RefreshByData(activityMapExploreData.TaskList, null, true);
	}

	// Token: 0x060057DD RID: 22493 RVA: 0x001CB6B4 File Offset: 0x001C98B4
	private void UpdateUnlockedState()
	{
		ActivityMapExploreData activityMapExploreData = this.ActivityBaseData as ActivityMapExploreData;
		if (activityMapExploreData == null || this.PanelLock == null)
		{
			return;
		}
		bool flag = activityMapExploreData.CanPreOpen();
		this.PanelLock.SetUiActive(!flag);
		base.GetButton(12).RootUIComp.Get().SetUIActive(flag);
		if (flag)
		{
			return;
		}
		this.PanelLock.SetButtonVisible(true);
		bool flag2 = activityMapExploreData.HasPreOpenCondition();
		int preOpenConditionGroupId = activityMapExploreData.PreOpenConditionGroupId;
		int num = flag2 ? preOpenConditionGroupId : activityMapExploreData.ConditionGroupId;
		if (num != 0)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(num);
			if (!string.IsNullOrEmpty(conditionGroupHintText))
			{
				this.PanelLock.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
			}
		}
	}

	// Token: 0x060057DE RID: 22494 RVA: 0x001CB75A File Offset: 0x001C995A
	private void OnActivityMapExploreStateUpdate()
	{
		this.UpdateTaskList();
	}

	// Token: 0x04003C08 RID: 15368
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySubMapExploreItem, IActivitySubMapExploreItemData> ItemLayout;

	// Token: 0x04003C09 RID: 15369
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04003C0A RID: 15370
	private ExploreActivity? ExploreInfo;

	// Token: 0x02006A6C RID: 27244
	private class EChildType
	{
		// Token: 0x04023059 RID: 143449
		public const int TxtLeftTitle = 0;

		// Token: 0x0402305A RID: 143450
		public const int TxtProgress = 1;

		// Token: 0x0402305B RID: 143451
		public const int TxtAreaName = 2;

		// Token: 0x0402305C RID: 143452
		public const int TxtMainTitle = 3;

		// Token: 0x0402305D RID: 143453
		public const int TxtRemainTime = 4;

		// Token: 0x0402305E RID: 143454
		public const int ItemDescRoot = 5;

		// Token: 0x0402305F RID: 143455
		public const int TxtDesc = 6;

		// Token: 0x04023060 RID: 143456
		public const int ItemRewardTitleRoot = 7;

		// Token: 0x04023061 RID: 143457
		public const int TxtRewardNum = 8;

		// Token: 0x04023062 RID: 143458
		public const int TxtRewardDesc = 9;

		// Token: 0x04023063 RID: 143459
		public const int ScrollBarReward = 10;

		// Token: 0x04023064 RID: 143460
		public const int ItemReward = 11;

		// Token: 0x04023065 RID: 143461
		public const int BtnJump = 12;

		// Token: 0x04023066 RID: 143462
		public const int TxtJumpDesc = 13;

		// Token: 0x04023067 RID: 143463
		public const int ItemUnlocked = 14;

		// Token: 0x04023068 RID: 143464
		public const int TextureLeftBg = 15;

		// Token: 0x04023069 RID: 143465
		public const int TextureLeftBgAni = 16;
	}
}
