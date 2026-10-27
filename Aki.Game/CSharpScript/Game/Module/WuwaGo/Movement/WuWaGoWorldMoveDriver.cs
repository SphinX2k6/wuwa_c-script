using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x02004730 RID: 18224
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoWorldMoveDriver : IWuWaGoTimeStopParticipant
	{
		// Token: 0x170076FB RID: 30459
		// (get) Token: 0x0602F9E6 RID: 195046 RVA: 0x00B08157 File Offset: 0x00B06357
		// (set) Token: 0x0602F9E7 RID: 195047 RVA: 0x00B0815F File Offset: 0x00B0635F
		public bool PausedByTimeStop { get; set; }

		// Token: 0x0602F9E8 RID: 195048 RVA: 0x00B08168 File Offset: 0x00B06368
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

		// Token: 0x0602F9E9 RID: 195049 RVA: 0x00B0844C File Offset: 0x00B0664C
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

		// Token: 0x0602F9EA RID: 195050 RVA: 0x00B0848F File Offset: 0x00B0668F
		public void PauseByTimeStop()
		{
			WuWaGoTimeStop.PauseTimerHandle(this.TickHandle);
			WuWaGoTimeStop.PauseTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x0602F9EB RID: 195051 RVA: 0x00B084A7 File Offset: 0x00B066A7
		public void ResumeByTimeStop()
		{
			WuWaGoTimeStop.ResumeTimerHandle(this.TickHandle);
			WuWaGoTimeStop.ResumeTimerHandle(this.TimeoutHandle);
		}

		// Token: 0x0602F9EC RID: 195052 RVA: 0x00B084BF File Offset: 0x00B066BF
		public void CancelByTimeStop(string reason)
		{
			this.Finish(false, false);
		}

		// Token: 0x0602F9ED RID: 195053 RVA: 0x00B084CC File Offset: 0x00B066CC
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

		// Token: 0x0602F9EE RID: 195054 RVA: 0x00B0866C File Offset: 0x00B0686C
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

		// Token: 0x0602F9EF RID: 195055 RVA: 0x00B086C8 File Offset: 0x00B068C8
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

		// Token: 0x0602F9F0 RID: 195056 RVA: 0x00B08841 File Offset: 0x00B06A41
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

		// Token: 0x0602F9F1 RID: 195057 RVA: 0x00B08870 File Offset: 0x00B06A70
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

		// Token: 0x0602F9F2 RID: 195058 RVA: 0x00B088F0 File Offset: 0x00B06AF0
		private void OnTimeout(float delta)
		{
			Func<bool> shouldAbort = this.Options.ShouldAbort;
			bool flag = shouldAbort == null || !shouldAbort();
			this.Finish(flag, flag);
		}

		// Token: 0x0602F9F3 RID: 195059 RVA: 0x00B08920 File Offset: 0x00B06B20
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

		// Token: 0x0602F9F4 RID: 195060 RVA: 0x00B08A04 File Offset: 0x00B06C04
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

		// Token: 0x0602F9F5 RID: 195061 RVA: 0x00B08A34 File Offset: 0x00B06C34
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

		// Token: 0x04019B60 RID: 105312
		private const int DEFAULT_ARRIVE_TOLERANCE = 5;

		// Token: 0x04019B61 RID: 105313
		private const int DEFAULT_DURATION_MS = 300;

		// Token: 0x04019B62 RID: 105314
		private const int DEFAULT_TICK_INTERVAL_MS = 20;

		// Token: 0x04019B63 RID: 105315
		private const int DEFAULT_SETTLE_DURATION_MS = 60;

		// Token: 0x04019B64 RID: 105316
		private const float DEFAULT_SAFE_TIMEOUT_RATIO = 1.5f;

		// Token: 0x04019B65 RID: 105317
		private const float DEFAULT_EARLY_STOP_STEP_RATIO = 1f;

		// Token: 0x04019B67 RID: 105319
		private readonly CustomPromise<bool> Done = new CustomPromise<bool>();

		// Token: 0x04019B68 RID: 105320
		private readonly List<WuWaGoWorldMoveDriver.IMoveTargetRuntime> RuntimeTargets = new List<WuWaGoWorldMoveDriver.IMoveTargetRuntime>();

		// Token: 0x04019B69 RID: 105321
		private readonly Vector FromWorldPosition = Vector.Create();

		// Token: 0x04019B6A RID: 105322
		private readonly Vector ToWorldPosition = Vector.Create();

		// Token: 0x04019B6B RID: 105323
		private readonly Vector WorldDelta = Vector.Create();

		// Token: 0x04019B6C RID: 105324
		private readonly Vector RunningDirection = Vector.Create();

		// Token: 0x04019B6D RID: 105325
		private readonly Vector CurrentAnchor = Vector.Create();

		// Token: 0x04019B6E RID: 105326
		private readonly Vector InterpLocation = Vector.Create();

		// Token: 0x04019B6F RID: 105327
		private readonly int TickIntervalMs;

		// Token: 0x04019B70 RID: 105328
		private readonly float TickDeltaSeconds;

		// Token: 0x04019B71 RID: 105329
		private readonly int SettleDurationMs;

		// Token: 0x04019B72 RID: 105330
		private readonly float ArriveTolerance;

		// Token: 0x04019B73 RID: 105331
		private readonly float OneStepLen;

		// Token: 0x04019B74 RID: 105332
		private readonly float TimeoutMs;

		// Token: 0x04019B75 RID: 105333
		private readonly float Speed;

		// Token: 0x04019B76 RID: 105334
		private readonly double Distance;

		// Token: 0x04019B77 RID: 105335
		private WuWaGoWorldMoveDriver.EWorldMovePhase Phase;

		// Token: 0x04019B78 RID: 105336
		private int SettleElapsedMs;

		// Token: 0x04019B79 RID: 105337
		private double RunningAlpha;

		// Token: 0x04019B7A RID: 105338
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x04019B7B RID: 105339
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x04019B7C RID: 105340
		[Nullable(2)]
		private Action UnregisterTimeStop;

		// Token: 0x04019B7D RID: 105341
		private bool Resolved;

		// Token: 0x04019B7E RID: 105342
		private readonly IWuWaGoWorldMoveDriverOptions Options;

		// Token: 0x0200A993 RID: 43411
		[NullableContext(0)]
		private enum EWorldMovePhase
		{
			// Token: 0x040339D9 RID: 211417
			Running,
			// Token: 0x040339DA RID: 211418
			Settling
		}

		// Token: 0x0200A994 RID: 43412
		private interface IMoveTargetRuntime
		{
			// Token: 0x1700A157 RID: 41303
			// (get) Token: 0x0604D717 RID: 317207
			[Nullable(2)]
			WuWaGoBaseUnit Unit { [NullableContext(2)] get; }

			// Token: 0x1700A158 RID: 41304
			// (get) Token: 0x0604D718 RID: 317208
			[Nullable(2)]
			AActor Actor { [NullableContext(2)] get; }

			// Token: 0x1700A159 RID: 41305
			// (get) Token: 0x0604D719 RID: 317209
			Vector StartLocation { get; }

			// Token: 0x1700A15A RID: 41306
			// (get) Token: 0x0604D71A RID: 317210
			Vector TargetLocation { get; }
		}

		// Token: 0x0200A995 RID: 43413
		[Nullable(0)]
		[RequiredMember]
		private class MoveTargetRuntime : WuWaGoWorldMoveDriver.IMoveTargetRuntime
		{
			// Token: 0x1700A15B RID: 41307
			// (get) Token: 0x0604D71B RID: 317211 RVA: 0x01460EAA File Offset: 0x0145F0AA
			// (set) Token: 0x0604D71C RID: 317212 RVA: 0x01460EB2 File Offset: 0x0145F0B2
			[Nullable(2)]
			public WuWaGoBaseUnit Unit { [NullableContext(2)] get; [NullableContext(2)] set; }

			// Token: 0x1700A15C RID: 41308
			// (get) Token: 0x0604D71D RID: 317213 RVA: 0x01460EBB File Offset: 0x0145F0BB
			// (set) Token: 0x0604D71E RID: 317214 RVA: 0x01460EC3 File Offset: 0x0145F0C3
			[Nullable(2)]
			public AActor Actor { [NullableContext(2)] get; [NullableContext(2)] set; }

			// Token: 0x1700A15D RID: 41309
			// (get) Token: 0x0604D71F RID: 317215 RVA: 0x01460ECC File Offset: 0x0145F0CC
			// (set) Token: 0x0604D720 RID: 317216 RVA: 0x01460ED4 File Offset: 0x0145F0D4
			[RequiredMember]
			public Vector StartLocation { get; set; }

			// Token: 0x1700A15E RID: 41310
			// (get) Token: 0x0604D721 RID: 317217 RVA: 0x01460EDD File Offset: 0x0145F0DD
			// (set) Token: 0x0604D722 RID: 317218 RVA: 0x01460EE5 File Offset: 0x0145F0E5
			[RequiredMember]
			public Vector TargetLocation { get; set; }

			// Token: 0x0604D723 RID: 317219 RVA: 0x01460EEE File Offset: 0x0145F0EE
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public MoveTargetRuntime()
			{
			}
		}
	}
}
