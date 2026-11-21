using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004017 RID: 16407
	[NullableContext(1)]
	[Nullable(0)]
	public class MusicSubtitleView : UiTickViewBase
	{
		// Token: 0x170053E2 RID: 21474
		// (get) Token: 0x06029863 RID: 170083 RVA: 0x00BB9179 File Offset: 0x00BB7379
		private int RequestId
		{
			get
			{
				MusicSubtitleManager.IMusicSubtitleViewParam musicSubtitleViewParam = this.OpenParam as MusicSubtitleManager.IMusicSubtitleViewParam;
				if (musicSubtitleViewParam == null)
				{
					return 0;
				}
				return musicSubtitleViewParam.RequestId;
			}
		}

		// Token: 0x170053E3 RID: 21475
		// (get) Token: 0x06029864 RID: 170084 RVA: 0x00BB9191 File Offset: 0x00BB7391
		private bool IsStoppedOrClosing
		{
			get
			{
				return this.IsStopped || this.ClosePromise != null || this.WaitToDestroy || this.IsDestroyByClear || base.IsDestroyOrDestroying;
			}
		}

		// Token: 0x06029865 RID: 170085 RVA: 0x00BB91BC File Offset: 0x00BB73BC
		public unsafe MusicSubtitleView(UiViewInfo viewInfo) : base(viewInfo)
		{
			this.AudioListener = new MusicSubtitleManager.MusicSubtitleViewListener
			{
				OnAudioReset = new Action(this.ResetSubtitle),
				OnAudioStart = delegate(float position, string @event)
				{
					if (this.IsStoppedOrClosing)
					{
						return;
					}
					this.CurrentTime = position;
					this.IsPlaying = true;
					this.ResetAudioStartTimeByCurrentTime();
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "[MusicSubtitle] 音乐字幕播放开始";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("akEvent", @event);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StartTime", this.AudioStartTime);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StartPosition", position);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				},
				OnAudioEnd = delegate(string @event)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "[MusicSubtitle] 音乐字幕播放结束";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("akEvent", @event);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.StopAndClose();
				}
			};
		}

		// Token: 0x06029866 RID: 170086 RVA: 0x00BB9228 File Offset: 0x00BB7428
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029867 RID: 170087 RVA: 0x00BB9294 File Offset: 0x00BB7494
		protected unsafe override void OnStart()
		{
			if (this.IsStoppedOrClosing)
			{
				return;
			}
			this.ResetSubtitle();
			string musicSubtitleGroupTag = MusicSubtitleManager.GetMusicSubtitleGroupTag(this.RequestId);
			if (string.IsNullOrEmpty(musicSubtitleGroupTag))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[MusicSubtitle] 音乐字幕配置错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", musicSubtitleGroupTag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RequestId", this.RequestId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.StopAndClose();
				return;
			}
			IReadOnlyList<MusicSubTitle> musicSubtitle = MusicSubtitleConfig.Instance.GetMusicSubtitle(musicSubtitleGroupTag);
			if (musicSubtitle == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "[MusicSubtitle] 找不到音乐字幕配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", musicSubtitleGroupTag);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.StopAndClose();
				return;
			}
			foreach (MusicSubTitle musicSubTitle in musicSubtitle)
			{
				SubtitleConfigProxy subtitleConfigProxy = new SubtitleConfigProxy();
				subtitleConfigProxy.StartTime = musicSubTitle.AppearTime * 1000f;
				subtitleConfigProxy.EndTime = musicSubTitle.EndTime * 1000f;
				subtitleConfigProxy.OriginSubtitleId = PublicUtil.Instance.GetConfigIdByTable(ETableText.OriginSubtitle, new int?(musicSubTitle.Id));
				subtitleConfigProxy.TranslationSubtitleId = PublicUtil.Instance.GetConfigIdByTable(ETableText.TranslationSubtitle, new int?(musicSubTitle.Id));
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(subtitleConfigProxy.OriginSubtitleId);
				subtitleConfigProxy.HideOrigin = configTextByKey.Contains("{KeepOrigin}");
				this.SubtitleConfigList.Add(subtitleConfigProxy);
			}
			this.SubtitleConfigList.Sort((SubtitleConfigProxy a, SubtitleConfigProxy b) => a.StartTime.CompareTo(b.StartTime));
		}

		// Token: 0x06029868 RID: 170088 RVA: 0x00BB9470 File Offset: 0x00BB7670
		protected override void OnAfterShow()
		{
			if (this.IsStoppedOrClosing)
			{
				return;
			}
			this.OnVideoViewShow();
			EventSystem.Instance.Add(EEventName.VideoViewShow, new Action(this.OnVideoViewShow));
			EventSystem.Instance.Add<bool>(EEventName.VideoViewHide, new Action<bool>(this.OnVideoViewHide));
			EventSystem.Instance.Add(EEventName.PlotSequenceStarted, new Action(this.ResetAudioStartTime));
			EventSystem.Instance.Add(EEventName.PlotSequenceEnd, new Action(this.SeekAudio));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.OnApplicationHasReactivated));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.OnApplicationWillDeactivate));
			this.ResetSubtitle();
			if (!MusicSubtitleManager.AttachView(this.RequestId, this.AudioListener))
			{
				this.StopAndClose();
			}
		}

		// Token: 0x06029869 RID: 170089 RVA: 0x00BB954C File Offset: 0x00BB774C
		private void ResetSubtitle()
		{
			if (this.IsStoppedOrClosing)
			{
				return;
			}
			this.IsPlaying = false;
			this.CurrentTime = 0f;
			this.TimeSinceLastCorrection = 0f;
			this.AudioStartTime = 0f;
			this.CurrentSubtitleProxy = null;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x0602986A RID: 170090 RVA: 0x00BB95B6 File Offset: 0x00BB77B6
		public void StopAndClose()
		{
			this.StopAudio();
			if (this.ClosePromise == null && !this.WaitToDestroy && !this.IsDestroyByClear && !base.IsDestroyOrDestroying)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0602986B RID: 170091 RVA: 0x00BB95E5 File Offset: 0x00BB77E5
		private void StopAudio()
		{
			this.IsStopped = true;
			this.IsPlaying = false;
			MusicSubtitleManager.Stop(this.RequestId);
		}

		// Token: 0x0602986C RID: 170092 RVA: 0x00BB9600 File Offset: 0x00BB7800
		protected override void OnBeforeHide()
		{
		}

		// Token: 0x0602986D RID: 170093 RVA: 0x00BB9604 File Offset: 0x00BB7804
		protected override void OnAfterHide()
		{
			if (this.InVideo)
			{
				this.GetOriginalItem().SetUIParent(UiLayer.Instance.GetLayerRootUiItem(ELayerType.Float), false);
				this.InVideo = false;
			}
			EventSystem.Instance.Remove(EEventName.VideoViewShow, new Action(this.OnVideoViewShow));
			EventSystem.Instance.Remove<bool>(EEventName.VideoViewHide, new Action<bool>(this.OnVideoViewHide));
			EventSystem.Instance.Remove(EEventName.PlotSequenceStarted, new Action(this.ResetAudioStartTime));
			EventSystem.Instance.Remove(EEventName.PlotSequenceEnd, new Action(this.SeekAudio));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.OnApplicationHasReactivated));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.OnApplicationWillDeactivate));
			this.IsPlaying = false;
			MusicSubtitleManager.DetachView(this.RequestId, this.AudioListener);
		}

		// Token: 0x0602986E RID: 170094 RVA: 0x00BB96F1 File Offset: 0x00BB78F1
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602986F RID: 170095 RVA: 0x00BB96F4 File Offset: 0x00BB78F4
		private void OnVideoViewShow()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.VideoView);
			if (!this.InVideo && viewByName != null)
			{
				UUIItem rootItem = viewByName.GetRootItem();
				this.GetOriginalItem().SetUIParent(rootItem, false);
				this.InVideo = true;
			}
		}

		// Token: 0x06029870 RID: 170096 RVA: 0x00BB9737 File Offset: 0x00BB7937
		private void OnVideoViewHide(bool isPlayToEnd)
		{
			if (this.InVideo)
			{
				this.GetOriginalItem().SetUIParent(UiLayer.Instance.GetLayerRootUiItem(ELayerType.Float), false);
				this.InVideo = false;
			}
			if (!isPlayToEnd)
			{
				this.StopAndClose();
			}
		}

		// Token: 0x06029871 RID: 170097 RVA: 0x00BB976C File Offset: 0x00BB796C
		private void OnApplicationHasReactivated()
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[MusicSubtitle] 应用重新激活", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (!this.InVideo)
				{
					this.SeekAudio();
				}
			}, null, null);
		}

		// Token: 0x06029872 RID: 170098 RVA: 0x00BB9788 File Offset: 0x00BB7988
		private void OnApplicationWillDeactivate()
		{
			Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[MusicSubtitle] 应用将暂停", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!this.InVideo)
			{
				this.ResetAudioStartTime();
			}
		}

		// Token: 0x06029873 RID: 170099 RVA: 0x00BB97C0 File Offset: 0x00BB79C0
		protected override void OnTick(float deltaTime)
		{
			if (!this.IsPlaying || this.IsStoppedOrClosing)
			{
				return;
			}
			this.CurrentTime += deltaTime;
			this.TimeSinceLastCorrection += deltaTime;
			if (this.TimeSinceLastCorrection > 1000f || deltaTime > 100f)
			{
				this.TimeSinceLastCorrection = 0f;
				this.SyncAudioTimeToSubtitle();
			}
			UUIText text = base.GetText(0);
			UUIText text2 = base.GetText(1);
			SubtitleConfigProxy subtitleInRange = this.GetSubtitleInRange(this.CurrentTime);
			if (this.CurrentSubtitleProxy != subtitleInRange && subtitleInRange != null)
			{
				this.CurrentSubtitleProxy = subtitleInRange;
				text2.SetUIActive(true);
				text2.ShowTextNew(subtitleInRange.TranslationSubtitleId);
				if (subtitleInRange.HideOrigin)
				{
					text.SetUIActive(false);
				}
				else
				{
					text.SetUIActive(true);
					text.ShowTextNew(subtitleInRange.OriginSubtitleId);
				}
			}
			if (subtitleInRange == null && this.CurrentSubtitleProxy != null)
			{
				text.SetUIActive(false);
				text2.SetUIActive(false);
				this.CurrentSubtitleProxy = null;
			}
		}

		// Token: 0x06029874 RID: 170100 RVA: 0x00BB98A8 File Offset: 0x00BB7AA8
		[NullableContext(2)]
		private SubtitleConfigProxy GetSubtitleInRange(float time)
		{
			foreach (SubtitleConfigProxy subtitleConfigProxy in this.SubtitleConfigList)
			{
				if (time >= subtitleConfigProxy.StartTime && time < subtitleConfigProxy.EndTime)
				{
					return subtitleConfigProxy;
				}
			}
			return null;
		}

		// Token: 0x06029875 RID: 170101 RVA: 0x00BB9910 File Offset: 0x00BB7B10
		private void SyncAudioTimeToSubtitle()
		{
			if (!this.IsPlaying || this.IsStoppedOrClosing)
			{
				return;
			}
			int? sourcePlayPosition = MusicSubtitleManager.GetSourcePlayPosition(this.RequestId);
			if (sourcePlayPosition != null)
			{
				this.CurrentTime = (float)sourcePlayPosition.Value;
			}
		}

		// Token: 0x06029876 RID: 170102 RVA: 0x00BB9954 File Offset: 0x00BB7B54
		public unsafe void SeekAudio()
		{
			if (!this.IsPlaying || this.IsStoppedOrClosing || SequenceModel.Instance.IsPlaying)
			{
				return;
			}
			float num = SequenceModel.Instance.GetCurrentPlayPosition() * 1000f - this.AudioStartTime;
			if (MathUtils.Instance.IsNearlyEqual((double)num, (double)this.CurrentTime, new double?((double)40)))
			{
				return;
			}
			this.CurrentTime = num;
			MusicSubtitleManager.Seek(this.RequestId, (int)this.CurrentTime);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[MusicSubtitleSync] 同步音频时间";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentTime", this.CurrentTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AudioStartTime", this.AudioStartTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06029877 RID: 170103 RVA: 0x00BB9A34 File Offset: 0x00BB7C34
		public void ResetAudioStartTime()
		{
			if (!this.IsPlaying || this.IsStoppedOrClosing || !SequenceModel.Instance.IsPlaying)
			{
				return;
			}
			this.SyncAudioTimeToSubtitle();
			this.ResetAudioStartTimeByCurrentTime();
		}

		// Token: 0x06029878 RID: 170104 RVA: 0x00BB9A60 File Offset: 0x00BB7C60
		private void ResetAudioStartTimeByCurrentTime()
		{
			if (!SequenceModel.Instance.IsPlaying)
			{
				return;
			}
			this.AudioStartTime = SequenceModel.Instance.GetCurrentPlayPosition() * 1000f - this.CurrentTime;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[MusicSubtitleSync] 重置音频开始时间";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AudioStartTime", this.AudioStartTime);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x04016AA0 RID: 92832
		private const string HIDE_ORIGIN_LABEL = "{KeepOrigin}";

		// Token: 0x04016AA1 RID: 92833
		private const int AUDIO_SYNC_TIME = 1000;

		// Token: 0x04016AA2 RID: 92834
		private const int LAG_TIME = 100;

		// Token: 0x04016AA3 RID: 92835
		private readonly List<SubtitleConfigProxy> SubtitleConfigList = new List<SubtitleConfigProxy>();

		// Token: 0x04016AA4 RID: 92836
		private float CurrentTime;

		// Token: 0x04016AA5 RID: 92837
		[Nullable(2)]
		private SubtitleConfigProxy CurrentSubtitleProxy;

		// Token: 0x04016AA6 RID: 92838
		private float TimeSinceLastCorrection;

		// Token: 0x04016AA7 RID: 92839
		private bool IsPlaying;

		// Token: 0x04016AA8 RID: 92840
		private bool IsStopped;

		// Token: 0x04016AA9 RID: 92841
		private float AudioStartTime = -1f;

		// Token: 0x04016AAA RID: 92842
		private bool InVideo;

		// Token: 0x04016AAB RID: 92843
		private readonly MusicSubtitleManager.IMusicSubtitleViewListener AudioListener;

		// Token: 0x02009BD5 RID: 39893
		[NullableContext(0)]
		private enum EChildComp
		{
			// Token: 0x0403082E RID: 198702
			OriginSubtitleTxt,
			// Token: 0x0403082F RID: 198703
			TranslationSubtitleTxt
		}
	}
}
