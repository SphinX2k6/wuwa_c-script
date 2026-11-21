using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200405B RID: 16475
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotTextAudioComponent
	{
		// Token: 0x06029C0C RID: 171020 RVA: 0x00BCB347 File Offset: 0x00BC9547
		public void Init(PlotTextAudioComponentContext context)
		{
			this.OnAudioStartDelegate = context.OnAudioStartDelegate;
			this.OnAudioEndDelegate = context.OnAudioEndDelegate;
			this.OnAudioLoadTimeoutDelegate = context.OnAudioLoadTimeoutDelegate;
		}

		// Token: 0x06029C0D RID: 171021 RVA: 0x00BCB370 File Offset: 0x00BC9570
		public bool PlayTalkAudio(PlotTextAudioComponentPlayTalkContext context)
		{
			if (this.IsPlaying || this.IsLoading)
			{
				return false;
			}
			this.IsLoading = true;
			PlotAudio plotAudioConfig = context.PlotAudioConfig;
			ExternalSourceSetting? config = ConfigExternalSourceSettingById.GetConfig(plotAudioConfig.ExternalSourceSetting, true);
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(plotAudioConfig);
			string eventName = AudioSystem.Instance.parseAudioEventPath(config.Value.SubtitleEvent);
			this.PlayType = EPlotTextAudioComponentPlayType.Talk;
			this.PlayTalkContext = context;
			int id = this.UniqueId;
			AActor target = null;
			this.PlotPlayEventResult = AudioSystem.Instance.PostEvent(eventName, target, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = config.Value.SubtitleSrc,
				ExternalSourceMediaName = externalSourcesMediaName,
				CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					this.OnAudioPlayCallback(id, eventName, callbackType, callbackInfo);
				}
			}));
			this.AddAudioLoadTimeoutTimer();
			return true;
		}

		// Token: 0x06029C0E RID: 171022 RVA: 0x00BCB470 File Offset: 0x00BC9670
		public bool TryPlayTalkAudioByTalkItem(ITalkItem talkItem)
		{
			PlotAudio? plotAudio = (talkItem.PlayVoice != null && talkItem.PlayVoice.Value) ? ConfigPlotAudioById.GetConfig(talkItem.TidTalk, true) : null;
			if (plotAudio == null)
			{
				return false;
			}
			PlotTextAudioComponentPlayTalkContext context = new PlotTextAudioComponentPlayTalkContext
			{
				PlotAudioConfig = plotAudio.Value
			};
			return this.PlayTalkAudio(context);
		}

		// Token: 0x06029C0F RID: 171023 RVA: 0x00BCB4DC File Offset: 0x00BC96DC
		public bool PlayTone(PlotTextAudioComponentPlayToneContext context)
		{
			if (this.IsPlaying || this.IsLoading)
			{
				return false;
			}
			Interjection? config = ConfigInterjectionByTimberIdAndUniversalToneId.GetConfig(context.TimberId, context.UniversalToneId, true);
			if (config == null)
			{
				return false;
			}
			string eventName = AudioSystem.Instance.parseAudioEventPath(config.Value.AkEvent);
			int id = this.UniqueId;
			this.EventName = eventName;
			this.PlayType = EPlotTextAudioComponentPlayType.Tone;
			this.PlayToneContext = context;
			this.IsLoading = true;
			AActor target = null;
			this.PlotPlayEventResult = AudioSystem.Instance.PostEvent(eventName, target, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					this.OnAudioPlayCallback(id, eventName, callbackType, callbackInfo);
				}
			}));
			this.AddAudioLoadTimeoutTimer();
			return true;
		}

		// Token: 0x06029C10 RID: 171024 RVA: 0x00BCB5C4 File Offset: 0x00BC97C4
		public bool TryPlayToneByTalkItem(ITalkItem talkItem)
		{
			if (this.IsPlaying || this.IsLoading)
			{
				return false;
			}
			IUniversalTone universalTone = talkItem.UniversalTone;
			if (universalTone != null && universalTone.TimberId != null)
			{
				bool flag;
				if (universalTone == null)
				{
					flag = true;
				}
				else
				{
					int universalToneId = universalTone.UniversalToneId;
					flag = false;
				}
				if (!flag)
				{
					PlotTextAudioComponentPlayToneContext context = new PlotTextAudioComponentPlayToneContext
					{
						TimberId = universalTone.TimberId.Value,
						UniversalToneId = universalTone.UniversalToneId
					};
					return this.PlayTone(context);
				}
			}
			return false;
		}

		// Token: 0x06029C11 RID: 171025 RVA: 0x00BCB63C File Offset: 0x00BC983C
		[NullableContext(2)]
		public void PlayAkEvent(IPostAkEventType config)
		{
			if (config == null)
			{
				return;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(((IPostAkEventGlobal)config).AkEvent);
			if (text == null)
			{
				return;
			}
			if (config.Type == EPostAkEvent.Global)
			{
				AudioSystem.Instance.PostEvent(text);
				return;
			}
			if (config.Type == EPostAkEvent.Target)
			{
				int entityId = ((IPostAkEventTargeted)config).EntityId;
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
				if (entityByPbDataId == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Event;
					ELogAuthor author = ELogAuthor.LZK;
					string message = "实体不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				BaseActorComponent component = entityByPbDataId.Entity.GetComponent<BaseActorComponent>();
				AActor aactor = (component != null) ? component.Owner : null;
				if (aactor == null || !aactor.IsValid())
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Event;
					ELogAuthor author2 = ELogAuthor.LZK;
					string message2 = "未能获取到该实体对应的有效Actor";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entityId);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				AudioSystem.Instance.PostEvent(text, aactor, null);
			}
		}

		// Token: 0x06029C12 RID: 171026 RVA: 0x00BCB73E File Offset: 0x00BC993E
		public void PlayTalkItemStartEvent(ITalkItem talkItem)
		{
			this.PlayAkEvent(talkItem.TalkAkEvent);
		}

		// Token: 0x06029C13 RID: 171027 RVA: 0x00BCB74C File Offset: 0x00BC994C
		public void PlayTalkItemEndEvent(ITalkItem talkItem)
		{
			this.PlayAkEvent(talkItem.TalkEndAkEvent);
		}

		// Token: 0x06029C14 RID: 171028 RVA: 0x00BCB75C File Offset: 0x00BC995C
		public void PauseAudio()
		{
			if (this.IsPaused)
			{
				return;
			}
			if (!this.IsLoading && this.PlotPlayEventResult == 0)
			{
				return;
			}
			if (this.IsLoading)
			{
				TimerHandle audioLoadTimeoutTimer = this.AudioLoadTimeoutTimer;
				if (audioLoadTimeoutTimer != null)
				{
					audioLoadTimeoutTimer.Pause();
				}
			}
			if (this.PlotPlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(1000)
				}));
			}
			this.IsPaused = true;
		}

		// Token: 0x06029C15 RID: 171029 RVA: 0x00BCB7DC File Offset: 0x00BC99DC
		public void ResumeAudio()
		{
			if (!this.IsPaused)
			{
				return;
			}
			if (this.CurLang != LanguageSystem.Instance.PackageAudio)
			{
				this.CurLang = LanguageSystem.Instance.PackageAudio;
				this.StopAudio();
				this.Replay();
				return;
			}
			if (this.IsLoading)
			{
				TimerHandle audioLoadTimeoutTimer = this.AudioLoadTimeoutTimer;
				if (audioLoadTimeoutTimer != null)
				{
					audioLoadTimeoutTimer.Resume();
				}
			}
			if (this.PlotPlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(1000)
				}));
			}
			this.IsPaused = false;
		}

		// Token: 0x06029C16 RID: 171030 RVA: 0x00BCB880 File Offset: 0x00BC9A80
		public void StopAudio()
		{
			this.RemoveAudioLoadTimeoutTimer();
			this.UniqueId++;
			AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.PlotPlayEventResult = 0;
			this.EventName = "";
			this.IsPlaying = false;
			this.IsLoading = false;
			this.IsPaused = false;
		}

		// Token: 0x06029C17 RID: 171031 RVA: 0x00BCB8F4 File Offset: 0x00BC9AF4
		public void Replay()
		{
			EPlotTextAudioComponentPlayType playType = this.PlayType;
			if (playType != EPlotTextAudioComponentPlayType.Talk)
			{
				if (playType != EPlotTextAudioComponentPlayType.Tone)
				{
					return;
				}
				if (this.PlayToneContext == null)
				{
					return;
				}
				this.PlayTone(this.PlayToneContext);
				return;
			}
			else
			{
				if (this.PlayTalkContext == null)
				{
					return;
				}
				this.PlayTalkAudio(this.PlayTalkContext);
				return;
			}
		}

		// Token: 0x06029C18 RID: 171032 RVA: 0x00BCB940 File Offset: 0x00BC9B40
		protected unsafe void OnAudioPlayCallback(int id, string eventName, EAkCallbackType callbackType, [Nullable(2)] UAkCallbackInfo callbackInfo)
		{
			if (id != this.UniqueId)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "[PlotViewHud] 废弃的音频回调";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventName", eventName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("type", callbackType);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (callbackType == EAkCallbackType.EndOfEvent)
			{
				this.OnAudioEnd();
				return;
			}
			if (callbackType == EAkCallbackType.Duration)
			{
				this.AudioDuration = ((UAkDurationCallbackInfo)callbackInfo).Duration;
				this.OnAudioStart();
			}
		}

		// Token: 0x06029C19 RID: 171033 RVA: 0x00BCB9F4 File Offset: 0x00BC9BF4
		protected void AddAudioLoadTimeoutTimer()
		{
			if (this.AudioLoadTimeoutTimer != null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 音频加载超时定时器已存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!this.IsLoading)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 未处于音频加载状态，无法添加音频加载超时定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsPlaying)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 正在播放音频，无法添加音频加载超时定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.AudioLoadTimeoutTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnAudioLoadTimeout), 3000f, null, null, true, 1f);
		}

		// Token: 0x06029C1A RID: 171034 RVA: 0x00BCBA99 File Offset: 0x00BC9C99
		protected void RemoveAudioLoadTimeoutTimer()
		{
			if (this.AudioLoadTimeoutTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AudioLoadTimeoutTimer);
				this.AudioLoadTimeoutTimer = null;
			}
		}

		// Token: 0x06029C1B RID: 171035 RVA: 0x00BCBABB File Offset: 0x00BC9CBB
		protected void OnAudioStart()
		{
			this.IsLoading = false;
			this.IsPlaying = true;
			this.RemoveAudioLoadTimeoutTimer();
			Action onAudioStartDelegate = this.OnAudioStartDelegate;
			if (onAudioStartDelegate == null)
			{
				return;
			}
			onAudioStartDelegate();
		}

		// Token: 0x06029C1C RID: 171036 RVA: 0x00BCBAE1 File Offset: 0x00BC9CE1
		protected void OnAudioEnd()
		{
			this.IsPlaying = false;
			this.PlotPlayEventResult = 0;
			this.UniqueId++;
			Action onAudioEndDelegate = this.OnAudioEndDelegate;
			if (onAudioEndDelegate == null)
			{
				return;
			}
			onAudioEndDelegate();
		}

		// Token: 0x06029C1D RID: 171037 RVA: 0x00BCBB10 File Offset: 0x00BC9D10
		protected void OnAudioLoadTimeout(float _)
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 音频加载超时", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.StopAudio();
			Action onAudioLoadTimeoutDelegate = this.OnAudioLoadTimeoutDelegate;
			if (onAudioLoadTimeoutDelegate == null)
			{
				return;
			}
			onAudioLoadTimeoutDelegate();
		}

		// Token: 0x06029C1E RID: 171038 RVA: 0x00BCBB4F File Offset: 0x00BC9D4F
		public float GetAudioDuration()
		{
			return this.AudioDuration;
		}

		// Token: 0x06029C1F RID: 171039 RVA: 0x00BCBB57 File Offset: 0x00BC9D57
		public bool GetIsPlaying()
		{
			return this.IsPlaying;
		}

		// Token: 0x06029C20 RID: 171040 RVA: 0x00BCBB5F File Offset: 0x00BC9D5F
		public bool GetIsLoading()
		{
			return this.IsLoading;
		}

		// Token: 0x06029C21 RID: 171041 RVA: 0x00BCBB67 File Offset: 0x00BC9D67
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x06029C22 RID: 171042 RVA: 0x00BCBB6F File Offset: 0x00BC9D6F
		public EPlotTextAudioComponentPlayType GetPlayType()
		{
			return this.PlayType;
		}

		// Token: 0x06029C23 RID: 171043 RVA: 0x00BCBB77 File Offset: 0x00BC9D77
		public string GetEventName()
		{
			return this.EventName;
		}

		// Token: 0x04016C68 RID: 93288
		private int UniqueId;

		// Token: 0x04016C69 RID: 93289
		private string EventName = "";

		// Token: 0x04016C6A RID: 93290
		private float AudioDuration;

		// Token: 0x04016C6B RID: 93291
		private EPlotTextAudioComponentPlayType PlayType;

		// Token: 0x04016C6C RID: 93292
		[Nullable(2)]
		private PlotTextAudioComponentPlayTalkContext PlayTalkContext;

		// Token: 0x04016C6D RID: 93293
		[Nullable(2)]
		private PlotTextAudioComponentPlayToneContext PlayToneContext;

		// Token: 0x04016C6E RID: 93294
		private int PlotPlayEventResult;

		// Token: 0x04016C6F RID: 93295
		private bool IsPlaying;

		// Token: 0x04016C70 RID: 93296
		private bool IsLoading;

		// Token: 0x04016C71 RID: 93297
		private bool IsPaused;

		// Token: 0x04016C72 RID: 93298
		[Nullable(2)]
		private TimerHandle AudioLoadTimeoutTimer;

		// Token: 0x04016C73 RID: 93299
		private string CurLang = LanguageSystem.Instance.PackageAudio;

		// Token: 0x04016C74 RID: 93300
		[Nullable(2)]
		private Action OnAudioStartDelegate;

		// Token: 0x04016C75 RID: 93301
		[Nullable(2)]
		private Action OnAudioEndDelegate;

		// Token: 0x04016C76 RID: 93302
		[Nullable(2)]
		private Action OnAudioLoadTimeoutDelegate;
	}
}
