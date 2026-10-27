using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200471B RID: 18203
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoTimeStop : IStaticVariableResetter
	{
		// Token: 0x0602F910 RID: 194832 RVA: 0x00B044AE File Offset: 0x00B026AE
		static WuWaGoTimeStop()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoTimeStop.CreateStaticDefaultValue), new Action(WuWaGoTimeStop.ResetStaticDefaultValue));
		}

		// Token: 0x170076F1 RID: 30449
		// (get) Token: 0x0602F911 RID: 194833 RVA: 0x00B044CD File Offset: 0x00B026CD
		public static bool IsPaused
		{
			get
			{
				return WuWaGoTimeStop.ActiveTokens.Count > 0;
			}
		}

		// Token: 0x0602F912 RID: 194834 RVA: 0x00B044DC File Offset: 0x00B026DC
		public static void CreateStaticDefaultValue()
		{
			WuWaGoTimeStop.NextToken = 0;
			WuWaGoTimeStop.ActiveTokens = new Dictionary<int, string>();
			WuWaGoTimeStop.Participants = new HashSet<IWuWaGoTimeStopParticipant>();
		}

		// Token: 0x0602F913 RID: 194835 RVA: 0x00B044F8 File Offset: 0x00B026F8
		public static void ResetStaticDefaultValue()
		{
			WuWaGoTimeStop.NextToken = 0;
			WuWaGoTimeStop.ActiveTokens = null;
			WuWaGoTimeStop.Participants = null;
		}

		// Token: 0x0602F914 RID: 194836 RVA: 0x00B0450C File Offset: 0x00B0270C
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

		// Token: 0x0602F915 RID: 194837 RVA: 0x00B04546 File Offset: 0x00B02746
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

		// Token: 0x0602F916 RID: 194838 RVA: 0x00B04564 File Offset: 0x00B02764
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

		// Token: 0x0602F917 RID: 194839 RVA: 0x00B045D8 File Offset: 0x00B027D8
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

		// Token: 0x0602F918 RID: 194840 RVA: 0x00B0461C File Offset: 0x00B0281C
		public static void CancelAll(string reason)
		{
			foreach (IWuWaGoTimeStopParticipant wuWaGoTimeStopParticipant in new List<IWuWaGoTimeStopParticipant>(WuWaGoTimeStop.Participants))
			{
				wuWaGoTimeStopParticipant.CancelByTimeStop(reason);
			}
			WuWaGoTimeStop.Participants.Clear();
			WuWaGoTimeStop.ActiveTokens.Clear();
		}

		// Token: 0x0602F919 RID: 194841 RVA: 0x00B04688 File Offset: 0x00B02888
		public static void Clear()
		{
			WuWaGoTimeStop.CancelAll("WuWaGoTimeStop.Clear");
			WuWaGoTimeStop.NextToken = 0;
		}

		// Token: 0x0602F91A RID: 194842 RVA: 0x00B0469A File Offset: 0x00B0289A
		[NullableContext(2)]
		public static void PauseTimerHandle(TimerHandle handle)
		{
			if (handle == null || !handle.Valid() || handle.IsPause())
			{
				return;
			}
			handle.Pause();
		}

		// Token: 0x0602F91B RID: 194843 RVA: 0x00B046BD File Offset: 0x00B028BD
		[NullableContext(2)]
		public static void ResumeTimerHandle(TimerHandle handle)
		{
			if (handle == null || !handle.Valid() || !handle.IsPause())
			{
				return;
			}
			handle.Resume();
		}

		// Token: 0x0602F91C RID: 194844 RVA: 0x00B046E0 File Offset: 0x00B028E0
		private static void PauseAll()
		{
			foreach (IWuWaGoTimeStopParticipant participant in WuWaGoTimeStop.Participants)
			{
				WuWaGoTimeStop.PauseParticipant(participant);
			}
		}

		// Token: 0x0602F91D RID: 194845 RVA: 0x00B04730 File Offset: 0x00B02930
		private static void ResumeAll()
		{
			foreach (IWuWaGoTimeStopParticipant participant in WuWaGoTimeStop.Participants)
			{
				WuWaGoTimeStop.ResumeParticipant(participant);
			}
		}

		// Token: 0x0602F91E RID: 194846 RVA: 0x00B04780 File Offset: 0x00B02980
		private static void PauseParticipant(IWuWaGoTimeStopParticipant participant)
		{
			if (participant.PausedByTimeStop)
			{
				return;
			}
			participant.PausedByTimeStop = true;
			participant.PauseByTimeStop();
		}

		// Token: 0x0602F91F RID: 194847 RVA: 0x00B04798 File Offset: 0x00B02998
		private static void ResumeParticipant(IWuWaGoTimeStopParticipant participant)
		{
			if (!participant.PausedByTimeStop)
			{
				return;
			}
			participant.PausedByTimeStop = false;
			participant.ResumeByTimeStop();
		}

		// Token: 0x04019B13 RID: 105235
		private static int NextToken;

		// Token: 0x04019B14 RID: 105236
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, string> ActiveTokens;

		// Token: 0x04019B15 RID: 105237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static HashSet<IWuWaGoTimeStopParticipant> Participants;
	}
}
