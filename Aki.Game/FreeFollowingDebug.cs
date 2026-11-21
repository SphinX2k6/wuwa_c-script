using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002668 RID: 9832
[NullableContext(1)]
[Nullable(0)]
public class FreeFollowingDebug
{
	// Token: 0x060189DB RID: 100827 RVA: 0x00777A6A File Offset: 0x00775C6A
	public void Reset(FreeFollowingRuntime runtime)
	{
		this.LastState = runtime.State;
		this.LastSide = runtime.CurrentSide;
		this.LastSummaryLogTime = 0.0;
		this.LastTargetFound = true;
	}

	// Token: 0x060189DC RID: 100828 RVA: 0x00777A9A File Offset: 0x00775C9A
	public void RecordTargetResult(bool found, FreeFollowingRuntime runtime)
	{
		if (!found)
		{
			bool lastTargetFound = this.LastTargetFound;
		}
		this.LastTargetFound = found;
	}

	// Token: 0x060189DD RID: 100829 RVA: 0x00777AAD File Offset: 0x00775CAD
	public void LogWalkTemporaryPause(FreeFollowingRuntime runtime)
	{
	}

	// Token: 0x060189DE RID: 100830 RVA: 0x00777AAF File Offset: 0x00775CAF
	public void DrawCandidate(Vector candidate, bool valid)
	{
		FreeFollowingDebug.DrawSphere(candidate, valid ? ColorUtils.LinearWhite : ColorUtils.LinearRed);
	}

	// Token: 0x060189DF RID: 100831 RVA: 0x00777AC8 File Offset: 0x00775CC8
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

	// Token: 0x060189E0 RID: 100832 RVA: 0x00777E4C File Offset: 0x0077604C
	private void DrawSectorLine(CharacterActorComponent leader, Vector direction, double minDistance, double maxDistance, FLinearColor color)
	{
		direction.Multiply(minDistance, this.CacheVector);
		this.CacheVector.AdditionEqual(leader.ActorLocationProxy);
		direction.Multiply(maxDistance, this.CacheVector2);
		this.CacheVector2.AdditionEqual(leader.ActorLocationProxy);
		FreeFollowingDebug.DrawLine(this.CacheVector, this.CacheVector2, color);
	}

	// Token: 0x060189E1 RID: 100833 RVA: 0x00777EAD File Offset: 0x007760AD
	private static void DrawSphere(Vector point, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, point.ToUeVector(false), 20f, 10, new FLinearColor?(color), 0f, 0f);
	}

	// Token: 0x060189E2 RID: 100834 RVA: 0x00777ED7 File Offset: 0x007760D7
	private static void DrawLine(Vector from, Vector to, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, from.ToUeVector(false), to.ToUeVector(false), color, 0f, 0f);
	}

	// Token: 0x060189E3 RID: 100835 RVA: 0x00777EFC File Offset: 0x007760FC
	private static void DrawArrow(Vector from, Vector to, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, from.ToUeVector(false), to.ToUeVector(false), 30f, color, 0f, 2f);
	}

	// Token: 0x060189E4 RID: 100836 RVA: 0x00777F28 File Offset: 0x00776128
	private static void DrawCircle(CharacterActorComponent leader, double radius, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugCircle(GlobalData.World, leader.ActorLocationProxy.ToUeVector(false), (float)radius, 30, new FLinearColor?(color), 0f, 2f, new FVectorDouble?(leader.ActorForwardProxy.ToUeVector(false)), new FVectorDouble?(leader.ActorRightProxy.ToUeVector(false)), true);
	}

	// Token: 0x0400D5C8 RID: 54728
	private readonly Vector Target = Vector.Create();

	// Token: 0x0400D5C9 RID: 54729
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400D5CA RID: 54730
	private readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400D5CB RID: 54731
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400D5CC RID: 54732
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400D5CD RID: 54733
	private EFreeFollowingState LastState;

	// Token: 0x0400D5CE RID: 54734
	private EFreeFollowingSide LastSide = EFreeFollowingSide.Right;

	// Token: 0x0400D5CF RID: 54735
	private double LastSummaryLogTime;

	// Token: 0x0400D5D0 RID: 54736
	private bool LastTargetFound = true;
}
