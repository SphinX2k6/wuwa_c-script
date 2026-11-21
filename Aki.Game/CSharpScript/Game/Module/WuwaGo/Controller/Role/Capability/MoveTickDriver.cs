using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02003697 RID: 13975
	[NullableContext(1)]
	[Nullable(0)]
	internal class MoveTickDriver : IWuWaGoTimeStopParticipant
	{
		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x06024444 RID: 148548 RVA: 0x00A41DAF File Offset: 0x00A3FFAF
		// (set) Token: 0x06024445 RID: 148549 RVA: 0x00A41DB7 File Offset: 0x00A3FFB7
		public bool PausedByTimeStop { get; set; }

		// Token: 0x06024446 RID: 148550 RVA: 0x00A41DC0 File Offset: 0x00A3FFC0
		public MoveTickDriver(WuWaGoRole role, Vector targetLocation, float speed, float timeoutMs)
		{
			this.Role = role;
			this.TargetLocation = targetLocation;
			this.Speed = speed;
			this.TimeoutMs = timeoutMs;
			this.OneStepLen = Math.Max(5f, this.Speed * 0.02f * 1f);
		}

		// Token: 0x06024447 RID: 148551 RVA: 0x00A41E4C File Offset: 0x00A4004C
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

		// Token: 0x06024448 RID: 148552 RVA: 0x00A41E8F File Offset: 0x00A4008F
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TickHandle);
			WuWaGoTimeStop.PauseTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x06024449 RID: 148553 RVA: 0x00A41EA7 File Offset: 0x00A400A7
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TickHandle);
			WuWaGoTimeStop.ResumeTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x0602444A RID: 148554 RVA: 0x00A41EBF File Offset: 0x00A400BF
		public void CancelByTimeStop(string reason)
		{
			this.Finish(false);
		}

		// Token: 0x0602444B RID: 148555 RVA: 0x00A41EC8 File Offset: 0x00A400C8
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

		// Token: 0x0602444C RID: 148556 RVA: 0x00A41F18 File Offset: 0x00A40118
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

		// Token: 0x0602444D RID: 148557 RVA: 0x00A42010 File Offset: 0x00A40210
		private void EnterSettle(FVectorDouble current)
		{
			this.Phase = MoveTickDriver.EPhase.Settling;
			this.SettleElapsedMs = 0f;
			this.SettleStart.Set(current.X, current.Y, current.Z);
			this.WriteMonsterInputDirect(Vector.ZeroVector);
			this.WriteMonsterMoveState(ECharMoveStateType.Stand);
		}

		// Token: 0x0602444E RID: 148558 RVA: 0x00A42060 File Offset: 0x00A40260
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

		// Token: 0x0602444F RID: 148559 RVA: 0x00A420D0 File Offset: 0x00A402D0
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

		// Token: 0x06024450 RID: 148560 RVA: 0x00A42118 File Offset: 0x00A40318
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

		// Token: 0x06024451 RID: 148561 RVA: 0x00A421C2 File Offset: 0x00A403C2
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

		// Token: 0x06024452 RID: 148562 RVA: 0x00A421DC File Offset: 0x00A403DC
		private void WriteMonsterInputDirect(FVector worldDir)
		{
			UAbpLogicParams monsterLogicParams = this.GetMonsterLogicParams();
			if (monsterLogicParams == null)
			{
				return;
			}
			monsterLogicParams.InputDirectRef = worldDir;
		}

		// Token: 0x06024453 RID: 148563 RVA: 0x00A421FC File Offset: 0x00A403FC
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

		// Token: 0x0401431C RID: 82716
		private const int ARRIVE_TOLERANCE = 5;

		// Token: 0x0401431D RID: 82717
		private const int TICK_INTERVAL_MS = 20;

		// Token: 0x0401431E RID: 82718
		private const float TICK_DELTA_SECONDS = 0.02f;

		// Token: 0x0401431F RID: 82719
		private const float EARLY_STOP_STEP_RATIO = 1f;

		// Token: 0x04014320 RID: 82720
		private const int SETTLE_DURATION_MS = 60;

		// Token: 0x04014321 RID: 82721
		private const string TIMER_NAME_TICK = "WuWaGo.MoveCapability.Tick";

		// Token: 0x04014322 RID: 82722
		private const string TIMER_NAME_TIMEOUT = "WuWaGo.MoveCapability.Timeout";

		// Token: 0x04014324 RID: 82724
		private readonly CustomPromise<bool> Done = new CustomPromise<bool>();

		// Token: 0x04014325 RID: 82725
		private readonly Vector TickDir = Vector.Create();

		// Token: 0x04014326 RID: 82726
		private readonly Vector StepTarget = Vector.Create();

		// Token: 0x04014327 RID: 82727
		private readonly Vector SettleStart = Vector.Create();

		// Token: 0x04014328 RID: 82728
		private readonly Vector SettlePos = Vector.Create();

		// Token: 0x04014329 RID: 82729
		private readonly float OneStepLen;

		// Token: 0x0401432A RID: 82730
		private MoveTickDriver.EPhase Phase;

		// Token: 0x0401432B RID: 82731
		private float SettleElapsedMs;

		// Token: 0x0401432C RID: 82732
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x0401432D RID: 82733
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x0401432E RID: 82734
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x0401432F RID: 82735
		private bool Resolved;

		// Token: 0x04014330 RID: 82736
		private readonly WuWaGoRole Role;

		// Token: 0x04014331 RID: 82737
		private readonly Vector TargetLocation;

		// Token: 0x04014332 RID: 82738
		private readonly float Speed;

		// Token: 0x04014333 RID: 82739
		private readonly float TimeoutMs;

		// Token: 0x02009396 RID: 37782
		[NullableContext(0)]
		private enum EPhase
		{
			// Token: 0x0402E2CD RID: 189133
			Running,
			// Token: 0x0402E2CE RID: 189134
			Settling
		}
	}
}
