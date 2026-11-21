using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200364B RID: 13899
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoTimeStop : IStaticVariableResetter
	{
		// Token: 0x060240D6 RID: 147670 RVA: 0x00A3417E File Offset: 0x00A3237E
		static WuWaGoTimeStop()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoTimeStop.CreateStaticDefaultValue), new Action(WuWaGoTimeStop.ResetStaticDefaultValue));
		}

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x060240D7 RID: 147671 RVA: 0x00A3419D File Offset: 0x00A3239D
		public static bool IsPaused
		{
			get
			{
				return WuWaGoTimeStop.ActiveTokens.Count > 0;
			}
		}

		// Token: 0x060240D8 RID: 147672 RVA: 0x00A341AC File Offset: 0x00A323AC
		public static void CreateStaticDefaultValue()
		{
			WuWaGoTimeStop.NextToken = 0;
			WuWaGoTimeStop.ActiveTokens = new Dictionary<int, string>();
			WuWaGoTimeStop.Participants = new HashSet<IWuWaGoTimeStopParticipant>();
		}

		// Token: 0x060240D9 RID: 147673 RVA: 0x00A341C8 File Offset: 0x00A323C8
		public static void ResetStaticDefaultValue()
		{
			WuWaGoTimeStop.NextToken = 0;
			WuWaGoTimeStop.ActiveTokens = null;
			WuWaGoTimeStop.Participants = null;
		}

		// Token: 0x060240DA RID: 147674 RVA: 0x00A341DC File Offset: 0x00A323DC
		public static int Begin(string reason)
		{
			int num = ++WuWaGoTimeStop.NextToken;
			WuWaGoTimeStop.ActiveTokens.Add(num, reason);
			if (WuWaGoTimeStop.ActiveTokens.Count == 1)
			{
				WuWaGoTimeStop.PauseAll();
			}
			return num;
		}

		// Token: 0x060240DB RID: 147675 RVA: 0x00A34216 File Offset: 0x00A32416
		public static void End(int token)
		{
			if (!WuWaGoTimeStop.ActiveTokens.Remove(token))
			{
				return;
			}
			if (!WuWaGoTimeStop.IsPaused)
			{
				WuWaGoTimeStop.ResumeAll();
			}
		}

		// Token: 0x060240DC RID: 147676 RVA: 0x00A34234 File Offset: 0x00A32434
		public static Action Register(IWuWaGoTimeStopParticipant participant, EWuWaGoTimeStopPolicy policy = EWuWaGoTimeStopPolicy.Pausable)
		{
			if (policy == EWuWaGoTimeStopPolicy.Ignore)
			{
				return delegate()
				{
				};
			}
			WuWaGoTimeStop.Participants.Add(participant);
			if (WuWaGoTimeStop.IsPaused)
			{
				WuWaGoTimeStop.PauseParticipant(participant);
			}
			bool registered = true;
			return delegate()
			{
				if (!registered)
				{
					return;
				}
				registered = false;
				WuWaGoTimeStop.Participants.Remove(participant);
			};
		}

		// Token: 0x060240DD RID: 147677 RVA: 0x00A342A8 File Offset: 0x00A324A8
		[NullableContext(0)]
		public static UniTask<EWuWaGoTimeStopWaitResult> Wait(int durationMs)
		{
			WuWaGoTimeStop.<Wait>d__11 <Wait>d__;
			<Wait>d__.<>t__builder = AsyncUniTaskMethodBuilder<EWuWaGoTimeStopWaitResult>.Create();
			<Wait>d__.durationMs = durationMs;
			<Wait>d__.<>1__state = -1;
			<Wait>d__.<>t__builder.Start<WuWaGoTimeStop.<Wait>d__11>(ref <Wait>d__);
			return <Wait>d__.<>t__builder.Task;
		}

		// Token: 0x060240DE RID: 147678 RVA: 0x00A342EC File Offset: 0x00A324EC
		public static void CancelAll(string reason)
		{
			foreach (IWuWaGoTimeStopParticipant wuWaGoTimeStopParticipant in new List<IWuWaGoTimeStopParticipant>(WuWaGoTimeStop.Participants))
			{
				wuWaGoTimeStopParticipant.CancelByTimeStop(reason);
			}
			WuWaGoTimeStop.Participants.Clear();
			WuWaGoTimeStop.ActiveTokens.Clear();
		}

		// Token: 0x060240DF RID: 147679 RVA: 0x00A34358 File Offset: 0x00A32558
		public static void Clear()
		{
			WuWaGoTimeStop.CancelAll("WuWaGoTimeStop.Clear");
			WuWaGoTimeStop.NextToken = 0;
		}

		// Token: 0x060240E0 RID: 147680 RVA: 0x00A3436A File Offset: 0x00A3256A
		[NullableContext(2)]
		public static void PauseTimerHandle(TimerHandle handle)
		{
			if (handle == null || !handle.Valid() || handle.IsPause())
			{
				return;
			}
			handle.Pause();
		}

		// Token: 0x060240E1 RID: 147681 RVA: 0x00A3438D File Offset: 0x00A3258D
		[NullableContext(2)]
		public static void ResumeTimerHandle(TimerHandle handle)
		{
			if (handle == null || !handle.Valid() || !handle.IsPause())
			{
				return;
			}
			handle.Resume();
		}

		// Token: 0x060240E2 RID: 147682 RVA: 0x00A343B0 File Offset: 0x00A325B0
		private static void PauseAll()
		{
			foreach (IWuWaGoTimeStopParticipant participant in WuWaGoTimeStop.Participants)
			{
				WuWaGoTimeStop.PauseParticipant(participant);
			}
		}

		// Token: 0x060240E3 RID: 147683 RVA: 0x00A34400 File Offset: 0x00A32600
		private static void ResumeAll()
		{
			foreach (IWuWaGoTimeStopParticipant participant in WuWaGoTimeStop.Participants)
			{
				WuWaGoTimeStop.ResumeParticipant(participant);
			}
		}

		// Token: 0x060240E4 RID: 147684 RVA: 0x00A34450 File Offset: 0x00A32650
		private static void PauseParticipant(IWuWaGoTimeStopParticipant participant)
		{
			if (participant.PausedByTimeStop)
			{
				return;
			}
			participant.PausedByTimeStop = true;
			participant.PauseByTimeStop();
		}

		// Token: 0x060240E5 RID: 147685 RVA: 0x00A34468 File Offset: 0x00A32668
		private static void ResumeParticipant(IWuWaGoTimeStopParticipant participant)
		{
			if (!participant.PausedByTimeStop)
			{
				return;
			}
			participant.PausedByTimeStop = false;
			participant.ResumeByTimeStop();
		}

		// Token: 0x040141C2 RID: 82370
		private static int NextToken;

		// Token: 0x040141C3 RID: 82371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, string> ActiveTokens;

		// Token: 0x040141C4 RID: 82372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static HashSet<IWuWaGoTimeStopParticipant> Participants;
	}
}
