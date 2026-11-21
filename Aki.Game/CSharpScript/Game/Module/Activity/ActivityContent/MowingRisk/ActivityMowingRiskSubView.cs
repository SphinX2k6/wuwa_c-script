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
	// Token: 0x02005353 RID: 21331
	public class ActivityMowingRiskSubView : ActivitySubViewBase
	{
		// Token: 0x0603513D RID: 217405 RVA: 0x00ED2A54 File Offset: 0x00ED0C54
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

		// Token: 0x0603513E RID: 217406 RVA: 0x00ED2CF4 File Offset: 0x00ED0EF4
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMowingRiskSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMowingRiskSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603513F RID: 217407 RVA: 0x00ED2D37 File Offset: 0x00ED0F37
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotMowingRiskReward, base.GetItem(12), 0);
		}

		// Token: 0x06035140 RID: 217408 RVA: 0x00ED2D54 File Offset: 0x00ED0F54
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
			this.FunctionalComponent.SetRewardButtonFunction(new Action(this.OnClickBtnReward));
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.OnClickBtnEnter));
		}

		// Token: 0x06035141 RID: 217409 RVA: 0x00ED2DB7 File Offset: 0x00ED0FB7
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06035142 RID: 217410 RVA: 0x00ED2DBE File Offset: 0x00ED0FBE
		protected override void OnSetData()
		{
		}

		// Token: 0x06035143 RID: 217411 RVA: 0x00ED2DC0 File Offset: 0x00ED0FC0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MowingRiskOnGetReward, new Action(this.RefreshRewardCountText));
		}

		// Token: 0x06035144 RID: 217412 RVA: 0x00ED2DDE File Offset: 0x00ED0FDE
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MowingRiskOnGetReward, new Action(this.RefreshRewardCountText));
		}

		// Token: 0x06035145 RID: 217413 RVA: 0x00ED2DFC File Offset: 0x00ED0FFC
		protected override void OnRefreshView()
		{
			this.RefreshText();
			this.RefreshRewards();
			this.RefreshState();
			this.RefreshRedDot();
			this.TryShowNewInstanceTips();
			this.RefreshRewardCountText();
		}

		// Token: 0x06035146 RID: 217414 RVA: 0x00ED2E24 File Offset: 0x00ED1024
		private void TryShowNewInstanceTips()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			if (instance.IsNewInstanceOpen && instance.IsPreQuestFinished)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ActivityMowing_Newlevelunlock", Array.Empty<object>());
			}
		}

		// Token: 0x06035147 RID: 217415 RVA: 0x00ED2E5C File Offset: 0x00ED105C
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

		// Token: 0x06035148 RID: 217416 RVA: 0x00ED2E9C File Offset: 0x00ED109C
		private void RefreshText()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), instance.ActivityTitleTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), instance.ActivityDescriptionTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "CollectActivity_Button_ahead", Array.Empty<object>());
		}

		// Token: 0x06035149 RID: 217417 RVA: 0x00ED2F04 File Offset: 0x00ED1104
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

		// Token: 0x0603514A RID: 217418 RVA: 0x00ED2F68 File Offset: 0x00ED1168
		private void RefreshRewards()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardScrollView.RefreshByData(previewReward, null, false);
		}

		// Token: 0x0603514B RID: 217419 RVA: 0x00ED2F98 File Offset: 0x00ED1198
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

		// Token: 0x0603514C RID: 217420 RVA: 0x00ED2FF8 File Offset: 0x00ED11F8
		private void RefreshRedDot()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			this.FunctionalComponent.SetRewardRedDotVisible(instance.HasAnyReward);
			this.FunctionalComponent.FunctionButton.SetRedDotVisible(instance.IsNewInstanceOpen);
			EventSystem.Instance.Emit(EEventName.MowingRiskOnRefreshRewardRedDot);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
		}

		// Token: 0x0603514D RID: 217421 RVA: 0x00ED3060 File Offset: 0x00ED1260
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

		// Token: 0x0603514E RID: 217422 RVA: 0x00ED30A7 File Offset: 0x00ED12A7
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

		// Token: 0x0603514F RID: 217423 RVA: 0x00ED30C8 File Offset: 0x00ED12C8
		private UniTask OnClickBtnEnterAsync()
		{
			ActivityMowingRiskSubView.<OnClickBtnEnterAsync>d__21 <OnClickBtnEnterAsync>d__;
			<OnClickBtnEnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickBtnEnterAsync>d__.<>4__this = this;
			<OnClickBtnEnterAsync>d__.<>1__state = -1;
			<OnClickBtnEnterAsync>d__.<>t__builder.Start<ActivityMowingRiskSubView.<OnClickBtnEnterAsync>d__21>(ref <OnClickBtnEnterAsync>d__);
			return <OnClickBtnEnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401C072 RID: 114802
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401C073 RID: 114803
		[Nullable(2)]
		private ActivityFunctionalArea FunctionalComponent;

		// Token: 0x0200AFB6 RID: 44982
		private class EActivityMowingComponents
		{
			// Token: 0x040364E9 RID: 222441
			public const int TitleItem = 0;

			// Token: 0x040364EA RID: 222442
			public const int TxtTitle = 1;

			// Token: 0x040364EB RID: 222443
			public const int DescItem = 2;

			// Token: 0x040364EC RID: 222444
			public const int TxtDesc = 3;

			// Token: 0x040364ED RID: 222445
			public const int RewardItem = 4;

			// Token: 0x040364EE RID: 222446
			public const int RewardScrollView = 5;

			// Token: 0x040364EF RID: 222447
			public const int FunctionItem = 6;

			// Token: 0x040364F0 RID: 222448
			public const int PnlAactive = 7;

			// Token: 0x040364F1 RID: 222449
			public const int BtnRewardItem = 8;

			// Token: 0x040364F2 RID: 222450
			public const int BtnEnter = 9;

			// Token: 0x040364F3 RID: 222451
			public const int TxtTime = 10;

			// Token: 0x040364F4 RID: 222452
			public const int PnlButton = 11;

			// Token: 0x040364F5 RID: 222453
			public const int RedDot = 12;

			// Token: 0x040364F6 RID: 222454
			public const int TxtCondition = 13;

			// Token: 0x040364F7 RID: 222455
			public const int TxtConfirm = 14;

			// Token: 0x040364F8 RID: 222456
			public const int BtnCircle = 15;

			// Token: 0x040364F9 RID: 222457
			public const int RewardText = 16;
		}
	}
}
