using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA3 RID: 16291
	[NullableContext(1)]
	[Nullable(0)]
	public class MusicSubtitleManager : IStaticVariableResetter
	{
		// Token: 0x0602935A RID: 168794 RVA: 0x00B9236D File Offset: 0x00B9056D
		static MusicSubtitleManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicSubtitleManager.CreateStaticDefaultValue), new Action(MusicSubtitleManager.ResetStaticDefaultValue));
		}

		// Token: 0x0602935B RID: 168795 RVA: 0x00B9238C File Offset: 0x00B9058C
		public unsafe static void Play(IPostAkEventMusicSubtitle config)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MusicSubtitleView);
			if (config.IsEndAkEvent.GetValueOrDefault())
			{
				MusicSubtitleView musicSubtitleView = viewByName as MusicSubtitleView;
				if (musicSubtitleView != null)
				{
					musicSubtitleView.StopAndClose();
					return;
				}
				if (MusicSubtitleManager.ActiveSession != null)
				{
					MusicSubtitleManager.Stop(MusicSubtitleManager.ActiveSession.RequestId);
				}
				return;
			}
			else
			{
				if (MusicSubtitleManager.ActiveSession != null || MusicSubtitleManager.OpeningViewRequestId != null || viewByName != null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "[MusicSubtitle] 已有音乐字幕正在播放或打开界面，拒绝重复请求";
					string item = "Event";
					MusicSubtitleManager.IMusicSubtitleSession activeSession = MusicSubtitleManager.ActiveSession;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (activeSession != null) ? activeSession.Event : null);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				string @event = AudioSystem.Instance.parseAudioEventPath(config.AkEvent);
				if (string.IsNullOrEmpty(config.MusicSubtitleGroupTag) || string.IsNullOrEmpty(@event))
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Plot;
					ELogAuthor author2 = ELogAuthor.FZX;
					string message2 = "[MusicSubtitle] 音乐字幕配置错误";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MusicSubtitleGroupTag", config.MusicSubtitleGroupTag);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AkEvent", config.AkEvent);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				double milliseconds = KuroTime.GetMilliseconds64();
				MusicSubtitleManager.IMusicSubtitleSession session = new MusicSubtitleManager.MusicSubtitleSession
				{
					RequestId = ++MusicSubtitleManager.NextRequestId,
					MusicSubtitleGroupTag = config.MusicSubtitleGroupTag,
					Event = @event,
					Handle = 0,
					IsLoop = config.IsLoop.GetValueOrDefault(),
					RequestTime = milliseconds,
					AudioStartTime = null,
					HasHandledDuration = false,
					Listener = null
				};
				MusicSubtitleManager.ActiveSession = session;
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Plot;
				ELogAuthor author3 = ELogAuthor.FZX;
				string message3 = "[MusicSubtitle] 音乐字幕请求开始";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("time", milliseconds);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				if (!MusicSubtitleManager.PlayAudio(session))
				{
					return;
				}
				MusicSubtitleManager.IMusicSubtitleViewParam param = new MusicSubtitleManager.MusicSubtitleViewParam
				{
					RequestId = session.RequestId
				};
				MusicSubtitleManager.OpeningViewRequestId = new int?(session.RequestId);
				UiManager.Instance.OpenView(EUiViewName.MusicSubtitleView, param, delegate(bool success, int viewId)
				{
					int? openingViewRequestId = MusicSubtitleManager.OpeningViewRequestId;
					int requestId = session.RequestId;
					if (openingViewRequestId.GetValueOrDefault() == requestId & openingViewRequestId != null)
					{
						MusicSubtitleManager.OpeningViewRequestId = null;
					}
					if (!success && MusicSubtitleManager.ActiveSession == session)
					{
						global::Log instance4 = global::Log.Instance;
						ELogModule module4 = ELogModule.Plot;
						ELogAuthor author4 = ELogAuthor.FZX;
						string message4 = "[MusicSubtitle] 音乐字幕界面打开失败";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("akEvent", @event);
						instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						MusicSubtitleManager.Stop(session.RequestId);
						return;
					}
					if (success && MusicSubtitleManager.ActiveSession != session)
					{
						MusicSubtitleView musicSubtitleView2 = UiManager.Instance.GetView(viewId) as MusicSubtitleView;
						if (musicSubtitleView2 == null)
						{
							return;
						}
						musicSubtitleView2.StopAndClose();
					}
				});
				return;
			}
		}

		// Token: 0x0602935C RID: 168796 RVA: 0x00B925D4 File Offset: 0x00B907D4
		private static bool PlayAudio(MusicSubtitleManager.IMusicSubtitleSession session)
		{
			MusicSubtitleManager.<>c__DisplayClass12_0 CS$<>8__locals1 = new MusicSubtitleManager.<>c__DisplayClass12_0();
			CS$<>8__locals1.session = session;
			if (!MusicSubtitleManager.CanPlayAudio(CS$<>8__locals1.session))
			{
				MusicSubtitleManager.Stop(CS$<>8__locals1.session.RequestId);
				return false;
			}
			CS$<>8__locals1.session.RequestTime = KuroTime.GetMilliseconds64();
			CS$<>8__locals1.session.AudioStartTime = null;
			CS$<>8__locals1.session.HasHandledDuration = false;
			MusicSubtitleManager.<>c__DisplayClass12_0 CS$<>8__locals2 = CS$<>8__locals1;
			MusicSubtitleManager.IMusicSubtitleSession session2 = CS$<>8__locals1.session;
			int playbackId = session2.PlaybackId + 1;
			session2.PlaybackId = playbackId;
			CS$<>8__locals2.playbackId = playbackId;
			MusicSubtitleManager.IMusicSubtitleViewListener listener = CS$<>8__locals1.session.Listener;
			if (listener != null)
			{
				listener.OnAudioReset();
			}
			if (!MusicSubtitleManager.CanPlayAudio(CS$<>8__locals1.session))
			{
				MusicSubtitleManager.Stop(CS$<>8__locals1.session.RequestId);
				return false;
			}
			CS$<>8__locals1.session.Handle = AudioSystem.Instance.PostEvent(CS$<>8__locals1.session.Event, null, new PostEventArgs?(new PostEventArgs
			{
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo _)
				{
					MusicSubtitleManager.HandleAudioCallback(CS$<>8__locals1.session, CS$<>8__locals1.playbackId, callbackType);
				},
				CallbackMask = new ECallbackMask?((ECallbackMask)9)
			}));
			if (!MusicSubtitleManager.CanPlayAudio(CS$<>8__locals1.session))
			{
				MusicSubtitleManager.StopAudio(CS$<>8__locals1.session);
				return false;
			}
			if (CS$<>8__locals1.session.Handle == 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[MusicSubtitle] 音乐字幕播放失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("akEvent", CS$<>8__locals1.session.Event);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				MusicSubtitleManager.FinishSession(CS$<>8__locals1.session);
				return false;
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.MSY;
			string message2 = "[MusicSubtitle][Game.Action] PostEvent";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Event", CS$<>8__locals1.session.Event);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return true;
		}

		// Token: 0x0602935D RID: 168797 RVA: 0x00B9277E File Offset: 0x00B9097E
		[NullableContext(2)]
		public static string GetMusicSubtitleGroupTag(int requestId)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
			{
				return null;
			}
			return session.MusicSubtitleGroupTag;
		}

		// Token: 0x0602935E RID: 168798 RVA: 0x00B92794 File Offset: 0x00B90994
		public static bool AttachView(int requestId, MusicSubtitleManager.IMusicSubtitleViewListener listener)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null || !MusicSubtitleManager.CanPlayAudio(session))
			{
				return false;
			}
			session.Listener = listener;
			if (session.HasHandledDuration)
			{
				MusicSubtitleManager.NotifyAudioStart(session, null);
			}
			return true;
		}

		// Token: 0x0602935F RID: 168799 RVA: 0x00B927D4 File Offset: 0x00B909D4
		public static void DetachView(int requestId, MusicSubtitleManager.IMusicSubtitleViewListener listener)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (((session != null) ? session.Listener : null) == listener)
			{
				session.Listener = null;
			}
		}

		// Token: 0x06029360 RID: 168800 RVA: 0x00B92800 File Offset: 0x00B90A00
		public static int? GetSourcePlayPosition(int requestId)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
			{
				return null;
			}
			return AudioSystem.Instance.GetSourcePlayPosition(session.Handle, false);
		}

		// Token: 0x06029361 RID: 168801 RVA: 0x00B92834 File Offset: 0x00B90A34
		public static void Seek(int requestId, int position)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
			{
				return;
			}
			AudioSystem.Instance.SeekOnEvent(session.Event, position, new SeekOnEventArgs?(new SeekOnEventArgs(null, new int?(session.Handle), null)));
		}

		// Token: 0x06029362 RID: 168802 RVA: 0x00B9287C File Offset: 0x00B90A7C
		public static void Stop(int requestId)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
			{
				return;
			}
			MusicSubtitleManager.StopAudio(session);
		}

		// Token: 0x06029363 RID: 168803 RVA: 0x00B9289C File Offset: 0x00B90A9C
		private static void StopAudio(MusicSubtitleManager.IMusicSubtitleSession session)
		{
			if (MusicSubtitleManager.ActiveSession == session)
			{
				MusicSubtitleManager.ActiveSession = null;
			}
			session.Listener = null;
			session.HasHandledDuration = false;
			session.AudioStartTime = null;
			int handle = session.Handle;
			session.Handle = 0;
			if (handle != 0)
			{
				AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
		}

		// Token: 0x06029364 RID: 168804 RVA: 0x00B9290C File Offset: 0x00B90B0C
		private static void FinishSession(MusicSubtitleManager.IMusicSubtitleSession session)
		{
			MusicSubtitleManager.IMusicSubtitleViewListener listener = session.Listener;
			MusicSubtitleManager.StopAudio(session);
			if (listener != null)
			{
				listener.OnAudioEnd(session.Event);
				return;
			}
			MusicSubtitleView musicSubtitleView = UiManager.Instance.GetViewByName(EUiViewName.MusicSubtitleView) as MusicSubtitleView;
			MusicSubtitleManager.IMusicSubtitleViewParam musicSubtitleViewParam = ((musicSubtitleView != null) ? musicSubtitleView.OpenParam : null) as MusicSubtitleManager.IMusicSubtitleViewParam;
			int? num = (musicSubtitleViewParam != null) ? new int?(musicSubtitleViewParam.RequestId) : null;
			int requestId = session.RequestId;
			if (num.GetValueOrDefault() == requestId & num != null)
			{
				musicSubtitleView.StopAndClose();
			}
		}

		// Token: 0x06029365 RID: 168805 RVA: 0x00B929A0 File Offset: 0x00B90BA0
		private static bool CanPlayAudio(MusicSubtitleManager.IMusicSubtitleSession session)
		{
			if (MusicSubtitleManager.ActiveSession != session)
			{
				return false;
			}
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MusicSubtitleView);
			return viewByName == null || (viewByName.ClosePromise == null && !viewByName.WaitToDestroy && !viewByName.IsDestroyByClear && !viewByName.IsDestroyOrDestroying && !viewByName.LastHide);
		}

		// Token: 0x06029366 RID: 168806 RVA: 0x00B929F8 File Offset: 0x00B90BF8
		[NullableContext(2)]
		private static MusicSubtitleManager.IMusicSubtitleSession GetSession(int requestId)
		{
			MusicSubtitleManager.IMusicSubtitleSession activeSession = MusicSubtitleManager.ActiveSession;
			if (activeSession == null || activeSession.RequestId != requestId)
			{
				return null;
			}
			return activeSession;
		}

		// Token: 0x06029367 RID: 168807 RVA: 0x00B92A1C File Offset: 0x00B90C1C
		private static void HandleAudioCallback(MusicSubtitleManager.IMusicSubtitleSession session, int playbackId, EAkCallbackType callbackType)
		{
			if (MusicSubtitleManager.ActiveSession != session || session.PlaybackId != playbackId)
			{
				return;
			}
			if (!MusicSubtitleManager.CanPlayAudio(session))
			{
				MusicSubtitleManager.Stop(session.RequestId);
				return;
			}
			if (callbackType == EAkCallbackType.EndOfEvent)
			{
				session.Handle = 0;
				if (session.IsLoop && session.HasHandledDuration)
				{
					MusicSubtitleManager.PlayAudio(session);
					return;
				}
				if (session.IsLoop)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "[MusicSubtitle] 循环音乐未正常起播即结束，停止循环";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("akEvent", session.Event);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				MusicSubtitleManager.FinishSession(session);
				return;
			}
			else
			{
				if (callbackType != EAkCallbackType.Duration || session.HasHandledDuration)
				{
					return;
				}
				session.HasHandledDuration = true;
				session.AudioStartTime = new double?(KuroTime.GetMilliseconds64());
				double num = session.AudioStartTime.Value - session.RequestTime;
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "[MusicSubtitle] 音乐字幕正式开始";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("delayTime", num);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				if (num > 40.0)
				{
					MusicSubtitleManager.Seek(session.RequestId, (int)num);
					session.AudioStartTime = new double?(session.RequestTime);
					MusicSubtitleManager.NotifyAudioStart(session, new int?((int)num));
					return;
				}
				MusicSubtitleManager.NotifyAudioStart(session, null);
				return;
			}
		}

		// Token: 0x06029368 RID: 168808 RVA: 0x00B92B5C File Offset: 0x00B90D5C
		private static void NotifyAudioStart(MusicSubtitleManager.IMusicSubtitleSession session, int? startPosition = null)
		{
			MusicSubtitleManager.IMusicSubtitleViewListener listener = session.Listener;
			if (listener == null || session.AudioStartTime == null)
			{
				return;
			}
			int? num = startPosition;
			double num2;
			if (num == null)
			{
				int? sourcePlayPosition = AudioSystem.Instance.GetSourcePlayPosition(session.Handle, false);
				num2 = ((sourcePlayPosition != null) ? ((double)sourcePlayPosition.GetValueOrDefault()) : (KuroTime.GetMilliseconds64() - session.AudioStartTime.Value));
			}
			else
			{
				num2 = (double)num.GetValueOrDefault();
			}
			double num3 = num2;
			listener.OnAudioStart((float)num3, session.Event);
		}

		// Token: 0x06029369 RID: 168809 RVA: 0x00B92BE7 File Offset: 0x00B90DE7
		public static void CreateStaticDefaultValue()
		{
			MusicSubtitleManager.ActiveSession = null;
			MusicSubtitleManager.OpeningViewRequestId = null;
			MusicSubtitleManager.NextRequestId = 0;
		}

		// Token: 0x0602936A RID: 168810 RVA: 0x00B92C00 File Offset: 0x00B90E00
		public static void ResetStaticDefaultValue()
		{
			MusicSubtitleManager.ActiveSession = null;
			MusicSubtitleManager.OpeningViewRequestId = null;
			MusicSubtitleManager.NextRequestId = 0;
		}

		// Token: 0x040166F1 RID: 91889
		private const int AUDIO_START_SYNC_THRESHOLD = 40;

		// Token: 0x040166F2 RID: 91890
		[Nullable(2)]
		private static MusicSubtitleManager.IMusicSubtitleSession ActiveSession;

		// Token: 0x040166F3 RID: 91891
		private static int? OpeningViewRequestId;

		// Token: 0x040166F4 RID: 91892
		private static int NextRequestId;

		// Token: 0x02009B1A RID: 39706
		public interface IMusicSubtitleViewParam
		{
			// Token: 0x17007903 RID: 30979
			// (get) Token: 0x06044AAB RID: 281259
			// (set) Token: 0x06044AAC RID: 281260
			int RequestId { get; set; }
		}

		// Token: 0x02009B1B RID: 39707
		[NullableContext(0)]
		[RequiredMember]
		public class MusicSubtitleViewParam : MusicSubtitleManager.IMusicSubtitleViewParam
		{
			// Token: 0x17007904 RID: 30980
			// (get) Token: 0x06044AAD RID: 281261 RVA: 0x0147FF16 File Offset: 0x0147E116
			// (set) Token: 0x06044AAE RID: 281262 RVA: 0x0147FF1E File Offset: 0x0147E11E
			[RequiredMember]
			public int RequestId { get; set; }

			// Token: 0x06044AAF RID: 281263 RVA: 0x0147FF27 File Offset: 0x0147E127
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MusicSubtitleViewParam()
			{
			}
		}

		// Token: 0x02009B1C RID: 39708
		public interface IMusicSubtitleViewListener
		{
			// Token: 0x17007905 RID: 30981
			// (get) Token: 0x06044AB0 RID: 281264
			// (set) Token: 0x06044AB1 RID: 281265
			Action OnAudioReset { get; set; }

			// Token: 0x17007906 RID: 30982
			// (get) Token: 0x06044AB2 RID: 281266
			// (set) Token: 0x06044AB3 RID: 281267
			Action<float, string> OnAudioStart { get; set; }

			// Token: 0x17007907 RID: 30983
			// (get) Token: 0x06044AB4 RID: 281268
			// (set) Token: 0x06044AB5 RID: 281269
			Action<string> OnAudioEnd { get; set; }
		}

		// Token: 0x02009B1D RID: 39709
		[Nullable(0)]
		[RequiredMember]
		public class MusicSubtitleViewListener : MusicSubtitleManager.IMusicSubtitleViewListener
		{
			// Token: 0x17007908 RID: 30984
			// (get) Token: 0x06044AB6 RID: 281270 RVA: 0x0147FF2F File Offset: 0x0147E12F
			// (set) Token: 0x06044AB7 RID: 281271 RVA: 0x0147FF37 File Offset: 0x0147E137
			[RequiredMember]
			public Action OnAudioReset { get; set; }

			// Token: 0x17007909 RID: 30985
			// (get) Token: 0x06044AB8 RID: 281272 RVA: 0x0147FF40 File Offset: 0x0147E140
			// (set) Token: 0x06044AB9 RID: 281273 RVA: 0x0147FF48 File Offset: 0x0147E148
			[RequiredMember]
			public Action<float, string> OnAudioStart { get; set; }

			// Token: 0x1700790A RID: 30986
			// (get) Token: 0x06044ABA RID: 281274 RVA: 0x0147FF51 File Offset: 0x0147E151
			// (set) Token: 0x06044ABB RID: 281275 RVA: 0x0147FF59 File Offset: 0x0147E159
			[RequiredMember]
			public Action<string> OnAudioEnd { get; set; }

			// Token: 0x06044ABC RID: 281276 RVA: 0x0147FF62 File Offset: 0x0147E162
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MusicSubtitleViewListener()
			{
			}
		}

		// Token: 0x02009B1E RID: 39710
		private interface IMusicSubtitleSession
		{
			// Token: 0x1700790B RID: 30987
			// (get) Token: 0x06044ABD RID: 281277
			// (set) Token: 0x06044ABE RID: 281278
			int RequestId { get; set; }

			// Token: 0x1700790C RID: 30988
			// (get) Token: 0x06044ABF RID: 281279
			// (set) Token: 0x06044AC0 RID: 281280
			string MusicSubtitleGroupTag { get; set; }

			// Token: 0x1700790D RID: 30989
			// (get) Token: 0x06044AC1 RID: 281281
			// (set) Token: 0x06044AC2 RID: 281282
			string Event { get; set; }

			// Token: 0x1700790E RID: 30990
			// (get) Token: 0x06044AC3 RID: 281283
			// (set) Token: 0x06044AC4 RID: 281284
			int Handle { get; set; }

			// Token: 0x1700790F RID: 30991
			// (get) Token: 0x06044AC5 RID: 281285
			// (set) Token: 0x06044AC6 RID: 281286
			bool IsLoop { get; set; }

			// Token: 0x17007910 RID: 30992
			// (get) Token: 0x06044AC7 RID: 281287
			// (set) Token: 0x06044AC8 RID: 281288
			int PlaybackId { get; set; }

			// Token: 0x17007911 RID: 30993
			// (get) Token: 0x06044AC9 RID: 281289
			// (set) Token: 0x06044ACA RID: 281290
			double RequestTime { get; set; }

			// Token: 0x17007912 RID: 30994
			// (get) Token: 0x06044ACB RID: 281291
			// (set) Token: 0x06044ACC RID: 281292
			double? AudioStartTime { get; set; }

			// Token: 0x17007913 RID: 30995
			// (get) Token: 0x06044ACD RID: 281293
			// (set) Token: 0x06044ACE RID: 281294
			bool HasHandledDuration { get; set; }

			// Token: 0x17007914 RID: 30996
			// (get) Token: 0x06044ACF RID: 281295
			// (set) Token: 0x06044AD0 RID: 281296
			[Nullable(2)]
			MusicSubtitleManager.IMusicSubtitleViewListener Listener { [NullableContext(2)] get; [NullableContext(2)] set; }
		}

		// Token: 0x02009B1F RID: 39711
		[Nullable(0)]
		[RequiredMember]
		private class MusicSubtitleSession : MusicSubtitleManager.IMusicSubtitleSession
		{
			// Token: 0x17007915 RID: 30997
			// (get) Token: 0x06044AD1 RID: 281297 RVA: 0x0147FF6A File Offset: 0x0147E16A
			// (set) Token: 0x06044AD2 RID: 281298 RVA: 0x0147FF72 File Offset: 0x0147E172
			[RequiredMember]
			public int RequestId { get; set; }

			// Token: 0x17007916 RID: 30998
			// (get) Token: 0x06044AD3 RID: 281299 RVA: 0x0147FF7B File Offset: 0x0147E17B
			// (set) Token: 0x06044AD4 RID: 281300 RVA: 0x0147FF83 File Offset: 0x0147E183
			[RequiredMember]
			public string MusicSubtitleGroupTag { get; set; }

			// Token: 0x17007917 RID: 30999
			// (get) Token: 0x06044AD5 RID: 281301 RVA: 0x0147FF8C File Offset: 0x0147E18C
			// (set) Token: 0x06044AD6 RID: 281302 RVA: 0x0147FF94 File Offset: 0x0147E194
			[RequiredMember]
			public string Event { get; set; }

			// Token: 0x17007918 RID: 31000
			// (get) Token: 0x06044AD7 RID: 281303 RVA: 0x0147FF9D File Offset: 0x0147E19D
			// (set) Token: 0x06044AD8 RID: 281304 RVA: 0x0147FFA5 File Offset: 0x0147E1A5
			[RequiredMember]
			public int Handle { get; set; }

			// Token: 0x17007919 RID: 31001
			// (get) Token: 0x06044AD9 RID: 281305 RVA: 0x0147FFAE File Offset: 0x0147E1AE
			// (set) Token: 0x06044ADA RID: 281306 RVA: 0x0147FFB6 File Offset: 0x0147E1B6
			[RequiredMember]
			public bool IsLoop { get; set; }

			// Token: 0x1700791A RID: 31002
			// (get) Token: 0x06044ADB RID: 281307 RVA: 0x0147FFBF File Offset: 0x0147E1BF
			// (set) Token: 0x06044ADC RID: 281308 RVA: 0x0147FFC7 File Offset: 0x0147E1C7
			public int PlaybackId { get; set; }

			// Token: 0x1700791B RID: 31003
			// (get) Token: 0x06044ADD RID: 281309 RVA: 0x0147FFD0 File Offset: 0x0147E1D0
			// (set) Token: 0x06044ADE RID: 281310 RVA: 0x0147FFD8 File Offset: 0x0147E1D8
			[RequiredMember]
			public double RequestTime { get; set; }

			// Token: 0x1700791C RID: 31004
			// (get) Token: 0x06044ADF RID: 281311 RVA: 0x0147FFE1 File Offset: 0x0147E1E1
			// (set) Token: 0x06044AE0 RID: 281312 RVA: 0x0147FFE9 File Offset: 0x0147E1E9
			public double? AudioStartTime { get; set; }

			// Token: 0x1700791D RID: 31005
			// (get) Token: 0x06044AE1 RID: 281313 RVA: 0x0147FFF2 File Offset: 0x0147E1F2
			// (set) Token: 0x06044AE2 RID: 281314 RVA: 0x0147FFFA File Offset: 0x0147E1FA
			[RequiredMember]
			public bool HasHandledDuration { get; set; }

			// Token: 0x1700791E RID: 31006
			// (get) Token: 0x06044AE3 RID: 281315 RVA: 0x01480003 File Offset: 0x0147E203
			// (set) Token: 0x06044AE4 RID: 281316 RVA: 0x0148000B File Offset: 0x0147E20B
			[Nullable(2)]
			public MusicSubtitleManager.IMusicSubtitleViewListener Listener { [NullableContext(2)] get; [NullableContext(2)] set; }

			// Token: 0x06044AE5 RID: 281317 RVA: 0x01480014 File Offset: 0x0147E214
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MusicSubtitleSession()
			{
			}
		}
	}
}
