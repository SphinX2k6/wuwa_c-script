using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02005019 RID: 20505
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivitySpring25SubView : ActivitySubViewBase
	{
		// Token: 0x170063EE RID: 25582
		// (get) Token: 0x060334F6 RID: 210166 RVA: 0x00E62CD8 File Offset: 0x00E60ED8
		// (set) Token: 0x060334F7 RID: 210167 RVA: 0x00E62CE0 File Offset: 0x00E60EE0
		private ActivityTitleTypeA TitleComponent { get; set; }

		// Token: 0x170063EF RID: 25583
		// (get) Token: 0x060334F8 RID: 210168 RVA: 0x00E62CE9 File Offset: 0x00E60EE9
		// (set) Token: 0x060334F9 RID: 210169 RVA: 0x00E62CF1 File Offset: 0x00E60EF1
		private ActivityDescriptionTypeA DescriptionComponent { get; set; }

		// Token: 0x170063F0 RID: 25584
		// (get) Token: 0x060334FA RID: 210170 RVA: 0x00E62CFA File Offset: 0x00E60EFA
		// (set) Token: 0x060334FB RID: 210171 RVA: 0x00E62D02 File Offset: 0x00E60F02
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent { get; set; }

		// Token: 0x170063F1 RID: 25585
		// (get) Token: 0x060334FC RID: 210172 RVA: 0x00E62D0B File Offset: 0x00E60F0B
		// (set) Token: 0x060334FD RID: 210173 RVA: 0x00E62D13 File Offset: 0x00E60F13
		private ActivityFunctionalTypeA FunctionalComponent { get; set; }

		// Token: 0x060334FE RID: 210174 RVA: 0x00E62D1C File Offset: 0x00E60F1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060334FF RID: 210175 RVA: 0x00E62E70 File Offset: 0x00E61070
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySpring25SubView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySpring25SubView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033500 RID: 210176 RVA: 0x00E62EB4 File Offset: 0x00E610B4
		protected override void OnStart()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			Activity? activity = (activityBaseData != null) ? activityBaseData.LocalConfig : null;
			Spring25ActivitySubViewData spring25ActivitySubViewData = Spring25Model.Instance.BuildActivitySubViewData();
			ActivityTitleTypeA titleComponent = this.TitleComponent;
			if (titleComponent != null)
			{
				titleComponent.SetActivityBaseData(this.ActivityBaseData);
			}
			ActivityTitleTypeA titleComponent2 = this.TitleComponent;
			if (titleComponent2 != null)
			{
				ActivityBaseData activityBaseData2 = this.ActivityBaseData;
				titleComponent2.SetTitleByText((activityBaseData2 != null) ? activityBaseData2.GetTitle() : null);
			}
			ActivityTitleTypeA titleComponent3 = this.TitleComponent;
			if (titleComponent3 != null)
			{
				titleComponent3.SetSubTitleVisible(!StringUtils.IsEmpty((activity != null) ? activity.GetValueOrDefault().DescTheme : null));
			}
			if (((activity != null) ? activity.GetValueOrDefault().DescTheme : null) != null)
			{
				ActivityTitleTypeA titleComponent4 = this.TitleComponent;
				if (titleComponent4 != null)
				{
					titleComponent4.SetSubTitleByTextId(activity.Value.DescTheme, Array.Empty<string>());
				}
			}
			this.RefreshTimerText();
			ActivityDescriptionTypeA descriptionComponent = this.DescriptionComponent;
			if (descriptionComponent != null)
			{
				descriptionComponent.SetContentVisible(!StringUtils.IsEmpty((activity != null) ? activity.GetValueOrDefault().Desc : null));
			}
			if (((activity != null) ? activity.GetValueOrDefault().Desc : null) != null)
			{
				ActivityDescriptionTypeA descriptionComponent2 = this.DescriptionComponent;
				if (descriptionComponent2 != null)
				{
					descriptionComponent2.SetContentByTextId(activity.Value.Desc, Array.Empty<string>());
				}
			}
			ActivityBaseData activityBaseData3 = this.ActivityBaseData;
			List<TItem> dataList = (activityBaseData3 != null) ? activityBaseData3.GetPreviewReward(null) : null;
			ActivityRewardList<CommonItemSmallItemGrid, TItem> rewardListComponent = this.RewardListComponent;
			if (rewardListComponent != null)
			{
				rewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			}
			ActivityRewardList<CommonItemSmallItemGrid, TItem> rewardListComponent2 = this.RewardListComponent;
			if (rewardListComponent2 != null)
			{
				rewardListComponent2.RefreshItemLayout(dataList, null);
			}
			ActivityRewardList<CommonItemSmallItemGrid, TItem> rewardListComponent3 = this.RewardListComponent;
			if (rewardListComponent3 != null)
			{
				rewardListComponent3.SetTitleByTextId(spring25ActivitySubViewData.RewardTextId);
			}
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent != null)
			{
				ActivityButtonItem functionButton = functionalComponent.FunctionButton;
				if (functionButton != null)
				{
					functionButton.SetFunction(new Action(this.HandleOnClickConfirm));
				}
			}
			ActivityFunctionalTypeA functionalComponent2 = this.FunctionalComponent;
			if (functionalComponent2 != null)
			{
				ActivityButtonItem functionButton2 = functionalComponent2.FunctionButton;
				if (functionButton2 != null)
				{
					functionButton2.SetLocalTextNew(spring25ActivitySubViewData.ButtonTextId, Array.Empty<object>());
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), spring25ActivitySubViewData.ProgressTextId, Array.Empty<object>());
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(spring25ActivitySubViewData.Current, true);
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), spring25ActivitySubViewData.TotalTextId, new <>z__ReadOnlySingleElementList<object>(spring25ActivitySubViewData.TotalTextArg));
			UUITexture texture = base.GetTexture(8);
			if (texture != null)
			{
				texture.SetUIActive(spring25ActivitySubViewData.IsMale);
			}
			UUITexture texture2 = base.GetTexture(7);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(!spring25ActivitySubViewData.IsMale);
		}

		// Token: 0x06033501 RID: 210177 RVA: 0x00E6315A File Offset: 0x00E6135A
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			ActivityButtonItem functionButton = functionalComponent.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.BindRedDot(ERedDotName.Spring25Enter, 0);
		}

		// Token: 0x06033502 RID: 210178 RVA: 0x00E63182 File Offset: 0x00E61382
		protected override void OnAfterHide()
		{
			base.OnAfterHide();
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			ActivityButtonItem functionButton = functionalComponent.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.UnBindGivenUid(0);
		}

		// Token: 0x06033503 RID: 210179 RVA: 0x00E631A5 File Offset: 0x00E613A5
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
		}

		// Token: 0x06033504 RID: 210180 RVA: 0x00E631C3 File Offset: 0x00E613C3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
		}

		// Token: 0x06033505 RID: 210181 RVA: 0x00E631E1 File Offset: 0x00E613E1
		protected override void OnTimer(float delta)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06033506 RID: 210182 RVA: 0x00E631EC File Offset: 0x00E613EC
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			ActivityTitleTypeA titleComponent = this.TitleComponent;
			if (titleComponent != null)
			{
				titleComponent.SetTimeTextVisible(item);
			}
			if (item)
			{
				ActivityTitleTypeA titleComponent2 = this.TitleComponent;
				if (titleComponent2 == null)
				{
					return;
				}
				titleComponent2.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06033507 RID: 210183 RVA: 0x00E63234 File Offset: 0x00E61434
		private void HandleOnClickConfirm()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivitySpring25Controller.Instance.HandleConfirmClickInActivitySubView();
			});
		}

		// Token: 0x06033508 RID: 210184 RVA: 0x00E63268 File Offset: 0x00E61468
		private void HandleSpring25InviteDone()
		{
			Spring25ActivitySubViewData spring25ActivitySubViewData = Spring25Model.Instance.BuildActivitySubViewData();
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(spring25ActivitySubViewData.Current, true);
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), spring25ActivitySubViewData.TotalTextId, new <>z__ReadOnlySingleElementList<object>(spring25ActivitySubViewData.TotalTextArg));
		}

		// Token: 0x0200ACD9 RID: 44249
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403572B RID: 218923
			public const int ActivityTitleItem = 0;

			// Token: 0x0403572C RID: 218924
			public const int ActivityDescItem = 1;

			// Token: 0x0403572D RID: 218925
			public const int ActivityRewardItem = 2;

			// Token: 0x0403572E RID: 218926
			public const int ActivityFunctionItem = 3;

			// Token: 0x0403572F RID: 218927
			public const int ProgressText = 4;

			// Token: 0x04035730 RID: 218928
			public const int CurrentNumText = 5;

			// Token: 0x04035731 RID: 218929
			public const int TotalNumText = 6;

			// Token: 0x04035732 RID: 218930
			public const int FemaleTexture = 7;

			// Token: 0x04035733 RID: 218931
			public const int MaleTexture = 8;
		}
	}
}
