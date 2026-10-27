using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057FC RID: 22524
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreConfirmButton : UiPanelBase
	{
		// Token: 0x0603943E RID: 234558 RVA: 0x00D944A7 File Offset: 0x00D926A7
		public RewardExploreConfirmButton(AActor rootActor, int buttonIndex)
		{
			this.ButtonIndex = buttonIndex;
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x0603943F RID: 234559 RVA: 0x00D944C0 File Offset: 0x00D926C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039440 RID: 234560 RVA: 0x00D945A8 File Offset: 0x00D927A8
		protected override void OnBeforeDestroy()
		{
			this.RemoveTimeDown();
			this.ButtonData = null;
		}

		// Token: 0x06039441 RID: 234561 RVA: 0x00D945B8 File Offset: 0x00D927B8
		public void Refresh(IRewardExploreConfirmButton buttonData)
		{
			this.ButtonData = buttonData;
			this.SetButtonText(buttonData.ButtonTextId);
			bool flag = !StringUtils.IsEmpty(buttonData.DescriptionTextId);
			this.SetButtonDescriptionVisible(flag);
			if (flag)
			{
				this.RefreshButtonDescription();
			}
		}

		// Token: 0x06039442 RID: 234562 RVA: 0x00D945F8 File Offset: 0x00D927F8
		private void SetButtonText(string textId)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
		}

		// Token: 0x06039443 RID: 234563 RVA: 0x00D9461E File Offset: 0x00D9281E
		private void SetButtonDescriptionVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x06039444 RID: 234564 RVA: 0x00D94634 File Offset: 0x00D92834
		private void RefreshButtonDescription()
		{
			string descriptionTextId = this.ButtonData.DescriptionTextId;
			List<object> descriptionArgs = this.ButtonData.DescriptionArgs;
			int? timeDown = this.ButtonData.TimeDown;
			UUIText text = base.GetText(2);
			int? num = timeDown;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, descriptionTextId, new <>z__ReadOnlySingleElementList<object>(timeDown / TimeUtil.Instance.InverseMillisecond));
				this.RemoveTimeDown();
				this.AddTimeDown(timeDown.Value);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, descriptionTextId, descriptionArgs);
		}

		// Token: 0x06039445 RID: 234565 RVA: 0x00D946F4 File Offset: 0x00D928F4
		private void AddTimeDown(int timeDown)
		{
			if (this.TimeDown == 0)
			{
				this.TimeDown = timeDown / TimeUtil.Instance.InverseMillisecond;
			}
			this.TimeDownTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimeDownRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x06039446 RID: 234566 RVA: 0x00D94744 File Offset: 0x00D92944
		private void RemoveTimeDown()
		{
			if (this.TimeDownTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.TimeDownTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimeDownTimerId);
				this.TimeDownTimerId = null;
			}
		}

		// Token: 0x06039447 RID: 234567 RVA: 0x00D94778 File Offset: 0x00D92978
		private void OnTimeDownRefresh(float _)
		{
			this.TimeDown--;
			if (this.TimeDown <= 0)
			{
				this.RemoveTimeDown();
				if (this.ButtonData.OnTimeDownOnCallback != null)
				{
					this.ButtonData.OnTimeDownOnCallback();
				}
				if (this.ButtonData.IsTimeDownCloseView)
				{
					UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
				}
			}
			string descriptionTextId = this.ButtonData.DescriptionTextId;
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, descriptionTextId, new <>z__ReadOnlySingleElementList<object>(this.TimeDown));
		}

		// Token: 0x06039448 RID: 234568 RVA: 0x00D9480C File Offset: 0x00D92A0C
		private void AddCdTimer(int cdTime)
		{
			this.CdTimeDown = cdTime / TimeUtil.Instance.InverseMillisecond;
			this.CdTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnCdTimeRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x06039449 RID: 234569 RVA: 0x00D94849 File Offset: 0x00D92A49
		private void RemoveCdTimer()
		{
			if (this.CdTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.CdTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CdTimerId);
				this.CdTimerId = null;
			}
		}

		// Token: 0x0603944A RID: 234570 RVA: 0x00D94880 File Offset: 0x00D92A80
		private void OnCdTimeRefresh(float _)
		{
			this.CdTimeDown--;
			if (this.CdTimeDown > 0)
			{
				UUIText text = base.GetText(0);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.ButtonData.ButtonTextId, null);
				string text2 = ConfigMultiTextLang.GetLocalTextNew("OnClickCd", null);
				text2 = StringUtils.Format(text2, new string[]
				{
					this.CdTimeDown.ToString()
				});
				if (text != null)
				{
					text.SetText(localTextNew + text2, true);
				}
				return;
			}
			this.RemoveCdTimer();
			this.SetButtonText(this.ButtonData.ButtonTextId);
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(true);
		}

		// Token: 0x0603944B RID: 234571 RVA: 0x00D94920 File Offset: 0x00D92B20
		private void OnClickedButton()
		{
			Action<int> onClickedCallback = this.ButtonData.OnClickedCallback;
			if (onClickedCallback != null)
			{
				onClickedCallback(this.ButtonIndex);
			}
			int? clickCd = this.ButtonData.ClickCd;
			int? num = clickCd;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				this.AddCdTimer(clickCd.Value);
				UUIButtonComponent button = base.GetButton(3);
				if (button != null)
				{
					button.SetSelfInteractive(false);
				}
				UUIText text = base.GetText(0);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.ButtonData.ButtonTextId, null);
				string text2 = ConfigMultiTextLang.GetLocalTextNew("OnClickCd", null);
				text2 = StringUtils.Format(text2, new string[]
				{
					(clickCd / TimeUtil.Instance.InverseMillisecond).ToString()
				});
				if (text != null)
				{
					text.SetText(localTextNew + text2, true);
				}
			}
			if (this.ButtonData.IsClickedCloseView)
			{
				UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
			}
		}

		// Token: 0x0401DF34 RID: 122676
		[Nullable(2)]
		private IRewardExploreConfirmButton ButtonData;

		// Token: 0x0401DF35 RID: 122677
		private int TimeDown;

		// Token: 0x0401DF36 RID: 122678
		[Nullable(2)]
		private TimerHandle TimeDownTimerId;

		// Token: 0x0401DF37 RID: 122679
		private int CdTimeDown;

		// Token: 0x0401DF38 RID: 122680
		[Nullable(2)]
		private TimerHandle CdTimerId;

		// Token: 0x0401DF39 RID: 122681
		private readonly int ButtonIndex;

		// Token: 0x0200B9F1 RID: 47601
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038369 RID: 230249
			public const int ButtonText = 0;

			// Token: 0x0403836A RID: 230250
			public const int DescriptionItem = 1;

			// Token: 0x0403836B RID: 230251
			public const int DescriptionText = 2;

			// Token: 0x0403836C RID: 230252
			public const int Button = 3;
		}
	}
}
