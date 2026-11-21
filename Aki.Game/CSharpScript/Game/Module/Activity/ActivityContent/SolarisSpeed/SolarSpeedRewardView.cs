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
	// Token: 0x0200504B RID: 20555
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardView : UiViewBase
	{
		// Token: 0x06033733 RID: 210739 RVA: 0x00E687C8 File Offset: 0x00E669C8
		public SolarSpeedRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033734 RID: 210740 RVA: 0x00E687D4 File Offset: 0x00E669D4
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

		// Token: 0x06033735 RID: 210741 RVA: 0x00E68860 File Offset: 0x00E66A60
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033736 RID: 210742 RVA: 0x00E688A4 File Offset: 0x00E66AA4
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

		// Token: 0x06033737 RID: 210743 RVA: 0x00E6893C File Offset: 0x00E66B3C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSpeedClickRewardTab, new Action<int>(this.HandleSolarSpeedClickRewardTab));
			EventSystem.Instance.Add(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x06033738 RID: 210744 RVA: 0x00E689A0 File Offset: 0x00E66BA0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSpeedClickRewardTab, new Action<int>(this.HandleSolarSpeedClickRewardTab));
			EventSystem.Instance.Remove(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x06033739 RID: 210745 RVA: 0x00E68A01 File Offset: 0x00E66C01
		protected override void OnBeforeShow()
		{
			this.CaptionPlayer.LitePlayAsync("Start", false, false);
			this.RewardPlayer.LitePlayAsync("Start", false, false);
		}

		// Token: 0x0603373A RID: 210746 RVA: 0x00E68A2C File Offset: 0x00E66C2C
		protected override UniTask OnBeforeHideAsync()
		{
			SolarSpeedRewardView.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<SolarSpeedRewardView.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603373B RID: 210747 RVA: 0x00E68A70 File Offset: 0x00E66C70
		private void RefreshByOpenParam()
		{
			ISolarSpeedRewardViewData solarSpeedRewardViewData = this.OpenParam as ISolarSpeedRewardViewData;
			this.RewardItem.OpenParam = solarSpeedRewardViewData.RewardPanelData;
			this.RewardItem.RefreshByOpenParam();
		}

		// Token: 0x0603373C RID: 210748 RVA: 0x00E68AA5 File Offset: 0x00E66CA5
		private void HandleOnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603373D RID: 210749 RVA: 0x00E68AB0 File Offset: 0x00E66CB0
		private void HandleSolarSpeedClickRewardTab(int id)
		{
			ISolarSpeedRewardViewData solarSpeedRewardViewData = SolarSpeedModel.Instance.BuildSolarSpeedRewardViewDataById(id);
			this.OpenParam = solarSpeedRewardViewData;
			this.RewardItem.OpenParam = solarSpeedRewardViewData.RewardPanelData;
			this.RewardItem.RefreshByOpenParam();
			this.RewardPlayer.LiteStop();
			this.RewardPlayer.LitePlayAsync("Switch", false, false);
		}

		// Token: 0x0603373E RID: 210750 RVA: 0x00E68B0C File Offset: 0x00E66D0C
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

		// Token: 0x0603373F RID: 210751 RVA: 0x00E68B50 File Offset: 0x00E66D50
		private void HandleOnActivitySequenceEmitEvent(string param)
		{
			this.RewardItem.PlayStart(param);
		}

		// Token: 0x0401B53F RID: 111935
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B540 RID: 111936
		private SolarSpeedRewardPanel RewardItem;

		// Token: 0x0401B541 RID: 111937
		private UiSequencePlayer CaptionPlayer;

		// Token: 0x0401B542 RID: 111938
		private UiSequencePlayer RewardPlayer;

		// Token: 0x0200AD08 RID: 44296
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403580B RID: 219147
			public const int CaptionItem = 0;

			// Token: 0x0403580C RID: 219148
			public const int RewardItem = 1;

			// Token: 0x0403580D RID: 219149
			public const int PointText = 2;
		}
	}
}
