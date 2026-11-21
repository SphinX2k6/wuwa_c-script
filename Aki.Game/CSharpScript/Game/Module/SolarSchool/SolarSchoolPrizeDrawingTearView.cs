using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005935 RID: 22837
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolPrizeDrawingTearView : UiTickViewBase, IKujiTearGamepadHandler
	{
		// Token: 0x17006BD3 RID: 27603
		// (get) Token: 0x0603843D RID: 230461 RVA: 0x00FBB2EB File Offset: 0x00FB94EB
		[Nullable(1)]
		private static SolarSchoolPrizeDrawingCenter Center
		{
			[NullableContext(1)]
			get
			{
				return SolarSchoolPrizeDrawingCenter.Instance;
			}
		}

		// Token: 0x17006BD4 RID: 27604
		// (get) Token: 0x0603843E RID: 230462 RVA: 0x00FBB2F2 File Offset: 0x00FB94F2
		private int ActivityId
		{
			get
			{
				return SolarSchoolPrizeDrawingTearView.Center.CurrentActivityId;
			}
		}

		// Token: 0x0603843F RID: 230463 RVA: 0x00FBB2FE File Offset: 0x00FB94FE
		public bool GetGamepadCanPress()
		{
			return this.GamepadCanPress;
		}

		// Token: 0x06038440 RID: 230464 RVA: 0x00FBB306 File Offset: 0x00FB9506
		public void SetGamepadCanPress(bool value)
		{
			this.GamepadCanPress = value;
			UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		}

		// Token: 0x06038441 RID: 230465 RVA: 0x00FBB319 File Offset: 0x00FB9519
		[NullableContext(1)]
		public SolarSchoolPrizeDrawingTearView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038442 RID: 230466 RVA: 0x00FBB324 File Offset: 0x00FB9524
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

		// Token: 0x06038443 RID: 230467 RVA: 0x00FBB4F8 File Offset: 0x00FB96F8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolPrizeDrawingTearView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolPrizeDrawingTearView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038444 RID: 230468 RVA: 0x00FBB53C File Offset: 0x00FB973C
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
			SolarSchoolPrizeDrawingTearParam solarSchoolPrizeDrawingTearParam = this.OpenParam as SolarSchoolPrizeDrawingTearParam;
			this.CurrentCost = ((solarSchoolPrizeDrawingTearParam != null) ? solarSchoolPrizeDrawingTearParam.FirstCost : SolarSchoolPrizeDrawingTearView.Center.GetCostA());
			this.FirstGacha();
		}

		// Token: 0x06038445 RID: 230469 RVA: 0x00FBB624 File Offset: 0x00FB9824
		protected override void OnBeforeDestroy()
		{
			SolarSchoolGamePlayModel.Instance.SetRewardTipSuppress(false);
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

		// Token: 0x06038446 RID: 230470 RVA: 0x00FBB678 File Offset: 0x00FB9878
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChanged));
		}

		// Token: 0x06038447 RID: 230471 RVA: 0x00FBB6B2 File Offset: 0x00FB98B2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChanged));
		}

		// Token: 0x06038448 RID: 230472 RVA: 0x00FBB6EC File Offset: 0x00FB98EC
		private void OnInputControllerChanged(EInputControllerType oldController, EInputControllerType newController)
		{
			this.IsGamepad = Info.Instance.IsInGamepad();
			if (!this.IsGamepad)
			{
				if (this.State == SolarSchoolPrizeDrawingTearView.EState.Ready)
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

		// Token: 0x06038449 RID: 230473 RVA: 0x00FBB73E File Offset: 0x00FB993E
		public void OnGamepadPress()
		{
			this.IsGamepadHolding = true;
			this.OnStartDragging(null);
		}

		// Token: 0x0603844A RID: 230474 RVA: 0x00FBB74F File Offset: 0x00FB994F
		public void OnGamepadRelease()
		{
			this.IsGamepadHolding = false;
			this.OnStopDragging(null);
		}

		// Token: 0x0603844B RID: 230475 RVA: 0x00FBB760 File Offset: 0x00FB9960
		public void OnGamepadHold(float percent)
		{
			float num = (percent >= 1f) ? 1f : MathUtils.Instance.Lerp(this.CachedProgress, percent, 0.2f);
			this.CachedProgress = num;
			float offsetX = MathUtils.Instance.Lerp(0f, -100f, num);
			this.RotationTick(offsetX, 0f);
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem == null)
			{
				return;
			}
			fadeInTearItem.OnTick(num);
		}

		// Token: 0x0603844C RID: 230476 RVA: 0x00FBB7D0 File Offset: 0x00FB99D0
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
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem == null)
			{
				return;
			}
			fadeInTearItem.OnTick(Math.Max(val, this.CachedProgress));
		}

		// Token: 0x0603844D RID: 230477 RVA: 0x00FBB878 File Offset: 0x00FB9A78
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

		// Token: 0x0603844E RID: 230478 RVA: 0x00FBB92F File Offset: 0x00FB9B2F
		private void FirstGacha()
		{
			this.BeforeGachaRequest();
			this.RefreshTearItemAsync().ContinueWith(new Action(this.AfterGachaRequest));
		}

		// Token: 0x0603844F RID: 230479 RVA: 0x00FBB950 File Offset: 0x00FB9B50
		private UniTask GachaRequest()
		{
			SolarSchoolPrizeDrawingTearView.<GachaRequest>d__36 <GachaRequest>d__;
			<GachaRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GachaRequest>d__.<>4__this = this;
			<GachaRequest>d__.<>1__state = -1;
			<GachaRequest>d__.<>t__builder.Start<SolarSchoolPrizeDrawingTearView.<GachaRequest>d__36>(ref <GachaRequest>d__);
			return <GachaRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06038450 RID: 230480 RVA: 0x00FBB993 File Offset: 0x00FB9B93
		private void BeforeGachaRequest()
		{
			SolarSchoolGamePlayModel.Instance.SetRewardTipSuppress(true);
			this.RefreshByState(SolarSchoolPrizeDrawingTearView.EState.Ready, false);
		}

		// Token: 0x06038451 RID: 230481 RVA: 0x00FBB9A8 File Offset: 0x00FB9BA8
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

		// Token: 0x06038452 RID: 230482 RVA: 0x00FBB9CC File Offset: 0x00FB9BCC
		private UniTask RefreshTearItemAsync()
		{
			SolarSchoolPrizeDrawingTearView.<RefreshTearItemAsync>d__39 <RefreshTearItemAsync>d__;
			<RefreshTearItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTearItemAsync>d__.<>4__this = this;
			<RefreshTearItemAsync>d__.<>1__state = -1;
			<RefreshTearItemAsync>d__.<>t__builder.Start<SolarSchoolPrizeDrawingTearView.<RefreshTearItemAsync>d__39>(ref <RefreshTearItemAsync>d__);
			return <RefreshTearItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038453 RID: 230483 RVA: 0x00FBBA10 File Offset: 0x00FB9C10
		private void OnClickFunctionButton()
		{
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem != null && fadeInTearItem.IsUnOpened())
			{
				return;
			}
			if (SolarSchoolPrizeDrawingTearView.Center.IsAllFinished(this.ActivityId))
			{
				base.CloseMe(null);
				return;
			}
			switch (SolarSchoolPrizeDrawingTearView.Center.ResolveDrawCost())
			{
			case ESolarSchoolDrawCostCheck.UseA:
				this.CurrentCost = SolarSchoolPrizeDrawingTearView.Center.GetCostA();
				this.GachaRequest();
				return;
			case ESolarSchoolDrawCostCheck.NeedConfirmB:
			{
				SolarSchoolCostCurrency costB = SolarSchoolPrizeDrawingTearView.Center.GetCostB();
				SolarSchoolUtils.ShowCostConfirmPopup(SolarSchoolPrizeDrawingTearView.Center.GetCostConfirmId(), costB.Num, delegate
				{
					if (SolarSchoolPrizeDrawingTearView.Center.IsAllFinished(this.ActivityId) || !SolarSchoolPrizeDrawingTearView.Center.HasEnough(SolarSchoolPrizeDrawingTearView.Center.GetCostB()))
					{
						return;
					}
					this.CurrentCost = SolarSchoolPrizeDrawingTearView.Center.GetCostB();
					this.GachaRequest();
				});
				return;
			}
			case ESolarSchoolDrawCostCheck.NotEnough:
				base.CloseMe(null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06038454 RID: 230484 RVA: 0x00FBBAB6 File Offset: 0x00FB9CB6
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038455 RID: 230485 RVA: 0x00FBBAC0 File Offset: 0x00FB9CC0
		private void OnClickSkip()
		{
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem == null || !fadeInTearItem.IsUnOpened())
			{
				return;
			}
			this.FadeInTearItem.SetTearShadowActive(false);
			this.SetGamepadCanPress(false);
			string animName = SolarSchoolTearType2AnimName.GetAnimName(this.LastTearType);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely(animName, true, false, null, null, false);
		}

		// Token: 0x06038456 RID: 230486 RVA: 0x00FBBB22 File Offset: 0x00FB9D22
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "SkipA" || sequenceName == "SkipB" || sequenceName == "SkipC")
			{
				SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
				if (fadeInTearItem == null)
				{
					return;
				}
				fadeInTearItem.Open(false);
			}
		}

		// Token: 0x06038457 RID: 230487 RVA: 0x00FBBB5C File Offset: 0x00FB9D5C
		[NullableContext(1)]
		private void OnOpenAnimationEvent(string param)
		{
			if (param == "Reveal")
			{
				SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
				if (fadeInTearItem == null)
				{
					return;
				}
				fadeInTearItem.PlayRevelAnimation();
			}
		}

		// Token: 0x06038458 RID: 230488 RVA: 0x00FBBB7B File Offset: 0x00FB9D7B
		private bool OnStartDragging(ULGUIPointerEventData data)
		{
			this.IsDragging = true;
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem != null && fadeInTearItem.IsUnOpened())
			{
				this.RefreshByState(SolarSchoolPrizeDrawingTearView.EState.InProgress, true);
				SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem2 = this.FadeInTearItem;
				if (fadeInTearItem2 != null)
				{
					fadeInTearItem2.OnStartDragging();
				}
			}
			return true;
		}

		// Token: 0x06038459 RID: 230489 RVA: 0x00FBBBB2 File Offset: 0x00FB9DB2
		private bool OnStopDragging(ULGUIPointerEventData data)
		{
			this.IsDragging = false;
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			if (fadeInTearItem != null && fadeInTearItem.IsUnOpened())
			{
				this.RefreshByState(SolarSchoolPrizeDrawingTearView.EState.Ready, true);
				SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem2 = this.FadeInTearItem;
				if (fadeInTearItem2 != null)
				{
					fadeInTearItem2.OnStopDragging();
				}
			}
			return true;
		}

		// Token: 0x0603845A RID: 230490 RVA: 0x00FBBBEC File Offset: 0x00FB9DEC
		private void OnTearOpened()
		{
			this.SetGamepadCanPress(false);
			if (this.GetFxLevel() != ESolarSchoolFxLevel.None)
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

		// Token: 0x0603845B RID: 230491 RVA: 0x00FBBCB4 File Offset: 0x00FB9EB4
		private void RefreshButtonText()
		{
			if (SolarSchoolPrizeDrawingTearView.Center.IsAllFinished(this.ActivityId))
			{
				ActivityButtonItem functionButton = this.FunctionButton;
				if (functionButton == null)
				{
					return;
				}
				functionButton.SetShowText("PrefabTextItem_1120255634_Text");
				return;
			}
			else if (!SolarSchoolPrizeDrawingTearView.Center.HaveEnoughCoinToRoll())
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

		// Token: 0x0603845C RID: 230492 RVA: 0x00FBBD20 File Offset: 0x00FB9F20
		private void AfterEndAnimationDelay()
		{
			this.EndDelayTimerHandle = null;
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem = this.FadeInTearItem;
			SolarSchoolPrizeDrawingTearItemBase tearItem = (fadeInTearItem != null) ? fadeInTearItem.GetTearItem() : null;
			SolarSchoolPrizeDrawingTearCoverItemBase fadeOutTearItem = this.FadeOutTearItem;
			if (fadeOutTearItem != null)
			{
				fadeOutTearItem.AttachTearItemToContent(tearItem);
			}
			SolarSchoolPrizeDrawingTearCoverItem fadeInTearItem2 = this.FadeInTearItem;
			if (fadeInTearItem2 != null)
			{
				fadeInTearItem2.SetUiActive(false);
			}
			SolarSchoolPrizeDrawingTearCoverItemBase fadeOutTearItem2 = this.FadeOutTearItem;
			if (fadeOutTearItem2 != null)
			{
				fadeOutTearItem2.SetUiActive(true);
			}
			this.RefreshByState(SolarSchoolPrizeDrawingTearView.EState.End, true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Next", false, false, null, null, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.StopCurrentSequence(false, false);
			}
			SolarSchoolGamePlayModel.Instance.SetRewardTipSuppress(false);
		}

		// Token: 0x0603845D RID: 230493 RVA: 0x00FBBDC8 File Offset: 0x00FB9FC8
		private void RefreshByState(SolarSchoolPrizeDrawingTearView.EState state, bool controlAlpha = true)
		{
			this.State = state;
			this.SetUiActiveNew(base.GetItem(6), state == SolarSchoolPrizeDrawingTearView.EState.Ready && !this.IsGamepad, controlAlpha, null);
			this.SetUiActiveNew(base.GetButton(1).RootUIComp.Get(), state == SolarSchoolPrizeDrawingTearView.EState.Ready, controlAlpha, null);
			this.SetUiActiveNew(base.GetButton(0).RootUIComp.Get(), state == SolarSchoolPrizeDrawingTearView.EState.End, controlAlpha, null);
			this.SetUiActiveNew(this.FunctionButton.GetRootItem(), state == SolarSchoolPrizeDrawingTearView.EState.End, controlAlpha, null);
		}

		// Token: 0x0603845E RID: 230494 RVA: 0x00FBBE74 File Offset: 0x00FBA074
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

		// Token: 0x0603845F RID: 230495 RVA: 0x00FBBEF4 File Offset: 0x00FBA0F4
		private ESolarSchoolFxLevel GetFxLevel()
		{
			ESolarSchoolFxLevel result;
			switch (this.LastTearType)
			{
			case ESolarSchoolTearType.Single:
				result = ESolarSchoolFxLevel.None;
				break;
			case ESolarSchoolTearType.SingleMultiple:
				result = ESolarSchoolFxLevel.Minor;
				break;
			case ESolarSchoolTearType.Double:
				result = ESolarSchoolFxLevel.Minor;
				break;
			case ESolarSchoolTearType.Super:
				result = ESolarSchoolFxLevel.Super;
				break;
			default:
				result = ESolarSchoolFxLevel.None;
				break;
			}
			return result;
		}

		// Token: 0x0401DA23 RID: 121379
		private bool IsDragging;

		// Token: 0x0401DA24 RID: 121380
		private ESolarSchoolTearType LastTearType;

		// Token: 0x0401DA25 RID: 121381
		private SolarSchoolCostCurrency CurrentCost;

		// Token: 0x0401DA26 RID: 121382
		private float CachedProgress;

		// Token: 0x0401DA27 RID: 121383
		private TimerHandle EndDelayTimerHandle;

		// Token: 0x0401DA28 RID: 121384
		private ActivityButtonItem FunctionButton;

		// Token: 0x0401DA29 RID: 121385
		private UUIItem ContentItem;

		// Token: 0x0401DA2A RID: 121386
		private SolarSchoolPrizeDrawingTearCoverItemBase FadeOutTearItem;

		// Token: 0x0401DA2B RID: 121387
		private SolarSchoolPrizeDrawingTearCoverItem FadeInTearItem;

		// Token: 0x0401DA2C RID: 121388
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401DA2D RID: 121389
		private SolarSchoolPrizeDrawingTearView.EState State;

		// Token: 0x0401DA2E RID: 121390
		private bool IsGamepad;

		// Token: 0x0401DA2F RID: 121391
		private bool GamepadCanPress;

		// Token: 0x0401DA30 RID: 121392
		private bool IsGamepadHolding;

		// Token: 0x0200B4EB RID: 46315
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04037EFF RID: 229119
			BtnBack,
			// Token: 0x04037F00 RID: 229120
			BtnSkip,
			// Token: 0x04037F01 RID: 229121
			BtnAgain,
			// Token: 0x04037F02 RID: 229122
			ScrollTear,
			// Token: 0x04037F03 RID: 229123
			TearRoot,
			// Token: 0x04037F04 RID: 229124
			PnlCoin,
			// Token: 0x04037F05 RID: 229125
			ActionTips,
			// Token: 0x04037F06 RID: 229126
			FadeInItem,
			// Token: 0x04037F07 RID: 229127
			FadeOutItem,
			// Token: 0x04037F08 RID: 229128
			NiagaraStand
		}

		// Token: 0x0200B4EC RID: 46316
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04037F0A RID: 229130
			Ready,
			// Token: 0x04037F0B RID: 229131
			InProgress,
			// Token: 0x04037F0C RID: 229132
			End
		}
	}
}
