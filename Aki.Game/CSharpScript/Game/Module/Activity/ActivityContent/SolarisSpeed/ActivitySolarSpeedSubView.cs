using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060CB RID: 24779
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySolarSpeedSubView : ActivitySubViewBase
	{
		// Token: 0x0603EA53 RID: 256595 RVA: 0x00F21054 File Offset: 0x00F1F254
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.HandleOnClickReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EA54 RID: 256596 RVA: 0x00F211C0 File Offset: 0x00F1F3C0
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySolarSpeedSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySolarSpeedSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA55 RID: 256597 RVA: 0x00F21204 File Offset: 0x00F1F404
		protected override void OnStart()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			ISolarSpeedActivitySubViewData solarSpeedActivitySubViewData = SolarSpeedModel.Instance.BuildActivitySubViewData();
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.TitleComponent.SetSubTitleVisible(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null));
			if (((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null) != null)
			{
				this.TitleComponent.SetSubTitleByTextId(localConfig.Value.DescTheme, Array.Empty<string>());
			}
			this.RefreshTimerText();
			this.DescriptionComponent.SetContentVisible(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().Desc : null));
			if (((localConfig != null) ? localConfig.GetValueOrDefault().Desc : null) != null)
			{
				this.DescriptionComponent.SetContentByTextId(localConfig.Value.Desc, Array.Empty<string>());
			}
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
			this.RewardListComponent.SetTitleByTextId(solarSpeedActivitySubViewData.RewardTextId);
			bool flag = this.ActivityBaseData.IsUnLock();
			this.FunctionalComponent.SetPanelConditionVisible(!flag);
			this.FunctionalComponent.FunctionButton.SetActive(flag);
			if (flag)
			{
				this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.HandleOnClickConfirm));
				this.FunctionalComponent.FunctionButton.SetLocalTextNew(solarSpeedActivitySubViewData.ButtonTextId, Array.Empty<object>());
			}
			else
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			this.RewardProgressGetter = solarSpeedActivitySubViewData.RewardProgressCurrentGetter;
			this.RewardProgressTextId = solarSpeedActivitySubViewData.RewardProgressTextId;
			this.RewardProgressTotal = solarSpeedActivitySubViewData.RewardProgressTotal;
			if (flag)
			{
				string text = (this.RewardProgressGetter == null) ? "0" : this.RewardProgressGetter();
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), solarSpeedActivitySubViewData.RewardProgressTextId, new <>z__ReadOnlyArray<object>(new object[]
				{
					text,
					solarSpeedActivitySubViewData.RewardProgressTotal
				}));
			}
			this.RewardRedDotStateGetter = solarSpeedActivitySubViewData.RewardRedDotStateGetter;
			if (this.RewardRedDotStateGetter != null)
			{
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(this.RewardRedDotStateGetter());
				}
			}
			this.ConfirmRedDotStateGetter = solarSpeedActivitySubViewData.ConfirmRedDotStateGetter;
			if (this.ConfirmRedDotStateGetter != null)
			{
				ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
				if (functionalComponent == null)
				{
					return;
				}
				functionalComponent.SetFunctionRedDotVisible(this.ConfirmRedDotStateGetter());
			}
		}

		// Token: 0x0603EA56 RID: 256598 RVA: 0x00F214EE File Offset: 0x00F1F6EE
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
		}

		// Token: 0x0603EA57 RID: 256599 RVA: 0x00F214F6 File Offset: 0x00F1F6F6
		protected override void OnAfterHide()
		{
			base.OnAfterHide();
		}

		// Token: 0x0603EA58 RID: 256600 RVA: 0x00F214FE File Offset: 0x00F1F6FE
		protected override void OnRefreshView()
		{
			EventSystem.Instance.Emit(EEventName.SolarSpeedSubViewOnRefreshView);
		}

		// Token: 0x0603EA59 RID: 256601 RVA: 0x00F21510 File Offset: 0x00F1F710
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Add<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.HandleOnChallengeInstanceRedDot));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.HandleRefreshCommonActivityRedDot));
		}

		// Token: 0x0603EA5A RID: 256602 RVA: 0x00F21574 File Offset: 0x00F1F774
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Remove(EEventName.OnChallengeInstanceRedDot, new <>f__AnonymousDelegate2<int>(this.HandleOnChallengeInstanceRedDot));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.HandleRefreshCommonActivityRedDot));
		}

		// Token: 0x0603EA5B RID: 256603 RVA: 0x00F215D5 File Offset: 0x00F1F7D5
		protected override void OnTimer(float delta)
		{
			this.RefreshTimerText();
		}

		// Token: 0x0603EA5C RID: 256604 RVA: 0x00F215E0 File Offset: 0x00F1F7E0
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x0603EA5D RID: 256605 RVA: 0x00F2161D File Offset: 0x00F1F81D
		private void HandleOnClickConfirm()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivitySolarSpeedController.Instance.HandleConfirmClickInActivitySubView();
			});
		}

		// Token: 0x0603EA5E RID: 256606 RVA: 0x00F2164E File Offset: 0x00F1F84E
		private void HandleOnClickReward()
		{
			ActivitySolarSpeedController.Instance.HandleOnClickRewardInActivitySubView();
		}

		// Token: 0x0603EA5F RID: 256607 RVA: 0x00F2165C File Offset: 0x00F1F85C
		private void HandleSolarSpeedRewarded()
		{
			if (this.RewardRedDotStateGetter != null)
			{
				UUIItem item = base.GetItem(5);
				if (item != null)
				{
					item.SetUIActive(this.RewardRedDotStateGetter());
				}
			}
			if (this.RewardProgressGetter != null)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), this.RewardProgressTextId, new <>z__ReadOnlyArray<object>(new object[]
				{
					this.RewardProgressGetter(),
					this.RewardProgressTotal
				}));
			}
		}

		// Token: 0x0603EA60 RID: 256608 RVA: 0x00F216CF File Offset: 0x00F1F8CF
		private void HandleOnChallengeInstanceRedDot(int i = 0)
		{
			if (this.ConfirmRedDotStateGetter != null)
			{
				ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
				if (functionalComponent == null)
				{
					return;
				}
				functionalComponent.SetFunctionRedDotVisible(this.ConfirmRedDotStateGetter());
			}
		}

		// Token: 0x0603EA61 RID: 256609 RVA: 0x00F216F4 File Offset: 0x00F1F8F4
		private void HandleRefreshCommonActivityRedDot(int activityId)
		{
			if (activityId != SolarSpeedModel.Instance.CurrentActivityId)
			{
				return;
			}
			if (this.ConfirmRedDotStateGetter != null)
			{
				ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
				if (functionalComponent == null)
				{
					return;
				}
				functionalComponent.SetFunctionRedDotVisible(this.ConfirmRedDotStateGetter());
			}
		}

		// Token: 0x04020C05 RID: 134149
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04020C06 RID: 134150
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04020C07 RID: 134151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04020C08 RID: 134152
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x04020C09 RID: 134153
		private Func<bool> RewardRedDotStateGetter;

		// Token: 0x04020C0A RID: 134154
		private Func<bool> ConfirmRedDotStateGetter;

		// Token: 0x04020C0B RID: 134155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<string> RewardProgressGetter;

		// Token: 0x04020C0C RID: 134156
		[Nullable(1)]
		private string RewardProgressTextId;

		// Token: 0x04020C0D RID: 134157
		[Nullable(1)]
		private string RewardProgressTotal;

		// Token: 0x0200C317 RID: 49943
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AE88 RID: 241288
			public const int ActivityTitleItem = 0;

			// Token: 0x0403AE89 RID: 241289
			public const int ActivityDescItem = 1;

			// Token: 0x0403AE8A RID: 241290
			public const int ActivityRewardItem = 2;

			// Token: 0x0403AE8B RID: 241291
			public const int ActivityFunctionItem = 3;

			// Token: 0x0403AE8C RID: 241292
			public const int RewardButton = 4;

			// Token: 0x0403AE8D RID: 241293
			public const int RedDotItem = 5;

			// Token: 0x0403AE8E RID: 241294
			public const int RewardRoot = 6;

			// Token: 0x0403AE8F RID: 241295
			public const int RewardValueText = 7;
		}
	}
}
