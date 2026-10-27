using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060CD RID: 24781
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardView : UiViewBase
	{
		// Token: 0x0603EA6F RID: 256623 RVA: 0x00F219F8 File Offset: 0x00F1FBF8
		public SolarSpeedRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EA70 RID: 256624 RVA: 0x00F21A04 File Offset: 0x00F1FC04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EA71 RID: 256625 RVA: 0x00F21A90 File Offset: 0x00F1FC90
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA72 RID: 256626 RVA: 0x00F21AD4 File Offset: 0x00F1FCD4
		protected override void OnStart()
		{
			ISolarSpeedRewardViewData solarSpeedRewardViewData = this.OpenParam as ISolarSpeedRewardViewData;
			this.CaptionItem.SetTitleByTextIdAndArgNew(solarSpeedRewardViewData.TitleTextId, Array.Empty<object>());
			this.CaptionItem.SetTitleIcon(solarSpeedRewardViewData.TitleIconPath);
			this.CaptionItem.SetCloseCallBack(new Action(this.HandleOnCloseClick));
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			this.RefreshByOpenParam();
			this.CaptionPlayer.LitePlayAsync("Start", false, false);
			this.RewardPlayer.LitePlayAsync("Start", false, false);
		}

		// Token: 0x0603EA73 RID: 256627 RVA: 0x00F21B6C File Offset: 0x00F1FD6C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSpeedClickRewardTab, new Action<int>(this.HandleSolarSpeedClickRewardTab));
			EventSystem.Instance.Add(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x0603EA74 RID: 256628 RVA: 0x00F21BD0 File Offset: 0x00F1FDD0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSpeedClickRewardTab, new Action<int>(this.HandleSolarSpeedClickRewardTab));
			EventSystem.Instance.Remove(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x0603EA75 RID: 256629 RVA: 0x00F21C31 File Offset: 0x00F1FE31
		protected override void OnBeforeShow()
		{
			this.CaptionPlayer.LitePlayAsync("Start", false, false);
			this.RewardPlayer.LitePlayAsync("Start", false, false);
		}

		// Token: 0x0603EA76 RID: 256630 RVA: 0x00F21C5C File Offset: 0x00F1FE5C
		protected override UniTask OnBeforeHideAsync()
		{
			SolarSpeedRewardView.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<SolarSpeedRewardView.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA77 RID: 256631 RVA: 0x00F21CA0 File Offset: 0x00F1FEA0
		private void RefreshByOpenParam()
		{
			ISolarSpeedRewardViewData solarSpeedRewardViewData = this.OpenParam as ISolarSpeedRewardViewData;
			this.RewardItem.OpenParam = solarSpeedRewardViewData.RewardPanelData;
			this.RewardItem.RefreshByOpenParam();
		}

		// Token: 0x0603EA78 RID: 256632 RVA: 0x00F21CD5 File Offset: 0x00F1FED5
		private void HandleOnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603EA79 RID: 256633 RVA: 0x00F21CE0 File Offset: 0x00F1FEE0
		private void HandleSolarSpeedClickRewardTab(int id)
		{
			ISolarSpeedRewardViewData solarSpeedRewardViewData = SolarSpeedModel.Instance.BuildSolarSpeedRewardViewDataById(id);
			this.OpenParam = solarSpeedRewardViewData;
			this.RewardItem.OpenParam = solarSpeedRewardViewData.RewardPanelData;
			this.RewardItem.RefreshByOpenParam();
			this.RewardPlayer.LiteStop();
			this.RewardPlayer.LitePlayAsync("Switch", false, false);
		}

		// Token: 0x0603EA7A RID: 256634 RVA: 0x00F21D3C File Offset: 0x00F1FF3C
		private void HandleSolarSpeedRewarded()
		{
			SolarSpeedModel instance = SolarSpeedModel.Instance;
			if (instance.CurrentChosenTabInRewardView == null)
			{
				return;
			}
			this.OpenParam = instance.BuildSolarSpeedRewardViewDataById(instance.CurrentChosenTabInRewardView.Value);
			this.RefreshByOpenParam();
		}

		// Token: 0x0603EA7B RID: 256635 RVA: 0x00F21D80 File Offset: 0x00F1FF80
		private void HandleOnActivitySequenceEmitEvent(string param)
		{
			this.RewardItem.PlayStart(param);
		}

		// Token: 0x04020C12 RID: 134162
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020C13 RID: 134163
		private SolarSpeedRewardPanel RewardItem;

		// Token: 0x04020C14 RID: 134164
		private UiSequencePlayer CaptionPlayer;

		// Token: 0x04020C15 RID: 134165
		private UiSequencePlayer RewardPlayer;

		// Token: 0x0200C31D RID: 49949
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AEA3 RID: 241315
			public const int CaptionItem = 0;

			// Token: 0x0403AEA4 RID: 241316
			public const int RewardItem = 1;

			// Token: 0x0403AEA5 RID: 241317
			public const int PointText = 2;
		}
	}
}
