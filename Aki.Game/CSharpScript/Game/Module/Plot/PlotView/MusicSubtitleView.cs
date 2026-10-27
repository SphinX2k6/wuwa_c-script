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
	// Token: 0x02005048 RID: 20552
	[NullableContext(1)]
	[Nullable(0)]
	public class MusicSubtitleView : UiTickViewBase
	{
		// Token: 0x06034987 RID: 215431 RVA: 0x00C6C0DC File Offset: 0x00C6A2DC
		public unsafe MusicSubtitleView(UiViewInfo viewInfo) : base(viewInfo)
		{
			this.AudioListener = new MusicSubtitleManager.MusicSubtitleViewListener
			{
				OnAudioStart = delegate(float position, string @event)
				{
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
					this.IsPlaying = false;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "[MusicSubtitle] 音乐字幕播放结束";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("akEvent", @event);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					base.CloseMe(null);
				}
			};
		}

		// Token: 0x06034988 RID: 215432 RVA: 0x00C6C138 File Offset: 0x00C6A338
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

		// Token: 0x06034989 RID: 215433 RVA: 0x00C6C1A4 File Offset: 0x00C6A3A4
		protected unsafe override void OnStart()
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			MusicSubtitleManager.IMusicSubtitleViewParam musicSubtitleViewParam = this.OpenParam as MusicSubtitleManager.IMusicSubtitleViewParam;
			this.RequestId = musicSubtitleViewParam.RequestId;
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
				MusicSubtitleManager.Stop(this.RequestId);
				base.CloseMe(null);
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
				MusicSubtitleManager.Stop(this.RequestId);
				base.CloseMe(null);
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

		// Token: 0x0603498A RID: 215434 RVA: 0x00C6C3C4 File Offset: 0x00C6A5C4
		protected override void OnAfterShow()
		{
			this.OnVideoViewShow();
			EventSystem.Instance.Add(EEventName.VideoViewShow, new Action(this.OnVideoViewShow));
			EventSystem.Instance.Add<bool>(EEventName.VideoViewHide, new Action<bool>(this.OnVideoViewHide));
			EventSystem.Instance.Add(EEventName.PlotSequenceStarted, new Action(this.ResetAudioStartTime));
			EventSystem.Instance.Add(EEventName.PlotSequenceEnd, new Action(this.SeekAudio));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.OnApplicationHasReactivated));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.OnApplicationWillDeactivate));
			if (!MusicSubtitleManager.AttachView(this.RequestId, this.AudioListener))
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603498B RID: 215435 RVA: 0x00C6C490 File Offset: 0x00C6A690
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

		// Token: 0x0603498C RID: 215436 RVA: 0x00C6C57D File Offset: 0x00C6A77D
		protected override void OnBeforeDestroy()
		{
			MusicSubtitleManager.DetachView(this.RequestId, this.AudioListener);
		}

		// Token: 0x0603498D RID: 215437 RVA: 0x00C6C590 File Offset: 0x00C6A790
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

		// Token: 0x0603498E RID: 215438 RVA: 0x00C6C5D4 File Offset: 0x00C6A7D4
		private void OnVideoViewHide(bool isPlayToEnd)
		{
			if (this.InVideo)
			{
				this.GetOriginalItem().SetUIParent(UiLayer.Instance.GetLayerRootUiItem(ELayerType.Float), false);
				this.InVideo = false;
			}
			if (!isPlayToEnd)
			{
				MusicSubtitleManager.Stop(this.RequestId);
				base.CloseMe(null);
			}
		}

		// Token: 0x0603498F RID: 215439 RVA: 0x00C6C620 File Offset: 0x00C6A820
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

		// Token: 0x06034990 RID: 215440 RVA: 0x00C6C63C File Offset: 0x00C6A83C
		private void OnApplicationWillDeactivate()
		{
			Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[MusicSubtitle] 应用将暂停", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!this.InVideo)
			{
				this.ResetAudioStartTime();
			}
		}

		// Token: 0x06034991 RID: 215441 RVA: 0x00C6C674 File Offset: 0x00C6A874
		protected override void OnTick(float deltaTime)
		{
			if (!this.IsPlaying)
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

		// Token: 0x06034992 RID: 215442 RVA: 0x00C6C754 File Offset: 0x00C6A954
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

		// Token: 0x06034993 RID: 215443 RVA: 0x00C6C7BC File Offset: 0x00C6A9BC
		private void SyncAudioTimeToSubtitle()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			int? sourcePlayPosition = MusicSubtitleManager.GetSourcePlayPosition(this.RequestId);
			if (sourcePlayPosition != null)
			{
				this.CurrentTime = (float)sourcePlayPosition.Value;
			}
		}

		// Token: 0x06034994 RID: 215444 RVA: 0x00C6C7F8 File Offset: 0x00C6A9F8
		public unsafe void SeekAudio()
		{
			if (!this.IsPlaying || !SequenceModel.Instance.IsPlaying)
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

		// Token: 0x06034995 RID: 215445 RVA: 0x00C6C8D0 File Offset: 0x00C6AAD0
		public void ResetAudioStartTime()
		{
			if (!this.IsPlaying || !SequenceModel.Instance.IsPlaying)
			{
				return;
			}
			this.SyncAudioTimeToSubtitle();
			this.ResetAudioStartTimeByCurrentTime();
		}

		// Token: 0x06034996 RID: 215446 RVA: 0x00C6C8F4 File Offset: 0x00C6AAF4
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

		// Token: 0x0401C07D RID: 114813
		private const string HIDE_ORIGIN_LABEL = "{KeepOrigin}";

		// Token: 0x0401C07E RID: 114814
		private const int AUDIO_SYNC_TIME = 1000;

		// Token: 0x0401C07F RID: 114815
		private const int LAG_TIME = 100;

		// Token: 0x0401C080 RID: 114816
		private readonly List<SubtitleConfigProxy> SubtitleConfigList = new List<SubtitleConfigProxy>();

		// Token: 0x0401C081 RID: 114817
		private float CurrentTime;

		// Token: 0x0401C082 RID: 114818
		[Nullable(2)]
		private SubtitleConfigProxy CurrentSubtitleProxy;

		// Token: 0x0401C083 RID: 114819
		private float TimeSinceLastCorrection;

		// Token: 0x0401C084 RID: 114820
		private bool IsPlaying;

		// Token: 0x0401C085 RID: 114821
		private int RequestId;

		// Token: 0x0401C086 RID: 114822
		private float AudioStartTime = -1f;

		// Token: 0x0401C087 RID: 114823
		private bool InVideo;

		// Token: 0x0401C088 RID: 114824
		private readonly MusicSubtitleManager.IMusicSubtitleViewListener AudioListener;

		// Token: 0x0200B19B RID: 45467
		[NullableContext(0)]
		private enum EChildComp
		{
			// Token: 0x04035DD9 RID: 220633
			OriginSubtitleTxt,
			// Token: 0x04035DDA RID: 220634
			TranslationSubtitleTxt
		}
	}
}
