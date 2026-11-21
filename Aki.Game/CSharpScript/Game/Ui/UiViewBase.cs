using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003570 RID: 13680
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiViewBase : UiPanelBase
	{
		// Token: 0x06022D54 RID: 142676 RVA: 0x009E568C File Offset: 0x009E388C
		protected UiViewBase(UiViewInfo viewInfo)
		{
			this.ViewInfo = viewInfo;
			this.MaskTag = ((viewInfo != null) ? viewInfo.Name.ToString() : null) + this.ComponentId.ToString();
			this.MemoryTag = UiConfig.Instance.GetMemoryTag(viewInfo.Name);
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x06022D55 RID: 142677 RVA: 0x009E570A File Offset: 0x009E390A
		public bool IsQueueView
		{
			get
			{
				return this.ViewInfo.SortIndex >= 0;
			}
		}

		// Token: 0x06022D56 RID: 142678 RVA: 0x009E571D File Offset: 0x009E391D
		[NullableContext(2)]
		public override CustomPromise GetClosePromiseImplement()
		{
			return this.ClosePromise;
		}

		// Token: 0x06022D57 RID: 142679 RVA: 0x009E5725 File Offset: 0x009E3925
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x06022D58 RID: 142680 RVA: 0x009E5727 File Offset: 0x009E3927
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x06022D59 RID: 142681 RVA: 0x009E5729 File Offset: 0x009E3929
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022D5A RID: 142682 RVA: 0x009E5730 File Offset: 0x009E3930
		protected virtual void OnAfterPlayStartSequence()
		{
		}

		// Token: 0x06022D5B RID: 142683 RVA: 0x009E5732 File Offset: 0x009E3932
		protected virtual void OnBeforePlayCloseSequence()
		{
		}

		// Token: 0x06022D5C RID: 142684 RVA: 0x009E5734 File Offset: 0x009E3934
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022D5D RID: 142685 RVA: 0x009E573B File Offset: 0x009E393B
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022D5E RID: 142686 RVA: 0x009E5742 File Offset: 0x009E3942
		protected virtual bool OnCheckIfNeedScene()
		{
			return true;
		}

		// Token: 0x06022D5F RID: 142687 RVA: 0x009E5745 File Offset: 0x009E3945
		protected virtual void OnHandleLoadScene()
		{
		}

		// Token: 0x06022D60 RID: 142688 RVA: 0x009E5748 File Offset: 0x009E3948
		protected virtual UniTask HandlePostLoadSceneAsync(bool isSceneLoad)
		{
			UiViewBase.<HandlePostLoadSceneAsync>d__34 <HandlePostLoadSceneAsync>d__;
			<HandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandlePostLoadSceneAsync>d__.<>4__this = this;
			<HandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
			<HandlePostLoadSceneAsync>d__.<>1__state = -1;
			<HandlePostLoadSceneAsync>d__.<>t__builder.Start<UiViewBase.<HandlePostLoadSceneAsync>d__34>(ref <HandlePostLoadSceneAsync>d__);
			return <HandlePostLoadSceneAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D61 RID: 142689 RVA: 0x009E5793 File Offset: 0x009E3993
		protected virtual UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022D62 RID: 142690 RVA: 0x009E579A File Offset: 0x009E399A
		protected virtual void OnHandlePostLoadScene(bool isSceneLoad)
		{
		}

		// Token: 0x06022D63 RID: 142691 RVA: 0x009E579C File Offset: 0x009E399C
		protected virtual void OnHandleReleaseScene()
		{
		}

		// Token: 0x06022D64 RID: 142692 RVA: 0x009E57A0 File Offset: 0x009E39A0
		protected UniTask HandlePreReleaseSceneAsync(bool isSceneRelease)
		{
			UiViewBase.<HandlePreReleaseSceneAsync>d__38 <HandlePreReleaseSceneAsync>d__;
			<HandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandlePreReleaseSceneAsync>d__.<>4__this = this;
			<HandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
			<HandlePreReleaseSceneAsync>d__.<>1__state = -1;
			<HandlePreReleaseSceneAsync>d__.<>t__builder.Start<UiViewBase.<HandlePreReleaseSceneAsync>d__38>(ref <HandlePreReleaseSceneAsync>d__);
			return <HandlePreReleaseSceneAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D65 RID: 142693 RVA: 0x009E57EB File Offset: 0x009E39EB
		protected virtual UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022D66 RID: 142694 RVA: 0x009E57F2 File Offset: 0x009E39F2
		public virtual void CloseSelf()
		{
			this.CloseMeAsync().ContinueWith(delegate(bool result)
			{
				if (!result)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCore;
					ELogAuthor author = ELogAuthor.TL;
					string message = "[CloseMe]流程执行异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewInfo.Name);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			});
		}

		// Token: 0x06022D67 RID: 142695 RVA: 0x009E580C File Offset: 0x009E3A0C
		[NullableContext(2)]
		public void CloseMe(Action<bool> callback = null)
		{
			this.CloseMeAsync().ContinueWith(delegate(bool result)
			{
				if (result)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(true);
					return;
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCore;
					ELogAuthor author = ELogAuthor.TL;
					string message = "[CloseMe]流程执行异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewInfo.Name);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(false);
					return;
				}
			});
		}

		// Token: 0x06022D68 RID: 142696 RVA: 0x009E5848 File Offset: 0x009E3A48
		[NullableContext(0)]
		public override UniTask<bool> CloseMeAsync()
		{
			UiViewBase.<CloseMeAsync>d__42 <CloseMeAsync>d__;
			<CloseMeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseMeAsync>d__.<>4__this = this;
			<CloseMeAsync>d__.<>1__state = -1;
			<CloseMeAsync>d__.<>t__builder.Start<UiViewBase.<CloseMeAsync>d__42>(ref <CloseMeAsync>d__);
			return <CloseMeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D69 RID: 142697 RVA: 0x009E588B File Offset: 0x009E3A8B
		public int GetViewId()
		{
			return this.ComponentId;
		}

		// Token: 0x06022D6A RID: 142698 RVA: 0x009E5894 File Offset: 0x009E3A94
		protected void PlaySequence(string sequenceName, [Nullable(2)] Action onStop = null, bool blockClick = false)
		{
			this.PlaySequenceAsync(sequenceName, blockClick, false, null).ContinueWith(delegate()
			{
				Action onStop2 = onStop;
				if (onStop2 == null)
				{
					return;
				}
				onStop2();
			});
		}

		// Token: 0x06022D6B RID: 142699 RVA: 0x009E58D4 File Offset: 0x009E3AD4
		protected UniTask PlaySequenceAsync(string sequenceName, bool blockClick = false, bool playReverse = false, float? playRate = null)
		{
			UiViewBase.<PlaySequenceAsync>d__45 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.blockClick = blockClick;
			<PlaySequenceAsync>d__.playReverse = playReverse;
			<PlaySequenceAsync>d__.playRate = playRate;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<UiViewBase.<PlaySequenceAsync>d__45>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D6C RID: 142700 RVA: 0x009E5938 File Offset: 0x009E3B38
		protected void PlayOrReplaySequence(string sequenceName, bool blockClick = false, int? playRate = null)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			int? num = playRate;
			uiViewSequence.PlayOrReplaySequenceByName(sequenceName, blockClick, (num != null) ? new float?((float)num.GetValueOrDefault()) : null);
		}

		// Token: 0x06022D6D RID: 142701 RVA: 0x009E5975 File Offset: 0x009E3B75
		[NullableContext(2)]
		protected void SetAudioEvent(string audioEvent)
		{
			this.AudioEvent = audioEvent;
		}

		// Token: 0x06022D6E RID: 142702 RVA: 0x009E597E File Offset: 0x009E3B7E
		protected virtual void RegisterUiBehavior()
		{
			this.InitUiViewSequenceBehavior();
			this.RegisterUiBlur();
			this.RegisterUiAudio();
			this.RegisterUiBehaviorHomeBtn();
		}

		// Token: 0x06022D6F RID: 142703 RVA: 0x009E5998 File Offset: 0x009E3B98
		private void PlayViewSequence(string sequenceName, [Nullable(2)] Action onStop = null)
		{
			this.PlaySequence(sequenceName, onStop, (this.ViewInfo.Type & (ELayerType.Normal | ELayerType.Plot | ELayerType.Pop)) > (ELayerType)0);
		}

		// Token: 0x06022D70 RID: 142704 RVA: 0x009E59B4 File Offset: 0x009E3BB4
		private UniTask PlayViewSequenceAsync(string sequenceName)
		{
			UiViewBase.<PlayViewSequenceAsync>d__50 <PlayViewSequenceAsync>d__;
			<PlayViewSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayViewSequenceAsync>d__.<>4__this = this;
			<PlayViewSequenceAsync>d__.sequenceName = sequenceName;
			<PlayViewSequenceAsync>d__.<>1__state = -1;
			<PlayViewSequenceAsync>d__.<>t__builder.Start<UiViewBase.<PlayViewSequenceAsync>d__50>(ref <PlayViewSequenceAsync>d__);
			return <PlayViewSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D71 RID: 142705 RVA: 0x009E59FF File Offset: 0x009E3BFF
		public void PauseCurrentSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PauseSequence();
		}

		// Token: 0x06022D72 RID: 142706 RVA: 0x009E5A11 File Offset: 0x009E3C11
		public void ResumeCurrentSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.ResumeSequence();
		}

		// Token: 0x06022D73 RID: 142707 RVA: 0x009E5A23 File Offset: 0x009E3C23
		private void InitUiViewSequenceBehavior()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			this.UiViewSequence.SetSequenceName(this.OpenParam as UiViewData);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06022D74 RID: 142708 RVA: 0x009E5A54 File Offset: 0x009E3C54
		private void RegisterUiBlur()
		{
			UiBehaviourUiBlur uiBehaviourUiBlur = new UiBehaviourUiBlur();
			this.UiBlurBehaviour = uiBehaviourUiBlur;
			uiBehaviourUiBlur.SetCurrentLayer(this.ViewInfo.Type);
			uiBehaviourUiBlur.SetViewInfo(this);
			base.AddUiBehavior(uiBehaviourUiBlur);
		}

		// Token: 0x06022D75 RID: 142709 RVA: 0x009E5A8D File Offset: 0x009E3C8D
		private void RegisterUiAudio()
		{
			base.AddUiBehavior(new UiBehaviorAudio(this));
		}

		// Token: 0x06022D76 RID: 142710 RVA: 0x009E5A9C File Offset: 0x009E3C9C
		private void RegisterUiBehaviorHomeBtn()
		{
			UiBehaviourHomeBtn uiBehaviourHomeBtn = new UiBehaviourHomeBtn();
			this.UiBehaviourHomeBtn = uiBehaviourHomeBtn;
			uiBehaviourHomeBtn.SetViewInfo(this);
			base.AddUiBehavior(uiBehaviourHomeBtn);
		}

		// Token: 0x06022D77 RID: 142711 RVA: 0x009E5AC4 File Offset: 0x009E3CC4
		[NullableContext(2)]
		public UUIViewAudioEffectComponent GetUiAudioComponent()
		{
			AActor aactor = (this.ChildPopView != null) ? this.ChildPopView.GetPopViewRootActor() : this.RootActor;
			if (aactor == null || !aactor.IsValid())
			{
				return null;
			}
			return aactor.GetComponentByClass(UUIViewAudioEffectComponent.StaticClass()) as UUIViewAudioEffectComponent;
		}

		// Token: 0x06022D78 RID: 142712 RVA: 0x009E5B0F File Offset: 0x009E3D0F
		public string GetBgm()
		{
			return this.OnGetBgm();
		}

		// Token: 0x06022D79 RID: 142713 RVA: 0x009E5B17 File Offset: 0x009E3D17
		public void RefreshUiBlurBehaviour()
		{
			UiBehaviourUiBlur uiBlurBehaviour = this.UiBlurBehaviour;
			if (uiBlurBehaviour == null)
			{
				return;
			}
			uiBlurBehaviour.RefreshBlur();
		}

		// Token: 0x06022D7A RID: 142714 RVA: 0x009E5B29 File Offset: 0x009E3D29
		public UUIItem GetBlurRootItem()
		{
			return this.OnGetBlurRootItem();
		}

		// Token: 0x06022D7B RID: 142715 RVA: 0x009E5B31 File Offset: 0x009E3D31
		protected virtual UUIItem OnGetBlurRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x06022D7C RID: 142716 RVA: 0x009E5B39 File Offset: 0x009E3D39
		public virtual bool GetBgmSwitch()
		{
			return true;
		}

		// Token: 0x06022D7D RID: 142717 RVA: 0x009E5B3C File Offset: 0x009E3D3C
		[NullableContext(2)]
		private UUIItem GetLayerRoot()
		{
			if (this.IsPreOpening)
			{
				return UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pool);
			}
			ELayerType layer = this.GetLayer();
			if (layer == ELayerType.Float)
			{
				UiFloatConfig? uiFloatConfig = UiViewConfig.Instance.GetUiFloatConfig(this.ViewInfo.Name);
				if (uiFloatConfig != null)
				{
					if (uiFloatConfig.Value.OnlyShowInMain)
					{
						return UiLayer.Instance.GetFloatUnit(ELayerType.BattleFloat, uiFloatConfig.Value.RootItemIndex);
					}
					return UiLayer.Instance.GetFloatUnit(ELayerType.Float, uiFloatConfig.Value.RootItemIndex);
				}
			}
			else if (layer == ELayerType.Loading)
			{
				return UiLayer.Instance.GetFloatUnit(ELayerType.Loading, 0);
			}
			return UiLayer.Instance.GetLayerRootUiItem(layer);
		}

		// Token: 0x06022D7E RID: 142718 RVA: 0x009E5C00 File Offset: 0x009E3E00
		public void InitRootActorLoadInfo()
		{
			UiViewInfo viewInfo = this.ViewInfo;
			base.SetRootActorLoadInfoByPath(viewInfo.UiPath, this.GetLayerRoot(), viewInfo.SourceType == ESourceType.UiActorPool, viewInfo.IsPermanent);
		}

		// Token: 0x06022D7F RID: 142719 RVA: 0x009E5C35 File Offset: 0x009E3E35
		protected virtual void OnBeforeCreateImplementImplement()
		{
		}

		// Token: 0x06022D80 RID: 142720 RVA: 0x009E5C37 File Offset: 0x009E3E37
		protected override void OnBeforeCreateImplement()
		{
			this.RegisterUiBehavior();
			this.OnBeforeCreateImplementImplement();
		}

		// Token: 0x06022D81 RID: 142721 RVA: 0x009E5C48 File Offset: 0x009E3E48
		protected override void OnAfterCreateImplement()
		{
			if (this.IsExistInLeaveLevel || UiManager.Instance.IsLockOpen)
			{
				Log.Instance.Info(ELogModule.UiCore, ELogAuthor.XXJ, "场景切换过程中, 设置无缝加载标记", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SetViewPermanent();
			}
		}

		// Token: 0x06022D82 RID: 142722 RVA: 0x009E5C8C File Offset: 0x009E3E8C
		private void SetViewPermanent()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCore;
			ELogAuthor author = ELogAuthor.TL;
			string message = "SetViewPermanent";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewInfo.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			LguiUtil.Instance.SetActorIsPermanent(base.GetOriginalActor(), true, true);
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.SetViewPermanent();
		}

		// Token: 0x06022D83 RID: 142723 RVA: 0x009E5CF4 File Offset: 0x009E3EF4
		protected override UniTask OnCreateAsyncImplementImplement()
		{
			UiViewBase.<OnCreateAsyncImplementImplement>d__69 <OnCreateAsyncImplementImplement>d__;
			<OnCreateAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsyncImplementImplement>d__.<>1__state = -1;
			<OnCreateAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnCreateAsyncImplementImplement>d__69>(ref <OnCreateAsyncImplementImplement>d__);
			return <OnCreateAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022D84 RID: 142724 RVA: 0x009E5D2F File Offset: 0x009E3F2F
		protected virtual void OnStartImplementImplement()
		{
		}

		// Token: 0x06022D85 RID: 142725 RVA: 0x009E5D34 File Offset: 0x009E3F34
		protected override void OnStartImplement()
		{
			this.SetAudioEvent(this.ViewInfo.AudioEvent);
			this.LastUiSceneRendering = ULGUIBPLibrary.GetWorldUISceneRendering(base.GetRootActor());
			this.FirstShow = true;
			EventSystem.Instance.Emit<EUiViewName>(EEventName.OnViewLoadCompleted, this.ViewInfo.Name);
			EventSystem.Instance.Emit<EUiViewName, UiViewBase>(EEventName.OnViewDone, this.ViewInfo.Name, this);
			this.UiViewSequence.AddSequenceStartEvent(this.UiViewSequence.StartSequenceName.ToString(), delegate(string arg1)
			{
				this.SkipAnimViewFlow = false;
				TimerSystem.Instance.Next(delegate(float arg)
				{
					InputDistributeController.Instance.BindActions(this.ViewInfo.SkipAnimActions, new TInputHandle<InputDistributeDefine.EActionType>(this.InterruptOpSkipAnim));
				}, null, null);
			});
			this.UiViewSequence.AddSequenceFinishEvent(this.UiViewSequence.StartSequenceName.ToString(), delegate(string arg1)
			{
				InputDistributeController.Instance.UnBindActions(this.ViewInfo.SkipAnimActions, new TInputHandle<InputDistributeDefine.EActionType>(this.InterruptOpSkipAnim));
			}, false);
			this.OnStartImplementImplement();
		}

		// Token: 0x06022D86 RID: 142726 RVA: 0x009E5DF0 File Offset: 0x009E3FF0
		protected virtual void OnBeforeShowImplementImplement()
		{
		}

		// Token: 0x06022D87 RID: 142727 RVA: 0x009E5DF4 File Offset: 0x009E3FF4
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			UiViewBase.<OnBeforeShowAsyncImplement>d__73 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<UiViewBase.<OnBeforeShowAsyncImplement>d__73>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022D88 RID: 142728 RVA: 0x009E5E37 File Offset: 0x009E4037
		protected virtual UniTask OnBeforeShowAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022D89 RID: 142729 RVA: 0x009E5E40 File Offset: 0x009E4040
		private UniTask OnBeforeShowAsync()
		{
			UiViewBase.<OnBeforeShowAsync>d__75 <OnBeforeShowAsync>d__;
			<OnBeforeShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsync>d__.<>4__this = this;
			<OnBeforeShowAsync>d__.<>1__state = -1;
			<OnBeforeShowAsync>d__.<>t__builder.Start<UiViewBase.<OnBeforeShowAsync>d__75>(ref <OnBeforeShowAsync>d__);
			return <OnBeforeShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D8A RID: 142730 RVA: 0x009E5E83 File Offset: 0x009E4083
		protected override void OnBeforeShowImplement()
		{
			this.OnAddEventListener();
			this.OnBeforeShowImplementImplement();
			this.ApplyPerformanceLimit();
		}

		// Token: 0x06022D8B RID: 142731 RVA: 0x009E5E98 File Offset: 0x009E4098
		protected override UniTask OnShowAsyncImplementImplement()
		{
			UiViewBase.<OnShowAsyncImplementImplement>d__77 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnShowAsyncImplementImplement>d__77>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022D8C RID: 142732 RVA: 0x009E5EDC File Offset: 0x009E40DC
		private void InterruptOpSkipAnim(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification ii)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			this.SkipAnimViewFlow = true;
			if (this.UiViewSequence.HasSequenceNameInPlaying(this.UiViewSequence.StartSequenceName.ToString()))
			{
				this.UiViewSequence.StopSequenceByKey(this.UiViewSequence.StartSequenceName.ToString(), true, true);
			}
			InputDistributeController.Instance.UnBindActions(this.ViewInfo.SkipAnimActions, new TInputHandle<InputDistributeDefine.EActionType>(this.InterruptOpSkipAnim));
		}

		// Token: 0x06022D8D RID: 142733 RVA: 0x009E5F50 File Offset: 0x009E4150
		public void TryEmitInterruptOpExitView()
		{
			if (this.SkipAnimViewFlow)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "跳过界面动画Start流程,关闭界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewInfo.Name);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UiNavigationNewController.Instance.HotKeyCloseView();
				this.SkipAnimViewFlow = false;
			}
		}

		// Token: 0x06022D8E RID: 142734 RVA: 0x009E5FAC File Offset: 0x009E41AC
		protected override void OnShowAsyncImplementImplementCompatible()
		{
			if (this.ViewInfo.IsFullScreen)
			{
				ULGUIBPLibrary.SetIsFullScreenUIRendering(base.GetRootActor(), true);
			}
			this.LoadScene();
			if (this.FirstShow)
			{
				this.PlayViewSequence(this.UiViewSequence.StartSequenceName, null);
				this.OnAfterPlayStartSequence();
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequencePurely("AutoLoop", false, false);
				}
				this.FirstShow = false;
				return;
			}
			this.PlayViewSequence(this.UiViewSequence.ShowSequenceName, null);
		}

		// Token: 0x06022D8F RID: 142735 RVA: 0x009E602C File Offset: 0x009E422C
		protected override void OnAfterShowImplement()
		{
			CustomPromise<bool> openPromise = this.OpenPromise;
			if (openPromise != null)
			{
				openPromise.SetResult(true);
			}
			CustomPromise showPromise = this.ShowPromise;
			if (showPromise != null)
			{
				showPromise.SetResult();
			}
			this.HandleAllLoadingFinishOperation();
			EventSystem.Instance.Emit<EUiViewName, UiViewBase>(EEventName.OnViewShow, this.ViewInfo.Name, this);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCore;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "界面显示完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewInfo.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06022D90 RID: 142736 RVA: 0x009E60B4 File Offset: 0x009E42B4
		protected unsafe override void HandleCacheShowActionFailIfIsPair()
		{
			if (this.FirstShow)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "界面在首次打开时已经执行了Hide逻辑,Show逻辑不生效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", this.ViewInfo.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", this.ComponentId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				CustomPromise<bool> openPromise = this.OpenPromise;
				if (openPromise == null)
				{
					return;
				}
				openPromise.SetResult(true);
			}
		}

		// Token: 0x06022D91 RID: 142737 RVA: 0x009E6148 File Offset: 0x009E4348
		protected override UniTask OnHideAsyncImplementImplement()
		{
			UiViewBase.<OnHideAsyncImplementImplement>d__83 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnHideAsyncImplementImplement>d__83>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022D92 RID: 142738 RVA: 0x009E618C File Offset: 0x009E438C
		protected override void OnHideAsyncImplementImplementCompatible()
		{
			this.CancelPerformanceSeqLimit();
			if (this.ViewInfo.IsFullScreen)
			{
				ULGUIBPLibrary.SetIsFullScreenUIRendering(base.GetRootActor(), this.LastUiSceneRendering);
			}
			if (this.LastHide)
			{
				this.LastHide = false;
				this.OnBeforePlayCloseSequence();
				this.PlayViewSequence(this.UiViewSequence.CloseSequenceName, null);
			}
			else
			{
				this.PlayViewSequence(this.UiViewSequence.HideSequenceName, null);
			}
			this.ReleaseScene();
		}

		// Token: 0x06022D93 RID: 142739 RVA: 0x009E61FF File Offset: 0x009E43FF
		protected virtual void OnAfterHideImplementImplement()
		{
		}

		// Token: 0x06022D94 RID: 142740 RVA: 0x009E6201 File Offset: 0x009E4401
		protected override void OnAfterHideImplement()
		{
			this.OnAfterHideImplementImplement();
			this.OnRemoveEventListener();
			EventSystem.Instance.Emit<EUiViewName>(EEventName.OnViewHidden, this.ViewInfo.Name);
			this.CancelPerformanceLimit();
			CustomPromise hidePromise = this.HidePromise;
			if (hidePromise == null)
			{
				return;
			}
			hidePromise.SetResult();
		}

		// Token: 0x06022D95 RID: 142741 RVA: 0x009E6240 File Offset: 0x009E4440
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			UiViewBase.<OnDestroyAsyncImplementImplement>d__87 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnDestroyAsyncImplementImplement>d__87>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022D96 RID: 142742 RVA: 0x009E6283 File Offset: 0x009E4483
		protected override void OnDestroyAsyncImplementImplementCompatible()
		{
			this.ChildPopView = null;
			this.ResetOperationQueue();
			UiManager.Instance.RemoveView(this.GetViewId());
		}

		// Token: 0x06022D97 RID: 142743 RVA: 0x009E62A4 File Offset: 0x009E44A4
		protected override void OnAfterDestroyImplement()
		{
			CustomPromise closePromise = this.ClosePromise;
			if (closePromise != null)
			{
				closePromise.SetResult();
			}
			EventSystem.Instance.Emit<EUiViewName, int>(EEventName.CloseView, this.ViewInfo.Name, this.GetViewId());
			if (this.ViewInfo.NeedGc)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "执行Force GC";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewInfo.Name);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				WorldController.Instance.ManuallyGarbageCollection(EGarbageCollectionReason.CloseUiView);
				WorldController.Instance.ForceGarbageCollection(false);
			}
		}

		// Token: 0x06022D98 RID: 142744 RVA: 0x009E6339 File Offset: 0x009E4539
		public void AddChildViewById(int childViewId)
		{
			base.AddChild(UiManager.Instance.GetView(childViewId));
		}

		// Token: 0x06022D99 RID: 142745 RVA: 0x009E634C File Offset: 0x009E454C
		private UniTask PlayViewCloseSequenceAsync()
		{
			UiViewBase.<PlayViewCloseSequenceAsync>d__91 <PlayViewCloseSequenceAsync>d__;
			<PlayViewCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayViewCloseSequenceAsync>d__.<>4__this = this;
			<PlayViewCloseSequenceAsync>d__.<>1__state = -1;
			<PlayViewCloseSequenceAsync>d__.<>t__builder.Start<UiViewBase.<PlayViewCloseSequenceAsync>d__91>(ref <PlayViewCloseSequenceAsync>d__);
			return <PlayViewCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D9A RID: 142746 RVA: 0x009E6390 File Offset: 0x009E4590
		private UniTask PlayViewHideSequenceAsync()
		{
			UiViewBase.<PlayViewHideSequenceAsync>d__92 <PlayViewHideSequenceAsync>d__;
			<PlayViewHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayViewHideSequenceAsync>d__.<>4__this = this;
			<PlayViewHideSequenceAsync>d__.<>1__state = -1;
			<PlayViewHideSequenceAsync>d__.<>t__builder.Start<UiViewBase.<PlayViewHideSequenceAsync>d__92>(ref <PlayViewHideSequenceAsync>d__);
			return <PlayViewHideSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022D9B RID: 142747 RVA: 0x009E63D3 File Offset: 0x009E45D3
		protected void DeleteCloseSequence()
		{
			this.UiViewSequence.CloseSequenceName = "Close";
		}

		// Token: 0x06022D9C RID: 142748 RVA: 0x009E63E5 File Offset: 0x009E45E5
		public ELayerType GetLayer()
		{
			return this.OnGetLayer();
		}

		// Token: 0x06022D9D RID: 142749 RVA: 0x009E63ED File Offset: 0x009E45ED
		protected virtual ELayerType OnGetLayer()
		{
			return this.ViewInfo.Type;
		}

		// Token: 0x06022D9E RID: 142750 RVA: 0x009E63FA File Offset: 0x009E45FA
		public float GetTimeDilation()
		{
			return this.OnGetTimeDilation();
		}

		// Token: 0x06022D9F RID: 142751 RVA: 0x009E6402 File Offset: 0x009E4602
		protected virtual float OnGetTimeDilation()
		{
			return this.ViewInfo.TimeDilation;
		}

		// Token: 0x06022DA0 RID: 142752 RVA: 0x009E640F File Offset: 0x009E460F
		protected virtual string OnGetBgm()
		{
			return this.ViewInfo.LoopAudioEvent;
		}

		// Token: 0x06022DA1 RID: 142753 RVA: 0x009E641C File Offset: 0x009E461C
		public void SetLoadingFinishOperation(Action finishOperation)
		{
			this.OperationQueue.Push(finishOperation);
		}

		// Token: 0x06022DA2 RID: 142754 RVA: 0x009E642A File Offset: 0x009E462A
		public void HandleAllLoadingFinishOperation()
		{
			while (this.OperationQueue.Size > 0)
			{
				Action action = this.OperationQueue.Pop();
				if (action != null)
				{
					action();
				}
			}
		}

		// Token: 0x06022DA3 RID: 142755 RVA: 0x009E6452 File Offset: 0x009E4652
		public void ResetOperationQueue()
		{
			this.OperationQueue.Clear();
		}

		// Token: 0x06022DA4 RID: 142756 RVA: 0x009E645F File Offset: 0x009E465F
		public virtual string GetBlackScreenTypeOnOpenViewLoadScene()
		{
			return "Start";
		}

		// Token: 0x06022DA5 RID: 142757 RVA: 0x009E6466 File Offset: 0x009E4666
		public virtual string GetBlackScreenTypeOnShowViewLoadScene()
		{
			return "Start";
		}

		// Token: 0x06022DA6 RID: 142758 RVA: 0x009E646D File Offset: 0x009E466D
		public virtual string GetBlackScreenStyle()
		{
			return "Default";
		}

		// Token: 0x06022DA7 RID: 142759 RVA: 0x009E6474 File Offset: 0x009E4674
		public virtual string GetBlackScreenStyleOnOpen()
		{
			return this.GetBlackScreenStyle();
		}

		// Token: 0x06022DA8 RID: 142760 RVA: 0x009E647C File Offset: 0x009E467C
		public virtual string GetBlackScreenStyleOnClose()
		{
			return this.GetBlackScreenStyle();
		}

		// Token: 0x06022DA9 RID: 142761 RVA: 0x009E6484 File Offset: 0x009E4684
		public bool WillLoadScene()
		{
			return !this.SkipLoadScene && !string.IsNullOrEmpty(this.ViewInfo.SceneId) && this.OnCheckIfNeedScene() && UiSceneManager.Instance.CurUiSceneId != this.ViewInfo.SceneId;
		}

		// Token: 0x06022DAA RID: 142762 RVA: 0x009E64C4 File Offset: 0x009E46C4
		public bool WillReleaseScene()
		{
			return !this.SkipReleaseScene && this.SceneLoaded;
		}

		// Token: 0x06022DAB RID: 142763 RVA: 0x009E64D8 File Offset: 0x009E46D8
		public virtual UniTask LoadScene()
		{
			UiViewBase.<LoadScene>d__113 <LoadScene>d__;
			<LoadScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadScene>d__.<>4__this = this;
			<LoadScene>d__.<>1__state = -1;
			<LoadScene>d__.<>t__builder.Start<UiViewBase.<LoadScene>d__113>(ref <LoadScene>d__);
			return <LoadScene>d__.<>t__builder.Task;
		}

		// Token: 0x06022DAC RID: 142764 RVA: 0x009E651C File Offset: 0x009E471C
		public virtual UniTask ReleaseScene()
		{
			UiViewBase.<ReleaseScene>d__114 <ReleaseScene>d__;
			<ReleaseScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReleaseScene>d__.<>4__this = this;
			<ReleaseScene>d__.<>1__state = -1;
			<ReleaseScene>d__.<>t__builder.Start<UiViewBase.<ReleaseScene>d__114>(ref <ReleaseScene>d__);
			return <ReleaseScene>d__.<>t__builder.Task;
		}

		// Token: 0x06022DAD RID: 142765 RVA: 0x009E655F File Offset: 0x009E475F
		public void OnPreOpen()
		{
			this.IsPreOpening = true;
		}

		// Token: 0x06022DAE RID: 142766 RVA: 0x009E6568 File Offset: 0x009E4768
		public void OnOpenAfterPreOpened()
		{
			this.IsPreOpening = false;
			if (this.GetOriginalItem() != null)
			{
				this.GetOriginalItem().SetUIParent(this.GetLayerRoot(), false);
			}
		}

		// Token: 0x06022DAF RID: 142767 RVA: 0x009E658C File Offset: 0x009E478C
		public void SetParentUiItem(UUIItem parentUiItem)
		{
			if (this.ParentUiItem == parentUiItem)
			{
				return;
			}
			this.ParentUiItem = parentUiItem;
			UUIItem rootItem = base.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetUIParent(this.ParentUiItem, false);
			}
		}

		// Token: 0x06022DB0 RID: 142768 RVA: 0x009E65C4 File Offset: 0x009E47C4
		public UniTask ClearAsync()
		{
			UiViewBase.<ClearAsync>d__118 <ClearAsync>d__;
			<ClearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAsync>d__.<>4__this = this;
			<ClearAsync>d__.<>1__state = -1;
			<ClearAsync>d__.<>t__builder.Start<UiViewBase.<ClearAsync>d__118>(ref <ClearAsync>d__);
			return <ClearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022DB1 RID: 142769 RVA: 0x009E6608 File Offset: 0x009E4808
		private bool GetCacheWorldFrame()
		{
			switch (this.ViewInfo.LockWorldRender)
			{
			case EViewLockWorldRenderType.Default:
				return this.ViewInfo.Type == ELayerType.Normal && string.IsNullOrEmpty(this.ViewInfo.SceneId);
			case EViewLockWorldRenderType.ForceLock:
				return true;
			case EViewLockWorldRenderType.Ignore:
				return false;
			default:
				return false;
			}
		}

		// Token: 0x06022DB2 RID: 142770 RVA: 0x009E665C File Offset: 0x009E485C
		public void ApplyPerformanceLimit()
		{
			bool cacheWorldFrame = this.GetCacheWorldFrame();
			if (!cacheWorldFrame && !this.ViewInfo.LockFrameRate)
			{
				return;
			}
			GameSettingsDeviceRender.Instance.ApplyPerformanceLimit(this.ViewInfo.Name.ToString(), cacheWorldFrame, this.ViewInfo.LockFrameRate);
		}

		// Token: 0x06022DB3 RID: 142771 RVA: 0x009E66B0 File Offset: 0x009E48B0
		public void CancelPerformanceLimit()
		{
			GameSettingsDeviceRender.Instance.CancelPerformanceLimit(this.ViewInfo.Name.ToString());
		}

		// Token: 0x06022DB4 RID: 142772 RVA: 0x009E66E0 File Offset: 0x009E48E0
		public void ApplyPerformanceSeqLimit()
		{
			bool flag = this.ViewInfo.LockWorldRender == EViewLockWorldRenderType.SeqLock;
			if (!flag && !this.ViewInfo.LockFrameRate)
			{
				return;
			}
			GameSettingsDeviceRender.Instance.ApplyPerformanceLimit(this.ViewInfo.Name.ToString() + "_Seq", flag, this.ViewInfo.LockFrameRate);
		}

		// Token: 0x06022DB5 RID: 142773 RVA: 0x009E6748 File Offset: 0x009E4948
		public void CancelPerformanceSeqLimit()
		{
			GameSettingsDeviceRender.Instance.CancelPerformanceLimit(this.ViewInfo.Name.ToString() + "_Seq");
		}

		// Token: 0x0401340C RID: 78860
		public readonly UiViewInfo ViewInfo;

		// Token: 0x0401340D RID: 78861
		[Nullable(2)]
		public IUiPopFrameInterface ChildPopView;

		// Token: 0x0401340E RID: 78862
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0401340F RID: 78863
		[Nullable(2)]
		protected UiBehaviourUiBlur UiBlurBehaviour;

		// Token: 0x04013410 RID: 78864
		[Nullable(2)]
		protected UiBehaviourHomeBtn UiBehaviourHomeBtn;

		// Token: 0x04013411 RID: 78865
		[Nullable(2)]
		protected string AudioEvent;

		// Token: 0x04013412 RID: 78866
		private bool FirstShow = true;

		// Token: 0x04013413 RID: 78867
		public bool LastHide;

		// Token: 0x04013414 RID: 78868
		protected PlayResult PlayEventResult = new PlayResult();

		// Token: 0x04013415 RID: 78869
		private bool LastUiSceneRendering;

		// Token: 0x04013416 RID: 78870
		public bool IsPreOpening;

		// Token: 0x04013417 RID: 78871
		public bool IsDestroyByClear;

		// Token: 0x04013418 RID: 78872
		public bool IsExistInLeaveLevel;

		// Token: 0x04013419 RID: 78873
		[Nullable(2)]
		public CustomPromise<bool> OpenPromise;

		// Token: 0x0401341A RID: 78874
		[Nullable(2)]
		public CustomPromise ClosePromise;

		// Token: 0x0401341B RID: 78875
		[Nullable(2)]
		public CustomPromise ShowPromise;

		// Token: 0x0401341C RID: 78876
		[Nullable(2)]
		public CustomPromise HidePromise;

		// Token: 0x0401341D RID: 78877
		[Nullable(2)]
		public CustomPromise LoadScenePromise;

		// Token: 0x0401341E RID: 78878
		private bool SkipAnimViewFlow;

		// Token: 0x0401341F RID: 78879
		public readonly string MaskTag;

		// Token: 0x04013420 RID: 78880
		private readonly Queue<Action> OperationQueue = new Queue<Action>(4);

		// Token: 0x04013421 RID: 78881
		public bool SkipLoadScene;

		// Token: 0x04013422 RID: 78882
		public bool SkipReleaseScene;

		// Token: 0x04013423 RID: 78883
		public bool SceneLoaded;

		// Token: 0x04013424 RID: 78884
		public bool SkipRemoveBlackScreen;
	}
}
