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
	// Token: 0x02005220 RID: 21024
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityPrizeDrawingTearView : UiTickViewBase, IKujiTearGamepadHandler
	{
		// Token: 0x170065D1 RID: 26065
		// (get) Token: 0x06034519 RID: 214297 RVA: 0x00EA3154 File Offset: 0x00EA1354
		[Nullable(1)]
		private ActivityPrizeDrawingData ActivityData
		{
			[NullableContext(1)]
			get
			{
				return ActivityPrizeDrawingController.Instance.ActivityData;
			}
		}

		// Token: 0x0603451A RID: 214298 RVA: 0x00EA3160 File Offset: 0x00EA1360
		public bool GetGamepadCanPress()
		{
			return this.GamepadCanPress;
		}

		// Token: 0x0603451B RID: 214299 RVA: 0x00EA3168 File Offset: 0x00EA1368
		public void SetGamepadCanPress(bool value)
		{
			this.GamepadCanPress = value;
			UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		}

		// Token: 0x0603451C RID: 214300 RVA: 0x00EA317B File Offset: 0x00EA137B
		[NullableContext(1)]
		public ActivityPrizeDrawingTearView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603451D RID: 214301 RVA: 0x00EA3184 File Offset: 0x00EA1384
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

		// Token: 0x0603451E RID: 214302 RVA: 0x00EA3358 File Offset: 0x00EA1558
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPrizeDrawingTearView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPrizeDrawingTearView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603451F RID: 214303 RVA: 0x00EA339C File Offset: 0x00EA159C
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

		// Token: 0x06034520 RID: 214304 RVA: 0x00EA345C File Offset: 0x00EA165C
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

		// Token: 0x06034521 RID: 214305 RVA: 0x00EA349A File Offset: 0x00EA169A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChanged));
		}

		// Token: 0x06034522 RID: 214306 RVA: 0x00EA34D4 File Offset: 0x00EA16D4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChanged));
		}

		// Token: 0x06034523 RID: 214307 RVA: 0x00EA3510 File Offset: 0x00EA1710
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

		// Token: 0x06034524 RID: 214308 RVA: 0x00EA3562 File Offset: 0x00EA1762
		public void OnGamepadPress()
		{
			this.IsGamepadHolding = true;
			this.OnStartDragging(null);
		}

		// Token: 0x06034525 RID: 214309 RVA: 0x00EA3573 File Offset: 0x00EA1773
		public void OnGamepadRelease()
		{
			this.IsGamepadHolding = false;
			this.OnStopDragging(null);
		}

		// Token: 0x06034526 RID: 214310 RVA: 0x00EA3584 File Offset: 0x00EA1784
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

		// Token: 0x06034527 RID: 214311 RVA: 0x00EA35F4 File Offset: 0x00EA17F4
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

		// Token: 0x06034528 RID: 214312 RVA: 0x00EA369C File Offset: 0x00EA189C
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

		// Token: 0x06034529 RID: 214313 RVA: 0x00EA3753 File Offset: 0x00EA1953
		private void FirstGacha()
		{
			this.BeforeGachaRequest();
			this.RefreshTearItemAsync().ContinueWith(new Action(this.AfterGachaRequest));
		}

		// Token: 0x0603452A RID: 214314 RVA: 0x00EA3774 File Offset: 0x00EA1974
		private UniTask GachaRequest()
		{
			ActivityPrizeDrawingTearView.<GachaRequest>d__33 <GachaRequest>d__;
			<GachaRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GachaRequest>d__.<>4__this = this;
			<GachaRequest>d__.<>1__state = -1;
			<GachaRequest>d__.<>t__builder.Start<ActivityPrizeDrawingTearView.<GachaRequest>d__33>(ref <GachaRequest>d__);
			return <GachaRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603452B RID: 214315 RVA: 0x00EA37B7 File Offset: 0x00EA19B7
		private void BeforeGachaRequest()
		{
			this.RefreshByState(ActivityPrizeDrawingTearView.EState.Ready, false);
		}

		// Token: 0x0603452C RID: 214316 RVA: 0x00EA37C1 File Offset: 0x00EA19C1
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

		// Token: 0x0603452D RID: 214317 RVA: 0x00EA37E4 File Offset: 0x00EA19E4
		private UniTask RefreshTearItemAsync()
		{
			ActivityPrizeDrawingTearView.<RefreshTearItemAsync>d__36 <RefreshTearItemAsync>d__;
			<RefreshTearItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTearItemAsync>d__.<>4__this = this;
			<RefreshTearItemAsync>d__.<>1__state = -1;
			<RefreshTearItemAsync>d__.<>t__builder.Start<ActivityPrizeDrawingTearView.<RefreshTearItemAsync>d__36>(ref <RefreshTearItemAsync>d__);
			return <RefreshTearItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603452E RID: 214318 RVA: 0x00EA3827 File Offset: 0x00EA1A27
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

		// Token: 0x0603452F RID: 214319 RVA: 0x00EA3867 File Offset: 0x00EA1A67
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034530 RID: 214320 RVA: 0x00EA3870 File Offset: 0x00EA1A70
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

		// Token: 0x06034531 RID: 214321 RVA: 0x00EA38D2 File Offset: 0x00EA1AD2
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

		// Token: 0x06034532 RID: 214322 RVA: 0x00EA390C File Offset: 0x00EA1B0C
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

		// Token: 0x06034533 RID: 214323 RVA: 0x00EA392B File Offset: 0x00EA1B2B
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

		// Token: 0x06034534 RID: 214324 RVA: 0x00EA3962 File Offset: 0x00EA1B62
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

		// Token: 0x06034535 RID: 214325 RVA: 0x00EA399C File Offset: 0x00EA1B9C
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

		// Token: 0x06034536 RID: 214326 RVA: 0x00EA3A64 File Offset: 0x00EA1C64
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

		// Token: 0x06034537 RID: 214327 RVA: 0x00EA3ACC File Offset: 0x00EA1CCC
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

		// Token: 0x06034538 RID: 214328 RVA: 0x00EA3B68 File Offset: 0x00EA1D68
		private void RefreshByState(ActivityPrizeDrawingTearView.EState state, bool controlAlpha = true)
		{
			this.State = state;
			this.SetUiActiveNew(base.GetItem(6), state == ActivityPrizeDrawingTearView.EState.Ready && !this.IsGamepad, controlAlpha, null);
			this.SetUiActiveNew(base.GetButton(1).RootUIComp.Get(), state == ActivityPrizeDrawingTearView.EState.Ready, controlAlpha, null);
			this.SetUiActiveNew(base.GetButton(0).RootUIComp.Get(), state == ActivityPrizeDrawingTearView.EState.End, controlAlpha, null);
			this.SetUiActiveNew(this.FunctionButton.GetRootItem(), state == ActivityPrizeDrawingTearView.EState.End, controlAlpha, null);
			this.SetUiActiveNew(base.GetItem(5), state != ActivityPrizeDrawingTearView.EState.InProgress, controlAlpha, null);
		}

		// Token: 0x06034539 RID: 214329 RVA: 0x00EA3C30 File Offset: 0x00EA1E30
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

		// Token: 0x0603453A RID: 214330 RVA: 0x00EA3CB0 File Offset: 0x00EA1EB0
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

		// Token: 0x0401BC81 RID: 113793
		private bool IsDragging;

		// Token: 0x0401BC82 RID: 113794
		private ETearType LastTearType;

		// Token: 0x0401BC83 RID: 113795
		private float CachedProgress;

		// Token: 0x0401BC84 RID: 113796
		private TimerHandle EndDelayTimerHandle;

		// Token: 0x0401BC85 RID: 113797
		private ActivityButtonItem FunctionButton;

		// Token: 0x0401BC86 RID: 113798
		private UUIItem ContentItem;

		// Token: 0x0401BC87 RID: 113799
		private PrizeDrawingTearCoverItemBase FadeOutTearItem;

		// Token: 0x0401BC88 RID: 113800
		private PrizeDrawingTearCoverItem FadeInTearItem;

		// Token: 0x0401BC89 RID: 113801
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401BC8A RID: 113802
		private ActivityPrizeDrawingTearView.EState State;

		// Token: 0x0401BC8B RID: 113803
		private bool IsGamepad;

		// Token: 0x0401BC8C RID: 113804
		private bool GamepadCanPress;

		// Token: 0x0401BC8D RID: 113805
		private bool IsGamepadHolding;

		// Token: 0x0200AE63 RID: 44643
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04035DE6 RID: 220646
			BtnBack,
			// Token: 0x04035DE7 RID: 220647
			BtnSkip,
			// Token: 0x04035DE8 RID: 220648
			BtnAgain,
			// Token: 0x04035DE9 RID: 220649
			ScrollTear,
			// Token: 0x04035DEA RID: 220650
			TearRoot,
			// Token: 0x04035DEB RID: 220651
			PnlCoin,
			// Token: 0x04035DEC RID: 220652
			ActionTips,
			// Token: 0x04035DED RID: 220653
			FadeInItem,
			// Token: 0x04035DEE RID: 220654
			FadeOutItem,
			// Token: 0x04035DEF RID: 220655
			NiagaraStand
		}

		// Token: 0x0200AE64 RID: 44644
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04035DF1 RID: 220657
			Ready,
			// Token: 0x04035DF2 RID: 220658
			InProgress,
			// Token: 0x04035DF3 RID: 220659
			End
		}
	}
}
