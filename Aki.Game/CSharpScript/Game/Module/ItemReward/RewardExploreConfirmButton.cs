using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047D3 RID: 18387
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreConfirmButton : UiPanelBase
	{
		// Token: 0x0602E352 RID: 189266 RVA: 0x00CE32EF File Offset: 0x00CE14EF
		public RewardExploreConfirmButton(AActor rootActor, int buttonIndex)
		{
			this.ButtonIndex = buttonIndex;
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x0602E353 RID: 189267 RVA: 0x00CE3308 File Offset: 0x00CE1508
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

		// Token: 0x0602E354 RID: 189268 RVA: 0x00CE33F0 File Offset: 0x00CE15F0
		protected override void OnBeforeDestroy()
		{
			this.RemoveTimeDown();
			this.ButtonData = null;
		}

		// Token: 0x0602E355 RID: 189269 RVA: 0x00CE3400 File Offset: 0x00CE1600
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

		// Token: 0x0602E356 RID: 189270 RVA: 0x00CE3440 File Offset: 0x00CE1640
		private void SetButtonText(string textId)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
		}

		// Token: 0x0602E357 RID: 189271 RVA: 0x00CE3466 File Offset: 0x00CE1666
		private void SetButtonDescriptionVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0602E358 RID: 189272 RVA: 0x00CE347C File Offset: 0x00CE167C
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

		// Token: 0x0602E359 RID: 189273 RVA: 0x00CE353C File Offset: 0x00CE173C
		private void AddTimeDown(int timeDown)
		{
			if (this.TimeDown == 0)
			{
				this.TimeDown = timeDown / TimeUtil.Instance.InverseMillisecond;
			}
			this.TimeDownTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimeDownRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x0602E35A RID: 189274 RVA: 0x00CE358C File Offset: 0x00CE178C
		private void RemoveTimeDown()
		{
			if (this.TimeDownTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.TimeDownTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimeDownTimerId);
				this.TimeDownTimerId = null;
			}
		}

		// Token: 0x0602E35B RID: 189275 RVA: 0x00CE35C0 File Offset: 0x00CE17C0
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

		// Token: 0x0602E35C RID: 189276 RVA: 0x00CE3654 File Offset: 0x00CE1854
		private void AddCdTimer(int cdTime)
		{
			this.CdTimeDown = cdTime / TimeUtil.Instance.InverseMillisecond;
			this.CdTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnCdTimeRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x0602E35D RID: 189277 RVA: 0x00CE3691 File Offset: 0x00CE1891
		private void RemoveCdTimer()
		{
			if (this.CdTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.CdTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CdTimerId);
				this.CdTimerId = null;
			}
		}

		// Token: 0x0602E35E RID: 189278 RVA: 0x00CE36C8 File Offset: 0x00CE18C8
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

		// Token: 0x0602E35F RID: 189279 RVA: 0x00CE3768 File Offset: 0x00CE1968
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

		// Token: 0x040189CB RID: 100811
		[Nullable(2)]
		private IRewardExploreConfirmButton ButtonData;

		// Token: 0x040189CC RID: 100812
		private int TimeDown;

		// Token: 0x040189CD RID: 100813
		[Nullable(2)]
		private TimerHandle TimeDownTimerId;

		// Token: 0x040189CE RID: 100814
		private int CdTimeDown;

		// Token: 0x040189CF RID: 100815
		[Nullable(2)]
		private TimerHandle CdTimerId;

		// Token: 0x040189D0 RID: 100816
		private readonly int ButtonIndex;

		// Token: 0x0200A407 RID: 41991
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032D56 RID: 208214
			public const int ButtonText = 0;

			// Token: 0x04032D57 RID: 208215
			public const int DescriptionItem = 1;

			// Token: 0x04032D58 RID: 208216
			public const int DescriptionText = 2;

			// Token: 0x04032D59 RID: 208217
			public const int Button = 3;
		}
	}
}
