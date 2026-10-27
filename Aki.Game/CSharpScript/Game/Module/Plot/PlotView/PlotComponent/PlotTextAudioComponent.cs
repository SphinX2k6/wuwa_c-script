using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200508B RID: 20619
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotTextAudioComponent
	{
		// Token: 0x06034D17 RID: 216343 RVA: 0x00C7DF6F File Offset: 0x00C7C16F
		public void Init(PlotTextAudioComponentContext context)
		{
			this.OnAudioStartDelegate = context.OnAudioStartDelegate;
			this.OnAudioEndDelegate = context.OnAudioEndDelegate;
			this.OnAudioLoadTimeoutDelegate = context.OnAudioLoadTimeoutDelegate;
		}

		// Token: 0x06034D18 RID: 216344 RVA: 0x00C7DF98 File Offset: 0x00C7C198
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

		// Token: 0x06034D19 RID: 216345 RVA: 0x00C7E098 File Offset: 0x00C7C298
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

		// Token: 0x06034D1A RID: 216346 RVA: 0x00C7E104 File Offset: 0x00C7C304
		public bool PlayTone(PlotTextAudioComponentPlayToneContext context)
		{
			if (this.IsPlaying || this.IsLoading)
			{
				return false;
			}
			this.IsLoading = true;
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

		// Token: 0x06034D1B RID: 216347 RVA: 0x00C7E1EC File Offset: 0x00C7C3EC
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

		// Token: 0x06034D1C RID: 216348 RVA: 0x00C7E264 File Offset: 0x00C7C464
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

		// Token: 0x06034D1D RID: 216349 RVA: 0x00C7E366 File Offset: 0x00C7C566
		public void PlayTalkItemStartEvent(ITalkItem talkItem)
		{
			this.PlayAkEvent(talkItem.TalkAkEvent);
		}

		// Token: 0x06034D1E RID: 216350 RVA: 0x00C7E374 File Offset: 0x00C7C574
		public void PlayTalkItemEndEvent(ITalkItem talkItem)
		{
			this.PlayAkEvent(talkItem.TalkEndAkEvent);
		}

		// Token: 0x06034D1F RID: 216351 RVA: 0x00C7E384 File Offset: 0x00C7C584
		public void PauseAudio()
		{
			if (this.IsPaused)
			{
				return;
			}
			if (this.IsLoading)
			{
				TimerHandle audioLoadTimeoutTimer = this.AudioLoadTimeoutTimer;
				if (audioLoadTimeoutTimer == null)
				{
					return;
				}
				audioLoadTimeoutTimer.Pause();
				return;
			}
			else
			{
				if (this.PlotPlayEventResult == 0)
				{
					return;
				}
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(1000)
				}));
				this.IsPaused = true;
				return;
			}
		}

		// Token: 0x06034D20 RID: 216352 RVA: 0x00C7E3F4 File Offset: 0x00C7C5F4
		public void ResumeAudio()
		{
			if (!this.IsPaused)
			{
				return;
			}
			if (this.IsLoading)
			{
				TimerHandle audioLoadTimeoutTimer = this.AudioLoadTimeoutTimer;
				if (audioLoadTimeoutTimer == null)
				{
					return;
				}
				audioLoadTimeoutTimer.Resume();
				return;
			}
			else
			{
				if (this.PlotPlayEventResult == 0)
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
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(1000)
				}));
				this.IsPaused = false;
				return;
			}
		}

		// Token: 0x06034D21 RID: 216353 RVA: 0x00C7E498 File Offset: 0x00C7C698
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

		// Token: 0x06034D22 RID: 216354 RVA: 0x00C7E50C File Offset: 0x00C7C70C
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

		// Token: 0x06034D23 RID: 216355 RVA: 0x00C7E558 File Offset: 0x00C7C758
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

		// Token: 0x06034D24 RID: 216356 RVA: 0x00C7E60C File Offset: 0x00C7C80C
		protected void AddAudioLoadTimeoutTimer()
		{
			if (this.AudioLoadTimeoutTimer != null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 音频加载超时定时器已存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsLoading)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 正在加载音频，无法添加音频加载超时定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsPlaying)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 正在播放音频，无法添加音频加载超时定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.AudioLoadTimeoutTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnAudioLoadTimeout), 3000f, null, null, true, 1f);
		}

		// Token: 0x06034D25 RID: 216357 RVA: 0x00C7E6B1 File Offset: 0x00C7C8B1
		protected void RemoveAudioLoadTimeoutTimer()
		{
			if (this.AudioLoadTimeoutTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AudioLoadTimeoutTimer);
				this.AudioLoadTimeoutTimer = null;
			}
		}

		// Token: 0x06034D26 RID: 216358 RVA: 0x00C7E6D3 File Offset: 0x00C7C8D3
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

		// Token: 0x06034D27 RID: 216359 RVA: 0x00C7E6F9 File Offset: 0x00C7C8F9
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

		// Token: 0x06034D28 RID: 216360 RVA: 0x00C7E728 File Offset: 0x00C7C928
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

		// Token: 0x06034D29 RID: 216361 RVA: 0x00C7E767 File Offset: 0x00C7C967
		public float GetAudioDuration()
		{
			return this.AudioDuration;
		}

		// Token: 0x06034D2A RID: 216362 RVA: 0x00C7E76F File Offset: 0x00C7C96F
		public bool GetIsPlaying()
		{
			return this.IsPlaying;
		}

		// Token: 0x06034D2B RID: 216363 RVA: 0x00C7E777 File Offset: 0x00C7C977
		public bool GetIsLoading()
		{
			return this.IsLoading;
		}

		// Token: 0x06034D2C RID: 216364 RVA: 0x00C7E77F File Offset: 0x00C7C97F
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x06034D2D RID: 216365 RVA: 0x00C7E787 File Offset: 0x00C7C987
		public EPlotTextAudioComponentPlayType GetPlayType()
		{
			return this.PlayType;
		}

		// Token: 0x06034D2E RID: 216366 RVA: 0x00C7E78F File Offset: 0x00C7C98F
		public string GetEventName()
		{
			return this.EventName;
		}

		// Token: 0x0401C23D RID: 115261
		private int UniqueId;

		// Token: 0x0401C23E RID: 115262
		private string EventName = "";

		// Token: 0x0401C23F RID: 115263
		private float AudioDuration;

		// Token: 0x0401C240 RID: 115264
		private EPlotTextAudioComponentPlayType PlayType;

		// Token: 0x0401C241 RID: 115265
		[Nullable(2)]
		private PlotTextAudioComponentPlayTalkContext PlayTalkContext;

		// Token: 0x0401C242 RID: 115266
		[Nullable(2)]
		private PlotTextAudioComponentPlayToneContext PlayToneContext;

		// Token: 0x0401C243 RID: 115267
		private int PlotPlayEventResult;

		// Token: 0x0401C244 RID: 115268
		private bool IsPlaying;

		// Token: 0x0401C245 RID: 115269
		private bool IsLoading;

		// Token: 0x0401C246 RID: 115270
		private bool IsPaused;

		// Token: 0x0401C247 RID: 115271
		[Nullable(2)]
		private TimerHandle AudioLoadTimeoutTimer;

		// Token: 0x0401C248 RID: 115272
		private string CurLang = LanguageSystem.Instance.PackageAudio;

		// Token: 0x0401C249 RID: 115273
		[Nullable(2)]
		private Action OnAudioStartDelegate;

		// Token: 0x0401C24A RID: 115274
		[Nullable(2)]
		private Action OnAudioEndDelegate;

		// Token: 0x0401C24B RID: 115275
		[Nullable(2)]
		private Action OnAudioLoadTimeoutDelegate;
	}
}
