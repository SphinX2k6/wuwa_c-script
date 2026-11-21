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
	// Token: 0x02006261 RID: 25185
	[NullableContext(1)]
	[Nullable(0)]
	public class MagneticDragModeStrategy : BaseDragModeStrategy
	{
		// Token: 0x17007300 RID: 29440
		// (get) Token: 0x0603CC4E RID: 248910 RVA: 0x011729A0 File Offset: 0x01170BA0
		public override EKuroSplineConstrainedDragMode Mode { get; }

		// Token: 0x0603CC4F RID: 248911 RVA: 0x011729A8 File Offset: 0x01170BA8
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

		// Token: 0x0603CC50 RID: 248912 RVA: 0x01172A54 File Offset: 0x01170C54
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

		// Token: 0x0603CC51 RID: 248913 RVA: 0x01172A8D File Offset: 0x01170C8D
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

		// Token: 0x0603CC52 RID: 248914 RVA: 0x01172AC4 File Offset: 0x01170CC4
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

		// Token: 0x0603CC53 RID: 248915 RVA: 0x01172B72 File Offset: 0x01170D72
		public override void SetCurrentScreenPosition(Vector screenPosition)
		{
			this.CachedMouseScreenPos.Set((float)screenPosition.X, (float)screenPosition.Y);
			this.HasInitialScreenPos = true;
			this.WakeIfSuspended();
		}

		// Token: 0x0603CC54 RID: 248916 RVA: 0x01172B9A File Offset: 0x01170D9A
		public override void ApplyScreenDelta(Vector screenDelta)
		{
			this.CachedMouseScreenPos.Set(this.CachedMouseScreenPos.X + (float)screenDelta.X, this.CachedMouseScreenPos.Y + (float)screenDelta.Y);
			this.HasInitialScreenPos = true;
			this.WakeIfSuspended();
		}

		// Token: 0x0603CC55 RID: 248917 RVA: 0x01172BDA File Offset: 0x01170DDA
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

		// Token: 0x0603CC56 RID: 248918 RVA: 0x01172C1A File Offset: 0x01170E1A
		private void StopTimerIfRunning()
		{
			if (this.MagneticTimerHandle != null)
			{
				this.MagneticTimerHandle.Remove();
				this.MagneticTimerHandle = null;
			}
		}

		// Token: 0x0603CC57 RID: 248919 RVA: 0x01172C37 File Offset: 0x01170E37
		private void EnsureTimerStarted()
		{
			if (this.MagneticTimerHandle != null)
			{
				return;
			}
			this.MagneticTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnMagneticTick), 20f, 1f, null, "MagneticDrag", true);
		}

		// Token: 0x0603CC58 RID: 248920 RVA: 0x01172C6F File Offset: 0x01170E6F
		private void WakeIfSuspended()
		{
			if (!this.MagneticIsSuspended)
			{
				return;
			}
			this.MagneticIsSuspended = false;
			this.EnsureTimerStarted();
		}

		// Token: 0x0603CC59 RID: 248921 RVA: 0x01172C88 File Offset: 0x01170E88
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

		// Token: 0x0603CC5A RID: 248922 RVA: 0x01172D00 File Offset: 0x01170F00
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

		// Token: 0x0603CC5B RID: 248923 RVA: 0x01172D5C File Offset: 0x01170F5C
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

		// Token: 0x0603CC5C RID: 248924 RVA: 0x01172F6C File Offset: 0x0117116C
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

		// Token: 0x0603CC5D RID: 248925 RVA: 0x01173020 File Offset: 0x01171220
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

		// Token: 0x0603CC5E RID: 248926 RVA: 0x011731D0 File Offset: 0x011713D0
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

		// Token: 0x0603CC5F RID: 248927 RVA: 0x011732B8 File Offset: 0x011714B8
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

		// Token: 0x0603CC60 RID: 248928 RVA: 0x01173304 File Offset: 0x01171504
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

		// Token: 0x0603CC61 RID: 248929 RVA: 0x01173380 File Offset: 0x01171580
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

		// Token: 0x0603CC62 RID: 248930 RVA: 0x01173401 File Offset: 0x01171601
		private void SuspendMagneticTick()
		{
			this.StopTimerIfRunning();
			this.MagneticIsSuspended = true;
			this.MagneticVelocity = 0f;
			this.ScreenDegenerateFrames = 0;
		}

		// Token: 0x0603CC63 RID: 248931 RVA: 0x01173424 File Offset: 0x01171624
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

		// Token: 0x04020380 RID: 131968
		private readonly List<SampleBufferEntry> SampleBuffer = new List<SampleBufferEntry>();

		// Token: 0x04020381 RID: 131969
		private FVector2D BisectionTempScreenPos = new FVector2D();

		// Token: 0x04020382 RID: 131970
		private FVector2D BisectionWidthScreenPosA = new FVector2D();

		// Token: 0x04020383 RID: 131971
		private FVector2D BisectionWidthScreenPosB = new FVector2D();

		// Token: 0x04020384 RID: 131972
		private float MagneticVelocity;

		// Token: 0x04020385 RID: 131973
		private FVector2D CachedMouseScreenPos = new FVector2D();

		// Token: 0x04020386 RID: 131974
		private bool HasInitialScreenPos;

		// Token: 0x04020387 RID: 131975
		[Nullable(2)]
		private TimerHandle MagneticTimerHandle;

		// Token: 0x04020388 RID: 131976
		private bool MagneticFallbackLogged;

		// Token: 0x04020389 RID: 131977
		private float LastMagneticTargetDistance;

		// Token: 0x0402038A RID: 131978
		private bool MagneticIsSuspended;

		// Token: 0x0402038B RID: 131979
		private int ScreenDegenerateFrames;

		// Token: 0x0402038C RID: 131980
		private FVector2D LastActorScreenPos = new FVector2D();

		// Token: 0x0402038D RID: 131981
		private readonly Vector TickMousePosVector = Vector.Create();
	}
}
