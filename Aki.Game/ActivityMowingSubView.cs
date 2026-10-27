using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001394 RID: 5012
public class ActivityMowingSubView : ActivitySubViewBase
{
	// Token: 0x06008C78 RID: 35960 RVA: 0x001E1CE0 File Offset: 0x001DFEE0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickBtnReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008C79 RID: 35961 RVA: 0x001E1F60 File Offset: 0x001E0160
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityMowingSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMowingSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008C7A RID: 35962 RVA: 0x001E1FA4 File Offset: 0x001E01A4
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, this.CreatePropItem, null, false, null);
		this.FunctionalComponent.SetRewardButtonFunction(new Action(this.OnClickBtnReward));
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.OnClickBtnEnter));
	}

	// Token: 0x06008C7B RID: 35963 RVA: 0x001E2001 File Offset: 0x001E0201
	protected override void OnSetData()
	{
		this.MowingData = (this.ActivityBaseData as ActivityMowingData);
	}

	// Token: 0x06008C7C RID: 35964 RVA: 0x001E2014 File Offset: 0x001E0214
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06008C7D RID: 35965 RVA: 0x001E2016 File Offset: 0x001E0216
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06008C7E RID: 35966 RVA: 0x001E2018 File Offset: 0x001E0218
	protected override void OnRefreshView()
	{
		this.RefreshText();
		this.RefreshRewards();
		this.RefreshState();
		this.RefreshRedDot();
		this.NewInstanceCheck();
	}

	// Token: 0x06008C7F RID: 35967 RVA: 0x001E2038 File Offset: 0x001E0238
	private void NewInstanceCheck()
	{
		bool flag = this.MowingData.IsNewInstanceOpen();
		bool preGuideQuestFinishState = this.MowingData.GetPreGuideQuestFinishState();
		if (flag && preGuideQuestFinishState)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityMowing_Newlevelunlock", null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
		}
	}

	// Token: 0x06008C80 RID: 35968 RVA: 0x001E2078 File Offset: 0x001E0278
	protected override void OnTimer(float gap)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(10).SetUIActive(item);
		if (item)
		{
			base.GetText(10).SetText(item2, true);
		}
	}

	// Token: 0x06008C81 RID: 35969 RVA: 0x001E20B8 File Offset: 0x001E02B8
	private void RefreshText()
	{
		string title = this.MowingData.GetTitle();
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(title, true);
		}
		string desc = this.MowingData.GetDesc();
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.SetText(desc, true);
		}
		UUIText text3 = base.GetText(14);
		if (text3 == null)
		{
			return;
		}
		text3.ShowTextNew("CollectActivity_Button_ahead");
	}

	// Token: 0x06008C82 RID: 35970 RVA: 0x001E211C File Offset: 0x001E031C
	private void RefreshRewards()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardScrollView.RefreshByData(previewReward, null, false);
	}

	// Token: 0x06008C83 RID: 35971 RVA: 0x001E214C File Offset: 0x001E034C
	private void RefreshState()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(flag);
	}

	// Token: 0x06008C84 RID: 35972 RVA: 0x001E21AC File Offset: 0x001E03AC
	private void RefreshRedDot()
	{
		bool rewardRedDotVisible = this.MowingData.IsHaveRewardToGet();
		this.FunctionalComponent.SetRewardRedDotVisible(rewardRedDotVisible);
		bool flag = this.MowingData.IsNewInstanceOpen();
		bool preGuideQuestFinishState = this.MowingData.GetPreGuideQuestFinishState();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(preGuideQuestFinishState && flag);
	}

	// Token: 0x06008C85 RID: 35973 RVA: 0x001E21FC File Offset: 0x001E03FC
	private void OnClickBtnReward()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, this.MowingData.GetRewardViewData(), null);
	}

	// Token: 0x06008C86 RID: 35974 RVA: 0x001E2219 File Offset: 0x001E0419
	private void OnClickBtnEnter()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.MowingData.GetPreGuideQuestFinishState())
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, this.MowingData.GetUnFinishPreGuideQuestId(), null);
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(ConfigCommonParamById.GetIntConfig("MowingMark").GetValueOrDefault()),
				MarkType = (EMarkType)ConfigCommonParamById.GetIntConfig("MowingMarkType").GetValueOrDefault(),
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
			this.MowingData.ReadNewInstance();
		});
	}

	// Token: 0x04003E5B RID: 15963
	[Nullable(2)]
	private ActivityMowingData MowingData;

	// Token: 0x04003E5C RID: 15964
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04003E5D RID: 15965
	[Nullable(2)]
	private ActivityFunctionalArea FunctionalComponent;

	// Token: 0x04003E5E RID: 15966
	[Nullable(1)]
	private readonly Func<CommonItemSmallItemGrid> CreatePropItem = () => new CommonItemSmallItemGrid();

	// Token: 0x02007A01 RID: 31233
	private class EActivityMowingComponents
	{
		// Token: 0x0402827F RID: 164479
		public const int TitleItem = 0;

		// Token: 0x04028280 RID: 164480
		public const int TxtTitle = 1;

		// Token: 0x04028281 RID: 164481
		public const int DescItem = 2;

		// Token: 0x04028282 RID: 164482
		public const int TxtDesc = 3;

		// Token: 0x04028283 RID: 164483
		public const int RewardItem = 4;

		// Token: 0x04028284 RID: 164484
		public const int RewardScrollView = 5;

		// Token: 0x04028285 RID: 164485
		public const int FunctionItem = 6;

		// Token: 0x04028286 RID: 164486
		public const int PnlAactive = 7;

		// Token: 0x04028287 RID: 164487
		public const int RewardButtonItem = 8;

		// Token: 0x04028288 RID: 164488
		public const int BtnEnter = 9;

		// Token: 0x04028289 RID: 164489
		public const int TxtTime = 10;

		// Token: 0x0402828A RID: 164490
		public const int PnlButton = 11;

		// Token: 0x0402828B RID: 164491
		public const int RedDot = 12;

		// Token: 0x0402828C RID: 164492
		public const int TxtCondition = 13;

		// Token: 0x0402828D RID: 164493
		public const int TxtConfirm = 14;

		// Token: 0x0402828E RID: 164494
		public const int BtnReward = 15;
	}
}
