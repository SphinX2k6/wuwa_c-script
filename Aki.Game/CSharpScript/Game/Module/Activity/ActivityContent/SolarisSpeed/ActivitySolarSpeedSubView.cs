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
	// Token: 0x02005049 RID: 20553
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySolarSpeedSubView : ActivitySubViewBase
	{
		// Token: 0x06033717 RID: 210711 RVA: 0x00E67E24 File Offset: 0x00E66024
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

		// Token: 0x06033718 RID: 210712 RVA: 0x00E67F90 File Offset: 0x00E66190
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySolarSpeedSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySolarSpeedSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033719 RID: 210713 RVA: 0x00E67FD4 File Offset: 0x00E661D4
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

		// Token: 0x0603371A RID: 210714 RVA: 0x00E682BE File Offset: 0x00E664BE
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
		}

		// Token: 0x0603371B RID: 210715 RVA: 0x00E682C6 File Offset: 0x00E664C6
		protected override void OnAfterHide()
		{
			base.OnAfterHide();
		}

		// Token: 0x0603371C RID: 210716 RVA: 0x00E682CE File Offset: 0x00E664CE
		protected override void OnRefreshView()
		{
			EventSystem.Instance.Emit(EEventName.SolarSpeedSubViewOnRefreshView);
		}

		// Token: 0x0603371D RID: 210717 RVA: 0x00E682E0 File Offset: 0x00E664E0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Add<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.HandleOnChallengeInstanceRedDot));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.HandleRefreshCommonActivityRedDot));
		}

		// Token: 0x0603371E RID: 210718 RVA: 0x00E68344 File Offset: 0x00E66544
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Remove(EEventName.OnChallengeInstanceRedDot, new <>f__AnonymousDelegate2<int>(this.HandleOnChallengeInstanceRedDot));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.HandleRefreshCommonActivityRedDot));
		}

		// Token: 0x0603371F RID: 210719 RVA: 0x00E683A5 File Offset: 0x00E665A5
		protected override void OnTimer(float delta)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06033720 RID: 210720 RVA: 0x00E683B0 File Offset: 0x00E665B0
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

		// Token: 0x06033721 RID: 210721 RVA: 0x00E683ED File Offset: 0x00E665ED
		private void HandleOnClickConfirm()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivitySolarSpeedController.Instance.HandleConfirmClickInActivitySubView();
			});
		}

		// Token: 0x06033722 RID: 210722 RVA: 0x00E6841E File Offset: 0x00E6661E
		private void HandleOnClickReward()
		{
			ActivitySolarSpeedController.Instance.HandleOnClickRewardInActivitySubView();
		}

		// Token: 0x06033723 RID: 210723 RVA: 0x00E6842C File Offset: 0x00E6662C
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

		// Token: 0x06033724 RID: 210724 RVA: 0x00E6849F File Offset: 0x00E6669F
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

		// Token: 0x06033725 RID: 210725 RVA: 0x00E684C4 File Offset: 0x00E666C4
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

		// Token: 0x0401B532 RID: 111922
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401B533 RID: 111923
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401B534 RID: 111924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401B535 RID: 111925
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401B536 RID: 111926
		private Func<bool> RewardRedDotStateGetter;

		// Token: 0x0401B537 RID: 111927
		private Func<bool> ConfirmRedDotStateGetter;

		// Token: 0x0401B538 RID: 111928
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<string> RewardProgressGetter;

		// Token: 0x0401B539 RID: 111929
		[Nullable(1)]
		private string RewardProgressTextId;

		// Token: 0x0401B53A RID: 111930
		[Nullable(1)]
		private string RewardProgressTotal;

		// Token: 0x0200AD02 RID: 44290
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040357F0 RID: 219120
			public const int ActivityTitleItem = 0;

			// Token: 0x040357F1 RID: 219121
			public const int ActivityDescItem = 1;

			// Token: 0x040357F2 RID: 219122
			public const int ActivityRewardItem = 2;

			// Token: 0x040357F3 RID: 219123
			public const int ActivityFunctionItem = 3;

			// Token: 0x040357F4 RID: 219124
			public const int RewardButton = 4;

			// Token: 0x040357F5 RID: 219125
			public const int RedDotItem = 5;

			// Token: 0x040357F6 RID: 219126
			public const int RewardRoot = 6;

			// Token: 0x040357F7 RID: 219127
			public const int RewardValueText = 7;
		}
	}
}
