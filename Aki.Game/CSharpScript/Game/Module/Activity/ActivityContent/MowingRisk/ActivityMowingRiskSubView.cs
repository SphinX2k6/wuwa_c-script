using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063D5 RID: 25557
	public class ActivityMowingRiskSubView : ActivitySubViewBase
	{
		// Token: 0x0604047C RID: 263292 RVA: 0x00F8BABC File Offset: 0x00F89CBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickBtnReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604047D RID: 263293 RVA: 0x00F8BD5C File Offset: 0x00F89F5C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMowingRiskSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMowingRiskSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604047E RID: 263294 RVA: 0x00F8BD9F File Offset: 0x00F89F9F
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotMowingRiskReward, base.GetItem(12), 0);
		}

		// Token: 0x0604047F RID: 263295 RVA: 0x00F8BDBC File Offset: 0x00F89FBC
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
			this.FunctionalComponent.SetRewardButtonFunction(new Action(this.OnClickBtnReward));
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.OnClickBtnEnter));
		}

		// Token: 0x06040480 RID: 263296 RVA: 0x00F8BE1F File Offset: 0x00F8A01F
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06040481 RID: 263297 RVA: 0x00F8BE26 File Offset: 0x00F8A026
		protected override void OnSetData()
		{
		}

		// Token: 0x06040482 RID: 263298 RVA: 0x00F8BE28 File Offset: 0x00F8A028
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MowingRiskOnGetReward, new Action(this.RefreshRewardCountText));
		}

		// Token: 0x06040483 RID: 263299 RVA: 0x00F8BE46 File Offset: 0x00F8A046
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MowingRiskOnGetReward, new Action(this.RefreshRewardCountText));
		}

		// Token: 0x06040484 RID: 263300 RVA: 0x00F8BE64 File Offset: 0x00F8A064
		protected override void OnRefreshView()
		{
			this.RefreshText();
			this.RefreshRewards();
			this.RefreshState();
			this.RefreshRedDot();
			this.TryShowNewInstanceTips();
			this.RefreshRewardCountText();
		}

		// Token: 0x06040485 RID: 263301 RVA: 0x00F8BE8C File Offset: 0x00F8A08C
		private void TryShowNewInstanceTips()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			if (instance.IsNewInstanceOpen && instance.IsPreQuestFinished)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ActivityMowing_Newlevelunlock", Array.Empty<object>());
			}
		}

		// Token: 0x06040486 RID: 263302 RVA: 0x00F8BEC4 File Offset: 0x00F8A0C4
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

		// Token: 0x06040487 RID: 263303 RVA: 0x00F8BF04 File Offset: 0x00F8A104
		private void RefreshText()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), instance.ActivityTitleTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), instance.ActivityDescriptionTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "CollectActivity_Button_ahead", Array.Empty<object>());
		}

		// Token: 0x06040488 RID: 263304 RVA: 0x00F8BF6C File Offset: 0x00F8A16C
		public void RefreshRewardCountText()
		{
			ValueTuple<int, int> rewardCount = MowingRiskModel.Instance.GetRewardCount();
			UUIText text = base.GetText(16);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(rewardCount.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(rewardCount.Item2);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06040489 RID: 263305 RVA: 0x00F8BFD0 File Offset: 0x00F8A1D0
		private void RefreshRewards()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardScrollView.RefreshByData(previewReward, null, false);
		}

		// Token: 0x0604048A RID: 263306 RVA: 0x00F8C000 File Offset: 0x00F8A200
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

		// Token: 0x0604048B RID: 263307 RVA: 0x00F8C060 File Offset: 0x00F8A260
		private void RefreshRedDot()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			this.FunctionalComponent.SetRewardRedDotVisible(instance.HasAnyReward);
			this.FunctionalComponent.FunctionButton.SetRedDotVisible(instance.IsNewInstanceOpen);
			EventSystem.Instance.Emit(EEventName.MowingRiskOnRefreshRewardRedDot);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
		}

		// Token: 0x0604048C RID: 263308 RVA: 0x00F8C0C8 File Offset: 0x00F8A2C8
		private void OnClickBtnReward()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, instance.BuildActivityRewardViewData(), delegate(bool success, int viewId)
			{
				if (success && UiManager.Instance.IsViewOpen(EUiViewName.CommonActivityView))
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x0604048D RID: 263309 RVA: 0x00F8C10F File Offset: 0x00F8A30F
		private void OnClickBtnEnter()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				UiAsyncTask task = new UiAsyncTask("ActivityMowingRiskSubView.OnClickBtnEnterAsync", delegate()
				{
					ActivityMowingRiskSubView.<<OnClickBtnEnter>b__20_1>d <<OnClickBtnEnter>b__20_1>d;
					<<OnClickBtnEnter>b__20_1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
					<<OnClickBtnEnter>b__20_1>d.<>4__this = this;
					<<OnClickBtnEnter>b__20_1>d.<>1__state = -1;
					<<OnClickBtnEnter>b__20_1>d.<>t__builder.Start<ActivityMowingRiskSubView.<<OnClickBtnEnter>b__20_1>d>(ref <<OnClickBtnEnter>b__20_1>d);
					return <<OnClickBtnEnter>b__20_1>d.<>t__builder.Task;
				}, null);
				base.RunAsyncTask(task);
			});
		}

		// Token: 0x0604048E RID: 263310 RVA: 0x00F8C130 File Offset: 0x00F8A330
		private UniTask OnClickBtnEnterAsync()
		{
			ActivityMowingRiskSubView.<OnClickBtnEnterAsync>d__21 <OnClickBtnEnterAsync>d__;
			<OnClickBtnEnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickBtnEnterAsync>d__.<>4__this = this;
			<OnClickBtnEnterAsync>d__.<>1__state = -1;
			<OnClickBtnEnterAsync>d__.<>t__builder.Start<ActivityMowingRiskSubView.<OnClickBtnEnterAsync>d__21>(ref <OnClickBtnEnterAsync>d__);
			return <OnClickBtnEnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04021743 RID: 137027
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x04021744 RID: 137028
		[Nullable(2)]
		private ActivityFunctionalArea FunctionalComponent;

		// Token: 0x0200C5CF RID: 50639
		private class EActivityMowingComponents
		{
			// Token: 0x0403BB8A RID: 244618
			public const int TitleItem = 0;

			// Token: 0x0403BB8B RID: 244619
			public const int TxtTitle = 1;

			// Token: 0x0403BB8C RID: 244620
			public const int DescItem = 2;

			// Token: 0x0403BB8D RID: 244621
			public const int TxtDesc = 3;

			// Token: 0x0403BB8E RID: 244622
			public const int RewardItem = 4;

			// Token: 0x0403BB8F RID: 244623
			public const int RewardScrollView = 5;

			// Token: 0x0403BB90 RID: 244624
			public const int FunctionItem = 6;

			// Token: 0x0403BB91 RID: 244625
			public const int PnlAactive = 7;

			// Token: 0x0403BB92 RID: 244626
			public const int BtnRewardItem = 8;

			// Token: 0x0403BB93 RID: 244627
			public const int BtnEnter = 9;

			// Token: 0x0403BB94 RID: 244628
			public const int TxtTime = 10;

			// Token: 0x0403BB95 RID: 244629
			public const int PnlButton = 11;

			// Token: 0x0403BB96 RID: 244630
			public const int RedDot = 12;

			// Token: 0x0403BB97 RID: 244631
			public const int TxtCondition = 13;

			// Token: 0x0403BB98 RID: 244632
			public const int TxtConfirm = 14;

			// Token: 0x0403BB99 RID: 244633
			public const int BtnCircle = 15;

			// Token: 0x0403BB9A RID: 244634
			public const int RewardText = 16;
		}
	}
}
