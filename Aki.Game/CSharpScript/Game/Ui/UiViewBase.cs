using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200463F RID: 17983
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiViewBase : UiPanelBase
	{
		// Token: 0x0602E60A RID: 189962 RVA: 0x00AB804C File Offset: 0x00AB624C
		protected UiViewBase(UiViewInfo viewInfo)
		{
			this.ViewInfo = viewInfo;
			this.MaskTag = ((viewInfo != null) ? viewInfo.Name.ToString() : null) + this.ComponentId.ToString();
			this.MemoryTag = UiConfig.Instance.GetMemoryTag(viewInfo.Name);
		}

		// Token: 0x170075FA RID: 30202
		// (get) Token: 0x0602E60B RID: 189963 RVA: 0x00AB80CA File Offset: 0x00AB62CA
		public bool IsQueueView
		{
			get
			{
				return this.ViewInfo.SortIndex >= 0;
			}
		}

		// Token: 0x0602E60C RID: 189964 RVA: 0x00AB80DD File Offset: 0x00AB62DD
		[NullableContext(2)]
		public override CustomPromise GetClosePromiseImplement()
		{
			return this.ClosePromise;
		}

		// Token: 0x0602E60D RID: 189965 RVA: 0x00AB80E5 File Offset: 0x00AB62E5
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x0602E60E RID: 189966 RVA: 0x00AB80E7 File Offset: 0x00AB62E7
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x0602E60F RID: 189967 RVA: 0x00AB80E9 File Offset: 0x00AB62E9
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E610 RID: 189968 RVA: 0x00AB80F0 File Offset: 0x00AB62F0
		protected virtual void OnAfterPlayStartSequence()
		{
		}

		// Token: 0x0602E611 RID: 189969 RVA: 0x00AB80F2 File Offset: 0x00AB62F2
		protected virtual void OnBeforePlayCloseSequence()
		{
		}

		// Token: 0x0602E612 RID: 189970 RVA: 0x00AB80F4 File Offset: 0x00AB62F4
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E613 RID: 189971 RVA: 0x00AB80FB File Offset: 0x00AB62FB
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E614 RID: 189972 RVA: 0x00AB8102 File Offset: 0x00AB6302
		protected virtual bool OnCheckIfNeedScene()
		{
			return true;
		}

		// Token: 0x0602E615 RID: 189973 RVA: 0x00AB8105 File Offset: 0x00AB6305
		protected virtual void OnHandleLoadScene()
		{
		}

		// Token: 0x0602E616 RID: 189974 RVA: 0x00AB8108 File Offset: 0x00AB6308
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

		// Token: 0x0602E617 RID: 189975 RVA: 0x00AB8153 File Offset: 0x00AB6353
		protected virtual UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E618 RID: 189976 RVA: 0x00AB815A File Offset: 0x00AB635A
		protected virtual void OnHandlePostLoadScene(bool isSceneLoad)
		{
		}

		// Token: 0x0602E619 RID: 189977 RVA: 0x00AB815C File Offset: 0x00AB635C
		protected virtual void OnHandleReleaseScene()
		{
		}

		// Token: 0x0602E61A RID: 189978 RVA: 0x00AB8160 File Offset: 0x00AB6360
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

		// Token: 0x0602E61B RID: 189979 RVA: 0x00AB81AB File Offset: 0x00AB63AB
		protected virtual UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E61C RID: 189980 RVA: 0x00AB81B2 File Offset: 0x00AB63B2
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

		// Token: 0x0602E61D RID: 189981 RVA: 0x00AB81CC File Offset: 0x00AB63CC
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

		// Token: 0x0602E61E RID: 189982 RVA: 0x00AB8208 File Offset: 0x00AB6408
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

		// Token: 0x0602E61F RID: 189983 RVA: 0x00AB824B File Offset: 0x00AB644B
		public int GetViewId()
		{
			return this.ComponentId;
		}

		// Token: 0x0602E620 RID: 189984 RVA: 0x00AB8254 File Offset: 0x00AB6454
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

		// Token: 0x0602E621 RID: 189985 RVA: 0x00AB8294 File Offset: 0x00AB6494
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

		// Token: 0x0602E622 RID: 189986 RVA: 0x00AB82F8 File Offset: 0x00AB64F8
		protected void PlayOrReplaySequence(string sequenceName, bool blockClick = false, int? playRate = null)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			int? num = playRate;
			uiViewSequence.PlayOrReplaySequenceByName(sequenceName, blockClick, (num != null) ? new float?((float)num.GetValueOrDefault()) : null);
		}

		// Token: 0x0602E623 RID: 189987 RVA: 0x00AB8335 File Offset: 0x00AB6535
		[NullableContext(2)]
		protected void SetAudioEvent(string audioEvent)
		{
			this.AudioEvent = audioEvent;
		}

		// Token: 0x0602E624 RID: 189988 RVA: 0x00AB833E File Offset: 0x00AB653E
		protected virtual void RegisterUiBehavior()
		{
			this.InitUiViewSequenceBehavior();
			this.RegisterUiBlur();
			this.RegisterUiAudio();
			this.RegisterUiBehaviorHomeBtn();
		}

		// Token: 0x0602E625 RID: 189989 RVA: 0x00AB8358 File Offset: 0x00AB6558
		private void PlayViewSequence(string sequenceName, [Nullable(2)] Action onStop = null)
		{
			this.PlaySequence(sequenceName, onStop, (this.ViewInfo.Type & (ELayerType.Normal | ELayerType.Plot | ELayerType.Pop)) > (ELayerType)0);
		}

		// Token: 0x0602E626 RID: 189990 RVA: 0x00AB8374 File Offset: 0x00AB6574
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

		// Token: 0x0602E627 RID: 189991 RVA: 0x00AB83BF File Offset: 0x00AB65BF
		public void PauseCurrentSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PauseSequence();
		}

		// Token: 0x0602E628 RID: 189992 RVA: 0x00AB83D1 File Offset: 0x00AB65D1
		public void ResumeCurrentSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.ResumeSequence();
		}

		// Token: 0x0602E629 RID: 189993 RVA: 0x00AB83E3 File Offset: 0x00AB65E3
		private void InitUiViewSequenceBehavior()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			this.UiViewSequence.SetSequenceName(this.OpenParam as UiViewData);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x0602E62A RID: 189994 RVA: 0x00AB8414 File Offset: 0x00AB6614
		private void RegisterUiBlur()
		{
			UiBehaviourUiBlur uiBehaviourUiBlur = new UiBehaviourUiBlur();
			this.UiBlurBehaviour = uiBehaviourUiBlur;
			uiBehaviourUiBlur.SetCurrentLayer(this.ViewInfo.Type);
			uiBehaviourUiBlur.SetViewInfo(this);
			base.AddUiBehavior(uiBehaviourUiBlur);
		}

		// Token: 0x0602E62B RID: 189995 RVA: 0x00AB8450 File Offset: 0x00AB6650
		private void RegisterUiAudio()
		{
			UiBehaviorAudio behavior = new UiBehaviorAudio(this);
			base.AddUiBehavior(behavior);
		}

		// Token: 0x0602E62C RID: 189996 RVA: 0x00AB846C File Offset: 0x00AB666C
		private void RegisterUiBehaviorHomeBtn()
		{
			UiBehaviourHomeBtn uiBehaviourHomeBtn = new UiBehaviourHomeBtn();
			this.UiBehaviourHomeBtn = uiBehaviourHomeBtn;
			uiBehaviourHomeBtn.SetViewInfo(this);
			base.AddUiBehavior(uiBehaviourHomeBtn);
		}

		// Token: 0x0602E62D RID: 189997 RVA: 0x00AB8494 File Offset: 0x00AB6694
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

		// Token: 0x0602E62E RID: 189998 RVA: 0x00AB84DF File Offset: 0x00AB66DF
		public string GetLoopAudioEvent()
		{
			return this.OnGetLoopAudioEvent();
		}

		// Token: 0x0602E62F RID: 189999 RVA: 0x00AB84E7 File Offset: 0x00AB66E7
		public void RefreshUiBlurBehaviour()
		{
			UiBehaviourUiBlur uiBlurBehaviour = this.UiBlurBehaviour;
			if (uiBlurBehaviour == null)
			{
				return;
			}
			uiBlurBehaviour.RefreshBlur();
		}

		// Token: 0x0602E630 RID: 190000 RVA: 0x00AB84F9 File Offset: 0x00AB66F9
		public UUIItem GetBlurRootItem()
		{
			return this.OnGetBlurRootItem();
		}

		// Token: 0x0602E631 RID: 190001 RVA: 0x00AB8501 File Offset: 0x00AB6701
		protected virtual UUIItem OnGetBlurRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x0602E632 RID: 190002 RVA: 0x00AB8509 File Offset: 0x00AB6709
		public virtual bool GetLoopAudioEventSwitch()
		{
			return true;
		}

		// Token: 0x0602E633 RID: 190003 RVA: 0x00AB850C File Offset: 0x00AB670C
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

		// Token: 0x0602E634 RID: 190004 RVA: 0x00AB85D0 File Offset: 0x00AB67D0
		public void InitRootActorLoadInfo()
		{
			UiViewInfo viewInfo = this.ViewInfo;
			base.SetRootActorLoadInfoByPath(viewInfo.UiPath, this.GetLayerRoot(), viewInfo.SourceType == ESourceType.UiActorPool, viewInfo.IsPermanent);
		}

		// Token: 0x0602E635 RID: 190005 RVA: 0x00AB8605 File Offset: 0x00AB6805
		protected virtual void OnBeforeCreateImplementImplement()
		{
		}

		// Token: 0x0602E636 RID: 190006 RVA: 0x00AB8607 File Offset: 0x00AB6807
		protected override void OnBeforeCreateImplement()
		{
			this.RegisterUiBehavior();
			this.OnBeforeCreateImplementImplement();
		}

		// Token: 0x0602E637 RID: 190007 RVA: 0x00AB8618 File Offset: 0x00AB6818
		protected override void OnAfterCreateImplement()
		{
			if (this.IsExistInLeaveLevel || UiManager.Instance.IsLockOpen)
			{
				Log.Instance.Info(ELogModule.UiCore, ELogAuthor.XXJ, "场景切换过程中, 设置无缝加载标记", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SetViewPermanent();
			}
		}

		// Token: 0x0602E638 RID: 190008 RVA: 0x00AB865C File Offset: 0x00AB685C
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

		// Token: 0x0602E639 RID: 190009 RVA: 0x00AB86C4 File Offset: 0x00AB68C4
		protected override UniTask OnCreateAsyncImplementImplement()
		{
			UiViewBase.<OnCreateAsyncImplementImplement>d__69 <OnCreateAsyncImplementImplement>d__;
			<OnCreateAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsyncImplementImplement>d__.<>1__state = -1;
			<OnCreateAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnCreateAsyncImplementImplement>d__69>(ref <OnCreateAsyncImplementImplement>d__);
			return <OnCreateAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E63A RID: 190010 RVA: 0x00AB86FF File Offset: 0x00AB68FF
		protected virtual void OnStartImplementImplement()
		{
		}

		// Token: 0x0602E63B RID: 190011 RVA: 0x00AB8704 File Offset: 0x00AB6904
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

		// Token: 0x0602E63C RID: 190012 RVA: 0x00AB87C0 File Offset: 0x00AB69C0
		protected virtual void OnBeforeShowImplementImplement()
		{
		}

		// Token: 0x0602E63D RID: 190013 RVA: 0x00AB87C4 File Offset: 0x00AB69C4
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			UiViewBase.<OnBeforeShowAsyncImplement>d__73 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<UiViewBase.<OnBeforeShowAsyncImplement>d__73>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E63E RID: 190014 RVA: 0x00AB8807 File Offset: 0x00AB6A07
		protected virtual UniTask OnBeforeShowAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E63F RID: 190015 RVA: 0x00AB8810 File Offset: 0x00AB6A10
		private UniTask OnBeforeShowAsync()
		{
			UiViewBase.<OnBeforeShowAsync>d__75 <OnBeforeShowAsync>d__;
			<OnBeforeShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsync>d__.<>4__this = this;
			<OnBeforeShowAsync>d__.<>1__state = -1;
			<OnBeforeShowAsync>d__.<>t__builder.Start<UiViewBase.<OnBeforeShowAsync>d__75>(ref <OnBeforeShowAsync>d__);
			return <OnBeforeShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E640 RID: 190016 RVA: 0x00AB8853 File Offset: 0x00AB6A53
		protected override void OnBeforeShowImplement()
		{
			this.OnAddEventListener();
			this.OnBeforeShowImplementImplement();
			this.ApplyPerformanceLimit();
		}

		// Token: 0x0602E641 RID: 190017 RVA: 0x00AB8868 File Offset: 0x00AB6A68
		protected override UniTask OnShowAsyncImplementImplement()
		{
			UiViewBase.<OnShowAsyncImplementImplement>d__77 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnShowAsyncImplementImplement>d__77>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E642 RID: 190018 RVA: 0x00AB88AC File Offset: 0x00AB6AAC
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

		// Token: 0x0602E643 RID: 190019 RVA: 0x00AB8920 File Offset: 0x00AB6B20
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

		// Token: 0x0602E644 RID: 190020 RVA: 0x00AB897C File Offset: 0x00AB6B7C
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

		// Token: 0x0602E645 RID: 190021 RVA: 0x00AB89FC File Offset: 0x00AB6BFC
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

		// Token: 0x0602E646 RID: 190022 RVA: 0x00AB8A84 File Offset: 0x00AB6C84
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

		// Token: 0x0602E647 RID: 190023 RVA: 0x00AB8B18 File Offset: 0x00AB6D18
		protected override UniTask OnHideAsyncImplementImplement()
		{
			UiViewBase.<OnHideAsyncImplementImplement>d__83 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnHideAsyncImplementImplement>d__83>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E648 RID: 190024 RVA: 0x00AB8B5C File Offset: 0x00AB6D5C
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

		// Token: 0x0602E649 RID: 190025 RVA: 0x00AB8BCF File Offset: 0x00AB6DCF
		protected virtual void OnAfterHideImplementImplement()
		{
		}

		// Token: 0x0602E64A RID: 190026 RVA: 0x00AB8BD1 File Offset: 0x00AB6DD1
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

		// Token: 0x0602E64B RID: 190027 RVA: 0x00AB8C10 File Offset: 0x00AB6E10
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			UiViewBase.<OnDestroyAsyncImplementImplement>d__87 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<UiViewBase.<OnDestroyAsyncImplementImplement>d__87>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E64C RID: 190028 RVA: 0x00AB8C53 File Offset: 0x00AB6E53
		protected override void OnDestroyAsyncImplementImplementCompatible()
		{
			this.ChildPopView = null;
			this.ResetOperationQueue();
			UiManager.Instance.RemoveView(this.GetViewId());
		}

		// Token: 0x0602E64D RID: 190029 RVA: 0x00AB8C74 File Offset: 0x00AB6E74
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

		// Token: 0x0602E64E RID: 190030 RVA: 0x00AB8D09 File Offset: 0x00AB6F09
		public void AddChildViewById(int childViewId)
		{
			base.AddChild(UiManager.Instance.GetView(childViewId));
		}

		// Token: 0x0602E64F RID: 190031 RVA: 0x00AB8D1C File Offset: 0x00AB6F1C
		private UniTask PlayViewCloseSequenceAsync()
		{
			UiViewBase.<PlayViewCloseSequenceAsync>d__91 <PlayViewCloseSequenceAsync>d__;
			<PlayViewCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayViewCloseSequenceAsync>d__.<>4__this = this;
			<PlayViewCloseSequenceAsync>d__.<>1__state = -1;
			<PlayViewCloseSequenceAsync>d__.<>t__builder.Start<UiViewBase.<PlayViewCloseSequenceAsync>d__91>(ref <PlayViewCloseSequenceAsync>d__);
			return <PlayViewCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E650 RID: 190032 RVA: 0x00AB8D60 File Offset: 0x00AB6F60
		private UniTask PlayViewHideSequenceAsync()
		{
			UiViewBase.<PlayViewHideSequenceAsync>d__92 <PlayViewHideSequenceAsync>d__;
			<PlayViewHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayViewHideSequenceAsync>d__.<>4__this = this;
			<PlayViewHideSequenceAsync>d__.<>1__state = -1;
			<PlayViewHideSequenceAsync>d__.<>t__builder.Start<UiViewBase.<PlayViewHideSequenceAsync>d__92>(ref <PlayViewHideSequenceAsync>d__);
			return <PlayViewHideSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E651 RID: 190033 RVA: 0x00AB8DA3 File Offset: 0x00AB6FA3
		protected void DeleteCloseSequence()
		{
			this.UiViewSequence.CloseSequenceName = "Close";
		}

		// Token: 0x0602E652 RID: 190034 RVA: 0x00AB8DB5 File Offset: 0x00AB6FB5
		public ELayerType GetLayer()
		{
			return this.OnGetLayer();
		}

		// Token: 0x0602E653 RID: 190035 RVA: 0x00AB8DBD File Offset: 0x00AB6FBD
		protected virtual ELayerType OnGetLayer()
		{
			return this.ViewInfo.Type;
		}

		// Token: 0x0602E654 RID: 190036 RVA: 0x00AB8DCA File Offset: 0x00AB6FCA
		public float GetTimeDilation()
		{
			return this.OnGetTimeDilation();
		}

		// Token: 0x0602E655 RID: 190037 RVA: 0x00AB8DD2 File Offset: 0x00AB6FD2
		protected virtual float OnGetTimeDilation()
		{
			return this.ViewInfo.TimeDilation;
		}

		// Token: 0x0602E656 RID: 190038 RVA: 0x00AB8DDF File Offset: 0x00AB6FDF
		protected virtual string OnGetLoopAudioEvent()
		{
			return this.ViewInfo.LoopAudioEvent;
		}

		// Token: 0x0602E657 RID: 190039 RVA: 0x00AB8DEC File Offset: 0x00AB6FEC
		public void SetLoadingFinishOperation(Action finishOperation)
		{
			this.OperationQueue.Push(finishOperation);
		}

		// Token: 0x0602E658 RID: 190040 RVA: 0x00AB8DFA File Offset: 0x00AB6FFA
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

		// Token: 0x0602E659 RID: 190041 RVA: 0x00AB8E22 File Offset: 0x00AB7022
		public void ResetOperationQueue()
		{
			this.OperationQueue.Clear();
		}

		// Token: 0x0602E65A RID: 190042 RVA: 0x00AB8E2F File Offset: 0x00AB702F
		public virtual string GetBlackScreenTypeOnOpenViewLoadScene()
		{
			return "Start";
		}

		// Token: 0x0602E65B RID: 190043 RVA: 0x00AB8E36 File Offset: 0x00AB7036
		public virtual string GetBlackScreenTypeOnShowViewLoadScene()
		{
			return "Start";
		}

		// Token: 0x0602E65C RID: 190044 RVA: 0x00AB8E3D File Offset: 0x00AB703D
		public virtual string GetBlackScreenStyle()
		{
			return "Default";
		}

		// Token: 0x0602E65D RID: 190045 RVA: 0x00AB8E44 File Offset: 0x00AB7044
		public virtual string GetBlackScreenStyleOnOpen()
		{
			return this.GetBlackScreenStyle();
		}

		// Token: 0x0602E65E RID: 190046 RVA: 0x00AB8E4C File Offset: 0x00AB704C
		public virtual string GetBlackScreenStyleOnClose()
		{
			return this.GetBlackScreenStyle();
		}

		// Token: 0x0602E65F RID: 190047 RVA: 0x00AB8E54 File Offset: 0x00AB7054
		public bool WillLoadScene()
		{
			return !this.SkipLoadScene && !string.IsNullOrEmpty(this.ViewInfo.SceneId) && this.OnCheckIfNeedScene() && UiSceneManager.Instance.CurUiSceneId != this.ViewInfo.SceneId;
		}

		// Token: 0x0602E660 RID: 190048 RVA: 0x00AB8E94 File Offset: 0x00AB7094
		public bool WillReleaseScene()
		{
			return !this.SkipReleaseScene && this.SceneLoaded;
		}

		// Token: 0x0602E661 RID: 190049 RVA: 0x00AB8EA8 File Offset: 0x00AB70A8
		public virtual UniTask LoadScene()
		{
			UiViewBase.<LoadScene>d__113 <LoadScene>d__;
			<LoadScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadScene>d__.<>4__this = this;
			<LoadScene>d__.<>1__state = -1;
			<LoadScene>d__.<>t__builder.Start<UiViewBase.<LoadScene>d__113>(ref <LoadScene>d__);
			return <LoadScene>d__.<>t__builder.Task;
		}

		// Token: 0x0602E662 RID: 190050 RVA: 0x00AB8EEC File Offset: 0x00AB70EC
		public virtual UniTask ReleaseScene()
		{
			UiViewBase.<ReleaseScene>d__114 <ReleaseScene>d__;
			<ReleaseScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReleaseScene>d__.<>4__this = this;
			<ReleaseScene>d__.<>1__state = -1;
			<ReleaseScene>d__.<>t__builder.Start<UiViewBase.<ReleaseScene>d__114>(ref <ReleaseScene>d__);
			return <ReleaseScene>d__.<>t__builder.Task;
		}

		// Token: 0x0602E663 RID: 190051 RVA: 0x00AB8F2F File Offset: 0x00AB712F
		public void OnPreOpen()
		{
			this.IsPreOpening = true;
		}

		// Token: 0x0602E664 RID: 190052 RVA: 0x00AB8F38 File Offset: 0x00AB7138
		public void OnOpenAfterPreOpened()
		{
			this.IsPreOpening = false;
			if (this.GetOriginalItem() != null)
			{
				this.GetOriginalItem().SetUIParent(this.GetLayerRoot(), false);
			}
		}

		// Token: 0x0602E665 RID: 190053 RVA: 0x00AB8F5C File Offset: 0x00AB715C
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

		// Token: 0x0602E666 RID: 190054 RVA: 0x00AB8F94 File Offset: 0x00AB7194
		public UniTask ClearAsync()
		{
			UiViewBase.<ClearAsync>d__118 <ClearAsync>d__;
			<ClearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAsync>d__.<>4__this = this;
			<ClearAsync>d__.<>1__state = -1;
			<ClearAsync>d__.<>t__builder.Start<UiViewBase.<ClearAsync>d__118>(ref <ClearAsync>d__);
			return <ClearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E667 RID: 190055 RVA: 0x00AB8FD8 File Offset: 0x00AB71D8
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

		// Token: 0x0602E668 RID: 190056 RVA: 0x00AB902C File Offset: 0x00AB722C
		public void ApplyPerformanceLimit()
		{
			bool cacheWorldFrame = this.GetCacheWorldFrame();
			if (!cacheWorldFrame && !this.ViewInfo.LockFrameRate)
			{
				return;
			}
			GameSettingsDeviceRender.Instance.ApplyPerformanceLimit(this.ViewInfo.Name.ToString(), cacheWorldFrame, this.ViewInfo.LockFrameRate);
		}

		// Token: 0x0602E669 RID: 190057 RVA: 0x00AB9080 File Offset: 0x00AB7280
		public void CancelPerformanceLimit()
		{
			GameSettingsDeviceRender.Instance.CancelPerformanceLimit(this.ViewInfo.Name.ToString());
		}

		// Token: 0x0602E66A RID: 190058 RVA: 0x00AB90B0 File Offset: 0x00AB72B0
		public void ApplyPerformanceSeqLimit()
		{
			bool flag = this.ViewInfo.LockWorldRender == EViewLockWorldRenderType.SeqLock;
			if (!flag && !this.ViewInfo.LockFrameRate)
			{
				return;
			}
			GameSettingsDeviceRender.Instance.ApplyPerformanceLimit(this.ViewInfo.Name.ToString() + "_Seq", flag, this.ViewInfo.LockFrameRate);
		}

		// Token: 0x0602E66B RID: 190059 RVA: 0x00AB9118 File Offset: 0x00AB7318
		public void CancelPerformanceSeqLimit()
		{
			GameSettingsDeviceRender.Instance.CancelPerformanceLimit(this.ViewInfo.Name.ToString() + "_Seq");
		}

		// Token: 0x04018DB3 RID: 101811
		public readonly UiViewInfo ViewInfo;

		// Token: 0x04018DB4 RID: 101812
		[Nullable(2)]
		public IUiPopFrameInterface ChildPopView;

		// Token: 0x04018DB5 RID: 101813
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x04018DB6 RID: 101814
		[Nullable(2)]
		protected UiBehaviourUiBlur UiBlurBehaviour;

		// Token: 0x04018DB7 RID: 101815
		[Nullable(2)]
		protected UiBehaviourHomeBtn UiBehaviourHomeBtn;

		// Token: 0x04018DB8 RID: 101816
		[Nullable(2)]
		protected string AudioEvent;

		// Token: 0x04018DB9 RID: 101817
		private bool FirstShow = true;

		// Token: 0x04018DBA RID: 101818
		public bool LastHide;

		// Token: 0x04018DBB RID: 101819
		protected PlayResult PlayEventResult = new PlayResult();

		// Token: 0x04018DBC RID: 101820
		private bool LastUiSceneRendering;

		// Token: 0x04018DBD RID: 101821
		public bool IsPreOpening;

		// Token: 0x04018DBE RID: 101822
		public bool IsDestroyByClear;

		// Token: 0x04018DBF RID: 101823
		public bool IsExistInLeaveLevel;

		// Token: 0x04018DC0 RID: 101824
		[Nullable(2)]
		public CustomPromise<bool> OpenPromise;

		// Token: 0x04018DC1 RID: 101825
		[Nullable(2)]
		public CustomPromise ClosePromise;

		// Token: 0x04018DC2 RID: 101826
		[Nullable(2)]
		public CustomPromise ShowPromise;

		// Token: 0x04018DC3 RID: 101827
		[Nullable(2)]
		public CustomPromise HidePromise;

		// Token: 0x04018DC4 RID: 101828
		[Nullable(2)]
		public CustomPromise LoadScenePromise;

		// Token: 0x04018DC5 RID: 101829
		private bool SkipAnimViewFlow;

		// Token: 0x04018DC6 RID: 101830
		public readonly string MaskTag;

		// Token: 0x04018DC7 RID: 101831
		private readonly Queue<Action> OperationQueue = new Queue<Action>(4);

		// Token: 0x04018DC8 RID: 101832
		public bool SkipLoadScene;

		// Token: 0x04018DC9 RID: 101833
		public bool SkipReleaseScene;

		// Token: 0x04018DCA RID: 101834
		public bool SceneLoaded;

		// Token: 0x04018DCB RID: 101835
		public bool SkipRemoveBlackScreen;
	}
}
