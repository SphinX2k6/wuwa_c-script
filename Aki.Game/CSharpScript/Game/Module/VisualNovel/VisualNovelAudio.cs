using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.Plot;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x0200379D RID: 14237
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelAudio
	{
		// Token: 0x06025074 RID: 151668 RVA: 0x00A752AC File Offset: 0x00A734AC
		public VisualNovelAudio(VisualNovelAssetCache assets)
		{
			this.Assets = assets;
		}

		// Token: 0x06025075 RID: 151669 RVA: 0x00A752D0 File Offset: 0x00A734D0
		[return: Nullable(2)]
		public VisualNovelAudioEvent PlayEvent(string audioEvent, float fadeOutTime, bool completeByDuration = true)
		{
			if (string.IsNullOrEmpty(audioEvent))
			{
				global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, "视觉小说音频事件缺少 AudioEvent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(audioEvent);
			if (string.IsNullOrEmpty(text))
			{
				global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, "视觉小说音频事件的 AudioEvent 路径无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			VisualNovelAudioEvent visualNovelAudioEvent = new VisualNovelAudioEvent(text, fadeOutTime, new Action<VisualNovelAudioEvent>(this.OnEventCompleted), "", "", completeByDuration, null);
			this.Events.Add(visualNovelAudioEvent);
			visualNovelAudioEvent.Play();
			return visualNovelAudioEvent;
		}

		// Token: 0x06025076 RID: 151670 RVA: 0x00A75370 File Offset: 0x00A73570
		[return: Nullable(2)]
		public VisualNovelAudioEvent PlayVoice(VisualNovelItem item)
		{
			bool flag;
			return this.PlayVoice(item, out flag);
		}

		// Token: 0x06025077 RID: 151671 RVA: 0x00A75388 File Offset: 0x00A73588
		[return: Nullable(2)]
		public VisualNovelAudioEvent PlayVoice(VisualNovelItem item, out bool playedRecordedVoice)
		{
			playedRecordedVoice = false;
			if (!this.VoiceEnabled)
			{
				return null;
			}
			VisualNovelAudioEvent visualNovelAudioEvent = this.CreateRecordedVoice(item);
			bool flag = visualNovelAudioEvent == null;
			if (flag)
			{
				visualNovelAudioEvent = this.CreateInterjection(item);
			}
			if (visualNovelAudioEvent == null)
			{
				return null;
			}
			VisualNovelAudioEvent voice = this.Voice;
			this.Events.Add(visualNovelAudioEvent);
			this.Voice = visualNovelAudioEvent;
			if (!visualNovelAudioEvent.Play())
			{
				this.Voice = voice;
				return null;
			}
			playedRecordedVoice = !flag;
			this.VoiceSpeakerId = item.SpeakerId;
			if (voice != null)
			{
				voice.Stop();
			}
			return visualNovelAudioEvent;
		}

		// Token: 0x06025078 RID: 151672 RVA: 0x00A7540B File Offset: 0x00A7360B
		[NullableContext(2)]
		public VisualNovelAudioEvent GetVoice(int speakerId)
		{
			if (this.VoiceSpeakerId != speakerId)
			{
				return null;
			}
			return this.Voice;
		}

		// Token: 0x06025079 RID: 151673 RVA: 0x00A75420 File Offset: 0x00A73620
		[return: Nullable(2)]
		private VisualNovelAudioEvent CreateRecordedVoice(VisualNovelItem item)
		{
			if (!item.PlayVoice || string.IsNullOrEmpty(item.TextKey))
			{
				return null;
			}
			PlotAudio? config = ConfigPlotAudioById.GetConfig(item.TextKey, true);
			if (config == null)
			{
				return null;
			}
			ExternalSourceSetting? config2 = ConfigExternalSourceSettingById.GetConfig(config.Value.ExternalSourceSetting, true);
			if (config2 == null)
			{
				return null;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(config2.Value.SubtitleEvent);
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(config2.Value.SubtitleSrc))
			{
				return null;
			}
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config.Value);
			SpineMouthAnimation mouthAnimation = this.Assets.GetMouthAnimation(externalSourcesMediaName);
			return new VisualNovelAudioEvent(text, 0f, new Action<VisualNovelAudioEvent>(this.OnEventCompleted), config2.Value.SubtitleSrc, externalSourcesMediaName, false, mouthAnimation);
		}

		// Token: 0x0602507A RID: 151674 RVA: 0x00A75508 File Offset: 0x00A73708
		[return: Nullable(2)]
		private VisualNovelAudioEvent CreateInterjection(VisualNovelItem item)
		{
			if (string.IsNullOrEmpty(item.Interjection))
			{
				return null;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(item.Interjection);
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			return new VisualNovelAudioEvent(text, 0f, new Action<VisualNovelAudioEvent>(this.OnEventCompleted), "", "", false, null);
		}

		// Token: 0x0602507B RID: 151675 RVA: 0x00A75562 File Offset: 0x00A73762
		public UniTask WaitVoiceAsync()
		{
			VisualNovelAudioEvent voice = this.Voice;
			if (voice == null)
			{
				return UniTask.CompletedTask;
			}
			return voice.Completion;
		}

		// Token: 0x0602507C RID: 151676 RVA: 0x00A75579 File Offset: 0x00A73779
		public void StopVoice()
		{
			VisualNovelAudioEvent voice = this.Voice;
			this.Voice = null;
			if (voice == null)
			{
				return;
			}
			voice.Stop();
		}

		// Token: 0x0602507D RID: 151677 RVA: 0x00A75594 File Offset: 0x00A73794
		public void SetVoiceEnabled(bool enabled)
		{
			this.VoiceEnabled = enabled;
			if (!this.VoiceEnabled)
			{
				this.StopVoice();
			}
		}

		// Token: 0x0602507E RID: 151678 RVA: 0x00A755AC File Offset: 0x00A737AC
		public void SetPlaybackRate(float playbackRate)
		{
			foreach (VisualNovelAudioEvent visualNovelAudioEvent in this.Events)
			{
				visualNovelAudioEvent.SetPlaybackRate(playbackRate);
			}
		}

		// Token: 0x0602507F RID: 151679 RVA: 0x00A75600 File Offset: 0x00A73800
		public void SetPaused(bool paused)
		{
			foreach (VisualNovelAudioEvent visualNovelAudioEvent in this.Events)
			{
				visualNovelAudioEvent.SetPaused(paused);
			}
		}

		// Token: 0x06025080 RID: 151680 RVA: 0x00A75654 File Offset: 0x00A73854
		[NullableContext(2)]
		public void SwitchState(IAudioState audioState)
		{
			if (audioState == null)
			{
				global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, "视觉小说 SwitchAudioState 缺少 AudioState", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			GameAudioController.Instance.UpdateAudioStatebyClient(audioState);
		}

		// Token: 0x06025081 RID: 151681 RVA: 0x00A75690 File Offset: 0x00A73890
		public void Dispose()
		{
			foreach (VisualNovelAudioEvent visualNovelAudioEvent in new List<VisualNovelAudioEvent>(this.Events))
			{
				visualNovelAudioEvent.Stop();
			}
			this.StopVoice();
		}

		// Token: 0x06025082 RID: 151682 RVA: 0x00A756EC File Offset: 0x00A738EC
		private void OnEventCompleted(VisualNovelAudioEvent audioEvent)
		{
			this.Events.Remove(audioEvent);
			if (this.Voice == audioEvent)
			{
				this.Voice = null;
			}
		}

		// Token: 0x040147B4 RID: 83892
		private readonly HashSet<VisualNovelAudioEvent> Events = new HashSet<VisualNovelAudioEvent>();

		// Token: 0x040147B5 RID: 83893
		private readonly VisualNovelAssetCache Assets;

		// Token: 0x040147B6 RID: 83894
		[Nullable(2)]
		private VisualNovelAudioEvent Voice;

		// Token: 0x040147B7 RID: 83895
		private int VoiceSpeakerId;

		// Token: 0x040147B8 RID: 83896
		private bool VoiceEnabled = true;
	}
}
