using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071AC RID: 29100
	[NullableContext(1)]
	[Nullable(0)]
	public class MagneticDragModeStrategy : BaseDragModeStrategy
	{
		// Token: 0x17009DB0 RID: 40368
		// (get) Token: 0x06047353 RID: 291667 RVA: 0x01218A9C File Offset: 0x01216C9C
		public override EKuroSplineConstrainedDragMode Mode { get; }

		// Token: 0x06047354 RID: 291668 RVA: 0x01218AA4 File Offset: 0x01216CA4
		private void OnMagneticTick(float deltaMs)
		{
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return;
			}
			USplineComponent constraintSpline = host.GetConstraintSpline();
			if (constraintSpline != null && constraintSpline.IsValid())
			{
				AActor actor = host.GetActor();
				if (actor != null && actor.IsValid())
				{
					if (!this.HasInitialScreenPos)
					{
						return;
					}
					this.TickMousePosVector.X = (double)this.CachedMouseScreenPos.X;
					this.TickMousePosVector.Y = (double)this.CachedMouseScreenPos.Y;
					this.TickMousePosVector.Z = 0.0;
					this.TickMagneticDrag(this.TickMousePosVector, deltaMs / 1000f);
					return;
				}
			}
			this.EndDrag();
		}

		// Token: 0x06047355 RID: 291669 RVA: 0x01218B50 File Offset: 0x01216D50
		public override void OnActivate(IKuroSplineConstrainedDrag host)
		{
			base.OnActivate(host);
			USplineComponent constraintSpline = host.GetConstraintSpline();
			if (constraintSpline != null && constraintSpline.IsValid())
			{
				int requiredSize = MagneticDragModeStrategy.ResolveCoarseSampleCount(constraintSpline.GetSplineLength());
				this.EnsureSampleBufferCapacity(requiredSize);
			}
		}

		// Token: 0x06047356 RID: 291670 RVA: 0x01218B89 File Offset: 0x01216D89
		public override void OnDeactivate()
		{
			base.OnDeactivate();
			this.StopTimerIfRunning();
			this.MagneticVelocity = 0f;
			this.MagneticIsSuspended = false;
			this.MagneticFallbackLogged = false;
			this.ScreenDegenerateFrames = 0;
			this.HasInitialScreenPos = false;
		}

		// Token: 0x06047357 RID: 291671 RVA: 0x01218BC0 File Offset: 0x01216DC0
		public override void BeginDrag()
		{
			base.BeginDrag();
			if (this.Host == null)
			{
				return;
			}
			this.MagneticVelocity = 0f;
			this.MagneticFallbackLogged = false;
			this.LastMagneticTargetDistance = this.Host.GetCurrentDistanceAlongSpline();
			this.MagneticIsSuspended = false;
			this.ScreenDegenerateFrames = 0;
			this.HasInitialScreenPos = false;
			this.CachedMouseScreenPos.Set(0f, 0f);
			this.LastActorScreenPos.Set(0f, 0f);
			USplineComponent constraintSpline = this.Host.GetConstraintSpline();
			if (constraintSpline != null && constraintSpline.IsValid())
			{
				int requiredSize = MagneticDragModeStrategy.ResolveCoarseSampleCount(constraintSpline.GetSplineLength());
				this.EnsureSampleBufferCapacity(requiredSize);
			}
			this.EnsureTimerStarted();
		}

		// Token: 0x06047358 RID: 291672 RVA: 0x01218C6E File Offset: 0x01216E6E
		public override void SetCurrentScreenPosition(Vector screenPosition)
		{
			this.CachedMouseScreenPos.Set((float)screenPosition.X, (float)screenPosition.Y);
			this.HasInitialScreenPos = true;
			this.WakeIfSuspended();
		}

		// Token: 0x06047359 RID: 291673 RVA: 0x01218C96 File Offset: 0x01216E96
		public override void ApplyScreenDelta(Vector screenDelta)
		{
			this.CachedMouseScreenPos.Set(this.CachedMouseScreenPos.X + (float)screenDelta.X, this.CachedMouseScreenPos.Y + (float)screenDelta.Y);
			this.HasInitialScreenPos = true;
			this.WakeIfSuspended();
		}

		// Token: 0x0604735A RID: 291674 RVA: 0x01218CD6 File Offset: 0x01216ED6
		public override void EndDrag()
		{
			base.EndDrag();
			this.StopTimerIfRunning();
			this.MagneticVelocity = 0f;
			this.MagneticFallbackLogged = false;
			this.LastMagneticTargetDistance = 0f;
			this.MagneticIsSuspended = false;
			this.ScreenDegenerateFrames = 0;
			this.HasInitialScreenPos = false;
		}

		// Token: 0x0604735B RID: 291675 RVA: 0x01218D16 File Offset: 0x01216F16
		private void StopTimerIfRunning()
		{
			if (this.MagneticTimerHandle != null)
			{
				this.MagneticTimerHandle.Remove();
				this.MagneticTimerHandle = null;
			}
		}

		// Token: 0x0604735C RID: 291676 RVA: 0x01218D33 File Offset: 0x01216F33
		private void EnsureTimerStarted()
		{
			if (this.MagneticTimerHandle != null)
			{
				return;
			}
			this.MagneticTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnMagneticTick), 20f, 1f, null, "MagneticDrag", true);
		}

		// Token: 0x0604735D RID: 291677 RVA: 0x01218D6B File Offset: 0x01216F6B
		private void WakeIfSuspended()
		{
			if (!this.MagneticIsSuspended)
			{
				return;
			}
			this.MagneticIsSuspended = false;
			this.EnsureTimerStarted();
		}

		// Token: 0x0604735E RID: 291678 RVA: 0x01218D84 File Offset: 0x01216F84
		public static IStepSpringResult StepSpringSimulation(float current, float target, float velocity, float stiffness, float damping, float dtSeconds, float maxStepSeconds, float convergeSpeedThreshold, float convergePosThreshold)
		{
			float num = Math.Min(dtSeconds, maxStepSeconds);
			float num2 = -stiffness * (current - target) - damping * velocity;
			float num3 = velocity + num2 * num;
			float num4 = current + num3 * num;
			bool flag = Math.Abs(num3) < convergeSpeedThreshold && Math.Abs(target - num4) < convergePosThreshold;
			return new StepSpringResult
			{
				NewPosition = (flag ? target : num4),
				NewVelocity = (flag ? 0f : num3),
				Converged = flag
			};
		}

		// Token: 0x0604735F RID: 291679 RVA: 0x01218DFC File Offset: 0x01216FFC
		private static int ResolveCoarseSampleCount(float splineLength)
		{
			int val = SplineConstrainedCommonDefineConstants.magneticCoarseSampleCountByQuality[GameSettingsDeviceRender.Instance.GameQualitySettingLevel];
			if (splineLength > 0f)
			{
				int val2 = (int)Math.Floor((double)splineLength / 0.5) + 1;
				val = Math.Min(val, val2);
			}
			val = Math.Min(val, 128);
			return Math.Max(val, 2);
		}

		// Token: 0x06047360 RID: 291680 RVA: 0x01218E58 File Offset: 0x01217058
		private float TickMagneticDrag(Vector currentMouseScreenPosition, float deltaTime)
		{
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return 0f;
			}
			this.CachedMouseScreenPos.Set((float)currentMouseScreenPosition.X, (float)currentMouseScreenPosition.Y);
			float num = this.FindClosestSplineDistanceToScreenPos(this.CachedMouseScreenPos);
			if (num < 0f)
			{
				this.LogFallbackOnce("all-projection-failed");
				this.DebugDrawMagnetic();
				return host.GetCurrentDistanceAlongSpline();
			}
			this.LastMagneticTargetDistance = num;
			float? magneticStiffness = host.GetMagneticStiffness();
			float? magneticDamping = host.GetMagneticDamping();
			float num4;
			if (magneticStiffness != null)
			{
				float? num2 = magneticStiffness;
				float num3 = 0f;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					num4 = magneticStiffness.Value;
					goto IL_A1;
				}
			}
			num4 = 50f;
			IL_A1:
			float stiffness = num4;
			float num5;
			if (magneticDamping != null)
			{
				float? num2 = magneticDamping;
				float num3 = 0f;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					num5 = magneticDamping.Value;
					goto IL_D9;
				}
			}
			num5 = 10f;
			IL_D9:
			float damping = num5;
			IStepSpringResult stepSpringResult = MagneticDragModeStrategy.StepSpringSimulation(host.GetCurrentDistanceAlongSpline(), num, this.MagneticVelocity, stiffness, damping, deltaTime, 0.033333335f, 0.01f, 0.5f);
			this.MagneticVelocity = stepSpringResult.NewVelocity;
			float result = host.SetDistanceAlongSpline(stepSpringResult.NewPosition, true);
			TsCharacterController characterController = Global.CharacterController;
			AActor actor = host.GetActor();
			if (characterController != null && characterController.IsValid() && actor != null && actor.IsValid())
			{
				FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
				FVector2D lastActorScreenPos = this.LastActorScreenPos;
				if (UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref lastActorScreenPos, false))
				{
					float x = this.LastActorScreenPos.X;
					float y = this.LastActorScreenPos.Y;
					FVector2D fvector2D = lastActorScreenPos;
					float num6 = fvector2D.X - x;
					float num7 = fvector2D.Y - y;
					float num8 = num6 * num6 + num7 * num7;
					this.LastActorScreenPos.Set(fvector2D.X, fvector2D.Y);
					if (num8 < 1f)
					{
						this.ScreenDegenerateFrames++;
					}
					else
					{
						this.ScreenDegenerateFrames = 0;
					}
				}
			}
			if (stepSpringResult.Converged || this.ScreenDegenerateFrames >= 5)
			{
				this.SuspendMagneticTick();
			}
			this.DebugDrawMagnetic();
			return result;
		}

		// Token: 0x06047361 RID: 291681 RVA: 0x01219068 File Offset: 0x01217268
		private unsafe void EnsureSampleBufferCapacity(int requiredSize)
		{
			if (requiredSize > 128)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "EnsureSampleBufferCapacity 过大";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("requiredSize", requiredSize);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Host", this.Host);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			while (this.SampleBuffer.Count < requiredSize)
			{
				this.SampleBuffer.Add(new SampleBufferEntry
				{
					Distance = 0f,
					ScreenPos = new FVector2D(),
					Valid = false
				});
			}
		}

		// Token: 0x06047362 RID: 291682 RVA: 0x0121911C File Offset: 0x0121731C
		private float FindClosestSplineDistanceToScreenPos(FVector2D mouseScreenPos)
		{
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return -1f;
			}
			USplineComponent constraintSpline = host.GetConstraintSpline();
			if (constraintSpline == null || !constraintSpline.IsValid())
			{
				return -1f;
			}
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null || !characterController.IsValid())
			{
				return -1f;
			}
			float splineLength = constraintSpline.GetSplineLength();
			if (splineLength <= 0f)
			{
				return -1f;
			}
			int num = MagneticDragModeStrategy.ResolveCoarseSampleCount(splineLength);
			this.EnsureSampleBufferCapacity(num);
			int num2 = -1;
			double num3 = double.PositiveInfinity;
			for (int i = 0; i < num; i++)
			{
				SampleBufferEntry sampleBufferEntry = this.SampleBuffer[i];
				sampleBufferEntry.Distance = (float)i / (float)(num - 1) * splineLength;
				FVectorDouble fvectorDouble = constraintSpline.D_GetLocationAtDistanceAlongSpline(sampleBufferEntry.Distance, ESplineCoordinateSpace.World);
				FVector2D screenPos = sampleBufferEntry.ScreenPos;
				bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref screenPos, false);
				sampleBufferEntry.Valid = flag;
				if (flag)
				{
					sampleBufferEntry.ScreenPos = screenPos;
					double num4 = Math.Pow((double)(sampleBufferEntry.ScreenPos.X - mouseScreenPos.X), 2.0) + Math.Pow((double)(sampleBufferEntry.ScreenPos.Y - mouseScreenPos.Y), 2.0);
					if (num4 < num3)
					{
						num3 = num4;
						num2 = i;
					}
				}
			}
			if (num2 < 0)
			{
				return -1f;
			}
			float loIn = (num2 > 0) ? this.SampleBuffer[num2 - 1].Distance : 0f;
			float hiIn = (num2 < num - 1) ? this.SampleBuffer[num2 + 1].Distance : splineLength;
			return this.RefineByBisection(constraintSpline, characterController, mouseScreenPos, loIn, hiIn);
		}

		// Token: 0x06047363 RID: 291683 RVA: 0x012192CC File Offset: 0x012174CC
		private float RefineByBisection(USplineComponent spline, APlayerController playerController, FVector2D mouseScreenPos, float loIn, float hiIn)
		{
			int num = 8;
			double num2 = 1.0;
			float num3 = loIn;
			float num4 = hiIn;
			for (int i = 0; i < num; i++)
			{
				float num5 = (num3 + num4) * 0.5f;
				float distance = (num3 + num5) * 0.5f;
				float distance2 = (num5 + num4) * 0.5f;
				double num6 = this.ScreenDistSqAtDistance(spline, playerController, mouseScreenPos, distance);
				double num7 = this.ScreenDistSqAtDistance(spline, playerController, mouseScreenPos, distance2);
				if (num6 < 0.0 && num7 < 0.0)
				{
					break;
				}
				if (num6 < 0.0)
				{
					num3 = num5;
				}
				else if (num7 < 0.0)
				{
					num4 = num5;
				}
				else
				{
					if (num6 < num7)
					{
						num4 = num5;
					}
					else
					{
						num3 = num5;
					}
					double num8 = this.ScreenWidthSqOnSpline(spline, playerController, num3, num4);
					if (num8 >= 0.0 && num8 < num2)
					{
						break;
					}
				}
			}
			return (num3 + num4) * 0.5f;
		}

		// Token: 0x06047364 RID: 291684 RVA: 0x012193B4 File Offset: 0x012175B4
		private double ScreenDistSqAtDistance(USplineComponent spline, APlayerController playerController, FVector2D mouseScreenPos, float distance)
		{
			FVectorDouble fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World);
			FVector2D bisectionTempScreenPos = this.BisectionTempScreenPos;
			if (!UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble, ref bisectionTempScreenPos, false))
			{
				return -1.0;
			}
			this.BisectionTempScreenPos = bisectionTempScreenPos;
			return (double)FVector2D.DistSquared(this.BisectionTempScreenPos, mouseScreenPos);
		}

		// Token: 0x06047365 RID: 291685 RVA: 0x01219400 File Offset: 0x01217600
		private double ScreenWidthSqOnSpline(USplineComponent spline, APlayerController playerController, float lo, float hi)
		{
			FVectorDouble fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(lo, ESplineCoordinateSpace.World);
			FVectorDouble fvectorDouble2 = spline.D_GetLocationAtDistanceAlongSpline(hi, ESplineCoordinateSpace.World);
			FVector2D bisectionWidthScreenPosA = this.BisectionWidthScreenPosA;
			if (!UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble, ref bisectionWidthScreenPosA, false))
			{
				return -1.0;
			}
			this.BisectionWidthScreenPosA = bisectionWidthScreenPosA;
			FVector2D bisectionWidthScreenPosB = this.BisectionWidthScreenPosB;
			if (!UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble2, ref bisectionWidthScreenPosB, false))
			{
				return -1.0;
			}
			this.BisectionWidthScreenPosB = bisectionWidthScreenPosB;
			return (double)FVector2D.DistSquared(this.BisectionWidthScreenPosA, this.BisectionWidthScreenPosB);
		}

		// Token: 0x06047366 RID: 291686 RVA: 0x0121947C File Offset: 0x0121767C
		private unsafe void LogFallbackOnce(string reason)
		{
			if (this.MagneticFallbackLogged)
			{
				return;
			}
			this.MagneticFallbackLogged = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "[MagneticDrag] degenerate frame — algorithm returned current distance (no update)";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "actorKey";
			IKuroSplineConstrainedDrag host = this.Host;
			ptr = new ValueTuple<string, object>(item, (host != null) ? host.GetActor() : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06047367 RID: 291687 RVA: 0x012194FD File Offset: 0x012176FD
		private void SuspendMagneticTick()
		{
			this.StopTimerIfRunning();
			this.MagneticIsSuspended = true;
			this.MagneticVelocity = 0f;
			this.ScreenDegenerateFrames = 0;
		}

		// Token: 0x06047368 RID: 291688 RVA: 0x01219520 File Offset: 0x01217720
		private void DebugDrawMagnetic()
		{
			if (SundryModel.Instance.GetModuleDebugLevel("SplineConstrainedDrag") <= 0)
			{
				return;
			}
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return;
			}
			USplineComponent constraintSpline = host.GetConstraintSpline();
			AActor actor = host.GetActor();
			if (constraintSpline == null || !constraintSpline.IsValid() || (actor == null || !actor.IsValid()))
			{
				return;
			}
			FVectorDouble lineStart = actor.D_K2_GetActorLocation();
			FVectorDouble fvectorDouble = constraintSpline.D_GetLocationAtDistanceAlongSpline(this.LastMagneticTargetDistance, ESplineCoordinateSpace.World);
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, fvectorDouble, 20f, 16, new FLinearColor?(ColorUtils.LinearCyan), 0f, 0f);
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, lineStart, fvectorDouble, ColorUtils.LinearCyan, 0f, 0f);
		}

		// Token: 0x04025711 RID: 153361
		private readonly List<SampleBufferEntry> SampleBuffer = new List<SampleBufferEntry>();

		// Token: 0x04025712 RID: 153362
		private FVector2D BisectionTempScreenPos = new FVector2D();

		// Token: 0x04025713 RID: 153363
		private FVector2D BisectionWidthScreenPosA = new FVector2D();

		// Token: 0x04025714 RID: 153364
		private FVector2D BisectionWidthScreenPosB = new FVector2D();

		// Token: 0x04025715 RID: 153365
		private float MagneticVelocity;

		// Token: 0x04025716 RID: 153366
		private FVector2D CachedMouseScreenPos = new FVector2D();

		// Token: 0x04025717 RID: 153367
		private bool HasInitialScreenPos;

		// Token: 0x04025718 RID: 153368
		[Nullable(2)]
		private TimerHandle MagneticTimerHandle;

		// Token: 0x04025719 RID: 153369
		private bool MagneticFallbackLogged;

		// Token: 0x0402571A RID: 153370
		private float LastMagneticTargetDistance;

		// Token: 0x0402571B RID: 153371
		private bool MagneticIsSuspended;

		// Token: 0x0402571C RID: 153372
		private int ScreenDegenerateFrames;

		// Token: 0x0402571D RID: 153373
		private FVector2D LastActorScreenPos = new FVector2D();

		// Token: 0x0402571E RID: 153374
		private readonly Vector TickMousePosVector = Vector.Create();
	}
}
