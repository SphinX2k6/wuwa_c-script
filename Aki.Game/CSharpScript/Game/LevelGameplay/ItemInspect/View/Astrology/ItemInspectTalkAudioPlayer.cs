using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02005F69 RID: 24425
	[NullableContext(2)]
	[Nullable(0)]
	public class ItemInspectTalkAudioPlayer
	{
		// Token: 0x0603ABB1 RID: 240561 RVA: 0x0109AB84 File Offset: 0x01098D84
		public void Play(ITalkItem talkItem)
		{
			PlotAudio? plotAudio = (talkItem != null && talkItem.PlayVoice.GetValueOrDefault() && !string.IsNullOrEmpty(talkItem.TidTalk)) ? ConfigPlotAudioById.GetConfig(talkItem.TidTalk, true) : null;
			if (plotAudio == null)
			{
				return;
			}
			ExternalSourceSetting? config = ConfigExternalSourceSettingById.GetConfig(plotAudio.Value.ExternalSourceSetting, true);
			if (config == null)
			{
				return;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(config.Value.SubtitleEvent);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(plotAudio.Value);
			this.CallbackEnableId++;
			int id = this.CallbackEnableId;
			AActor target = null;
			this.PlotPlayEventResult = AudioSystem.Instance.PostEvent(text, target, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = config.Value.SubtitleSrc,
				ExternalSourceMediaName = externalSourcesMediaName,
				CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (id != this.CallbackEnableId)
					{
						return;
					}
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						this.RemoveWaitAudioLoadTimer();
						this.PlotPlayEventResult = 0;
						this.CallbackEnableId++;
						return;
					}
					if (callbackType == EAkCallbackType.Duration)
					{
						this.RemoveWaitAudioLoadTimer();
					}
				}
			}));
			this.WaitAudioLoadTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				global::Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.LYY, "物品检视，加载剧情音频超时", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.Stop();
			}, 3000f, null, null, true, 1f);
		}

		// Token: 0x0603ABB2 RID: 240562 RVA: 0x0109ACE4 File Offset: 0x01098EE4
		public void Stop()
		{
			this.RemoveWaitAudioLoadTimer();
			this.CallbackEnableId++;
			if (this.PlotPlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
			this.PlotPlayEventResult = 0;
		}

		// Token: 0x0603ABB3 RID: 240563 RVA: 0x0109AD40 File Offset: 0x01098F40
		private void RemoveWaitAudioLoadTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.WaitAudioLoadTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.WaitAudioLoadTimer);
			}
			this.WaitAudioLoadTimer = null;
		}

		// Token: 0x0401EDF1 RID: 126449
		private const int MAX_LOAD_AUDIO_TIME = 3000;

		// Token: 0x0401EDF2 RID: 126450
		private TimerHandle WaitAudioLoadTimer;

		// Token: 0x0401EDF3 RID: 126451
		private int PlotPlayEventResult;

		// Token: 0x0401EDF4 RID: 126452
		private int CallbackEnableId;
	}
}
