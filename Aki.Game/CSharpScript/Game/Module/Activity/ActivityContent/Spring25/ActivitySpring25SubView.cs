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
	// Token: 0x0200609B RID: 24731
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivitySpring25SubView : ActivitySubViewBase
	{
		// Token: 0x1700908C RID: 37004
		// (get) Token: 0x0603E832 RID: 256050 RVA: 0x00F1BF14 File Offset: 0x00F1A114
		// (set) Token: 0x0603E833 RID: 256051 RVA: 0x00F1BF1C File Offset: 0x00F1A11C
		private ActivityTitleTypeA TitleComponent { get; set; }

		// Token: 0x1700908D RID: 37005
		// (get) Token: 0x0603E834 RID: 256052 RVA: 0x00F1BF25 File Offset: 0x00F1A125
		// (set) Token: 0x0603E835 RID: 256053 RVA: 0x00F1BF2D File Offset: 0x00F1A12D
		private ActivityDescriptionTypeA DescriptionComponent { get; set; }

		// Token: 0x1700908E RID: 37006
		// (get) Token: 0x0603E836 RID: 256054 RVA: 0x00F1BF36 File Offset: 0x00F1A136
		// (set) Token: 0x0603E837 RID: 256055 RVA: 0x00F1BF3E File Offset: 0x00F1A13E
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent { get; set; }

		// Token: 0x1700908F RID: 37007
		// (get) Token: 0x0603E838 RID: 256056 RVA: 0x00F1BF47 File Offset: 0x00F1A147
		// (set) Token: 0x0603E839 RID: 256057 RVA: 0x00F1BF4F File Offset: 0x00F1A14F
		private ActivityFunctionalTypeA FunctionalComponent { get; set; }

		// Token: 0x0603E83A RID: 256058 RVA: 0x00F1BF58 File Offset: 0x00F1A158
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

		// Token: 0x0603E83B RID: 256059 RVA: 0x00F1C0AC File Offset: 0x00F1A2AC
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySpring25SubView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySpring25SubView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E83C RID: 256060 RVA: 0x00F1C0F0 File Offset: 0x00F1A2F0
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

		// Token: 0x0603E83D RID: 256061 RVA: 0x00F1C396 File Offset: 0x00F1A596
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

		// Token: 0x0603E83E RID: 256062 RVA: 0x00F1C3BE File Offset: 0x00F1A5BE
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

		// Token: 0x0603E83F RID: 256063 RVA: 0x00F1C3E1 File Offset: 0x00F1A5E1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
		}

		// Token: 0x0603E840 RID: 256064 RVA: 0x00F1C3FF File Offset: 0x00F1A5FF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
		}

		// Token: 0x0603E841 RID: 256065 RVA: 0x00F1C41D File Offset: 0x00F1A61D
		protected override void OnTimer(float delta)
		{
			this.RefreshTimerText();
		}

		// Token: 0x0603E842 RID: 256066 RVA: 0x00F1C428 File Offset: 0x00F1A628
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

		// Token: 0x0603E843 RID: 256067 RVA: 0x00F1C470 File Offset: 0x00F1A670
		private void HandleOnClickConfirm()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivitySpring25Controller.Instance.HandleConfirmClickInActivitySubView();
			});
		}

		// Token: 0x0603E844 RID: 256068 RVA: 0x00F1C4A4 File Offset: 0x00F1A6A4
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

		// Token: 0x0200C2EE RID: 49902
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403ADC3 RID: 241091
			public const int ActivityTitleItem = 0;

			// Token: 0x0403ADC4 RID: 241092
			public const int ActivityDescItem = 1;

			// Token: 0x0403ADC5 RID: 241093
			public const int ActivityRewardItem = 2;

			// Token: 0x0403ADC6 RID: 241094
			public const int ActivityFunctionItem = 3;

			// Token: 0x0403ADC7 RID: 241095
			public const int ProgressText = 4;

			// Token: 0x0403ADC8 RID: 241096
			public const int CurrentNumText = 5;

			// Token: 0x0403ADC9 RID: 241097
			public const int TotalNumText = 6;

			// Token: 0x0403ADCA RID: 241098
			public const int FemaleTexture = 7;

			// Token: 0x0403ADCB RID: 241099
			public const int MaleTexture = 8;
		}
	}
}
