using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x02003661 RID: 13921
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoWorldMoveDriver : IWuWaGoTimeStopParticipant
	{
		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x060241B0 RID: 147888 RVA: 0x00A38013 File Offset: 0x00A36213
		// (set) Token: 0x060241B1 RID: 147889 RVA: 0x00A3801B File Offset: 0x00A3621B
		public bool PausedByTimeStop { get; set; }

		// Token: 0x060241B2 RID: 147890 RVA: 0x00A38024 File Offset: 0x00A36224
		public WuWaGoWorldMoveDriver(IWuWaGoWorldMoveDriverOptions options)
		{
			this.Options = options;
			this.FromWorldPosition.DeepCopy(this.Options.FromWorldPosition);
			this.ToWorldPosition.DeepCopy(this.Options.ToWorldPosition);
			this.TickIntervalMs = Math.Max(1, this.Options.TickIntervalMs.GetValueOrDefault(20));
			this.TickDeltaSeconds = (float)this.TickIntervalMs / 1000f;
			this.SettleDurationMs = Math.Max(0, this.Options.SettleDurationMs.GetValueOrDefault(60));
			this.ArriveTolerance = Math.Max(0f, this.Options.ArriveTolerance.GetValueOrDefault(5f));
			this.WorldDelta.Set(this.ToWorldPosition.X - this.FromWorldPosition.X, this.ToWorldPosition.Y - this.FromWorldPosition.Y, this.ToWorldPosition.Z - this.FromWorldPosition.Z);
			this.Distance = this.WorldDelta.Size();
			int num = Math.Max(1, this.Options.DurationMs.GetValueOrDefault(300));
			float? speed = this.Options.Speed;
			float speed2;
			if (speed != null && speed.GetValueOrDefault() != 0f)
			{
				speed = this.Options.Speed;
				float num2 = 0f;
				if (speed.GetValueOrDefault() > num2 & speed != null)
				{
					speed2 = this.Options.Speed.Value;
					goto IL_21C;
				}
			}
			speed2 = ((this.Distance <= 0.0) ? 0f : ((float)(this.Distance / (double)((float)num / 1000f))));
			IL_21C:
			this.Speed = speed2;
			float num3 = Math.Max(0f, this.Options.EarlyStopStepRatio.GetValueOrDefault(1f));
			this.OneStepLen = Math.Max(this.ArriveTolerance, this.Speed * this.TickDeltaSeconds * num3);
			double num4 = (this.Speed > 0f) ? (this.Distance / (double)this.Speed * 1000.0) : ((double)num);
			double val = (double)(this.TickIntervalMs * 2);
			int? timeoutMs = this.Options.TimeoutMs;
			this.TimeoutMs = (float)Math.Max(val, (timeoutMs != null) ? ((double)timeoutMs.GetValueOrDefault()) : (num4 * 1.5 + (double)this.SettleDurationMs));
		}

		// Token: 0x060241B3 RID: 147891 RVA: 0x00A38308 File Offset: 0x00A36508
		[NullableContext(0)]
		public UniTask<bool> Run()
		{
			WuWaGoWorldMoveDriver.<Run>d__38 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<WuWaGoWorldMoveDriver.<Run>d__38>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x060241B4 RID: 147892 RVA: 0x00A3834B File Offset: 0x00A3654B
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TickHandle);
			WuWaGoTimeStop.PauseTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x060241B5 RID: 147893 RVA: 0x00A38363 File Offset: 0x00A36563
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TickHandle);
			WuWaGoTimeStop.ResumeTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x060241B6 RID: 147894 RVA: 0x00A3837B File Offset: 0x00A3657B
		public void CancelByTimeStop(string reason)
		{
			this.Finish(false, false);
		}

		// Token: 0x060241B7 RID: 147895 RVA: 0x00A38388 File Offset: 0x00A36588
		private void CacheRuntimeTargets()
		{
			this.RuntimeTargets.Clear();
			foreach (IWuWaGoWorldMoveTarget wuWaGoWorldMoveTarget in this.Options.Targets)
			{
				if (wuWaGoWorldMoveTarget.Unit != null)
				{
					if (wuWaGoWorldMoveTarget.Unit.IsActorValid())
					{
						FVectorDouble? worldLocation = wuWaGoWorldMoveTarget.Unit.GetWorldLocation();
						if (worldLocation != null)
						{
							Vector startLocation = Vector.Create(wuWaGoWorldMoveTarget.FromWorldPosition ?? Vector.Create(worldLocation));
							Vector targetLocation = Vector.Create(wuWaGoWorldMoveTarget.ToWorldPosition ?? Vector.Create(worldLocation).Addition(this.WorldDelta, Vector.Create()));
							this.RuntimeTargets.Add(new WuWaGoWorldMoveDriver.MoveTargetRuntime
							{
								Unit = wuWaGoWorldMoveTarget.Unit,
								StartLocation = startLocation,
								TargetLocation = targetLocation
							});
						}
					}
				}
				else
				{
					AActor actor = wuWaGoWorldMoveTarget.Actor;
					if (actor != null && actor.IsValid())
					{
						this.RuntimeTargets.Add(new WuWaGoWorldMoveDriver.MoveTargetRuntime
						{
							Actor = actor,
							StartLocation = Vector.Create(wuWaGoWorldMoveTarget.FromWorldPosition ?? Vector.Create(actor.D_K2_GetActorLocation())),
							TargetLocation = Vector.Create(wuWaGoWorldMoveTarget.ToWorldPosition ?? Vector.Create(actor.D_K2_GetActorLocation()).Addition(this.WorldDelta, Vector.Create()))
						});
					}
				}
			}
		}

		// Token: 0x060241B8 RID: 147896 RVA: 0x00A38528 File Offset: 0x00A36728
		private void OnTick(float delta)
		{
			Func<bool> shouldAbort = this.Options.ShouldAbort;
			if (shouldAbort != null && shouldAbort())
			{
				this.Finish(false, false);
				return;
			}
			if (!this.HasAnyValidTarget())
			{
				this.Finish(true, true);
				return;
			}
			WuWaGoWorldMoveDriver.EWorldMovePhase phase = this.Phase;
			if (phase == WuWaGoWorldMoveDriver.EWorldMovePhase.Running)
			{
				this.TickRunning();
				return;
			}
			if (phase != WuWaGoWorldMoveDriver.EWorldMovePhase.Settling)
			{
				return;
			}
			this.TickSettling();
		}

		// Token: 0x060241B9 RID: 147897 RVA: 0x00A38584 File Offset: 0x00A36784
		private void TickRunning()
		{
			this.RunningDirection.Set(this.ToWorldPosition.X - this.CurrentAnchor.X, this.ToWorldPosition.Y - this.CurrentAnchor.Y, this.ToWorldPosition.Z - this.CurrentAnchor.Z);
			if (this.RunningDirection.Size() <= (double)this.OneStepLen)
			{
				this.EnterSettle();
				return;
			}
			this.RunningDirection.Normalize(9.99999993922529E-09);
			this.CurrentAnchor.Set(this.CurrentAnchor.X + this.RunningDirection.X * (double)this.Speed * (double)this.TickDeltaSeconds, this.CurrentAnchor.Y + this.RunningDirection.Y * (double)this.Speed * (double)this.TickDeltaSeconds, this.CurrentAnchor.Z + this.RunningDirection.Z * (double)this.Speed * (double)this.TickDeltaSeconds);
			this.RunningAlpha = Math.Min(1.0, Vector.Dist(this.FromWorldPosition, this.CurrentAnchor) / Math.Max(this.Distance, 9.999999974752427E-07));
			this.ApplyAlpha((float)this.RunningAlpha);
			IWuWaGoWorldMoveHooks hooks = this.Options.Hooks;
			if (hooks == null)
			{
				return;
			}
			Action<Vector> onRunning = hooks.OnRunning;
			if (onRunning == null)
			{
				return;
			}
			onRunning(this.RunningDirection);
		}

		// Token: 0x060241BA RID: 147898 RVA: 0x00A386FD File Offset: 0x00A368FD
		private void EnterSettle()
		{
			this.Phase = WuWaGoWorldMoveDriver.EWorldMovePhase.Settling;
			this.SettleElapsedMs = 0;
			IWuWaGoWorldMoveHooks hooks = this.Options.Hooks;
			if (hooks == null)
			{
				return;
			}
			Action onEnterSettle = hooks.OnEnterSettle;
			if (onEnterSettle == null)
			{
				return;
			}
			onEnterSettle();
		}

		// Token: 0x060241BB RID: 147899 RVA: 0x00A3872C File Offset: 0x00A3692C
		private void TickSettling()
		{
			if (this.SettleDurationMs <= 0)
			{
				this.Finish(true, true);
				return;
			}
			this.SettleElapsedMs += this.TickIntervalMs;
			float num = Math.Min(1f, (float)this.SettleElapsedMs / (float)this.SettleDurationMs);
			double num2 = this.RunningAlpha + (1.0 - this.RunningAlpha) * (double)num;
			this.ApplyAlpha((float)num2);
			if (num >= 1f)
			{
				this.Finish(true, true);
			}
		}

		// Token: 0x060241BC RID: 147900 RVA: 0x00A387AC File Offset: 0x00A369AC
		private void OnTimeout(float delta)
		{
			Func<bool> shouldAbort = this.Options.ShouldAbort;
			bool flag = shouldAbort == null || !shouldAbort();
			this.Finish(flag, flag);
		}

		// Token: 0x060241BD RID: 147901 RVA: 0x00A387DC File Offset: 0x00A369DC
		private void ApplyAlpha(float alpha)
		{
			foreach (WuWaGoWorldMoveDriver.IMoveTargetRuntime moveTargetRuntime in this.RuntimeTargets)
			{
				if (moveTargetRuntime.Unit != null)
				{
					if (moveTargetRuntime.Unit.IsActorValid())
					{
						Vector.Lerp(moveTargetRuntime.StartLocation, moveTargetRuntime.TargetLocation, (double)alpha, this.InterpLocation);
						moveTargetRuntime.Unit.SetActorWorldLocation(this.InterpLocation, false);
					}
				}
				else
				{
					AActor actor = moveTargetRuntime.Actor;
					if (actor != null && actor.IsValid())
					{
						Vector.Lerp(moveTargetRuntime.StartLocation, moveTargetRuntime.TargetLocation, (double)alpha, this.InterpLocation);
						moveTargetRuntime.Actor.D_K2_SetActorLocation(this.InterpLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
					}
				}
			}
		}

		// Token: 0x060241BE RID: 147902 RVA: 0x00A388C0 File Offset: 0x00A36AC0
		private bool HasAnyValidTarget()
		{
			return this.RuntimeTargets.Find(delegate(WuWaGoWorldMoveDriver.IMoveTargetRuntime target)
			{
				WuWaGoBaseUnit unit = target.Unit;
				if (unit == null)
				{
					AActor actor = target.Actor;
					return actor != null && actor.IsValid();
				}
				return unit.IsActorValid();
			}) != null;
		}

		// Token: 0x060241BF RID: 147903 RVA: 0x00A388F0 File Offset: 0x00A36AF0
		private void Finish(bool applyFinalAlpha = true, bool completed = true)
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
			if (this.HasAnyValidTarget())
			{
				if (applyFinalAlpha)
				{
					this.ApplyAlpha(1f);
				}
				else
				{
					this.ApplyAlpha(0f);
				}
			}
			IWuWaGoWorldMoveHooks hooks = this.Options.Hooks;
			if (hooks != null)
			{
				Action onFinish = hooks.OnFinish;
				if (onFinish != null)
				{
					onFinish();
				}
			}
			this.Done.SetResult(completed);
		}

		// Token: 0x04014210 RID: 82448
		private const int DEFAULT_ARRIVE_TOLERANCE = 5;

		// Token: 0x04014211 RID: 82449
		private const int DEFAULT_DURATION_MS = 300;

		// Token: 0x04014212 RID: 82450
		private const int DEFAULT_TICK_INTERVAL_MS = 20;

		// Token: 0x04014213 RID: 82451
		private const int DEFAULT_SETTLE_DURATION_MS = 60;

		// Token: 0x04014214 RID: 82452
		private const float DEFAULT_SAFE_TIMEOUT_RATIO = 1.5f;

		// Token: 0x04014215 RID: 82453
		private const float DEFAULT_EARLY_STOP_STEP_RATIO = 1f;

		// Token: 0x04014217 RID: 82455
		private readonly CustomPromise<bool> Done = new CustomPromise<bool>();

		// Token: 0x04014218 RID: 82456
		private readonly List<WuWaGoWorldMoveDriver.IMoveTargetRuntime> RuntimeTargets = new List<WuWaGoWorldMoveDriver.IMoveTargetRuntime>();

		// Token: 0x04014219 RID: 82457
		private readonly Vector FromWorldPosition = Vector.Create();

		// Token: 0x0401421A RID: 82458
		private readonly Vector ToWorldPosition = Vector.Create();

		// Token: 0x0401421B RID: 82459
		private readonly Vector WorldDelta = Vector.Create();

		// Token: 0x0401421C RID: 82460
		private readonly Vector RunningDirection = Vector.Create();

		// Token: 0x0401421D RID: 82461
		private readonly Vector CurrentAnchor = Vector.Create();

		// Token: 0x0401421E RID: 82462
		private readonly Vector InterpLocation = Vector.Create();

		// Token: 0x0401421F RID: 82463
		private readonly int TickIntervalMs;

		// Token: 0x04014220 RID: 82464
		private readonly float TickDeltaSeconds;

		// Token: 0x04014221 RID: 82465
		private readonly int SettleDurationMs;

		// Token: 0x04014222 RID: 82466
		private readonly float ArriveTolerance;

		// Token: 0x04014223 RID: 82467
		private readonly float OneStepLen;

		// Token: 0x04014224 RID: 82468
		private readonly float TimeoutMs;

		// Token: 0x04014225 RID: 82469
		private readonly float Speed;

		// Token: 0x04014226 RID: 82470
		private readonly double Distance;

		// Token: 0x04014227 RID: 82471
		private WuWaGoWorldMoveDriver.EWorldMovePhase Phase;

		// Token: 0x04014228 RID: 82472
		private int SettleElapsedMs;

		// Token: 0x04014229 RID: 82473
		private double RunningAlpha;

		// Token: 0x0401422A RID: 82474
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x0401422B RID: 82475
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x0401422C RID: 82476
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x0401422D RID: 82477
		private bool Resolved;

		// Token: 0x0401422E RID: 82478
		private readonly IWuWaGoWorldMoveDriverOptions Options;

		// Token: 0x0200934D RID: 37709
		[NullableContext(0)]
		private enum EWorldMovePhase
		{
			// Token: 0x0402E171 RID: 188785
			Running,
			// Token: 0x0402E172 RID: 188786
			Settling
		}

		// Token: 0x0200934E RID: 37710
		private interface IMoveTargetRuntime
		{
			// Token: 0x170078ED RID: 30957
			// (get) Token: 0x06043C3A RID: 277562
			[Nullable(2)]
			WuWaGoBaseUnit Unit { [NullableContext(2)] get; }

			// Token: 0x170078EE RID: 30958
			// (get) Token: 0x06043C3B RID: 277563
			[Nullable(2)]
			AActor Actor { [NullableContext(2)] get; }

			// Token: 0x170078EF RID: 30959
			// (get) Token: 0x06043C3C RID: 277564
			Vector StartLocation { get; }

			// Token: 0x170078F0 RID: 30960
			// (get) Token: 0x06043C3D RID: 277565
			Vector TargetLocation { get; }
		}

		// Token: 0x0200934F RID: 37711
		[Nullable(0)]
		[RequiredMember]
		private class MoveTargetRuntime : WuWaGoWorldMoveDriver.IMoveTargetRuntime
		{
			// Token: 0x170078F1 RID: 30961
			// (get) Token: 0x06043C3E RID: 277566 RVA: 0x0140F486 File Offset: 0x0140D686
			// (set) Token: 0x06043C3F RID: 277567 RVA: 0x0140F48E File Offset: 0x0140D68E
			[Nullable(2)]
			public WuWaGoBaseUnit Unit { [NullableContext(2)] get; [NullableContext(2)] set; }

			// Token: 0x170078F2 RID: 30962
			// (get) Token: 0x06043C40 RID: 277568 RVA: 0x0140F497 File Offset: 0x0140D697
			// (set) Token: 0x06043C41 RID: 277569 RVA: 0x0140F49F File Offset: 0x0140D69F
			[Nullable(2)]
			public AActor Actor { [NullableContext(2)] get; [NullableContext(2)] set; }

			// Token: 0x170078F3 RID: 30963
			// (get) Token: 0x06043C42 RID: 277570 RVA: 0x0140F4A8 File Offset: 0x0140D6A8
			// (set) Token: 0x06043C43 RID: 277571 RVA: 0x0140F4B0 File Offset: 0x0140D6B0
			[RequiredMember]
			public Vector StartLocation { get; set; }

			// Token: 0x170078F4 RID: 30964
			// (get) Token: 0x06043C44 RID: 277572 RVA: 0x0140F4B9 File Offset: 0x0140D6B9
			// (set) Token: 0x06043C45 RID: 277573 RVA: 0x0140F4C1 File Offset: 0x0140D6C1
			[RequiredMember]
			public Vector TargetLocation { get; set; }

			// Token: 0x06043C46 RID: 277574 RVA: 0x0140F4CA File Offset: 0x0140D6CA
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MoveTargetRuntime()
			{
			}
		}
	}
}
