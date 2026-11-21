using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A78 RID: 23160
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelView : SolarSchoolChildViewBase, IVisualNovelView
	{
		// Token: 0x17006CC0 RID: 27840
		// (get) Token: 0x060390FE RID: 233726 RVA: 0x00FFB06B File Offset: 0x00FF926B
		public VisualNovelTransform CgTransform
		{
			get
			{
				return this.CgMotion.Transform;
			}
		}

		// Token: 0x17006CC1 RID: 27841
		// (get) Token: 0x060390FF RID: 233727 RVA: 0x00FFB078 File Offset: 0x00FF9278
		public bool IsTyping
		{
			get
			{
				SolarSchoolVisualNovelCenterTextView centerTextView = this.CenterTextView;
				if (centerTextView == null || !centerTextView.IsTyping)
				{
					SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
					return dialogueItem != null && dialogueItem.IsTyping;
				}
				return true;
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06039100 RID: 233728 RVA: 0x00FFB0A4 File Offset: 0x00FF92A4
		// (remove) Token: 0x06039101 RID: 233729 RVA: 0x00FFB0DC File Offset: 0x00FF92DC
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action ContinueRequested;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06039102 RID: 233730 RVA: 0x00FFB114 File Offset: 0x00FF9314
		// (remove) Token: 0x06039103 RID: 233731 RVA: 0x00FFB14C File Offset: 0x00FF934C
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action<int> ChoiceSelected;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06039104 RID: 233732 RVA: 0x00FFB184 File Offset: 0x00FF9384
		// (remove) Token: 0x06039105 RID: 233733 RVA: 0x00FFB1BC File Offset: 0x00FF93BC
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action AutoPlayRequested;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06039106 RID: 233734 RVA: 0x00FFB1F4 File Offset: 0x00FF93F4
		// (remove) Token: 0x06039107 RID: 233735 RVA: 0x00FFB22C File Offset: 0x00FF942C
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action FastForwardStarted;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06039108 RID: 233736 RVA: 0x00FFB264 File Offset: 0x00FF9464
		// (remove) Token: 0x06039109 RID: 233737 RVA: 0x00FFB29C File Offset: 0x00FF949C
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action FastForwardEnded;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0603910A RID: 233738 RVA: 0x00FFB2D4 File Offset: 0x00FF94D4
		// (remove) Token: 0x0603910B RID: 233739 RVA: 0x00FFB30C File Offset: 0x00FF950C
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action UltraFastForwardRequested;

		// Token: 0x0603910C RID: 233740 RVA: 0x00FFB344 File Offset: 0x00FF9544
		protected unsafe override void OnRegisterComponent()
		{
			int num = 23;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnAutoButtonClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnReviewButtonClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnMenuButtonClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnHideUiButtonClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnUltraFastForwardButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603910D RID: 233741 RVA: 0x00FFB73C File Offset: 0x00FF993C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolVisualNovelView.<OnBeforeStartAsync>d__87 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<OnBeforeStartAsync>d__87>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603910E RID: 233742 RVA: 0x00FFB780 File Offset: 0x00FF9980
		protected override void OnStart()
		{
			this.SequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnSequenceStarted));
			UUIButtonComponent button = base.GetButton(6);
			button.OnPointDownCallBack.Bind(new Action(this.OnAccelerateButtonPressed));
			button.OnPointUpCallBack.Bind(new Action(this.OnAccelerateButtonReleased));
			button.OnPointCancelCallBack.Bind(new Action(this.OnAccelerateButtonReleased));
			this.CgBlur = (TsUiBlur)base.GetRootItem().GetOwner().GetComponentByClass(TsUiBlur.StaticClass());
			this.CgBlur.ApplyItem = base.GetRootItem();
			((UUIItem)base.GetSpine(15).GetOwner().GetComponentByClass(UUIItem.StaticClass())).SetUIActive(false);
		}

		// Token: 0x0603910F RID: 233743 RVA: 0x00FFB84C File Offset: 0x00FF9A4C
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			SolarSchoolVisualNovelView.<OnPlayingStartSequenceAsync>d__89 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<OnPlayingStartSequenceAsync>d__89>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039110 RID: 233744 RVA: 0x00FFB88F File Offset: 0x00FF9A8F
		public override void OnReopen()
		{
			this.EnsureOpeningPreparedAsync();
		}

		// Token: 0x06039111 RID: 233745 RVA: 0x00FFB898 File Offset: 0x00FF9A98
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			SolarSchoolVisualNovelView.<OnBeforeShowAsyncImplement>d__91 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<OnBeforeShowAsyncImplement>d__91>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06039112 RID: 233746 RVA: 0x00FFB8DB File Offset: 0x00FF9ADB
		protected override UniTask OnPlayingShowSequenceAsync()
		{
			if (this.SkipStartSequence)
			{
				this.SequencePlayer.StopSequenceByKey("ShowView", true, true);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06039113 RID: 233747 RVA: 0x00FFB8FC File Offset: 0x00FF9AFC
		protected override void OnBeforeShow()
		{
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			float? playbackRate = (visualNovelContext != null) ? new float?(visualNovelContext.PlaybackRate) : null;
			VisualNovelContext visualNovelContext2 = this.VisualNovelContext;
			this.SetSequencePlayback(playbackRate, visualNovelContext2 != null && visualNovelContext2.IsPaused);
		}

		// Token: 0x06039114 RID: 233748 RVA: 0x00FFB940 File Offset: 0x00FF9B40
		protected override void OnBeforeHide()
		{
			this.IsFastForwardHeld = false;
			this.ReplayFastForwardOnPlayerBind = false;
			this.SetSequencePlayback(null, false);
		}

		// Token: 0x06039115 RID: 233749 RVA: 0x00FFB96C File Offset: 0x00FF9B6C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewBegined, new Action<EUiViewName>(this.OnMenuViewOpening));
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OnMenuViewOpenFailed));
			EventSystem.Instance.Add<EUiViewName, UiViewBase>(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnMenuViewOpened));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnMenuViewClosed));
			this.OpenedMenuViewIds.RemoveWhere((int viewId) => UiManager.Instance.GetView(viewId) == null);
			this.TryResumeAfterMenuClosed();
		}

		// Token: 0x06039116 RID: 233750 RVA: 0x00FFBA10 File Offset: 0x00FF9C10
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewBegined, new Action<EUiViewName>(this.OnMenuViewOpening));
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OnMenuViewOpenFailed));
			EventSystem.Instance.Remove<EUiViewName, UiViewBase>(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnMenuViewOpened));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnMenuViewClosed));
		}

		// Token: 0x06039117 RID: 233751 RVA: 0x00FFBA84 File Offset: 0x00FF9C84
		private void ApplyContext(VisualNovelContext context)
		{
			if (this.VisualNovelContext != context)
			{
				this.IsUltraFastForwardConfirmPending = false;
			}
			this.ClearScreenEffects();
			base.ClearPresentFinished();
			this.ResetHiddenUiState();
			this.CloseCenterTextView();
			this.HideChoices();
			this.HideCharacterIntroduction();
			this.VisualNovelContext = context;
			this.ScreenEffects = new VisualNovelScreenEffects(this, this.VisualNovelContext);
			this.SetDialogueVisible(this.VisualNovelContext.DialogueVisible);
			this.SetAutoButtonVisible(this.VisualNovelContext.AutoButtonVisible);
			this.SetReviewButtonVisible(this.VisualNovelContext.ReviewButtonVisible);
			this.SetMenuButtonVisible(this.VisualNovelContext.MenuButtonVisible);
			this.SetAccelerateButtonVisible(this.VisualNovelContext.AccelerateButtonVisible);
			this.SetHideUiButtonVisible(this.VisualNovelContext.HideUiButtonVisible);
			this.SetUltraFastForwardButtonVisible(this.VisualNovelContext.UltraFastForwardButtonVisible);
			this.SetPlaybackMode(this.VisualNovelContext.PlaybackMode);
			this.SetPlaybackRate(this.VisualNovelContext.PlaybackRate);
			this.SetPaused(this.VisualNovelContext.IsPaused);
			this.SetInputLocked(this.VisualNovelContext.IsInputLocked);
			this.SetAssetCache(this.VisualNovelContext.Assets);
			this.HideCgImmediately();
			this.DestroyPreparedCgPrefab();
			this.ReplayFastForwardOnPlayerBind = true;
		}

		// Token: 0x06039118 RID: 233752 RVA: 0x00FFBBC0 File Offset: 0x00FF9DC0
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			SolarSchoolVisualNovelView.<OnPlayingCloseSequenceAsync>d__98 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<OnPlayingCloseSequenceAsync>d__98>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039119 RID: 233753 RVA: 0x00FFBC04 File Offset: 0x00FF9E04
		protected override void OnBeforeDestroy()
		{
			this.IsUltraFastForwardConfirmPending = false;
			this.IsFastForwardHeld = false;
			this.ReplayFastForwardOnPlayerBind = false;
			this.ClearScreenEffects();
			this.ScreenEffects = null;
			this.SetInputLocked(false);
			this.CloseCenterTextView();
			this.HideChoices();
			UUIButtonComponent button = base.GetButton(6);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
			button.OnPointCancelCallBack.Unbind();
			if (this.DialogueItem != null)
			{
				this.DialogueItem.ContinueRequested -= this.OnDialogueContinueRequested;
			}
			this.ContinueRequested = null;
			this.ChoiceSelected = null;
			this.AutoPlayRequested = null;
			this.FastForwardStarted = null;
			this.FastForwardEnded = null;
			this.UltraFastForwardRequested = null;
			this.DialogueItem = null;
			this.CenterTextView = null;
			this.CharacterIntroduceItem = null;
			this.NormalChoiceLayout = null;
			this.HideCgImmediately();
			this.DestroyPreparedCgPrefab();
			SolarSchoolRootView solarSchoolRootView = this.RootView as SolarSchoolRootView;
			if (solarSchoolRootView != null)
			{
				solarSchoolRootView.SetVisualNovelDateVisible(true);
			}
			this.CgBlur = null;
			this.AssetCache = null;
			this.VisualNovelContext = null;
			this.PlaybackRate = 1f;
			this.IsPaused = false;
			this.IsInputLocked = false;
			this.CharacterIntroductionVisible = false;
			this.CharacterIntroductionVersion = 0;
			this.OpenedMenuViewIds.Clear();
			this.IsPausedByMenu = false;
			this.FullScreenChoicesVisible = false;
			this.IsUiHidden = false;
			this.AutoButtonVisible = false;
			this.ReviewButtonVisible = false;
			this.MenuButtonVisible = false;
			this.AccelerateButtonVisible = false;
			this.HideUiButtonVisible = false;
			this.UltraFastForwardButtonVisible = false;
			this.DialogueVisible = false;
			this.DialogueVisibilityVersion = 0;
			this.CgDisplayType = ECgDisplayType.None;
		}

		// Token: 0x0603911A RID: 233754 RVA: 0x00FFBD90 File Offset: 0x00FF9F90
		public void SetAssetCache(VisualNovelAssetCache assetCache)
		{
			this.AssetCache = assetCache;
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetAssetCache(assetCache);
		}

		// Token: 0x0603911B RID: 233755 RVA: 0x00FFBDAC File Offset: 0x00FF9FAC
		public void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = Math.Max(playbackRate, 0.01f);
			SolarSchoolVisualNovelCenterTextView centerTextView = this.CenterTextView;
			if (centerTextView != null)
			{
				centerTextView.SetPlaybackRate(this.PlaybackRate);
			}
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem != null)
			{
				dialogueItem.SetPlaybackRate(this.PlaybackRate);
			}
			SolarSchoolVisualNovelChoiceView choiceView = this.ChoiceView;
			if (choiceView != null)
			{
				choiceView.SetPlaybackRate(this.PlaybackRate);
			}
			SolarSchoolVisualNovelHighCgItem cgPrefabItem = this.CgPrefabItem;
			if (cgPrefabItem != null)
			{
				cgPrefabItem.SetPlaybackRate(this.PlaybackRate);
			}
			this.CgMotion.SetPlaybackRate(this.PlaybackRate);
			VisualNovelScreenEffects screenEffects = this.ScreenEffects;
			if (screenEffects != null)
			{
				screenEffects.SetPlaybackRate(this.PlaybackRate);
			}
			this.SetSequencePlayback(new float?(this.PlaybackRate), this.IsPaused);
		}

		// Token: 0x0603911C RID: 233756 RVA: 0x00FFBE68 File Offset: 0x00FFA068
		public void SetPaused(bool paused)
		{
			this.IsPaused = paused;
			SolarSchoolVisualNovelCenterTextView centerTextView = this.CenterTextView;
			if (centerTextView != null)
			{
				centerTextView.SetPaused(paused);
			}
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem != null)
			{
				dialogueItem.SetPaused(paused);
			}
			SolarSchoolVisualNovelChoiceView choiceView = this.ChoiceView;
			if (choiceView != null)
			{
				choiceView.SetPaused(paused);
			}
			SolarSchoolVisualNovelHighCgItem cgPrefabItem = this.CgPrefabItem;
			if (cgPrefabItem != null)
			{
				cgPrefabItem.SetPaused(paused);
			}
			this.CgMotion.SetPaused(paused);
			VisualNovelScreenEffects screenEffects = this.ScreenEffects;
			if (screenEffects != null)
			{
				screenEffects.SetPaused(paused);
			}
			this.SetSequencePlayback(new float?(this.PlaybackRate), this.IsPaused);
		}

		// Token: 0x0603911D RID: 233757 RVA: 0x00FFBEF9 File Offset: 0x00FFA0F9
		public void SetAvatarConfig(int speakerId, IVisualNovelRoleConfig roleConfig)
		{
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetAvatarConfig(speakerId, roleConfig);
		}

		// Token: 0x0603911E RID: 233758 RVA: 0x00FFBF10 File Offset: 0x00FFA110
		public UniTask ShowTextAsync(VisualNovelItem item, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelView.<ShowTextAsync>d__104 <ShowTextAsync>d__;
			<ShowTextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowTextAsync>d__.<>4__this = this;
			<ShowTextAsync>d__.item = item;
			<ShowTextAsync>d__.playbackMode = playbackMode;
			<ShowTextAsync>d__.<>1__state = -1;
			<ShowTextAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowTextAsync>d__104>(ref <ShowTextAsync>d__);
			return <ShowTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603911F RID: 233759 RVA: 0x00FFBF63 File Offset: 0x00FFA163
		public void ShowText(string content)
		{
			this.DialogueItem.ShowNarrationAsync(content, EVisualNovelPlaybackMode.Manual).Forget();
		}

		// Token: 0x06039120 RID: 233760 RVA: 0x00FFBF77 File Offset: 0x00FFA177
		public void CompleteTyping()
		{
			SolarSchoolVisualNovelCenterTextView centerTextView = this.CenterTextView;
			if (centerTextView != null)
			{
				centerTextView.CompleteTyping();
			}
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.CompleteTyping();
		}

		// Token: 0x06039121 RID: 233761 RVA: 0x00FFBF9C File Offset: 0x00FFA19C
		private UniTask ShowCharacterDialogueAsync(SolarSchoolVisualNovelDialogueItem dialogueItem, VisualNovelItem item, string text, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelView.<ShowCharacterDialogueAsync>d__107 <ShowCharacterDialogueAsync>d__;
			<ShowCharacterDialogueAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCharacterDialogueAsync>d__.<>4__this = this;
			<ShowCharacterDialogueAsync>d__.dialogueItem = dialogueItem;
			<ShowCharacterDialogueAsync>d__.item = item;
			<ShowCharacterDialogueAsync>d__.text = text;
			<ShowCharacterDialogueAsync>d__.playbackMode = playbackMode;
			<ShowCharacterDialogueAsync>d__.<>1__state = -1;
			<ShowCharacterDialogueAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowCharacterDialogueAsync>d__107>(ref <ShowCharacterDialogueAsync>d__);
			return <ShowCharacterDialogueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039122 RID: 233762 RVA: 0x00FFC000 File Offset: 0x00FFA200
		private UniTask ShowCenterTextAsync(SolarSchoolVisualNovelDialogueItem dialogueItem, string text, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelView.<ShowCenterTextAsync>d__108 <ShowCenterTextAsync>d__;
			<ShowCenterTextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCenterTextAsync>d__.<>4__this = this;
			<ShowCenterTextAsync>d__.dialogueItem = dialogueItem;
			<ShowCenterTextAsync>d__.text = text;
			<ShowCenterTextAsync>d__.playbackMode = playbackMode;
			<ShowCenterTextAsync>d__.<>1__state = -1;
			<ShowCenterTextAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowCenterTextAsync>d__108>(ref <ShowCenterTextAsync>d__);
			return <ShowCenterTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039123 RID: 233763 RVA: 0x00FFC05C File Offset: 0x00FFA25C
		private UniTask EnsureOpeningPreparedAsync()
		{
			VisualNovelContext visualNovelContext = this.OpenParam as VisualNovelContext;
			if (visualNovelContext == null || visualNovelContext.IsStopped)
			{
				return UniTask.CompletedTask;
			}
			if (this.VisualNovelContext == visualNovelContext)
			{
				return this.OpeningTask;
			}
			this.ApplyContext(visualNovelContext);
			this.OpeningTask = this.PrepareFirstScreenAsync(visualNovelContext).Preserve();
			return this.OpeningTask;
		}

		// Token: 0x06039124 RID: 233764 RVA: 0x00FFC0B8 File Offset: 0x00FFA2B8
		private UniTask PrepareFirstScreenAsync(VisualNovelContext context)
		{
			SolarSchoolVisualNovelView.<PrepareFirstScreenAsync>d__110 <PrepareFirstScreenAsync>d__;
			<PrepareFirstScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareFirstScreenAsync>d__.<>4__this = this;
			<PrepareFirstScreenAsync>d__.context = context;
			<PrepareFirstScreenAsync>d__.<>1__state = -1;
			<PrepareFirstScreenAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<PrepareFirstScreenAsync>d__110>(ref <PrepareFirstScreenAsync>d__);
			return <PrepareFirstScreenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039125 RID: 233765 RVA: 0x00FFC104 File Offset: 0x00FFA304
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<SolarSchoolVisualNovelCenterTextView> GetOrOpenCenterTextViewAsync(bool prepareFirstScreen = false)
		{
			SolarSchoolVisualNovelView.<GetOrOpenCenterTextViewAsync>d__111 <GetOrOpenCenterTextViewAsync>d__;
			<GetOrOpenCenterTextViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SolarSchoolVisualNovelCenterTextView>.Create();
			<GetOrOpenCenterTextViewAsync>d__.<>4__this = this;
			<GetOrOpenCenterTextViewAsync>d__.prepareFirstScreen = prepareFirstScreen;
			<GetOrOpenCenterTextViewAsync>d__.<>1__state = -1;
			<GetOrOpenCenterTextViewAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<GetOrOpenCenterTextViewAsync>d__111>(ref <GetOrOpenCenterTextViewAsync>d__);
			return <GetOrOpenCenterTextViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039126 RID: 233766 RVA: 0x00FFC150 File Offset: 0x00FFA350
		private UniTask CloseCenterTextViewAsync()
		{
			SolarSchoolVisualNovelView.<CloseCenterTextViewAsync>d__112 <CloseCenterTextViewAsync>d__;
			<CloseCenterTextViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseCenterTextViewAsync>d__.<>4__this = this;
			<CloseCenterTextViewAsync>d__.<>1__state = -1;
			<CloseCenterTextViewAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<CloseCenterTextViewAsync>d__112>(ref <CloseCenterTextViewAsync>d__);
			return <CloseCenterTextViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039127 RID: 233767 RVA: 0x00FFC194 File Offset: 0x00FFA394
		private void CloseCenterTextView()
		{
			int? num = this.ClearCenterTextView();
			if (num != null)
			{
				UiManager.Instance.CloseViewById(num.Value, null);
			}
		}

		// Token: 0x06039128 RID: 233768 RVA: 0x00FFC1C4 File Offset: 0x00FFA3C4
		private int? ClearCenterTextView()
		{
			if (this.CenterTextView != null)
			{
				this.CenterTextView.ContinueRequested -= this.OnDialogueContinueRequested;
				this.CenterTextView.UltraFastForwardRequested -= this.OnUltraFastForwardButtonClicked;
			}
			this.CenterTextView = null;
			int? centerTextViewId = this.CenterTextViewId;
			this.CenterTextViewId = null;
			return centerTextViewId;
		}

		// Token: 0x06039129 RID: 233769 RVA: 0x00FFC220 File Offset: 0x00FFA420
		private static string ResolveText(VisualNovelItem item)
		{
			if (!string.IsNullOrEmpty(item.TextKey))
			{
				return PublicUtil.Instance.GetFlowConfigLocalText(item.TextKey) ?? item.TextKey;
			}
			if (item.TextId == null)
			{
				return string.Empty;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[TextId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item.TextId.Value);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0603912A RID: 233770 RVA: 0x00FFC2AC File Offset: 0x00FFA4AC
		private static string ResolveSpeakerName(int speakerId)
		{
			Speaker? config = ConfigSpeakerById.GetConfig(speakerId, true);
			if (config == null)
			{
				return string.Empty;
			}
			return PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(config.Value.Id)) ?? string.Empty;
		}

		// Token: 0x0603912B RID: 233771 RVA: 0x00FFC2F8 File Offset: 0x00FFA4F8
		public void SetDialogueVisible(bool visible)
		{
			if (!visible)
			{
				this.CloseCenterTextView();
			}
			if (!this.IsUiHidden && base.IsShow)
			{
				if (this.DialogueVisible != visible)
				{
					this.DialogueVisible = visible;
					int num = this.DialogueVisibilityVersion + 1;
					this.DialogueVisibilityVersion = num;
					int version = num;
					if (visible)
					{
						SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
						if (dialogueItem != null)
						{
							dialogueItem.SetUiActive(true);
						}
						SolarSchoolVisualNovelDialogueItem dialogueItem2 = this.DialogueItem;
						if (dialogueItem2 == null)
						{
							return;
						}
						dialogueItem2.PlayStartSequence();
						return;
					}
					else
					{
						this.HideDialogueAsync(version).Forget();
					}
				}
				return;
			}
			this.DialogueVisible = visible;
			SolarSchoolVisualNovelDialogueItem dialogueItem3 = this.DialogueItem;
			if (dialogueItem3 == null)
			{
				return;
			}
			dialogueItem3.SetUiActive(this.IsUiHidden || visible);
		}

		// Token: 0x0603912C RID: 233772 RVA: 0x00FFC394 File Offset: 0x00FFA594
		private UniTask HideDialogueAsync(int version)
		{
			SolarSchoolVisualNovelView.<HideDialogueAsync>d__118 <HideDialogueAsync>d__;
			<HideDialogueAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideDialogueAsync>d__.<>4__this = this;
			<HideDialogueAsync>d__.version = version;
			<HideDialogueAsync>d__.<>1__state = -1;
			<HideDialogueAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<HideDialogueAsync>d__118>(ref <HideDialogueAsync>d__);
			return <HideDialogueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603912D RID: 233773 RVA: 0x00FFC3DF File Offset: 0x00FFA5DF
		private void OnDialogueContinueRequested()
		{
			if (this.IsUiHidden)
			{
				this.RestoreVisualNovelUi();
				return;
			}
			if (this.IsInputLocked)
			{
				return;
			}
			Action continueRequested = this.ContinueRequested;
			if (continueRequested == null)
			{
				return;
			}
			continueRequested();
		}

		// Token: 0x0603912E RID: 233774 RVA: 0x00FFC40C File Offset: 0x00FFA60C
		public bool ShowCharacterIntroduction(int characterId)
		{
			SolarSchoolCharacterIntroduceItem characterIntroduceItem = this.CharacterIntroduceItem;
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(characterId);
			if (role == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.VisualNovel;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "角色介绍找不到第二索拉角色配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("characterId", characterId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			SolarSchoolRole value = role.Value;
			characterIntroduceItem.Show(value.IntroductionName, value.IntroductionInfluenceName, value.IntroductionColor, value.Introduction);
			this.CharacterIntroductionVisible = true;
			if (this.IsUiHidden)
			{
				characterIntroduceItem.SetUiActive(false);
			}
			this.CharacterIntroductionVersion++;
			this.PlaySequence("Sidebar_Start");
			return true;
		}

		// Token: 0x0603912F RID: 233775 RVA: 0x00FFC4C0 File Offset: 0x00FFA6C0
		public void HideCharacterIntroduction()
		{
			if (!this.CharacterIntroductionVisible)
			{
				return;
			}
			this.CharacterIntroductionVisible = false;
			int num = this.CharacterIntroductionVersion + 1;
			this.CharacterIntroductionVersion = num;
			int version = num;
			this.HideCharacterIntroductionAsync(version).Forget();
		}

		// Token: 0x06039130 RID: 233776 RVA: 0x00FFC4FC File Offset: 0x00FFA6FC
		private UniTask HideCharacterIntroductionAsync(int version)
		{
			SolarSchoolVisualNovelView.<HideCharacterIntroductionAsync>d__122 <HideCharacterIntroductionAsync>d__;
			<HideCharacterIntroductionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideCharacterIntroductionAsync>d__.<>4__this = this;
			<HideCharacterIntroductionAsync>d__.version = version;
			<HideCharacterIntroductionAsync>d__.<>1__state = -1;
			<HideCharacterIntroductionAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<HideCharacterIntroductionAsync>d__122>(ref <HideCharacterIntroductionAsync>d__);
			return <HideCharacterIntroductionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039131 RID: 233777 RVA: 0x00FFC547 File Offset: 0x00FFA747
		public UniTask PrepareAsync(VisualNovelItem item)
		{
			UniTask[] array = new UniTask[2];
			array[0] = this.PrepareCgPrefabAsync(item.CgConfig);
			int num = 1;
			VisualNovelScreenEffects screenEffects = this.ScreenEffects;
			array[num] = ((screenEffects != null) ? screenEffects.PrepareAsync(item) : UniTask.CompletedTask);
			return UniTask.WhenAll(array);
		}

		// Token: 0x06039132 RID: 233778 RVA: 0x00FFC588 File Offset: 0x00FFA788
		public UniTask ApplyCgAsync(IVisualNovelCgBase cgConfig)
		{
			SolarSchoolVisualNovelView.<ApplyCgAsync>d__124 <ApplyCgAsync>d__;
			<ApplyCgAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ApplyCgAsync>d__.<>4__this = this;
			<ApplyCgAsync>d__.cgConfig = cgConfig;
			<ApplyCgAsync>d__.<>1__state = -1;
			<ApplyCgAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ApplyCgAsync>d__124>(ref <ApplyCgAsync>d__);
			return <ApplyCgAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039133 RID: 233779 RVA: 0x00FFC5D3 File Offset: 0x00FFA7D3
		public UniTask PlayCgMoveAsync(VisualNovelCgMoveParameters parameters)
		{
			return this.CgMotion.MoveAsync(parameters);
		}

		// Token: 0x06039134 RID: 233780 RVA: 0x00FFC5E1 File Offset: 0x00FFA7E1
		public void SetCgTransform(VisualNovelTransform transform)
		{
			this.CgMotion.SetTransformImmediately(transform);
		}

		// Token: 0x06039135 RID: 233781 RVA: 0x00FFC5F0 File Offset: 0x00FFA7F0
		private UniTask ShowCgImageAsync(int imageId)
		{
			SolarSchoolVisualNovelView.<ShowCgImageAsync>d__127 <ShowCgImageAsync>d__;
			<ShowCgImageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCgImageAsync>d__.<>4__this = this;
			<ShowCgImageAsync>d__.imageId = imageId;
			<ShowCgImageAsync>d__.<>1__state = -1;
			<ShowCgImageAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowCgImageAsync>d__127>(ref <ShowCgImageAsync>d__);
			return <ShowCgImageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039136 RID: 233782 RVA: 0x00FFC63C File Offset: 0x00FFA83C
		private void ShowCgImage(int itemIndex, int textureIndex, UTexture texture, bool showBlur)
		{
			base.GetTexture(textureIndex).SetTexture(texture);
			base.GetTexture(textureIndex).SetUIActive(true);
			base.GetItem(itemIndex).SetUIActive(true);
			this.CgMotion.SetItem(base.GetItem(itemIndex));
			base.GetItem(8).SetUIActive(showBlur);
			this.RefreshCgBlur(showBlur);
		}

		// Token: 0x06039137 RID: 233783 RVA: 0x00FFC698 File Offset: 0x00FFA898
		private UniTask ShowCgPrefabAsync(IVisualNovelCgLoadPrefab config)
		{
			SolarSchoolVisualNovelView.<ShowCgPrefabAsync>d__129 <ShowCgPrefabAsync>d__;
			<ShowCgPrefabAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCgPrefabAsync>d__.<>4__this = this;
			<ShowCgPrefabAsync>d__.config = config;
			<ShowCgPrefabAsync>d__.<>1__state = -1;
			<ShowCgPrefabAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowCgPrefabAsync>d__129>(ref <ShowCgPrefabAsync>d__);
			return <ShowCgPrefabAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039138 RID: 233784 RVA: 0x00FFC6E4 File Offset: 0x00FFA8E4
		[NullableContext(2)]
		private UniTask PrepareCgPrefabAsync(IVisualNovelCgBase cgConfig)
		{
			IVisualNovelCgLoadPrefab visualNovelCgLoadPrefab = cgConfig as IVisualNovelCgLoadPrefab;
			int num = (visualNovelCgLoadPrefab != null) ? visualNovelCgLoadPrefab.PrefabId : 0;
			if (this.CgPrefabItem != null && this.CurrentCgPrefabId == num)
			{
				num = 0;
			}
			if (this.PreparedCgPrefabId == num)
			{
				return UniTask.CompletedTask;
			}
			this.DestroyPreparedCgPrefab();
			if (num == 0)
			{
				return UniTask.CompletedTask;
			}
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			string text = (visualNovelContext != null) ? visualNovelContext.ConfigCenter.GetCgPrefabPath(num) : null;
			if (string.IsNullOrEmpty(text))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.VisualNovel;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "视觉小说高级 CG 缺少预制体路径";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("prefabId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return UniTask.CompletedTask;
			}
			SolarSchoolVisualNovelHighCgItem solarSchoolVisualNovelHighCgItem = new SolarSchoolVisualNovelHighCgItem();
			this.PreparedCgPrefabItem = solarSchoolVisualNovelHighCgItem;
			this.PreparedCgPrefabId = num;
			return solarSchoolVisualNovelHighCgItem.PrepareAsync(text, base.GetItem(18));
		}

		// Token: 0x06039139 RID: 233785 RVA: 0x00FFC7AF File Offset: 0x00FFA9AF
		private void DestroyPreparedCgPrefab()
		{
			SolarSchoolVisualNovelHighCgItem preparedCgPrefabItem = this.PreparedCgPrefabItem;
			this.PreparedCgPrefabItem = null;
			this.PreparedCgPrefabId = 0;
			if (preparedCgPrefabItem == null)
			{
				return;
			}
			preparedCgPrefabItem.Destroy(null);
		}

		// Token: 0x0603913A RID: 233786 RVA: 0x00FFC7D0 File Offset: 0x00FFA9D0
		private UniTask HideCgAsync()
		{
			SolarSchoolVisualNovelView.<HideCgAsync>d__132 <HideCgAsync>d__;
			<HideCgAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideCgAsync>d__.<>4__this = this;
			<HideCgAsync>d__.<>1__state = -1;
			<HideCgAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<HideCgAsync>d__132>(ref <HideCgAsync>d__);
			return <HideCgAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603913B RID: 233787 RVA: 0x00FFC814 File Offset: 0x00FFAA14
		private void HideCgImmediately()
		{
			this.CgVersion++;
			SolarSchoolVisualNovelHighCgItem cgPrefabItem = this.CgPrefabItem;
			this.CgPrefabItem = null;
			this.CurrentCgPrefabId = 0;
			if (cgPrefabItem != null)
			{
				cgPrefabItem.SetUiActive(false);
			}
			if (cgPrefabItem != null)
			{
				cgPrefabItem.Destroy(null);
			}
			this.CgMotion.ClearItem();
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(11).SetUIActive(false);
			base.GetItem(13).SetUIActive(false);
			base.GetItem(18).SetUIActive(false);
			base.GetTexture(10).SetUIActive(false);
			base.GetTexture(12).SetUIActive(false);
			base.GetTexture(14).SetUIActive(false);
			this.RefreshCgBlur(false);
			this.CgDisplayType = ECgDisplayType.None;
			this.ApplyDateVisibility();
		}

		// Token: 0x0603913C RID: 233788 RVA: 0x00FFC8EA File Offset: 0x00FFAAEA
		private void RefreshCgBlur(bool enabled)
		{
			if (enabled)
			{
				this.CgBlur.SetEnableUiBlur(true);
				return;
			}
			UiBlurLogic.Instance.ResumeTopUiRenderAfterBlur();
		}

		// Token: 0x0603913D RID: 233789 RVA: 0x00FFC906 File Offset: 0x00FFAB06
		public UniTask PlayScreenEffectAsync(string path, bool persistent)
		{
			VisualNovelScreenEffects screenEffects = this.ScreenEffects;
			if (screenEffects == null)
			{
				return UniTask.CompletedTask;
			}
			return screenEffects.PlayAsync(path, persistent);
		}

		// Token: 0x0603913E RID: 233790 RVA: 0x00FFC91F File Offset: 0x00FFAB1F
		public UniTask StopScreenEffectAsync(string path)
		{
			VisualNovelScreenEffects screenEffects = this.ScreenEffects;
			if (screenEffects == null)
			{
				return UniTask.CompletedTask;
			}
			return screenEffects.StopAsync(path);
		}

		// Token: 0x0603913F RID: 233791 RVA: 0x00FFC937 File Offset: 0x00FFAB37
		public void CompleteScreenEffect(string path)
		{
			VisualNovelScreenEffects screenEffects = this.ScreenEffects;
			if (screenEffects == null)
			{
				return;
			}
			screenEffects.Complete(path);
		}

		// Token: 0x06039140 RID: 233792 RVA: 0x00FFC94C File Offset: 0x00FFAB4C
		public UniTask PlayCustomScreenEffectAsync(EVisualNovelScreenEffectCustomType effectType)
		{
			if (effectType != EVisualNovelScreenEffectCustomType.BurstEye)
			{
				if (effectType == EVisualNovelScreenEffectCustomType.Shake)
				{
					return this.PlayUiShakeAsync();
				}
				return UniTask.CompletedTask;
			}
			else
			{
				VisualNovelContext visualNovelContext = this.VisualNovelContext;
				if (visualNovelContext != null && visualNovelContext.PlaybackMode == EVisualNovelPlaybackMode.Skip)
				{
					return UniTask.CompletedTask;
				}
				this.CompleteCustomScreenEffect(effectType);
				return this.PlaySequenceAsyncNoStopRunning("EyeOpen");
			}
		}

		// Token: 0x06039141 RID: 233793 RVA: 0x00FFC99C File Offset: 0x00FFAB9C
		public void CompleteCustomScreenEffect(EVisualNovelScreenEffectCustomType effectType)
		{
			if (effectType != EVisualNovelScreenEffectCustomType.BurstEye)
			{
				if (effectType == EVisualNovelScreenEffectCustomType.Shake)
				{
					this.FinishUiShake();
					return;
				}
			}
			else
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null && sequencePlayer.IsSequenceInPlaying("EyeOpen"))
				{
					this.SequencePlayer.StopSequenceByKey("EyeOpen", true, true);
				}
			}
		}

		// Token: 0x06039142 RID: 233794 RVA: 0x00FFC9D7 File Offset: 0x00FFABD7
		public void ClearScreenEffects()
		{
			VisualNovelScreenEffects screenEffects = this.ScreenEffects;
			if (screenEffects != null)
			{
				screenEffects.Clear();
			}
			this.FinishUiShake();
			this.CompleteCustomScreenEffect(EVisualNovelScreenEffectCustomType.BurstEye);
		}

		// Token: 0x06039143 RID: 233795 RVA: 0x00FFC9F7 File Offset: 0x00FFABF7
		private UniTask PlayUiShakeAsync()
		{
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext != null && visualNovelContext.PlaybackMode == EVisualNovelPlaybackMode.Skip)
			{
				this.FinishUiShake();
				return UniTask.CompletedTask;
			}
			return ((SolarSchoolRootView)this.RootView).PlayVisualNovelShakeAsync();
		}

		// Token: 0x06039144 RID: 233796 RVA: 0x00FFCA2C File Offset: 0x00FFAC2C
		private void FinishUiShake()
		{
			((SolarSchoolRootView)this.RootView).FinishVisualNovelShake();
		}

		// Token: 0x06039145 RID: 233797 RVA: 0x00FFCA3E File Offset: 0x00FFAC3E
		private void SetSequencePlayback(float? playbackRate, bool paused)
		{
			((SolarSchoolRootView)this.RootView).SetVisualNovelPlayback(playbackRate, paused);
			SolarSchoolVisualNovelView.ApplySequencePlayback(this.RootActor, playbackRate.GetValueOrDefault(1f), paused);
		}

		// Token: 0x06039146 RID: 233798 RVA: 0x00FFCA6A File Offset: 0x00FFAC6A
		private void OnSequenceStarted(string sequenceName)
		{
			if (!base.IsHideOrHiding && !base.IsDestroyOrDestroying)
			{
				VisualNovelContext visualNovelContext = this.VisualNovelContext;
				if (visualNovelContext != null && !visualNovelContext.IsStopped)
				{
					SolarSchoolVisualNovelView.ApplySequencePlayback(this.RootActor, this.PlaybackRate, this.IsPaused);
					return;
				}
			}
		}

		// Token: 0x06039147 RID: 233799 RVA: 0x00FFCAA8 File Offset: 0x00FFACA8
		internal static void ApplySequencePlayback(AUIBaseActor actor, float playbackRate, bool paused)
		{
			if (!actor.IsValid())
			{
				return;
			}
			foreach (USequencePlayContext usequencePlayContext in actor.PlayContextsByKey.Values)
			{
				usequencePlayContext.PlayInfo.PlaySetting.PlayRate = playbackRate;
			}
			UUIItem uiitem = actor.GetUIItem();
			if (uiitem == null)
			{
				return;
			}
			foreach (string text in uiitem.LevelSequences.Keys)
			{
				if (!SolarSchoolVisualNovelView.IsViewTransitionSequence(text))
				{
					ALevelSequenceActor sequencePlayerByKey = actor.GetSequencePlayerByKey(text);
					ULevelSequencePlayer ulevelSequencePlayer = (sequencePlayerByKey != null) ? sequencePlayerByKey.SequencePlayer : null;
					if (ulevelSequencePlayer != null && ulevelSequencePlayer.IsValid() && !ulevelSequencePlayer.IsStopped())
					{
						ulevelSequencePlayer.SetPlayRate(playbackRate);
						if (paused)
						{
							if (ulevelSequencePlayer.IsPlaying())
							{
								ulevelSequencePlayer.Pause();
							}
						}
						else if (ulevelSequencePlayer.IsPaused())
						{
							if (ulevelSequencePlayer.IsReversed())
							{
								ulevelSequencePlayer.PlayReverse();
							}
							else
							{
								ulevelSequencePlayer.Play();
							}
						}
					}
				}
			}
		}

		// Token: 0x06039148 RID: 233800 RVA: 0x00FFCBE4 File Offset: 0x00FFADE4
		private static bool IsViewTransitionSequence(string sequenceName)
		{
			return sequenceName == "Start" || sequenceName == "Close" || sequenceName == "ShowView" || sequenceName == "HideView";
		}

		// Token: 0x06039149 RID: 233801 RVA: 0x00FFCC2C File Offset: 0x00FFAE2C
		private void PlaySequence(string sequenceName)
		{
			this.SequencePlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
		}

		// Token: 0x0603914A RID: 233802 RVA: 0x00FFCC50 File Offset: 0x00FFAE50
		private UniTask PlaySequenceAsync(string sequenceName)
		{
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			return this.SequencePlayer.PlaySequenceAsync(sequenceName, stopPromise, false, false, null);
		}

		// Token: 0x0603914B RID: 233803 RVA: 0x00FFCC7C File Offset: 0x00FFAE7C
		private UniTask PlaySequenceAsyncNoStopRunning(string sequenceName)
		{
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			return this.SequencePlayer.PlaySequenceAsyncNoStopRunning(sequenceName, stopPromise, false, false, null);
		}

		// Token: 0x0603914C RID: 233804 RVA: 0x00FFCCA8 File Offset: 0x00FFAEA8
		public UniTask ShowChoicesAsync(VisualNovelChoiceData choiceData)
		{
			SolarSchoolVisualNovelView.<ShowChoicesAsync>d__150 <ShowChoicesAsync>d__;
			<ShowChoicesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowChoicesAsync>d__.<>4__this = this;
			<ShowChoicesAsync>d__.choiceData = choiceData;
			<ShowChoicesAsync>d__.<>1__state = -1;
			<ShowChoicesAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowChoicesAsync>d__150>(ref <ShowChoicesAsync>d__);
			return <ShowChoicesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603914D RID: 233805 RVA: 0x00FFCCF4 File Offset: 0x00FFAEF4
		private UniTask ShowNormalChoicesAsync(VisualNovelChoiceData choiceData)
		{
			SolarSchoolVisualNovelView.<ShowNormalChoicesAsync>d__151 <ShowNormalChoicesAsync>d__;
			<ShowNormalChoicesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNormalChoicesAsync>d__.<>4__this = this;
			<ShowNormalChoicesAsync>d__.choiceData = choiceData;
			<ShowNormalChoicesAsync>d__.<>1__state = -1;
			<ShowNormalChoicesAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowNormalChoicesAsync>d__151>(ref <ShowNormalChoicesAsync>d__);
			return <ShowNormalChoicesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603914E RID: 233806 RVA: 0x00FFCD40 File Offset: 0x00FFAF40
		private UniTask ShowFullScreenChoicesAsync(VisualNovelChoiceData choiceData, VisualNovelContext context)
		{
			SolarSchoolVisualNovelView.<ShowFullScreenChoicesAsync>d__152 <ShowFullScreenChoicesAsync>d__;
			<ShowFullScreenChoicesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowFullScreenChoicesAsync>d__.<>4__this = this;
			<ShowFullScreenChoicesAsync>d__.choiceData = choiceData;
			<ShowFullScreenChoicesAsync>d__.context = context;
			<ShowFullScreenChoicesAsync>d__.<>1__state = -1;
			<ShowFullScreenChoicesAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<ShowFullScreenChoicesAsync>d__152>(ref <ShowFullScreenChoicesAsync>d__);
			return <ShowFullScreenChoicesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603914F RID: 233807 RVA: 0x00FFCD93 File Offset: 0x00FFAF93
		private SolarSchoolVisualNovelNormalChoiceItem CreateNormalChoiceItem()
		{
			return new SolarSchoolVisualNovelNormalChoiceItem
			{
				ChoiceSelected = new Action<int>(this.OnChoiceSelected),
				CanSelect = new Func<bool>(this.CanSelectChoice)
			};
		}

		// Token: 0x06039150 RID: 233808 RVA: 0x00FFCDC0 File Offset: 0x00FFAFC0
		private bool CanSelectChoice()
		{
			return this.ChoiceData != null && !this.IsChoicePending && (!this.NormalChoicesVisible || this.NormalChoicesInteractive) && (this.NormalChoicesVisible || this.FullScreenChoicesVisible) && (!this.IsPaused && !this.IsInputLocked && !this.IsUiHidden && !this.WaitToDestroy) && !base.IsDestroyOrDestroying;
		}

		// Token: 0x06039151 RID: 233809 RVA: 0x00FFCE30 File Offset: 0x00FFB030
		private void OnChoiceSelected(int optionIndex)
		{
			if (optionIndex < 0)
			{
				Action<int> choiceSelected = this.ChoiceSelected;
				if (choiceSelected == null)
				{
					return;
				}
				choiceSelected(optionIndex);
				return;
			}
			else
			{
				if (!this.CanSelectChoice() || optionIndex >= this.ChoiceData.Options.Count)
				{
					return;
				}
				VisualNovelChoiceOption visualNovelChoiceOption = this.ChoiceData.Options[optionIndex];
				if (visualNovelChoiceOption.State == EVisualNovelChoiceState.Locked)
				{
					return;
				}
				this.IsChoicePending = true;
				if (visualNovelChoiceOption.ConfirmBoxId != null)
				{
					this.ShowChoiceConfirmation(optionIndex, visualNovelChoiceOption.ConfirmBoxId.Value);
					return;
				}
				this.CompleteChoiceAsync(optionIndex).Forget();
				return;
			}
		}

		// Token: 0x06039152 RID: 233810 RVA: 0x00FFCEC4 File Offset: 0x00FFB0C4
		private void ShowChoiceConfirmation(int optionIndex, int confirmationBoxId)
		{
			int version = this.ChoiceVersion;
			bool confirmed = false;
			bool closed = false;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)confirmationBoxId);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (version != this.ChoiceVersion || this.WaitToDestroy || this.IsDestroyOrDestroying)
				{
					return;
				}
				confirmed = true;
				this.CompleteChoiceAsync(optionIndex).Forget();
			};
			confirmBoxDataNew.DestroyFunction = delegate()
			{
				closed = true;
				if (version != this.ChoiceVersion)
				{
					return;
				}
				this.ChoiceConfirmViewId = null;
				if (!confirmed)
				{
					this.IsChoicePending = false;
				}
			};
			confirmBoxDataNew.FinishOpenFunction = delegate(bool success, int viewId)
			{
				if (closed || version != this.ChoiceVersion || this.WaitToDestroy || this.IsDestroyOrDestroying)
				{
					if (success)
					{
						UiManager.Instance.CloseViewById(viewId, null);
					}
					return;
				}
				if (!success)
				{
					this.OnChoiceConfirmationFailed();
					return;
				}
				this.ChoiceConfirmViewId = new int?(viewId);
			};
			if (!ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				this.OnChoiceConfirmationFailed();
			}
		}

		// Token: 0x06039153 RID: 233811 RVA: 0x00FFCF58 File Offset: 0x00FFB158
		private void OnChoiceConfirmationFailed()
		{
			this.IsChoicePending = false;
			global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, "视觉小说选项二次确认框打开失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06039154 RID: 233812 RVA: 0x00FFCF8C File Offset: 0x00FFB18C
		private UniTask CompleteChoiceAsync(int optionIndex)
		{
			SolarSchoolVisualNovelView.<CompleteChoiceAsync>d__158 <CompleteChoiceAsync>d__;
			<CompleteChoiceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CompleteChoiceAsync>d__.<>4__this = this;
			<CompleteChoiceAsync>d__.optionIndex = optionIndex;
			<CompleteChoiceAsync>d__.<>1__state = -1;
			<CompleteChoiceAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelView.<CompleteChoiceAsync>d__158>(ref <CompleteChoiceAsync>d__);
			return <CompleteChoiceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039155 RID: 233813 RVA: 0x00FFCFD8 File Offset: 0x00FFB1D8
		private void CompleteChoiceWithError(string errorMessage)
		{
			global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, errorMessage, default(ReadOnlySpan<ValueTuple<string, object>>));
			Action<int> choiceSelected = this.ChoiceSelected;
			if (choiceSelected == null)
			{
				return;
			}
			choiceSelected(-1);
		}

		// Token: 0x06039156 RID: 233814 RVA: 0x00FFD014 File Offset: 0x00FFB214
		public void HideChoices()
		{
			int num = this.ChoiceVersion + 1;
			this.ChoiceVersion = num;
			int version = num;
			this.ChoiceData = null;
			this.IsChoicePending = false;
			this.CloseChoiceConfirmation();
			this.HideNormalChoices();
			this.HideFullScreenChoices(version);
		}

		// Token: 0x06039157 RID: 233815 RVA: 0x00FFD054 File Offset: 0x00FFB254
		private void CloseChoiceConfirmation()
		{
			if (this.ChoiceConfirmViewId == null)
			{
				return;
			}
			int value = this.ChoiceConfirmViewId.Value;
			this.ChoiceConfirmViewId = null;
			UiManager.Instance.CloseViewById(value, null);
		}

		// Token: 0x06039158 RID: 233816 RVA: 0x00FFD094 File Offset: 0x00FFB294
		private void HideNormalChoices()
		{
			this.NormalChoicesVisible = false;
			this.NormalChoicesInteractive = false;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsSequenceInPlaying("Option_Show"))
			{
				this.SequencePlayer.StopSequenceByKey("Option_Show", true, true);
			}
			UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null && sequencePlayer2.IsSequenceInPlaying("Option_Hide"))
			{
				this.SequencePlayer.StopSequenceByKey("Option_Hide", true, true);
			}
			base.GetItem(19).SetUIActive(false);
		}

		// Token: 0x06039159 RID: 233817 RVA: 0x00FFD114 File Offset: 0x00FFB314
		private void HideFullScreenChoices(int version)
		{
			if (this.ChoiceView != null)
			{
				this.ChoiceView.ChoiceSelected -= this.OnChoiceSelected;
				this.ChoiceView = null;
			}
			if (this.ChoiceViewId != null)
			{
				int value = this.ChoiceViewId.Value;
				this.ChoiceViewId = null;
				UiManager.Instance.CloseViewById(value, delegate(bool _)
				{
					if (version != this.ChoiceVersion || this.WaitToDestroy || this.IsDestroyOrDestroying)
					{
						return;
					}
					this.FullScreenChoicesVisible = false;
					this.ApplyControlButtonVisibility();
				});
				return;
			}
			if (!this.FullScreenChoicesVisible)
			{
				return;
			}
			this.FullScreenChoicesVisible = false;
			if (!this.WaitToDestroy && !base.IsDestroyOrDestroying)
			{
				this.ApplyControlButtonVisibility();
			}
		}

		// Token: 0x0603915A RID: 233818 RVA: 0x00FFD1BE File Offset: 0x00FFB3BE
		public void SetAutoButtonVisible(bool visible)
		{
			this.SetControlButtonVisible(0, ref this.AutoButtonVisible, visible);
			if (!visible)
			{
				base.GetItem(1).SetUIActive(false);
				base.GetItem(2).SetUIActive(false);
			}
		}

		// Token: 0x0603915B RID: 233819 RVA: 0x00FFD1EB File Offset: 0x00FFB3EB
		public void SetReviewButtonVisible(bool visible)
		{
			this.SetControlButtonVisible(3, ref this.ReviewButtonVisible, visible);
		}

		// Token: 0x0603915C RID: 233820 RVA: 0x00FFD1FB File Offset: 0x00FFB3FB
		public void SetMenuButtonVisible(bool visible)
		{
			this.SetControlButtonVisible(4, ref this.MenuButtonVisible, visible);
		}

		// Token: 0x0603915D RID: 233821 RVA: 0x00FFD20B File Offset: 0x00FFB40B
		public void SetAccelerateButtonVisible(bool visible)
		{
			this.SetControlButtonVisible(6, ref this.AccelerateButtonVisible, visible);
		}

		// Token: 0x0603915E RID: 233822 RVA: 0x00FFD21B File Offset: 0x00FFB41B
		public void SetHideUiButtonVisible(bool visible)
		{
			this.SetControlButtonVisible(7, ref this.HideUiButtonVisible, visible);
		}

		// Token: 0x0603915F RID: 233823 RVA: 0x00FFD22B File Offset: 0x00FFB42B
		public void SetUltraFastForwardButtonVisible(bool visible)
		{
			this.SetControlButtonVisible(16, ref this.UltraFastForwardButtonVisible, visible);
			SolarSchoolVisualNovelCenterTextView centerTextView = this.CenterTextView;
			if (centerTextView == null)
			{
				return;
			}
			centerTextView.SetUltraFastForwardButtonVisible(visible && !this.IsUiHidden && !this.FullScreenChoicesVisible);
		}

		// Token: 0x06039160 RID: 233824 RVA: 0x00FFD263 File Offset: 0x00FFB463
		private void SetControlButtonVisible(int componentIndex, ref bool currentVisible, bool visible)
		{
			currentVisible = visible;
			base.SetButtonUiActive(componentIndex, visible && !this.IsUiHidden && !this.FullScreenChoicesVisible);
		}

		// Token: 0x06039161 RID: 233825 RVA: 0x00FFD286 File Offset: 0x00FFB486
		private void ApplyControlButtonVisibility()
		{
			this.SetAllControlButtonsVisible(!this.IsUiHidden);
			if (this.VisualNovelContext != null)
			{
				this.ApplyPlaybackMode(this.VisualNovelContext.PlaybackMode);
			}
		}

		// Token: 0x06039162 RID: 233826 RVA: 0x00FFD2B0 File Offset: 0x00FFB4B0
		private void SetAllControlButtonsVisible(bool visible)
		{
			visible = (visible && !this.FullScreenChoicesVisible);
			base.SetButtonUiActive(0, visible && this.AutoButtonVisible);
			base.SetButtonUiActive(3, visible && this.ReviewButtonVisible);
			base.SetButtonUiActive(4, visible && this.MenuButtonVisible);
			base.SetButtonUiActive(6, visible && this.AccelerateButtonVisible);
			base.SetButtonUiActive(7, visible && this.HideUiButtonVisible);
			base.SetButtonUiActive(16, visible && this.UltraFastForwardButtonVisible);
			SolarSchoolVisualNovelCenterTextView centerTextView = this.CenterTextView;
			if (centerTextView != null)
			{
				centerTextView.SetUltraFastForwardButtonVisible(visible && this.UltraFastForwardButtonVisible);
			}
			if (visible)
			{
				return;
			}
			base.GetItem(1).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06039163 RID: 233827 RVA: 0x00FFD37C File Offset: 0x00FFB57C
		public void SetPlaybackMode(EVisualNovelPlaybackMode playbackMode)
		{
			if (playbackMode == EVisualNovelPlaybackMode.Skip)
			{
				VisualNovelScreenEffects screenEffects = this.ScreenEffects;
				if (screenEffects != null)
				{
					screenEffects.CompleteAll();
				}
				this.FinishUiShake();
				this.CompleteCustomScreenEffect(EVisualNovelScreenEffectCustomType.BurstEye);
			}
			this.ApplyPlaybackMode(playbackMode);
			if (!this.ReplayFastForwardOnPlayerBind)
			{
				return;
			}
			this.ReplayFastForwardOnPlayerBind = false;
			if (this.IsFastForwardHeld)
			{
				Action fastForwardStarted = this.FastForwardStarted;
				if (fastForwardStarted == null)
				{
					return;
				}
				fastForwardStarted();
			}
		}

		// Token: 0x06039164 RID: 233828 RVA: 0x00FFD3DC File Offset: 0x00FFB5DC
		private void ApplyPlaybackMode(EVisualNovelPlaybackMode playbackMode)
		{
			if (this.IsUiHidden || this.FullScreenChoicesVisible)
			{
				base.GetItem(1).SetUIActive(false);
				base.GetItem(2).SetUIActive(false);
				return;
			}
			base.GetItem(1).SetUIActive(this.AutoButtonVisible && playbackMode != EVisualNovelPlaybackMode.Auto);
			base.GetItem(2).SetUIActive(this.AutoButtonVisible && playbackMode == EVisualNovelPlaybackMode.Auto);
		}

		// Token: 0x06039165 RID: 233829 RVA: 0x00FFD450 File Offset: 0x00FFB650
		public void SetInputLocked(bool locked)
		{
			this.IsInputLocked = locked;
			UiLayer.Instance.SetShowMaskLayer("VisualNovelUltraFastForward", locked);
			base.GetButton(0).SetSelfInteractive(!locked);
			base.GetButton(3).SetSelfInteractive(!locked);
			base.GetButton(4).SetSelfInteractive(!locked);
			base.GetButton(6).SetSelfInteractive(!locked);
			base.GetButton(7).SetSelfInteractive(!locked);
			base.GetButton(16).SetSelfInteractive(!locked);
			SolarSchoolVisualNovelCenterTextView centerTextView = this.CenterTextView;
			if (centerTextView != null)
			{
				centerTextView.SetInputLocked(locked);
			}
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetInputLocked(locked);
		}

		// Token: 0x06039166 RID: 233830 RVA: 0x00FFD4F8 File Offset: 0x00FFB6F8
		private void OnAutoButtonClicked()
		{
			if (this.IsInputLocked)
			{
				return;
			}
			Action autoPlayRequested = this.AutoPlayRequested;
			if (autoPlayRequested == null)
			{
				return;
			}
			autoPlayRequested();
		}

		// Token: 0x06039167 RID: 233831 RVA: 0x00FFD513 File Offset: 0x00FFB713
		private void OnReviewButtonClicked()
		{
			if (this.IsInputLocked || this.IsChoicePending || this.VisualNovelContext == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolVisualNovelReviewView, this.VisualNovelContext, null);
		}

		// Token: 0x06039168 RID: 233832 RVA: 0x00FFD544 File Offset: 0x00FFB744
		private void OnMenuButtonClicked()
		{
			if (this.IsInputLocked || this.IsChoicePending || this.VisualNovelContext == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolSettingView, null, null);
		}

		// Token: 0x06039169 RID: 233833 RVA: 0x00FFD570 File Offset: 0x00FFB770
		private void OnHideUiButtonClicked()
		{
			if (this.IsInputLocked || this.IsChoicePending || this.IsUiHidden)
			{
				return;
			}
			if (this.NormalChoicesVisible && !this.NormalChoicesInteractive)
			{
				return;
			}
			this.IsUiHidden = true;
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext != null)
			{
				visualNovelContext.SetAutoAdvanceMuted(true);
			}
			this.IsFastForwardHeld = false;
			this.ReplayFastForwardOnPlayerBind = false;
			Action fastForwardEnded = this.FastForwardEnded;
			if (fastForwardEnded != null)
			{
				fastForwardEnded();
			}
			base.GetItem(22).SetUIActive(true);
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem != null)
			{
				dialogueItem.SetUiActive(true);
			}
			SolarSchoolVisualNovelDialogueItem dialogueItem2 = this.DialogueItem;
			if (dialogueItem2 != null)
			{
				dialogueItem2.SetContentVisible(false);
			}
			SolarSchoolCharacterIntroduceItem characterIntroduceItem = this.CharacterIntroduceItem;
			if (characterIntroduceItem != null)
			{
				characterIntroduceItem.SetUiActive(false);
			}
			base.GetItem(19).SetUIActive(false);
			this.SetAllControlButtonsVisible(false);
			this.ApplyDateVisibility();
		}

		// Token: 0x0603916A RID: 233834 RVA: 0x00FFD640 File Offset: 0x00FFB840
		private void RestoreVisualNovelUi()
		{
			if (!this.IsUiHidden)
			{
				return;
			}
			this.IsUiHidden = false;
			base.GetItem(22).SetUIActive(false);
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem != null)
			{
				dialogueItem.SetContentVisible(true);
			}
			SolarSchoolVisualNovelDialogueItem dialogueItem2 = this.DialogueItem;
			if (dialogueItem2 != null)
			{
				dialogueItem2.SetUiActive(this.DialogueVisible);
			}
			SolarSchoolCharacterIntroduceItem characterIntroduceItem = this.CharacterIntroduceItem;
			if (characterIntroduceItem != null)
			{
				characterIntroduceItem.SetUiActive(this.CharacterIntroductionVisible);
			}
			base.GetItem(19).SetUIActive(this.NormalChoicesVisible);
			this.ApplyControlButtonVisibility();
			this.ApplyDateVisibility();
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext == null)
			{
				return;
			}
			visualNovelContext.SetAutoAdvanceMuted(false);
		}

		// Token: 0x0603916B RID: 233835 RVA: 0x00FFD6DC File Offset: 0x00FFB8DC
		private void ResetHiddenUiState()
		{
			base.GetItem(22).SetUIActive(false);
			if (!this.IsUiHidden)
			{
				return;
			}
			this.IsUiHidden = false;
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem != null)
			{
				dialogueItem.SetContentVisible(true);
			}
			this.ApplyDateVisibility();
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext == null)
			{
				return;
			}
			visualNovelContext.SetAutoAdvanceMuted(false);
		}

		// Token: 0x0603916C RID: 233836 RVA: 0x00FFD730 File Offset: 0x00FFB930
		private void ApplyDateVisibility()
		{
			bool flag = this.CgDisplayType == ECgDisplayType.High || this.CgPrefabItem != null;
			SolarSchoolRootView solarSchoolRootView = this.RootView as SolarSchoolRootView;
			if (solarSchoolRootView == null)
			{
				return;
			}
			solarSchoolRootView.SetVisualNovelDateVisible(!this.IsUiHidden && !flag);
		}

		// Token: 0x0603916D RID: 233837 RVA: 0x00FFD777 File Offset: 0x00FFB977
		private void OnAccelerateButtonPressed()
		{
			if (this.IsInputLocked)
			{
				return;
			}
			this.IsFastForwardHeld = true;
			Action fastForwardStarted = this.FastForwardStarted;
			if (fastForwardStarted == null)
			{
				return;
			}
			fastForwardStarted();
		}

		// Token: 0x0603916E RID: 233838 RVA: 0x00FFD799 File Offset: 0x00FFB999
		private void OnAccelerateButtonReleased()
		{
			this.IsFastForwardHeld = false;
			if (this.IsInputLocked)
			{
				return;
			}
			Action fastForwardEnded = this.FastForwardEnded;
			if (fastForwardEnded == null)
			{
				return;
			}
			fastForwardEnded();
		}

		// Token: 0x0603916F RID: 233839 RVA: 0x00FFD7BC File Offset: 0x00FFB9BC
		private void OnUltraFastForwardButtonClicked()
		{
			SolarSchoolVisualNovelView.<>c__DisplayClass185_0 CS$<>8__locals1 = new SolarSchoolVisualNovelView.<>c__DisplayClass185_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.IsInputLocked || this.IsUltraFastForwardConfirmPending || this.WaitToDestroy || base.IsDestroyOrDestroying)
			{
				return;
			}
			if (this.NormalChoicesVisible || this.FullScreenChoicesVisible)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_CannotSkip", Array.Empty<object>());
				return;
			}
			CS$<>8__locals1.context = this.VisualNovelContext;
			if (CS$<>8__locals1.context == null || !CS$<>8__locals1.context.IsReady || CS$<>8__locals1.context.IsStopped || CS$<>8__locals1.context.IsPaused)
			{
				return;
			}
			this.IsUltraFastForwardConfirmPending = true;
			this.PauseForMenu();
			CS$<>8__locals1.closed = false;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolVisualNovelSkipConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.<OnUltraFastForwardButtonClicked>g__CloseConfirmation|0(true);
			};
			confirmBoxDataNew.DestroyFunction = delegate()
			{
				base.<OnUltraFastForwardButtonClicked>g__CloseConfirmation|0(false);
			};
			confirmBoxDataNew.FinishOpenFunction = delegate(bool success, int viewId)
			{
				if (!success)
				{
					base.<OnUltraFastForwardButtonClicked>g__CloseConfirmation|0(false);
					return;
				}
				if (CS$<>8__locals1.closed || CS$<>8__locals1.<>4__this.VisualNovelContext != CS$<>8__locals1.context || CS$<>8__locals1.<>4__this.WaitToDestroy || CS$<>8__locals1.<>4__this.IsDestroyOrDestroying)
				{
					UiManager.Instance.CloseViewById(viewId, null);
				}
			};
			if (!ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				CS$<>8__locals1.<OnUltraFastForwardButtonClicked>g__CloseConfirmation|0(false);
				return;
			}
			SolarSchoolGamePlayModel.Instance.LogReporter.ReportSkipClick(SolarSchoolVisualNovelEntry.CurrentFlowId);
		}

		// Token: 0x06039170 RID: 233840 RVA: 0x00FFD8DC File Offset: 0x00FFBADC
		private void OnMenuViewOpening(EUiViewName viewName)
		{
			if (!this.MenuViewNames.Contains(viewName))
			{
				return;
			}
			this.PauseForMenu();
		}

		// Token: 0x06039171 RID: 233841 RVA: 0x00FFD8F3 File Offset: 0x00FFBAF3
		private void OnMenuViewOpenFailed(EUiViewName viewName)
		{
			if (!this.MenuViewNames.Contains(viewName))
			{
				return;
			}
			this.TryResumeAfterMenuClosed();
		}

		// Token: 0x06039172 RID: 233842 RVA: 0x00FFD90A File Offset: 0x00FFBB0A
		private void OnMenuViewOpened(EUiViewName viewName, UiViewBase view)
		{
			if (!this.MenuViewNames.Contains(viewName))
			{
				return;
			}
			this.OpenedMenuViewIds.Add(view.GetViewId());
		}

		// Token: 0x06039173 RID: 233843 RVA: 0x00FFD92D File Offset: 0x00FFBB2D
		private void OnMenuViewClosed(EUiViewName viewName, int viewId)
		{
			if (!this.MenuViewNames.Contains(viewName))
			{
				return;
			}
			this.OpenedMenuViewIds.Remove(viewId);
			this.TryResumeAfterMenuClosed();
		}

		// Token: 0x06039174 RID: 233844 RVA: 0x00FFD954 File Offset: 0x00FFBB54
		private void PauseForMenu()
		{
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext == null || visualNovelContext.IsStopped || visualNovelContext.IsPaused)
			{
				return;
			}
			this.IsPausedByMenu = true;
			visualNovelContext.Player.Pause();
		}

		// Token: 0x06039175 RID: 233845 RVA: 0x00FFD990 File Offset: 0x00FFBB90
		private void TryResumeAfterMenuClosed()
		{
			if (!this.IsPausedByMenu || this.IsUltraFastForwardConfirmPending || this.OpenedMenuViewIds.Count > 0)
			{
				return;
			}
			foreach (EUiViewName viewName in this.MenuViewNames)
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return;
				}
			}
			this.IsPausedByMenu = false;
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext == null || visualNovelContext.IsStopped || !visualNovelContext.IsPaused)
			{
				return;
			}
			if (SolarSchoolGamePlayModel.Instance.GetCurrentStateType() == ESolarSchoolStageStateType.GameExit)
			{
				return;
			}
			visualNovelContext.Player.Resume();
		}

		// Token: 0x0401E062 RID: 122978
		private const string VIEW_START_SEQUENCE = "Start1";

		// Token: 0x0401E063 RID: 122979
		private const string VIEW_CLOSE_SEQUENCE = "Close1";

		// Token: 0x0401E064 RID: 122980
		private const string CHARACTER_INTRODUCTION_START_SEQUENCE = "Sidebar_Start";

		// Token: 0x0401E065 RID: 122981
		private const string CHARACTER_INTRODUCTION_CLOSE_SEQUENCE = "Sidebar_Close";

		// Token: 0x0401E066 RID: 122982
		private const string LOW_CG_START_SEQUENCE = "CG_Start1";

		// Token: 0x0401E067 RID: 122983
		private const string LOW_CG_CLOSE_SEQUENCE = "CG_Close1";

		// Token: 0x0401E068 RID: 122984
		private const string MIDDLE_CG_START_SEQUENCE = "CG_Start2";

		// Token: 0x0401E069 RID: 122985
		private const string MIDDLE_CG_CLOSE_SEQUENCE = "CG_Close2";

		// Token: 0x0401E06A RID: 122986
		private const string HIGH_CG_START_SEQUENCE = "CG_Start3";

		// Token: 0x0401E06B RID: 122987
		private const string HIGH_CG_CLOSE_SEQUENCE = "CG_Close3";

		// Token: 0x0401E06C RID: 122988
		private const string EYE_OPEN_SEQUENCE = "EyeOpen";

		// Token: 0x0401E06D RID: 122989
		private const string OPTION_SHOW_SEQUENCE = "Option_Show";

		// Token: 0x0401E06E RID: 122990
		private const string OPTION_HIDE_SEQUENCE = "Option_Hide";

		// Token: 0x0401E06F RID: 122991
		private const string INPUT_MASK_TAG = "VisualNovelUltraFastForward";

		// Token: 0x0401E070 RID: 122992
		private const string CONTROL_UI_START_SEQUENCE = "Icon_Start";

		// Token: 0x0401E071 RID: 122993
		private const string CONTROL_UI_CLOSE_SEQUENCE = "Icon_Close";

		// Token: 0x0401E072 RID: 122994
		[Nullable(2)]
		private VisualNovelContext VisualNovelContext;

		// Token: 0x0401E073 RID: 122995
		private UniTask OpeningTask = UniTask.CompletedTask;

		// Token: 0x0401E074 RID: 122996
		private bool SkipStartSequence;

		// Token: 0x0401E075 RID: 122997
		[Nullable(2)]
		private VisualNovelAssetCache AssetCache;

		// Token: 0x0401E076 RID: 122998
		private float PlaybackRate = 1f;

		// Token: 0x0401E077 RID: 122999
		private bool IsPaused;

		// Token: 0x0401E078 RID: 123000
		private bool IsInputLocked;

		// Token: 0x0401E079 RID: 123001
		[Nullable(2)]
		private SolarSchoolVisualNovelDialogueItem DialogueItem;

		// Token: 0x0401E07A RID: 123002
		private bool DialogueVisible;

		// Token: 0x0401E07B RID: 123003
		private int DialogueVisibilityVersion;

		// Token: 0x0401E07C RID: 123004
		[Nullable(2)]
		private SolarSchoolVisualNovelCenterTextView CenterTextView;

		// Token: 0x0401E07D RID: 123005
		private int? CenterTextViewId;

		// Token: 0x0401E07E RID: 123006
		[Nullable(2)]
		private SolarSchoolCharacterIntroduceItem CharacterIntroduceItem;

		// Token: 0x0401E07F RID: 123007
		private bool CharacterIntroductionVisible;

		// Token: 0x0401E080 RID: 123008
		private int CharacterIntroductionVersion;

		// Token: 0x0401E081 RID: 123009
		private readonly VisualNovelCgMotion CgMotion = new VisualNovelCgMotion();

		// Token: 0x0401E082 RID: 123010
		[Nullable(2)]
		private SolarSchoolVisualNovelHighCgItem CgPrefabItem;

		// Token: 0x0401E083 RID: 123011
		[Nullable(2)]
		private SolarSchoolVisualNovelHighCgItem PreparedCgPrefabItem;

		// Token: 0x0401E084 RID: 123012
		[Nullable(2)]
		private TsUiBlur CgBlur;

		// Token: 0x0401E085 RID: 123013
		private ECgDisplayType CgDisplayType;

		// Token: 0x0401E086 RID: 123014
		private int CurrentCgPrefabId;

		// Token: 0x0401E087 RID: 123015
		private int PreparedCgPrefabId;

		// Token: 0x0401E088 RID: 123016
		private int CgVersion;

		// Token: 0x0401E089 RID: 123017
		[Nullable(2)]
		private VisualNovelScreenEffects ScreenEffects;

		// Token: 0x0401E08A RID: 123018
		[Nullable(2)]
		private VisualNovelChoiceData ChoiceData;

		// Token: 0x0401E08B RID: 123019
		private int ChoiceVersion;

		// Token: 0x0401E08C RID: 123020
		private bool IsChoicePending;

		// Token: 0x0401E08D RID: 123021
		private int? ChoiceConfirmViewId;

		// Token: 0x0401E08E RID: 123022
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolVisualNovelNormalChoiceItem, VisualNovelChoiceOption> NormalChoiceLayout;

		// Token: 0x0401E08F RID: 123023
		private bool NormalChoicesVisible;

		// Token: 0x0401E090 RID: 123024
		private bool NormalChoicesInteractive;

		// Token: 0x0401E091 RID: 123025
		[Nullable(2)]
		private SolarSchoolVisualNovelChoiceView ChoiceView;

		// Token: 0x0401E092 RID: 123026
		private int? ChoiceViewId;

		// Token: 0x0401E093 RID: 123027
		private bool FullScreenChoicesVisible;

		// Token: 0x0401E094 RID: 123028
		private bool AutoButtonVisible;

		// Token: 0x0401E095 RID: 123029
		private bool ReviewButtonVisible;

		// Token: 0x0401E096 RID: 123030
		private bool MenuButtonVisible;

		// Token: 0x0401E097 RID: 123031
		private bool AccelerateButtonVisible;

		// Token: 0x0401E098 RID: 123032
		private bool HideUiButtonVisible;

		// Token: 0x0401E099 RID: 123033
		private bool UltraFastForwardButtonVisible;

		// Token: 0x0401E09A RID: 123034
		private bool IsUltraFastForwardConfirmPending;

		// Token: 0x0401E09B RID: 123035
		private bool IsUiHidden;

		// Token: 0x0401E09C RID: 123036
		private readonly HashSet<EUiViewName> MenuViewNames = new HashSet<EUiViewName>
		{
			EUiViewName.SolarSchoolSettingView,
			EUiViewName.SolarSchoolGalleryView,
			EUiViewName.SolarSchoolSaveView,
			EUiViewName.SolarSchoolLimitTimeRewardView,
			EUiViewName.SolarSchoolNormalRewardView,
			EUiViewName.SolarSchoolQuestDetailView
		};

		// Token: 0x0401E09D RID: 123037
		private readonly HashSet<int> OpenedMenuViewIds = new HashSet<int>();

		// Token: 0x0401E09E RID: 123038
		private bool IsPausedByMenu;

		// Token: 0x0401E0A5 RID: 123045
		private bool IsFastForwardHeld;

		// Token: 0x0401E0A6 RID: 123046
		private bool ReplayFastForwardOnPlayerBind;

		// Token: 0x0200B67E RID: 46718
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403874C RID: 231244
			public const int AutoButton = 0;

			// Token: 0x0403874D RID: 231245
			public const int PlayingItem = 1;

			// Token: 0x0403874E RID: 231246
			public const int PausedItem = 2;

			// Token: 0x0403874F RID: 231247
			public const int ReviewButton = 3;

			// Token: 0x04038750 RID: 231248
			public const int MenuButton = 4;

			// Token: 0x04038751 RID: 231249
			public const int DialogueItem = 5;

			// Token: 0x04038752 RID: 231250
			public const int AccelerateButton = 6;

			// Token: 0x04038753 RID: 231251
			public const int HideUiButton = 7;

			// Token: 0x04038754 RID: 231252
			public const int BlurItem = 8;

			// Token: 0x04038755 RID: 231253
			public const int LowCgItem = 9;

			// Token: 0x04038756 RID: 231254
			public const int LowCgTexture = 10;

			// Token: 0x04038757 RID: 231255
			public const int MiddleCgItem = 11;

			// Token: 0x04038758 RID: 231256
			public const int MiddleCgTexture = 12;

			// Token: 0x04038759 RID: 231257
			public const int HighCgItem = 13;

			// Token: 0x0403875A RID: 231258
			public const int HighCgTexture = 14;

			// Token: 0x0403875B RID: 231259
			public const int HighCgSpine = 15;

			// Token: 0x0403875C RID: 231260
			public const int UltraFastForwardButton = 16;

			// Token: 0x0403875D RID: 231261
			public const int IntroduceItem = 17;

			// Token: 0x0403875E RID: 231262
			public const int HighCgPrefabRootItem = 18;

			// Token: 0x0403875F RID: 231263
			public const int OptionRootItem = 19;

			// Token: 0x04038760 RID: 231264
			public const int OptionLayoutItem = 20;

			// Token: 0x04038761 RID: 231265
			public const int OptionTemplateItem = 21;

			// Token: 0x04038762 RID: 231266
			public const int HiddenUiItem = 22;
		}
	}
}
