using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200310D RID: 12557
[NullableContext(1)]
[Nullable(0)]
public class FreeFollowingDebug
{
	// Token: 0x0601AF8B RID: 110475 RVA: 0x0075189A File Offset: 0x0074FA9A
	public void Reset(FreeFollowingRuntime runtime)
	{
		this.LastState = runtime.State;
		this.LastSide = runtime.CurrentSide;
		this.LastSummaryLogTime = 0.0;
		this.LastTargetFound = true;
	}

	// Token: 0x0601AF8C RID: 110476 RVA: 0x007518CA File Offset: 0x0074FACA
	public void RecordTargetResult(bool found, FreeFollowingRuntime runtime)
	{
		if (!found)
		{
			bool lastTargetFound = this.LastTargetFound;
		}
		this.LastTargetFound = found;
	}

	// Token: 0x0601AF8D RID: 110477 RVA: 0x007518DD File Offset: 0x0074FADD
	public void LogWalkTemporaryPause(FreeFollowingRuntime runtime)
	{
	}

	// Token: 0x0601AF8E RID: 110478 RVA: 0x007518DF File Offset: 0x0074FADF
	public void DrawCandidate(Vector candidate, bool valid)
	{
		FreeFollowingDebug.DrawSphere(candidate, valid ? ColorUtils.LinearWhite : ColorUtils.LinearRed);
	}

	// Token: 0x0601AF8F RID: 110479 RVA: 0x007518F8 File Offset: 0x0074FAF8
	public void Draw(FreeFollowingRuntime runtime, CharacterActorComponent leader, CharacterActorComponent follower, ECharMoveState? leaderMoveState, ECharMoveState followerMoveState, double followerSpeed, FreeFollowingParams parameters, [Nullable(2)] Vector selectedTarget = null)
	{
		EFreeFollowingState state = runtime.State;
		EFreeFollowingSide currentSide = runtime.CurrentSide;
		double followerRadius = runtime.FollowerRadius;
		if (followerRadius > runtime.ActiveFollowRadius)
		{
			double activeStartFollowingRadius = runtime.ActiveStartFollowingRadius;
		}
		if (state != this.LastState)
		{
			this.LastState = state;
		}
		if (currentSide != this.LastSide)
		{
			this.LastSide = currentSide;
		}
		double now = Time.Instance.Now;
		if (now - this.LastSummaryLogTime >= 2000.0)
		{
			if (!double.IsNaN(runtime.TargetDistance))
			{
				runtime.TargetDistance.ToString("F1");
			}
			if (!runtime.HoldForLocalMovement)
			{
				bool localMovementActive = runtime.LocalMovementActive;
			}
			this.LastSummaryLogTime = now;
		}
		if (selectedTarget != null)
		{
			this.Target.DeepCopy(selectedTarget);
		}
		else
		{
			runtime.CalculateTarget(this.Target, leader, follower, 0.0, parameters);
		}
		FreeFollowingDebug.DrawSphere(this.Target, runtime.IsWalkTemporaryPauseActive() ? ColorUtils.LinearRed : ((runtime.IsDistanceFollowingActive && runtime.StopConfirmTime > 0.0) ? ColorUtils.LinearYellow : ColorUtils.LinearGreen));
		if (runtime.IsWalkTemporaryPauseActive())
		{
			FreeFollowingDebug.DrawLine(follower.ActorLocationProxy, this.Target, ColorUtils.LinearRed);
		}
		runtime.CopyPredictionCenter(this.CacheVector);
		FreeFollowingDebug.DrawSphere(this.CacheVector, ColorUtils.LinearCyan);
		UKismetSystemLibrary.D_DrawDebugCircle(GlobalData.World, this.CacheVector.ToUeVector(false), (float)runtime.ActiveFollowRadius, 30, new FLinearColor?(ColorUtils.LinearCyan), 0f, 2f, new FVectorDouble?(leader.ActorForwardProxy.ToUeVector(false)), new FVectorDouble?(leader.ActorRightProxy.ToUeVector(false)), true);
		FreeFollowingDebug.DrawLine(leader.ActorLocationProxy, this.CacheVector, ColorUtils.LinearCyan);
		double inB = Math.Max(100.0, runtime.ActiveFollowRadius);
		leader.ActorForwardProxy.Multiply(inB, this.CacheVector2);
		this.CacheVector2.AdditionEqual(leader.ActorLocationProxy);
		FreeFollowingDebug.DrawArrow(leader.ActorLocationProxy, this.CacheVector2, ColorUtils.LinearRed);
		runtime.ReferenceForward.Multiply(inB, this.TempVector2);
		this.TempVector2.AdditionEqual(leader.ActorLocationProxy);
		FreeFollowingDebug.DrawArrow(leader.ActorLocationProxy, this.TempVector2, ColorUtils.LinearBlue);
		if (runtime.UseWalkFollowingRules)
		{
			this.Target.Subtraction(leader.ActorLocationProxy, this.CacheVector2);
		}
		else
		{
			this.Target.Subtraction(this.CacheVector, this.CacheVector2);
		}
		Vector.VectorPlaneProject(this.CacheVector2, leader.ActorGravityDirectProxy, this.TempVector);
		if (this.TempVector.Normalize(9.99999993922529E-09))
		{
			double minDistance = runtime.UseWalkFollowingRules ? runtime.ActiveFollowRadius : 0.0;
			double maxDistance = runtime.UseWalkFollowingRules ? runtime.ActiveStartFollowingRadius : runtime.ActiveFollowRadius;
			this.DrawSectorLine(leader, this.TempVector, minDistance, maxDistance, ColorUtils.LinearGreen);
			this.TempVector.RotateAngleAxis(-parameters.SideAngleTolerance, leader.ActorUpProxy, this.TempVector2);
			this.DrawSectorLine(leader, this.TempVector2, minDistance, maxDistance, ColorUtils.LinearWhite);
			this.TempVector.RotateAngleAxis(parameters.SideAngleTolerance, leader.ActorUpProxy, this.TempVector2);
			this.DrawSectorLine(leader, this.TempVector2, minDistance, maxDistance, ColorUtils.LinearWhite);
		}
		FreeFollowingDebug.DrawCircle(leader, runtime.ActiveFollowRadius, ColorUtils.LinearGreen);
		FreeFollowingDebug.DrawCircle(leader, runtime.ActiveStartFollowingRadius, ColorUtils.LinearYellow);
	}

