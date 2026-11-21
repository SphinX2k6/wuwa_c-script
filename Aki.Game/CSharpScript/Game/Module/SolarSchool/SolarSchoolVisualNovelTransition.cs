using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A76 RID: 23158
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelTransition
	{
		// Token: 0x17006CBF RID: 27839
		// (get) Token: 0x060390EC RID: 233708 RVA: 0x00FFACA1 File Offset: 0x00FF8EA1
		public bool IsLoadingSequencePlaying
		{
			get
			{
				UMovieSceneSequencePlayer sequencePlayer = this.SequencePlayer;
				return sequencePlayer != null && sequencePlayer.IsPlaying();
			}
		}

		// Token: 0x060390ED RID: 233709 RVA: 0x00FFACB4 File Offset: 0x00FF8EB4
		public SolarSchoolVisualNovelTransition([Nullable(2)] Action<VisualNovelDate, bool> setTime, VisualNovelContext context, SolarSchoolRootView rootView)
		{
			this.SetTime = setTime;
			this.Context = context;
			this.RootView = rootView;
			this.RegisterTransition<IVisualNovelTransitionTime>(delegate(IVisualNovelTransitionTime transition, EVisualNovelPlaybackMode _)
			{
				IVisualNovelDate endDate = transition.EndDate;
				VisualNovelDate date = this.Context.Date;
				VisualNovelDate arg = (endDate != null) ? new VisualNovelDate(endDate.Month, endDate.Day, transition.EndPeriodId) : new VisualNovelDate(date.Month, date.Day, transition.EndPeriodId);
				Action<VisualNovelDate, bool> setTime2 = this.SetTime;
				if (setTime2 != null)
				{
					setTime2(arg, transition.IsFullScreen.GetValueOrDefault());
				}
				return UniTask.CompletedTask;
			});
			this.RegisterTransition<IVisualNovelTransitionLocation>(new SolarSchoolVisualNovelTransition.TypedTransitionHandler<IVisualNovelTransitionLocation>(this.PlayLocationAsync));
		}

		// Token: 0x060390EE RID: 233710 RVA: 0x00FFAD0C File Offset: 0x00FF8F0C
		public UniTask PlayAsync(IVisualNovelPerformanceTransition performance, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelTransition.<PlayAsync>d__12 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.performance = performance;
			<PlayAsync>d__.playbackMode = playbackMode;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelTransition.<PlayAsync>d__12>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390EF RID: 233711 RVA: 0x00FFAD60 File Offset: 0x00FF8F60
		private UniTask PlayLocationAsync(IVisualNovelTransitionLocation location, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelTransition.<PlayLocationAsync>d__13 <PlayLocationAsync>d__;
			<PlayLocationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayLocationAsync>d__.<>4__this = this;
			<PlayLocationAsync>d__.location = location;
			<PlayLocationAsync>d__.playbackMode = playbackMode;
			<PlayLocationAsync>d__.<>1__state = -1;
			<PlayLocationAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelTransition.<PlayLocationAsync>d__13>(ref <PlayLocationAsync>d__);
			return <PlayLocationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390F0 RID: 233712 RVA: 0x00FFADB3 File Offset: 0x00FF8FB3
		public void OnLoadingViewReady(SolarSchoolLocationChangeLoadingView view)
		{
			this.LoadingView = view;
		}

		// Token: 0x060390F1 RID: 233713 RVA: 0x00FFADBC File Offset: 0x00FF8FBC
		public void UpdateLoadingSequence()
		{
			if (this.SequencePlayer != null)
			{
				return;
			}
			SolarSchoolLocationChangeLoadingView loadingView = this.LoadingView;
			AUIBaseActor auibaseActor = ((loadingView != null) ? loadingView.GetRootItem().GetOwner() : null) as AUIBaseActor;
			ULevelSequencePlayer ulevelSequencePlayer;
			if (auibaseActor == null)
			{
				ulevelSequencePlayer = null;
			}
			else
			{
				ALevelSequenceActor sequencePlayerByKey = auibaseActor.GetSequencePlayerByKey("Start");
				ulevelSequencePlayer = ((sequencePlayerByKey != null) ? sequencePlayerByKey.SequencePlayer : null);
			}
			ULevelSequencePlayer ulevelSequencePlayer2 = ulevelSequencePlayer;
			if (ulevelSequencePlayer2 == null)
			{
				return;
			}
			this.SequencePlayer = ulevelSequencePlayer2;
			this.SetPlaybackRate(this.Context.PlaybackRate);
			if (this.Context.IsPaused)
			{
				this.SetPaused(true);
			}
			if (this.CompletionRequested)
			{
				this.Finish();
			}
		}

		// Token: 0x060390F2 RID: 233714 RVA: 0x00FFAE4A File Offset: 0x00FF904A
		public void SetPlaybackRate(float playbackRate)
		{
			UMovieSceneSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(playbackRate);
		}

		// Token: 0x060390F3 RID: 233715 RVA: 0x00FFAE5D File Offset: 0x00FF905D
		public void SetPaused(bool paused)
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			if (paused)
			{
				this.SequencePlayer.Pause();
				return;
			}
			this.SequencePlayer.Play();
		}

		// Token: 0x060390F4 RID: 233716 RVA: 0x00FFAE82 File Offset: 0x00FF9082
		public void Finish()
		{
			this.CompletionRequested = true;
			SolarSchoolLocationChangeLoadingView loadingView = this.LoadingView;
			if (loadingView == null)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = loadingView.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.StopSequenceByKey("Start", true, true);
		}

		// Token: 0x060390F5 RID: 233717 RVA: 0x00FFAEAC File Offset: 0x00FF90AC
		private void RegisterTransition<[Nullable(0)] TTransition>(SolarSchoolVisualNovelTransition.TypedTransitionHandler<TTransition> handler) where TTransition : IVisualNovelTransitionConfigBase
		{
			this.TransitionHandlers[typeof(TTransition)] = ((IVisualNovelTransitionConfigBase transition, EVisualNovelPlaybackMode playbackMode) => handler((TTransition)((object)transition), playbackMode));
		}

		// Token: 0x060390F6 RID: 233718 RVA: 0x00FFAEE8 File Offset: 0x00FF90E8
		private static void LogInvalidConfig(string message, [Nullable(2)] string configType = null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.VisualNovel;
			ELogAuthor author = ELogAuthor.LZK;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configType", configType ?? string.Empty);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0401E058 RID: 122968
		[Nullable(2)]
		private readonly Action<VisualNovelDate, bool> SetTime;

		// Token: 0x0401E059 RID: 122969
		private readonly Dictionary<Type, SolarSchoolVisualNovelTransition.TransitionHandler> TransitionHandlers = new Dictionary<Type, SolarSchoolVisualNovelTransition.TransitionHandler>();

		// Token: 0x0401E05A RID: 122970
		private readonly VisualNovelContext Context;

		// Token: 0x0401E05B RID: 122971
		private readonly SolarSchoolRootView RootView;

		// Token: 0x0401E05C RID: 122972
		[Nullable(2)]
		private SolarSchoolLocationChangeLoadingView LoadingView;

		// Token: 0x0401E05D RID: 122973
		[Nullable(2)]
		private UMovieSceneSequencePlayer SequencePlayer;

		// Token: 0x0401E05E RID: 122974
		private bool CompletionRequested;

		// Token: 0x0200B677 RID: 46711
		// (Invoke) Token: 0x06047D3A RID: 294202
		[NullableContext(0)]
		private delegate UniTask TransitionHandler(IVisualNovelTransitionConfigBase transition, EVisualNovelPlaybackMode playbackMode);

		// Token: 0x0200B678 RID: 46712
		// (Invoke) Token: 0x06047D3E RID: 294206
		[NullableContext(0)]
		private delegate UniTask TypedTransitionHandler<in TTransition>(TTransition transition, EVisualNovelPlaybackMode playbackMode) where TTransition : IVisualNovelTransitionConfigBase;
	}
}
