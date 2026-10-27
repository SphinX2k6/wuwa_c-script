using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FD9 RID: 20441
	[NullableContext(1)]
	[Nullable(0)]
	public class MusicSubtitleManager : IStaticVariableResetter
	{
		// Token: 0x060344D5 RID: 214229 RVA: 0x00C48611 File Offset: 0x00C46811
		static MusicSubtitleManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicSubtitleManager.CreateStaticDefaultValue), new Action(MusicSubtitleManager.ResetStaticDefaultValue));
		}

		// Token: 0x060344D6 RID: 214230 RVA: 0x00C48630 File Offset: 0x00C46830
		public unsafe static void Play(IPostAkEventMusicSubtitle config)
		{
			if (MusicSubtitleManager.ActiveSession != null || MusicSubtitleManager.OpeningViewRequestId != null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[MusicSubtitle] 已有音乐字幕正在播放或打开界面，忽略重复请求";
				string item = "Event";
				MusicSubtitleManager.IMusicSubtitleSession activeSession = MusicSubtitleManager.ActiveSession;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (activeSession != null) ? activeSession.Event : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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
			session.Handle = AudioSystem.Instance.PostEvent(@event, null, new PostEventArgs?(new PostEventArgs
			{
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo _)
				{
					MusicSubtitleManager.HandleAudioCallback(session, callbackType);
				},
				CallbackMask = new ECallbackMask?((ECallbackMask)9)
			}));
			if (session.Handle == 0)
			{
				MusicSubtitleManager.ActiveSession = null;
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.Plot;
				ELogAuthor author4 = ELogAuthor.FZX;
				string message4 = "[MusicSubtitle] 音乐字幕播放失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("akEvent", @event);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			global::Log instance5 = global::Log.Instance;
			ELogModule module5 = ELogModule.Audio;
			ELogAuthor author5 = ELogAuthor.MSY;
			string message5 = "[MusicSubtitle][Game.Action] PostEvent";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("Event", @event);
			instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			MusicSubtitleManager.IMusicSubtitleViewParam param = new MusicSubtitleManager.MusicSubtitleViewParam
			{
				RequestId = session.RequestId
			};
			MusicSubtitleManager.OpeningViewRequestId = new int?(session.RequestId);
			UiManager.Instance.OpenView(EUiViewName.MusicSubtitleView, param, delegate(bool success, int _)
			{
				int? openingViewRequestId = MusicSubtitleManager.OpeningViewRequestId;
				int requestId = session.RequestId;
				if (openingViewRequestId.GetValueOrDefault() == requestId & openingViewRequestId != null)
				{
					MusicSubtitleManager.OpeningViewRequestId = null;
				}
				if (!success && MusicSubtitleManager.ActiveSession == session)
				{
					global::Log instance6 = global::Log.Instance;
					ELogModule module6 = ELogModule.Plot;
					ELogAuthor author6 = ELogAuthor.FZX;
					string message6 = "[MusicSubtitle] 音乐字幕界面打开失败";
					ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("akEvent", @event);
					instance6.Info(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
					MusicSubtitleManager.Stop(session.RequestId);
				}
			});
		}

		// Token: 0x060344D7 RID: 214231 RVA: 0x00C488BB File Offset: 0x00C46ABB
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

		// Token: 0x060344D8 RID: 214232 RVA: 0x00C488D0 File Offset: 0x00C46AD0
		public static bool AttachView(int requestId, MusicSubtitleManager.IMusicSubtitleViewListener listener)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
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

		// Token: 0x060344D9 RID: 214233 RVA: 0x00C48908 File Offset: 0x00C46B08
		public static void DetachView(int requestId, MusicSubtitleManager.IMusicSubtitleViewListener listener)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (((session != null) ? session.Listener : null) == listener)
			{
				session.Listener = null;
			}
		}

		// Token: 0x060344DA RID: 214234 RVA: 0x00C48934 File Offset: 0x00C46B34
		public static int? GetSourcePlayPosition(int requestId)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
			{
				return null;
			}
			return AudioSystem.Instance.GetSourcePlayPosition(session.Handle, false);
		}

		// Token: 0x060344DB RID: 214235 RVA: 0x00C48968 File Offset: 0x00C46B68
		public static void Seek(int requestId, int position)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
			{
				return;
			}
			AudioSystem.Instance.SeekOnEvent(session.Event, position, new SeekOnEventArgs?(new SeekOnEventArgs(null, new int?(session.Handle), null)));
		}

		// Token: 0x060344DC RID: 214236 RVA: 0x00C489B0 File Offset: 0x00C46BB0
		public static void Stop(int requestId)
		{
			MusicSubtitleManager.IMusicSubtitleSession session = MusicSubtitleManager.GetSession(requestId);
			if (session == null)
			{
				return;
			}
			MusicSubtitleManager.ActiveSession = null;
			session.Listener = null;
			AudioSystem.Instance.ExecuteAction(session.Handle, EAudioActionType.Stop, null);
		}

		// Token: 0x060344DD RID: 214237 RVA: 0x00C489F0 File Offset: 0x00C46BF0
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

		// Token: 0x060344DE RID: 214238 RVA: 0x00C48A14 File Offset: 0x00C46C14
		private static void HandleAudioCallback(MusicSubtitleManager.IMusicSubtitleSession session, EAkCallbackType callbackType)
		{
			if (MusicSubtitleManager.ActiveSession != session)
			{
				return;
			}
			if (callbackType == EAkCallbackType.EndOfEvent)
			{
				MusicSubtitleManager.ActiveSession = null;
				MusicSubtitleManager.IMusicSubtitleViewListener listener = session.Listener;
				session.Listener = null;
				if (listener == null)
				{
					return;
				}
				listener.OnAudioEnd(session.Event);
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
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[MusicSubtitle] 音乐字幕正式开始";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("delayTime", num);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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

		// Token: 0x060344DF RID: 214239 RVA: 0x00C48B04 File Offset: 0x00C46D04
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

		// Token: 0x060344E0 RID: 214240 RVA: 0x00C48B8F File Offset: 0x00C46D8F
		public static void CreateStaticDefaultValue()
		{
			MusicSubtitleManager.ActiveSession = null;
			MusicSubtitleManager.OpeningViewRequestId = null;
			MusicSubtitleManager.NextRequestId = 0;
		}

		// Token: 0x060344E1 RID: 214241 RVA: 0x00C48BA8 File Offset: 0x00C46DA8
		public static void ResetStaticDefaultValue()
		{
			MusicSubtitleManager.ActiveSession = null;
			MusicSubtitleManager.OpeningViewRequestId = null;
			MusicSubtitleManager.NextRequestId = 0;
		}

		// Token: 0x0401BD16 RID: 113942
		private const int AUDIO_START_SYNC_THRESHOLD = 40;

		// Token: 0x0401BD17 RID: 113943
		[Nullable(2)]
		private static MusicSubtitleManager.IMusicSubtitleSession ActiveSession;

		// Token: 0x0401BD18 RID: 113944
		private static int? OpeningViewRequestId;

		// Token: 0x0401BD19 RID: 113945
		private static int NextRequestId;

		// Token: 0x0200B0EA RID: 45290
		public interface IMusicSubtitleViewParam
		{
			// Token: 0x1700A165 RID: 41317
			// (get) Token: 0x0604E4BB RID: 320699
			// (set) Token: 0x0604E4BC RID: 320700
			int RequestId { get; set; }
		}

		// Token: 0x0200B0EB RID: 45291
		[NullableContext(0)]
		[RequiredMember]
		public class MusicSubtitleViewParam : MusicSubtitleManager.IMusicSubtitleViewParam
		{
			// Token: 0x1700A166 RID: 41318
			// (get) Token: 0x0604E4BD RID: 320701 RVA: 0x014C6DFE File Offset: 0x014C4FFE
			// (set) Token: 0x0604E4BE RID: 320702 RVA: 0x014C6E06 File Offset: 0x014C5006
			[RequiredMember]
			public int RequestId { get; set; }

			// Token: 0x0604E4BF RID: 320703 RVA: 0x014C6E0F File Offset: 0x014C500F
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MusicSubtitleViewParam()
			{
			}
		}

		// Token: 0x0200B0EC RID: 45292
		public interface IMusicSubtitleViewListener
		{
			// Token: 0x1700A167 RID: 41319
			// (get) Token: 0x0604E4C0 RID: 320704
			// (set) Token: 0x0604E4C1 RID: 320705
			Action<float, string> OnAudioStart { get; set; }

			// Token: 0x1700A168 RID: 41320
			// (get) Token: 0x0604E4C2 RID: 320706
			// (set) Token: 0x0604E4C3 RID: 320707
			Action<string> OnAudioEnd { get; set; }
		}

		// Token: 0x0200B0ED RID: 45293
		[Nullable(0)]
		[RequiredMember]
		public class MusicSubtitleViewListener : MusicSubtitleManager.IMusicSubtitleViewListener
		{
			// Token: 0x1700A169 RID: 41321
			// (get) Token: 0x0604E4C4 RID: 320708 RVA: 0x014C6E17 File Offset: 0x014C5017
			// (set) Token: 0x0604E4C5 RID: 320709 RVA: 0x014C6E1F File Offset: 0x014C501F
			[RequiredMember]
			public Action<float, string> OnAudioStart { get; set; }

			// Token: 0x1700A16A RID: 41322
			// (get) Token: 0x0604E4C6 RID: 320710 RVA: 0x014C6E28 File Offset: 0x014C5028
			// (set) Token: 0x0604E4C7 RID: 320711 RVA: 0x014C6E30 File Offset: 0x014C5030
			[RequiredMember]
			public Action<string> OnAudioEnd { get; set; }

			// Token: 0x0604E4C8 RID: 320712 RVA: 0x014C6E39 File Offset: 0x014C5039
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MusicSubtitleViewListener()
			{
			}
		}

		// Token: 0x0200B0EE RID: 45294
		private interface IMusicSubtitleSession
		{
			// Token: 0x1700A16B RID: 41323
			// (get) Token: 0x0604E4C9 RID: 320713
			// (set) Token: 0x0604E4CA RID: 320714
			int RequestId { get; set; }

			// Token: 0x1700A16C RID: 41324
			// (get) Token: 0x0604E4CB RID: 320715
			// (set) Token: 0x0604E4CC RID: 320716
			string MusicSubtitleGroupTag { get; set; }

			// Token: 0x1700A16D RID: 41325
			// (get) Token: 0x0604E4CD RID: 320717
			// (set) Token: 0x0604E4CE RID: 320718
			string Event { get; set; }

			// Token: 0x1700A16E RID: 41326
			// (get) Token: 0x0604E4CF RID: 320719
			// (set) Token: 0x0604E4D0 RID: 320720
			int Handle { get; set; }

			// Token: 0x1700A16F RID: 41327
			// (get) Token: 0x0604E4D1 RID: 320721
			// (set) Token: 0x0604E4D2 RID: 320722
			double RequestTime { get; set; }

			// Token: 0x1700A170 RID: 41328
			// (get) Token: 0x0604E4D3 RID: 320723
			// (set) Token: 0x0604E4D4 RID: 320724
			double? AudioStartTime { get; set; }

			// Token: 0x1700A171 RID: 41329
			// (get) Token: 0x0604E4D5 RID: 320725
			// (set) Token: 0x0604E4D6 RID: 320726
			bool HasHandledDuration { get; set; }

			// Token: 0x1700A172 RID: 41330
			// (get) Token: 0x0604E4D7 RID: 320727
			// (set) Token: 0x0604E4D8 RID: 320728
			[Nullable(2)]
			MusicSubtitleManager.IMusicSubtitleViewListener Listener { [NullableContext(2)] get; [NullableContext(2)] set; }
		}

		// Token: 0x0200B0EF RID: 45295
		[Nullable(0)]
		[RequiredMember]
		private class MusicSubtitleSession : MusicSubtitleManager.IMusicSubtitleSession
		{
			// Token: 0x1700A173 RID: 41331
			// (get) Token: 0x0604E4D9 RID: 320729 RVA: 0x014C6E41 File Offset: 0x014C5041
			// (set) Token: 0x0604E4DA RID: 320730 RVA: 0x014C6E49 File Offset: 0x014C5049
			[RequiredMember]
			public int RequestId { get; set; }

			// Token: 0x1700A174 RID: 41332
			// (get) Token: 0x0604E4DB RID: 320731 RVA: 0x014C6E52 File Offset: 0x014C5052
			// (set) Token: 0x0604E4DC RID: 320732 RVA: 0x014C6E5A File Offset: 0x014C505A
			[RequiredMember]
			public string MusicSubtitleGroupTag { get; set; }

			// Token: 0x1700A175 RID: 41333
			// (get) Token: 0x0604E4DD RID: 320733 RVA: 0x014C6E63 File Offset: 0x014C5063
			// (set) Token: 0x0604E4DE RID: 320734 RVA: 0x014C6E6B File Offset: 0x014C506B
			[RequiredMember]
			public string Event { get; set; }

			// Token: 0x1700A176 RID: 41334
			// (get) Token: 0x0604E4DF RID: 320735 RVA: 0x014C6E74 File Offset: 0x014C5074
			// (set) Token: 0x0604E4E0 RID: 320736 RVA: 0x014C6E7C File Offset: 0x014C507C
			[RequiredMember]
			public int Handle { get; set; }

			// Token: 0x1700A177 RID: 41335
			// (get) Token: 0x0604E4E1 RID: 320737 RVA: 0x014C6E85 File Offset: 0x014C5085
			// (set) Token: 0x0604E4E2 RID: 320738 RVA: 0x014C6E8D File Offset: 0x014C508D
			[RequiredMember]
			public double RequestTime { get; set; }

			// Token: 0x1700A178 RID: 41336
			// (get) Token: 0x0604E4E3 RID: 320739 RVA: 0x014C6E96 File Offset: 0x014C5096
			// (set) Token: 0x0604E4E4 RID: 320740 RVA: 0x014C6E9E File Offset: 0x014C509E
			public double? AudioStartTime { get; set; }

			// Token: 0x1700A179 RID: 41337
			// (get) Token: 0x0604E4E5 RID: 320741 RVA: 0x014C6EA7 File Offset: 0x014C50A7
			// (set) Token: 0x0604E4E6 RID: 320742 RVA: 0x014C6EAF File Offset: 0x014C50AF
			[RequiredMember]
			public bool HasHandledDuration { get; set; }

			// Token: 0x1700A17A RID: 41338
			// (get) Token: 0x0604E4E7 RID: 320743 RVA: 0x014C6EB8 File Offset: 0x014C50B8
			// (set) Token: 0x0604E4E8 RID: 320744 RVA: 0x014C6EC0 File Offset: 0x014C50C0
			[Nullable(2)]
			public MusicSubtitleManager.IMusicSubtitleViewListener Listener { [NullableContext(2)] get; [NullableContext(2)] set; }

			// Token: 0x0604E4E9 RID: 320745 RVA: 0x014C6EC9 File Offset: 0x014C50C9
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MusicSubtitleSession()
			{
			}
		}
	}
}
