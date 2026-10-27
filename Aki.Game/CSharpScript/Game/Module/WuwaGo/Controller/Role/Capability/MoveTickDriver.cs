using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02004766 RID: 18278
	[NullableContext(1)]
	[Nullable(0)]
	internal class MoveTickDriver : IWuWaGoTimeStopParticipant
	{
		// Token: 0x17007756 RID: 30550
		// (get) Token: 0x0602FC7A RID: 195706 RVA: 0x00B11DEF File Offset: 0x00B0FFEF
		// (set) Token: 0x0602FC7B RID: 195707 RVA: 0x00B11DF7 File Offset: 0x00B0FFF7
		public bool PausedByTimeStop { get; set; }

		// Token: 0x0602FC7C RID: 195708 RVA: 0x00B11E00 File Offset: 0x00B10000
		public MoveTickDriver(WuWaGoRole role, Vector targetLocation, float speed, float timeoutMs)
		{
			this.Role = role;
			this.TargetLocation = targetLocation;
			this.Speed = speed;
			this.TimeoutMs = timeoutMs;
			this.OneStepLen = Math.Max(5f, this.Speed * 0.02f * 1f);
		}

		// Token: 0x0602FC7D RID: 195709 RVA: 0x00B11E8C File Offset: 0x00B1008C
		[NullableContext(0)]
		public UniTask<bool> Run()
		{
			MoveTickDriver.<Run>d__29 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<MoveTickDriver.<Run>d__29>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC7E RID: 195710 RVA: 0x00B11ECF File Offset: 0x00B100CF
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TickHandle);
			WuWaGoTimeStop.PauseTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x0602FC7F RID: 195711 RVA: 0x00B11EE7 File Offset: 0x00B100E7
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TickHandle);
			WuWaGoTimeStop.ResumeTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x0602FC80 RID: 195712 RVA: 0x00B11EFF File Offset: 0x00B100FF
		public void CancelByTimeStop(string reason)
		{
			this.Finish(false);
		}

		// Token: 0x0602FC81 RID: 195713 RVA: 0x00B11F08 File Offset: 0x00B10108
		private void OnTick(float delta)
		{
			FVectorDouble? worldLocation = this.Role.GetWorldLocation();
			if (worldLocation == null)
			{
				this.Finish(false);
				return;
			}
			FVectorDouble value = worldLocation.Value;
			MoveTickDriver.EPhase phase = this.Phase;
			if (phase == MoveTickDriver.EPhase.Running)
			{
				this.TickRunning(value);
				return;
			}
			if (phase != MoveTickDriver.EPhase.Settling)
			{
				return;
			}
			this.TickSettling();
		}

		// Token: 0x0602FC82 RID: 195714 RVA: 0x00B11F58 File Offset: 0x00B10158
		private void TickRunning(FVectorDouble current)
		{
			this.TickDir.Set(this.TargetLocation.X - current.X, this.TargetLocation.Y - current.Y, 0.0);
			if (this.TickDir.Size() <= (double)this.OneStepLen)
			{
				this.EnterSettle(current);
				return;
			}
			this.TickDir.Normalize(9.99999993922529E-09);
			double num = this.TickDir.X * (double)this.Speed * 0.019999999552965164;
			double num2 = this.TickDir.Y * (double)this.Speed * 0.019999999552965164;
			this.StepTarget.Set(current.X + num, current.Y + num2, current.Z);
			this.Role.SetActorWorldLocation(this.StepTarget, false);
			this.WriteMonsterInputDirect(this.TickDir.ToUeVectorOld());
		}

		// Token: 0x0602FC83 RID: 195715 RVA: 0x00B12050 File Offset: 0x00B10250
		private void EnterSettle(FVectorDouble current)
		{
			this.Phase = MoveTickDriver.EPhase.Settling;
			this.SettleElapsedMs = 0f;
			this.SettleStart.Set(current.X, current.Y, current.Z);
			this.WriteMonsterInputDirect(Vector.ZeroVector);
			this.WriteMonsterMoveState(ECharMoveStateType.Stand);
		}

		// Token: 0x0602FC84 RID: 195716 RVA: 0x00B120A0 File Offset: 0x00B102A0
		private void TickSettling()
		{
			this.SettleElapsedMs += 20f;
			float num = Math.Min(1f, this.SettleElapsedMs / 60f);
			Vector.Lerp(this.SettleStart, this.TargetLocation, (double)num, this.SettlePos);
			this.Role.SetActorWorldLocation(this.SettlePos, false);
			if (num >= 1f)
			{
				this.Finish(true);
			}
		}

		// Token: 0x0602FC85 RID: 195717 RVA: 0x00B12110 File Offset: 0x00B10310
		private void OnTimeout(float delta)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WuWaGo;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "MoveCapability：移动超时兜底，直接吸附目标格";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actor", this.Role.GetActorName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.Finish(true);
		}

		// Token: 0x0602FC86 RID: 195718 RVA: 0x00B12158 File Offset: 0x00B10358
		private void Finish(bool completed = true)
		{
			if (this.Resolved)
			{
				return;
			}
			this.Resolved = true;
			Action unregisterTimeStop = this.UnregisterTimeStop;
			if (unregisterTimeStop != null)
			{
				unregisterTimeStop();
			}
			this.UnregisterTimeStop = null;
			TimerHandle tickHandle = this.TickHandle;
			if (tickHandle != null && tickHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TickHandle);
			}
			TimerHandle timeoutHandle = this.TimeoutHandle;
			if (timeoutHandle != null && timeoutHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimeoutHandle);
			}
			if (this.Role.IsActorValid())
			{
				this.WriteMonsterInputDirect(Vector.ZeroVector);
				this.WriteMonsterMoveState(ECharMoveStateType.Stand);
			}
			this.Done.SetResult(completed);
		}

		// Token: 0x0602FC87 RID: 195719 RVA: 0x00B12202 File Offset: 0x00B10402
		[NullableContext(2)]
		private UAbpLogicParams GetMonsterLogicParams()
		{
			UKuroAnimInstanceChar animInstance = this.Role.GetAnimInstance();
			if (animInstance == null)
			{
				return null;
			}
			return animInstance.LogicParams;
		}

		// Token: 0x0602FC88 RID: 195720 RVA: 0x00B1221C File Offset: 0x00B1041C
		private void WriteMonsterInputDirect(FVector worldDir)
		{
			UAbpLogicParams monsterLogicParams = this.GetMonsterLogicParams();
			if (monsterLogicParams == null)
			{
				return;
			}
			monsterLogicParams.InputDirectRef = worldDir;
		}

		// Token: 0x0602FC89 RID: 195721 RVA: 0x00B1223C File Offset: 0x00B1043C
		private void WriteMonsterMoveState(ECharMoveStateType state)
		{
			UAbpLogicParams monsterLogicParams = this.GetMonsterLogicParams();
			if (monsterLogicParams == null)
			{
				return;
			}
			monsterLogicParams.CharMoveStateRef = state;
			monsterLogicParams.CharPositionStateRef = ECharPositionStateType.Ground;
		}

		// Token: 0x04019C6C RID: 105580
		private const int ARRIVE_TOLERANCE = 5;

		// Token: 0x04019C6D RID: 105581
		private const int TICK_INTERVAL_MS = 20;

		// Token: 0x04019C6E RID: 105582
		private const float TICK_DELTA_SECONDS = 0.02f;

		// Token: 0x04019C6F RID: 105583
		private const float EARLY_STOP_STEP_RATIO = 1f;

		// Token: 0x04019C70 RID: 105584
		private const int SETTLE_DURATION_MS = 60;

		// Token: 0x04019C71 RID: 105585
		private const string TIMER_NAME_TICK = "WuWaGo.MoveCapability.Tick";

		// Token: 0x04019C72 RID: 105586
		private const string TIMER_NAME_TIMEOUT = "WuWaGo.MoveCapability.Timeout";

		// Token: 0x04019C74 RID: 105588
		private readonly CustomPromise<bool> Done = new CustomPromise<bool>();

		// Token: 0x04019C75 RID: 105589
		private readonly Vector TickDir = Vector.Create();

		// Token: 0x04019C76 RID: 105590
		private readonly Vector StepTarget = Vector.Create();

		// Token: 0x04019C77 RID: 105591
		private readonly Vector SettleStart = Vector.Create();

		// Token: 0x04019C78 RID: 105592
		private readonly Vector SettlePos = Vector.Create();

		// Token: 0x04019C79 RID: 105593
		private readonly float OneStepLen;

		// Token: 0x04019C7A RID: 105594
		private MoveTickDriver.EPhase Phase;

		// Token: 0x04019C7B RID: 105595
		private float SettleElapsedMs;

		// Token: 0x04019C7C RID: 105596
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x04019C7D RID: 105597
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x04019C7E RID: 105598
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x04019C7F RID: 105599
		private bool Resolved;

		// Token: 0x04019C80 RID: 105600
		private readonly WuWaGoRole Role;

		// Token: 0x04019C81 RID: 105601
		private readonly Vector TargetLocation;

		// Token: 0x04019C82 RID: 105602
		private readonly float Speed;

		// Token: 0x04019C83 RID: 105603
		private readonly float TimeoutMs;

		// Token: 0x0200A9E1 RID: 43489
		[NullableContext(0)]
		private enum EPhase
		{
			// Token: 0x04033B3D RID: 211773
			Running,
			// Token: 0x04033B3E RID: 211774
			Settling
		}
	}
}
