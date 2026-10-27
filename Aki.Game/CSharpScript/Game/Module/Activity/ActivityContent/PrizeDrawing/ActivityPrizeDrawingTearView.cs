using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing
{
	// Token: 0x020062A2 RID: 25250
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityPrizeDrawingTearView : UiTickViewBase
	{
		// Token: 0x1700926F RID: 37487
		// (get) Token: 0x0603F858 RID: 260184 RVA: 0x00F5C1F8 File Offset: 0x00F5A3F8
		[Nullable(1)]
		private ActivityPrizeDrawingData ActivityData
		{
			[NullableContext(1)]
			get
			{
				return ActivityPrizeDrawingController.Instance.ActivityData;
			}
		}

		// Token: 0x0603F859 RID: 260185 RVA: 0x00F5C204 File Offset: 0x00F5A404
		public bool GetGamepadCanPress()
		{
			return this.GamepadCanPress;
		}

		// Token: 0x0603F85A RID: 260186 RVA: 0x00F5C20C File Offset: 0x00F5A40C
		public void SetGamepadCanPress(bool value)
		{
			this.GamepadCanPress = value;
			UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		}

		// Token: 0x0603F85B RID: 260187 RVA: 0x00F5C21F File Offset: 0x00F5A41F
		[NullableContext(1)]
		public ActivityPrizeDrawingTearView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F85C RID: 260188 RVA: 0x00F5C228 File Offset: 0x00F5A428
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBack));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickSkip));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F85D RID: 260189 RVA: 0x00F5C3FC File Offset: 0x00F5A5FC
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPrizeDrawingTearView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPrizeDrawingTearView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F85E RID: 260190 RVA: 0x00F5C440 File Offset: 0x00F5A640
		protected override void OnStart()
		{
			this.ContentItem = base.GetItem(4);
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnStartDragging));
			}
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnStopDragging));
			}
			ActivityButtonItem functionButton = this.FunctionButton;
			if (functionButton != null)
			{
				functionButton.SetFunction(new Action(this.OnClickFunctionButton));
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.OnInputControllerChanged(Info.Instance.InputControllerType, Info.Instance.InputControllerType);
			this.FirstGacha();
		}

		// Token: 0x0603F85F RID: 260191 RVA: 0x00F5C500 File Offset: 0x00F5A700
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			if (this.EndDelayTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.EndDelayTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.EndDelayTimerHandle);
			}
		}

		// Token: 0x0603F860 RID: 260192 RVA: 0x00F5C53E File Offset: 0x00F5A73E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChanged));
		}

		// Token: 0x0603F861 RID: 260193 RVA: 0x00F5C578 File Offset: 0x00F5A778
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChanged));
		}

		// Token: 0x0603F862 RID: 260194 RVA: 0x00F5C5B4 File Offset: 0x00F5A7B4
		private void OnInputControllerChanged(EInputControllerType oldController, EInputControllerType newController)
		{
			this.IsGamepad = Info.Instance.IsInGamepad();
			if (!this.IsGamepad)
			{
				if (this.State == ActivityPrizeDrawingTearView.EState.Ready)
				{
					UUIItem item = base.GetItem(6);
					if (item == null)
					{
						return;
					}
					item.SetUIActive(true);
				}
				return;
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0603F863 RID: 260195 RVA: 0x00F5C606 File Offset: 0x00F5A806
		public void OnGamepadPress()
		{
			this.IsGamepadHolding = true;
			this.OnStartDragging(null);
		}

		// Token: 0x0603F864 RID: 260196 RVA: 0x00F5C617 File Offset: 0x00F5A817
		public void OnGamepadRelease()
		{
			this.IsGamepadHolding = false;
			this.OnStopDragging(null);
		}

		// Token: 0x0603F865 RID: 260197 RVA: 0x00F5C628 File Offset: 0x00F5A828
		public void OnGamepadHold(float percent)
		{
			float num = (percent >= 1f) ? 1f : MathUtils.Instance.Lerp(this.CachedProgress, percent, 0.2f);
			this.CachedProgress = num;
			float offsetX = MathUtils.Instance.Lerp(0f, -100f, num);
			this.RotationTick(offsetX, 0f);
			PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem == null)
			{
				return;
			}
			fadeInTearItem.OnTick(num);
		}

		// Token: 0x0603F866 RID: 260198 RVA: 0x00F5C698 File Offset: 0x00F5A898
		protected override void OnTick(float delta)
		{
			if (this.IsGamepadHolding)
			{
				return;
			}
			this.CachedProgress = MathUtils.Instance.Lerp(this.CachedProgress, 0f, 0.2f);
			float anchorOffsetX = this.ContentItem.GetAnchorOffsetX();
			float anchorOffsetY = this.ContentItem.GetAnchorOffsetY();
			this.RotationTick(anchorOffsetX, anchorOffsetY);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) != null)
			{
				return;
			}
			float val = MathUtils.Instance.Clamp(-anchorOffsetX / 110f, 0f, 1f);
			PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem == null)
			{
				return;
			}
			fadeInTearItem.OnTick(Math.Max(val, this.CachedProgress));
		}

		// Token: 0x0603F867 RID: 260199 RVA: 0x00F5C740 File Offset: 0x00F5A940
		private void RotationTick(float offsetX, float offsetY)
		{
			FRotator relativeRotation = this.ContentItem.RelativeRotation;
			float currentValue = 0f;
			float currentValue2 = 0f;
			if (this.IsDragging)
			{
				currentValue2 = -offsetY / 10f;
				currentValue = offsetX / 10f;
			}
			float to = MathUtils.Instance.Clamp(currentValue, -20f, 20f);
			float to2 = MathUtils.Instance.Clamp(currentValue2, -20f, 20f);
			relativeRotation.Roll = MathUtils.Instance.Lerp(relativeRotation.Roll, to2, 0.4f);
			relativeRotation.Pitch = MathUtils.Instance.Lerp(relativeRotation.Pitch, to, 0.4f);
			this.ContentItem.SetUIRelativeRotation(relativeRotation);
		}

		// Token: 0x0603F868 RID: 260200 RVA: 0x00F5C7F7 File Offset: 0x00F5A9F7
		private void FirstGacha()
		{
			this.BeforeGachaRequest();
			this.RefreshTearItemAsync().ContinueWith(new Action(this.AfterGachaRequest));
		}

		// Token: 0x0603F869 RID: 260201 RVA: 0x00F5C818 File Offset: 0x00F5AA18
		private UniTask GachaRequest()
		{
			ActivityPrizeDrawingTearView.<GachaRequest>d__33 <GachaRequest>d__;
			<GachaRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GachaRequest>d__.<>4__this = this;
			<GachaRequest>d__.<>1__state = -1;
			<GachaRequest>d__.<>t__builder.Start<ActivityPrizeDrawingTearView.<GachaRequest>d__33>(ref <GachaRequest>d__);
			return <GachaRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603F86A RID: 260202 RVA: 0x00F5C85B File Offset: 0x00F5AA5B
		private void BeforeGachaRequest()
		{
			this.RefreshByState(ActivityPrizeDrawingTearView.EState.Ready, false);
		}

		// Token: 0x0603F86B RID: 260203 RVA: 0x00F5C865 File Offset: 0x00F5AA65
		private void AfterGachaRequest()
		{
			this.SetGamepadCanPress(true);
			this.RefreshButtonText();
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603F86C RID: 260204 RVA: 0x00F5C888 File Offset: 0x00F5AA88
		private UniTask RefreshTearItemAsync()
		{
			ActivityPrizeDrawingTearView.<RefreshTearItemAsync>d__36 <RefreshTearItemAsync>d__;
			<RefreshTearItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTearItemAsync>d__.<>4__this = this;
			<RefreshTearItemAsync>d__.<>1__state = -1;
			<RefreshTearItemAsync>d__.<>t__builder.Start<ActivityPrizeDrawingTearView.<RefreshTearItemAsync>d__36>(ref <RefreshTearItemAsync>d__);
			return <RefreshTearItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F86D RID: 260205 RVA: 0x00F5C8CB File Offset: 0x00F5AACB
		private void OnClickFunctionButton()
		{
			PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem != null && fadeInTearItem.IsUnOpened())
			{
				return;
			}
			if (this.ActivityData.IsAllFinished() || !this.ActivityData.HaveEnoughCoinToRoll())
			{
				base.CloseMe(null);
				return;
			}
			this.GachaRequest();
		}

		// Token: 0x0603F86E RID: 260206 RVA: 0x00F5C90B File Offset: 0x00F5AB0B
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603F86F RID: 260207 RVA: 0x00F5C914 File Offset: 0x00F5AB14
		private void OnClickSkip()
		{
			PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem == null || !fadeInTearItem.IsUnOpened())
			{
				return;
			}
			this.FadeInTearItem.SetTearShadowActive(false);
			this.SetGamepadCanPress(false);
			string animName = TearType2AnimName.GetAnimName(this.LastTearType);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely(animName, true, false, null, null, false);
		}

		// Token: 0x0603F870 RID: 260208 RVA: 0x00F5C976 File Offset: 0x00F5AB76
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "SkipA" || sequenceName == "SkipB" || sequenceName == "SkipC")
			{
				PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
				if (fadeInTearItem == null)
				{
					return;
				}
				fadeInTearItem.Open(false);
			}
		}

		// Token: 0x0603F871 RID: 260209 RVA: 0x00F5C9B0 File Offset: 0x00F5ABB0
		[NullableContext(1)]
		private void OnOpenAnimationEvent(string param)
		{
			if (param == "Reveal")
			{
				PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
				if (fadeInTearItem == null)
				{
					return;
				}
				fadeInTearItem.PlayRevelAnimation();
			}
		}

		// Token: 0x0603F872 RID: 260210 RVA: 0x00F5C9CF File Offset: 0x00F5ABCF
		private bool OnStartDragging(ULGUIPointerEventData data)
		{
			this.IsDragging = true;
			PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem != null && fadeInTearItem.IsUnOpened())
			{
				this.RefreshByState(ActivityPrizeDrawingTearView.EState.InProgress, true);
				PrizeDrawingTearCoverItem fadeInTearItem2 = this.FadeInTearItem;
				if (fadeInTearItem2 != null)
				{
					fadeInTearItem2.OnStartDragging();
				}
			}
			return true;
		}

		// Token: 0x0603F873 RID: 260211 RVA: 0x00F5CA06 File Offset: 0x00F5AC06
		private bool OnStopDragging(ULGUIPointerEventData data)
		{
			this.IsDragging = false;
			PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem != null && fadeInTearItem.IsUnOpened())
			{
				this.RefreshByState(ActivityPrizeDrawingTearView.EState.Ready, true);
				PrizeDrawingTearCoverItem fadeInTearItem2 = this.FadeInTearItem;
				if (fadeInTearItem2 != null)
				{
					fadeInTearItem2.OnStopDragging();
				}
			}
			return true;
		}

		// Token: 0x0603F874 RID: 260212 RVA: 0x00F5CA40 File Offset: 0x00F5AC40
		private void OnTearOpened()
		{
			this.SetGamepadCanPress(false);
			if (this.GetFxLevel() != EFxLevel.None)
			{
				UUIItem item = base.GetItem(9);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.SetUiActiveNew(this.FadeInTearItem.GetFxControl(), false, true, new float?(0.5f));
				this.SetUiActiveNew(this.FadeInTearItem.GetFxControlMinor(), false, true, new float?(0.5f));
				if (this.EndDelayTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.EndDelayTimerHandle))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.EndDelayTimerHandle);
				}
				this.EndDelayTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.AfterEndAnimationDelay();
				}, 500f, null, null, true, 1f);
				return;
			}
			this.AfterEndAnimationDelay();
		}

		// Token: 0x0603F875 RID: 260213 RVA: 0x00F5CB08 File Offset: 0x00F5AD08
		private void RefreshButtonText()
		{
			if (this.ActivityData.IsAllFinished())
			{
				ActivityButtonItem functionButton = this.FunctionButton;
				if (functionButton == null)
				{
					return;
				}
				functionButton.SetShowText("PrefabTextItem_1120255634_Text");
				return;
			}
			else if (!this.ActivityData.HaveEnoughCoinToRoll())
			{
				ActivityButtonItem functionButton2 = this.FunctionButton;
				if (functionButton2 == null)
				{
					return;
				}
				functionButton2.SetShowText("Ichiban_Kuji_confirm");
				return;
			}
			else
			{
				ActivityButtonItem functionButton3 = this.FunctionButton;
				if (functionButton3 == null)
				{
					return;
				}
				functionButton3.SetShowText("Ichiban_Kuji_TearAgain");
				return;
			}
		}

		// Token: 0x0603F876 RID: 260214 RVA: 0x00F5CB70 File Offset: 0x00F5AD70
		private void AfterEndAnimationDelay()
		{
			this.EndDelayTimerHandle = null;
			PrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			PrizeDrawingTearItemBase tearItem = (fadeInTearItem != null) ? fadeInTearItem.GetTearItem() : null;
			PrizeDrawingTearCoverItemBase fadeOutTearItem = this.FadeOutTearItem;
			if (fadeOutTearItem != null)
			{
				fadeOutTearItem.AttachTearItemToContent(tearItem);
			}
			PrizeDrawingTearCoverItem fadeInTearItem2 = this.FadeInTearItem;
			if (fadeInTearItem2 != null)
			{
				fadeInTearItem2.SetUiActive(false);
			}
			PrizeDrawingTearCoverItemBase fadeOutTearItem2 = this.FadeOutTearItem;
			if (fadeOutTearItem2 != null)
			{
				fadeOutTearItem2.SetUiActive(true);
			}
			this.RefreshByState(ActivityPrizeDrawingTearView.EState.End, true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Next", false, false, null, null, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.StopCurrentSequence(false, false);
		}

		// Token: 0x0603F877 RID: 260215 RVA: 0x00F5CC0C File Offset: 0x00F5AE0C
		private void RefreshByState(ActivityPrizeDrawingTearView.EState state, bool controlAlpha = true)
		{
			this.State = state;
			this.SetUiActiveNew(base.GetItem(6), state == ActivityPrizeDrawingTearView.EState.Ready && !this.IsGamepad, controlAlpha, null);
			this.SetUiActiveNew(base.GetButton(1).RootUIComp.Get(), state == ActivityPrizeDrawingTearView.EState.Ready, controlAlpha, null);
			this.SetUiActiveNew(base.GetButton(0).RootUIComp.Get(), state == ActivityPrizeDrawingTearView.EState.End, controlAlpha, null);
			this.SetUiActiveNew(this.FunctionButton.GetRootItem(), state == ActivityPrizeDrawingTearView.EState.End, controlAlpha, null);
			this.SetUiActiveNew(base.GetItem(5), state != ActivityPrizeDrawingTearView.EState.InProgress, controlAlpha, null);
		}

		// Token: 0x0603F878 RID: 260216 RVA: 0x00F5CCD4 File Offset: 0x00F5AED4
		[NullableContext(1)]
		private void SetUiActiveNew(UUIItem uiItem, bool active, bool controlAlpha, float? overrideDuration = null)
		{
			if (controlAlpha)
			{
				float endValue = active ? 1f : 0f;
				bool flag = !uiItem.IsUIActiveInHierarchy() && active;
				if (flag)
				{
					uiItem.SetUIActive(true);
				}
				uiItem.PlayUIItemAlphaTween(flag ? 0f : uiItem.GetAlpha(), endValue, overrideDuration.GetValueOrDefault(0.2f));
			}
			else
			{
				uiItem.SetUIActive(active);
				uiItem.SetAlpha(active ? 1f : 0f);
			}
			uiItem.SetRaycastTarget(active);
		}

		// Token: 0x0603F879 RID: 260217 RVA: 0x00F5CD54 File Offset: 0x00F5AF54
		private EFxLevel GetFxLevel()
		{
			EFxLevel result;
			switch (this.LastTearType)
			{
			case ETearType.Single:
				result = EFxLevel.None;
				break;
			case ETearType.SingleMultiple:
				result = EFxLevel.Minor;
				break;
			case ETearType.Double:
				result = EFxLevel.Minor;
				break;
			case ETearType.Super:
				result = EFxLevel.Super;
				break;
			default:
				result = EFxLevel.None;
				break;
			}
			return result;
		}

		// Token: 0x04021352 RID: 136018
		private bool IsDragging;

		// Token: 0x04021353 RID: 136019
		private ETearType LastTearType;

		// Token: 0x04021354 RID: 136020
		private float CachedProgress;

		// Token: 0x04021355 RID: 136021
		private TimerHandle EndDelayTimerHandle;

		// Token: 0x04021356 RID: 136022
		private ActivityButtonItem FunctionButton;

		// Token: 0x04021357 RID: 136023
		private UUIItem ContentItem;

		// Token: 0x04021358 RID: 136024
		private PrizeDrawingTearCoverItemBase FadeOutTearItem;

		// Token: 0x04021359 RID: 136025
		private PrizeDrawingTearCoverItem FadeInTearItem;

		// Token: 0x0402135A RID: 136026
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0402135B RID: 136027
		private ActivityPrizeDrawingTearView.EState State;

		// Token: 0x0402135C RID: 136028
		private bool IsGamepad;

		// Token: 0x0402135D RID: 136029
		private bool GamepadCanPress;

		// Token: 0x0402135E RID: 136030
		private bool IsGamepadHolding;

		// Token: 0x0200C47C RID: 50300
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x0403B484 RID: 242820
			BtnBack,
			// Token: 0x0403B485 RID: 242821
			BtnSkip,
			// Token: 0x0403B486 RID: 242822
			BtnAgain,
			// Token: 0x0403B487 RID: 242823
			ScrollTear,
			// Token: 0x0403B488 RID: 242824
			TearRoot,
			// Token: 0x0403B489 RID: 242825
			PnlCoin,
			// Token: 0x0403B48A RID: 242826
			ActionTips,
			// Token: 0x0403B48B RID: 242827
			FadeInItem,
			// Token: 0x0403B48C RID: 242828
			FadeOutItem,
			// Token: 0x0403B48D RID: 242829
			NiagaraStand
		}

		// Token: 0x0200C47D RID: 50301
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403B48F RID: 242831
			Ready,
			// Token: 0x0403B490 RID: 242832
			InProgress,
			// Token: 0x0403B491 RID: 242833
			End
		}
	}
}