	// Token: 0x0601AF90 RID: 110480 RVA: 0x00751C7C File Offset: 0x0074FE7C
	private void DrawSectorLine(CharacterActorComponent leader, Vector direction, double minDistance, double maxDistance, FLinearColor color)
	{
		direction.Multiply(minDistance, this.CacheVector);
		this.CacheVector.AdditionEqual(leader.ActorLocationProxy);
		direction.Multiply(maxDistance, this.CacheVector2);
		this.CacheVector2.AdditionEqual(leader.ActorLocationProxy);
		FreeFollowingDebug.DrawLine(this.CacheVector, this.CacheVector2, color);
	}

	// Token: 0x0601AF91 RID: 110481 RVA: 0x00751CDD File Offset: 0x0074FEDD
	private static void DrawSphere(Vector point, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, point.ToUeVector(false), 20f, 10, new FLinearColor?(color), 0f, 0f);
	}

	// Token: 0x0601AF92 RID: 110482 RVA: 0x00751D07 File Offset: 0x0074FF07
	private static void DrawLine(Vector from, Vector to, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, from.ToUeVector(false), to.ToUeVector(false), color, 0f, 0f);
	}

	// Token: 0x0601AF93 RID: 110483 RVA: 0x00751D2C File Offset: 0x0074FF2C
	private static void DrawArrow(Vector from, Vector to, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, from.ToUeVector(false), to.ToUeVector(false), 30f, color, 0f, 2f);
	}

	// Token: 0x0601AF94 RID: 110484 RVA: 0x00751D58 File Offset: 0x0074FF58
	private static void DrawCircle(CharacterActorComponent leader, double radius, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugCircle(GlobalData.World, leader.ActorLocationProxy.ToUeVector(false), (float)radius, 30, new FLinearColor?(color), 0f, 2f, new FVectorDouble?(leader.ActorForwardProxy.ToUeVector(false)), new FVectorDouble?(leader.ActorRightProxy.ToUeVector(false)), true);
	}

	// Token: 0x0400D1A7 RID: 53671
	private readonly Vector Target = Vector.Create();

	// Token: 0x0400D1A8 RID: 53672
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400D1A9 RID: 53673
	private readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400D1AA RID: 53674
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400D1AB RID: 53675
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400D1AC RID: 53676
	private EFreeFollowingState LastState;

	// Token: 0x0400D1AD RID: 53677
	private EFreeFollowingSide LastSide = EFreeFollowingSide.Right;

	// Token: 0x0400D1AE RID: 53678
	private double LastSummaryLogTime;

	// Token: 0x0400D1AF RID: 53679
	private bool LastTargetFound = true;
}
