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

// Token: 0x02000848 RID: 2120
public class ActivityMowingSubView : ActivitySubViewBase
{
	// Token: 0x06006013 RID: 24595 RVA: 0x001EAB34 File Offset: 0x001E8D34
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

	// Token: 0x06006014 RID: 24596 RVA: 0x001EADB4 File Offset: 0x001E8FB4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityMowingSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMowingSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006015 RID: 24597 RVA: 0x001EADF8 File Offset: 0x001E8FF8
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, this.CreatePropItem, null, false, null);
		this.FunctionalComponent.SetRewardButtonFunction(new Action(this.OnClickBtnReward));
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.OnClickBtnEnter));
	}

	// Token: 0x06006016 RID: 24598 RVA: 0x001EAE55 File Offset: 0x001E9055
	protected override void OnSetData()
	{
		this.MowingData = (this.ActivityBaseData as ActivityMowingData);
	}

	// Token: 0x06006017 RID: 24599 RVA: 0x001EAE68 File Offset: 0x001E9068
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06006018 RID: 24600 RVA: 0x001EAE6A File Offset: 0x001E906A
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06006019 RID: 24601 RVA: 0x001EAE6C File Offset: 0x001E906C
	protected override void OnRefreshView()
	{
		this.RefreshText();
		this.RefreshRewards();
		this.RefreshState();
		this.RefreshRedDot();
		this.NewInstanceCheck();
	}

	// Token: 0x0600601A RID: 24602 RVA: 0x001EAE8C File Offset: 0x001E908C
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

	// Token: 0x0600601B RID: 24603 RVA: 0x001EAECC File Offset: 0x001E90CC
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

	// Token: 0x0600601C RID: 24604 RVA: 0x001EAF0C File Offset: 0x001E910C
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

	// Token: 0x0600601D RID: 24605 RVA: 0x001EAF70 File Offset: 0x001E9170
	private void RefreshRewards()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardScrollView.RefreshByData(previewReward, null, false);
	}

	// Token: 0x0600601E RID: 24606 RVA: 0x001EAFA0 File Offset: 0x001E91A0
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

	// Token: 0x0600601F RID: 24607 RVA: 0x001EB000 File Offset: 0x001E9200
	private void RefreshRedDot()
	{
		bool rewardRedDotVisible = this.MowingData.IsHaveRewardToGet();
		this.FunctionalComponent.SetRewardRedDotVisible(rewardRedDotVisible);
		bool flag = this.MowingData.IsNewInstanceOpen();
		bool preGuideQuestFinishState = this.MowingData.GetPreGuideQuestFinishState();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(preGuideQuestFinishState && flag);
	}

	// Token: 0x06006020 RID: 24608 RVA: 0x001EB050 File Offset: 0x001E9250
	private void OnClickBtnReward()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, this.MowingData.GetRewardViewData(), null);
	}

	// Token: 0x06006021 RID: 24609 RVA: 0x001EB06D File Offset: 0x001E926D
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

	// Token: 0x04003EF3 RID: 16115
	[Nullable(2)]
	private ActivityMowingData MowingData;

	// Token: 0x04003EF4 RID: 16116
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04003EF5 RID: 16117
	[Nullable(2)]
	private ActivityFunctionalArea FunctionalComponent;

	// Token: 0x04003EF6 RID: 16118
	[Nullable(1)]
	private readonly Func<CommonItemSmallItemGrid> CreatePropItem = () => new CommonItemSmallItemGrid();

	// Token: 0x02006B8B RID: 27531
	private class EActivityMowingComponents
	{
		// Token: 0x040235AC RID: 144812
		public const int TitleItem = 0;

		// Token: 0x040235AD RID: 144813
		public const int TxtTitle = 1;

		// Token: 0x040235AE RID: 144814
		public const int DescItem = 2;

		// Token: 0x040235AF RID: 144815
		public const int TxtDesc = 3;

		// Token: 0x040235B0 RID: 144816
		public const int RewardItem = 4;

		// Token: 0x040235B1 RID: 144817
		public const int RewardScrollView = 5;

		// Token: 0x040235B2 RID: 144818
		public const int FunctionItem = 6;

		// Token: 0x040235B3 RID: 144819
		public const int PnlAactive = 7;

		// Token: 0x040235B4 RID: 144820
		public const int RewardButtonItem = 8;

		// Token: 0x040235B5 RID: 144821
		public const int BtnEnter = 9;

		// Token: 0x040235B6 RID: 144822
		public const int TxtTime = 10;

		// Token: 0x040235B7 RID: 144823
		public const int PnlButton = 11;

		// Token: 0x040235B8 RID: 144824
		public const int RedDot = 12;

		// Token: 0x040235B9 RID: 144825
		public const int TxtCondition = 13;

		// Token: 0x040235BA RID: 144826
		public const int TxtConfirm = 14;

		// Token: 0x040235BB RID: 144827
		public const int BtnReward = 15;
	}
}
