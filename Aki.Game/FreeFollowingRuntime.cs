using System;
using System.Runtime.CompilerServices;

// Token: 0x0200310C RID: 12556
[NullableContext(1)]
[Nullable(0)]
public class FreeFollowingRuntime
{
	// Token: 0x0601AF6B RID: 110443 RVA: 0x0074FFB4 File Offset: 0x0074E1B4
	public void Reset(CharacterActorComponent leader, bool followOnRight)
	{
		this.Initialized = true;
		this.LeaderEntityId = leader.Entity.Id;
		this.CurrentSide = (followOnRight ? EFreeFollowingSide.Right : EFreeFollowingSide.Left);
		this.ResetRuntimeState();
		this.ReferenceForward.DeepCopy(leader.ActorForwardProxy);
		Vector.VectorPlaneProject(this.ReferenceForward, leader.ActorGravityDirectProxy, this.TempVector);
		if (this.TempVector.Normalize(9.99999993922529E-09))
		{
			this.ReferenceForward.DeepCopy(this.TempVector);
		}
		else
		{
			this.ReferenceForward.DeepCopy(leader.ActorForwardProxy);
		}
		this.PredictionCenter.DeepCopy(leader.ActorLocationProxy);
		this.LastLeaderLocation.DeepCopy(leader.ActorLocationProxy);
	}

	// Token: 0x0601AF6C RID: 110444 RVA: 0x00750070 File Offset: 0x0074E270
	public void Clear()
	{
		this.Initialized = false;
		this.LeaderEntityId = 0;
		this.ResetRuntimeState();
	}

	// Token: 0x0601AF6D RID: 110445 RVA: 0x00750088 File Offset: 0x0074E288
	private void ResetRuntimeState()
	{
		this.State = EFreeFollowingState.Stable;
		this.FilteredLeaderSpeed = 0.0;
		this.FilteredLeaderAcceleration = 0.0;
		this.ForwardOffset = 0.0;
		this.FollowerRadius = 0.0;
		this.ActiveFollowRadius = 0.0;
		this.ActiveStartFollowingRadius = 0.0;
		this.RadialLag = 0.0;
		this.IsDistanceFollowingActive = false;
		this.IsStopRadiusAccepted = false;
		this.StopAngleError = double.NaN;
		this.IsStopAngleAccepted = false;
		this.UseWalkFollowingRules = false;
		this.MovementIntentRate = 1.0;
		this.LocalMovementActive = false;
		this.HoldForLocalMovement = false;
		this.OuterRingGateArmed = false;
		this.WalkBehindTargetPauseRemaining = 0.0;
		this.WalkBehindTargetPauseConsumed = false;
		this.TargetDistance = double.NaN;
		this.IsTargetDistanceAccepted = false;
		this.StopConfirmTime = 0.0;
		this.ReferenceForward.Reset();
		this.LastLeaderLocation.Reset();
		this.LeaderMoveDirection.Reset();
		this.WalkArrivalTarget.Reset();
		this.FilteredMovementIntentVelocity.Reset();
		this.PredictionCenter.Reset();
		this.RejoinDuration = 0.0;
		this.RecoverRate = 0.0;
		this.LastDeltaSeconds = 0.0;
		this.HadValidTargetLastFrame = false;
		this.WalkArrivalTargetValid = false;
		this.WalkArrivalHoldRemaining = 0.0;
		this.LeaderIsMoving = false;
		this.LeaderIsStand = false;
		this.FollowerSideRate = 0.0;
		this.LocalMovementConfirmTime = 0.0;
		this.FilteredMovementPathSpeed = 0.0;
		this.TimeSinceLastReversal = 1.5;
		this.LeaderCleanReversalThisFrame = false;
	}

	// Token: 0x0601AF6E RID: 110446 RVA: 0x0075026C File Offset: 0x0074E46C
	public void Update(double deltaSeconds, CharacterActorComponent leader, CharacterActorComponent follower, ECharMoveState? leaderMoveState, bool useWalkFollowingRules, double rejoinEnterDistance, double rejoinExitDistance, double illegalDistance, FreeFollowingParams parameters)
	{
		if (!this.Initialized || this.LeaderEntityId != leader.Entity.Id)
		{
			this.Reset(leader, parameters.FollowOnRight);
		}
		double num = Math.Max(deltaSeconds, 0.0001);
		this.LastDeltaSeconds = num;
		if (useWalkFollowingRules != this.UseWalkFollowingRules)
		{
			this.StopConfirmTime = 0.0;
		}
		this.UseWalkFollowingRules = useWalkFollowingRules;
		this.ActiveFollowRadius = (useWalkFollowingRules ? parameters.WalkFollowRadius : parameters.FollowRadius);
		this.ActiveStartFollowingRadius = (useWalkFollowingRules ? parameters.WalkStartFollowingRadius : parameters.StartFollowingRadius);
		if (!this.UseWalkFollowingRules)
		{
			this.WalkBehindTargetPauseRemaining = 0.0;
			this.WalkBehindTargetPauseConsumed = false;
			this.ResetWalkArrivalHold();
		}
		else
		{
			this.WalkBehindTargetPauseRemaining = Math.Max(0.0, this.WalkBehindTargetPauseRemaining - num);
			this.WalkArrivalHoldRemaining = Math.Max(0.0, this.WalkArrivalHoldRemaining - num);
		}
		this.TargetDistance = double.NaN;
		this.IsTargetDistanceAccepted = false;
		if (this.IsDistanceFollowingActive && !this.HadValidTargetLastFrame)
		{
			this.StopConfirmTime = 0.0;
		}
		this.HadValidTargetLastFrame = false;
		this.FollowerRadius = Math.Sqrt(GravityUtils.Instance.GetDistSquared2dForActor(follower, follower.ActorLocationProxy, leader.ActorLocationProxy));
		this.RadialLag = Math.Max(0.0, this.FollowerRadius - this.ActiveFollowRadius);
		this.IsStopRadiusAccepted = (this.FollowerRadius <= this.ActiveFollowRadius + 1.0);
		if (this.UseWalkFollowingRules && !this.IsStopRadiusAccepted && this.WalkBehindTargetPauseRemaining <= 0.0)
		{
			this.WalkBehindTargetPauseConsumed = false;
		}
		if (!this.UseWalkFollowingRules && !this.IsStopRadiusAccepted)
		{
			this.StopConfirmTime = 0.0;
		}
		if (!this.IsStopRadiusAccepted || this.IsDistanceFollowingActive)
		{
			this.StopAngleError = double.NaN;
			this.IsStopAngleAccepted = false;
		}
		this.UpdateLeaderMotion(num, leader, leaderMoveState, illegalDistance, parameters);
		this.HoldForLocalMovement = (this.LocalMovementActive && this.IsStopRadiusAccepted);
		this.ReferenceForward.Multiply(this.ForwardOffset, this.PredictionCenter);
		this.PredictionCenter.AdditionEqual(leader.ActorLocationProxy);
		this.UpdateDistanceFollowingState();
		bool flag = this.WalkArrivalTargetValid && this.WalkArrivalHoldRemaining > 0.0;
		bool flag2 = this.IsWalkTemporaryPauseActive();
		if (!this.HoldForLocalMovement && !flag && !flag2)
		{
			this.UpdatePhysicalSide(leader, follower);
		}
		this.UpdateFollowState(num, this.RadialLag, rejoinEnterDistance, rejoinExitDistance);
	}

	// Token: 0x0601AF6F RID: 110447 RVA: 0x0075051C File Offset: 0x0074E71C
	public void CalculateTarget(Vector output, CharacterActorComponent leader, CharacterActorComponent follower, double angleOffset, FreeFollowingParams parameters)
	{
		switch (this.State)
		{
		case EFreeFollowingState.Rejoin:
			this.CalculateRejoinTarget(output, leader, follower, angleOffset, parameters);
			return;
		case EFreeFollowingState.Recover:
			this.CalculateRejoinTarget(this.RejoinTarget, leader, follower, angleOffset, parameters);
			this.CalculateFormationTarget(this.FormationTarget, leader, angleOffset, parameters);
			this.RejoinTarget.Multiply(1.0 - this.RecoverRate, output);
			this.FormationTarget.Multiply(this.RecoverRate, this.TempVector);
			output.AdditionEqual(this.TempVector);
			return;
		}
		this.CalculateFormationTarget(output, leader, angleOffset, parameters);
	}

	// Token: 0x0601AF70 RID: 110448 RVA: 0x007505C8 File Offset: 0x0074E7C8
	public double GetCandidateSideScore(Vector candidate, CharacterActorComponent leader)
	{
		candidate.Subtraction(this.PredictionCenter, this.TempVector2);
		Vector.VectorPlaneProject(this.TempVector2, leader.ActorGravityDirectProxy, this.TempVector3);
		this.GetReferenceRight(leader, this.TempVector);
		return this.TempVector3.DotProduct(this.TempVector) * (double)this.CurrentSide;
	}

	// Token: 0x0601AF71 RID: 110449 RVA: 0x00750625 File Offset: 0x0074E825
	public void CopyPredictionCenter(Vector output)
	{
		output.DeepCopy(this.PredictionCenter);
	}

	// Token: 0x0601AF72 RID: 110450 RVA: 0x00750633 File Offset: 0x0074E833
	public bool IsWalkTemporaryPauseActive()
	{
		return this.WalkBehindTargetPauseRemaining > 0.0;
	}

	// Token: 0x0601AF73 RID: 110451 RVA: 0x00750646 File Offset: 0x0074E846
	public bool ShouldHoldPosition()
	{
		return !this.IsDistanceFollowingActive || this.IsWalkTemporaryPauseActive();
	}

	// Token: 0x0601AF74 RID: 110452 RVA: 0x00750658 File Offset: 0x0074E858
	public bool TryStopAtTarget(CharacterActorComponent leader, CharacterActorComponent follower, Vector selectedTarget, double targetTolerance, FreeFollowingParams parameters)
	{
		this.HadValidTargetLastFrame = true;
		this.TargetDistance = Math.Sqrt(GravityUtils.Instance.GetDistSquared2dForActor(follower, follower.ActorLocationProxy, selectedTarget));
		double num = Math.Max(0.0, targetTolerance);
		this.IsTargetDistanceAccepted = (this.TargetDistance <= num);
		if (!this.IsDistanceFollowingActive)
		{
			this.StopConfirmTime = 0.0;
			return false;
		}
		if (this.UseWalkFollowingRules)
		{
			this.StopAngleError = double.NaN;
			this.IsStopAngleAccepted = false;
			if (this.TryHoldAfterWalkArrival(follower, selectedTarget, num * 2.0))
			{
				return true;
			}
			if (this.TryPauseForWalkBehindTarget(leader, follower, selectedTarget, parameters))
			{
				return true;
			}
			if (!this.IsTargetDistanceAccepted)
			{
				this.StopConfirmTime = 0.0;
				return false;
			}
			if (!this.UpdateStopConfirmation(parameters))
			{
				return false;
			}
			this.StartWalkArrivalHold(selectedTarget);
			return true;
		}
		else
		{
			if (this.LeaderIsMoving)
			{
				this.StopConfirmTime = 0.0;
				return false;
			}
			if (!this.IsStopRadiusAccepted)
			{
				this.StopConfirmTime = 0.0;
				return false;
			}
			selectedTarget.Subtraction(this.PredictionCenter, this.TempVector);
			Vector.VectorPlaneProject(this.TempVector, leader.ActorGravityDirectProxy, this.TempVector2);
			follower.ActorLocationProxy.Subtraction(leader.ActorLocationProxy, this.TempVector3);
			Vector.VectorPlaneProject(this.TempVector3, leader.ActorGravityDirectProxy, this.TempVector4);
			if (!this.TempVector2.Normalize(9.99999993922529E-09) || !this.TempVector4.Normalize(9.99999993922529E-09))
			{
				this.StopAngleError = double.NaN;
				this.IsStopAngleAccepted = false;
				this.StopConfirmTime = 0.0;
				return false;
			}
			double d = MathUtils.Instance.Clamp(this.TempVector2.DotProduct(this.TempVector4), -1.0, 1.0);
			this.StopAngleError = Math.Acos(d) * 57.295780181884766;
			this.IsStopAngleAccepted = (this.StopAngleError <= parameters.SideAngleTolerance);
			if (!this.IsStopAngleAccepted)
			{
				this.StopConfirmTime = 0.0;
				return false;
			}
			if (!this.UpdateStopConfirmation(parameters))
			{
				return false;
			}
			this.IsDistanceFollowingActive = false;
			this.OuterRingGateArmed = true;
			this.State = EFreeFollowingState.Stable;
			this.RejoinDuration = 0.0;
			this.RecoverRate = 0.0;
			return true;
		}
	}

	// Token: 0x0601AF75 RID: 110453 RVA: 0x007508CA File Offset: 0x0074EACA
	private bool UpdateStopConfirmation(FreeFollowingParams parameters)
	{
		this.StopConfirmTime = Math.Min(parameters.StopConfirmTime, this.StopConfirmTime + this.LastDeltaSeconds);
		return this.StopConfirmTime >= parameters.StopConfirmTime;
	}

	// Token: 0x0601AF76 RID: 110454 RVA: 0x007508FB File Offset: 0x0074EAFB
	private void StartWalkArrivalHold(Vector selectedTarget)
	{
		this.WalkArrivalTarget.DeepCopy(selectedTarget);
		this.WalkArrivalTargetValid = true;
		this.WalkArrivalHoldRemaining = 0.3;
		this.StopConfirmTime = 0.0;
	}

	// Token: 0x0601AF77 RID: 110455 RVA: 0x00750930 File Offset: 0x0074EB30
	private bool TryHoldAfterWalkArrival(CharacterActorComponent follower, Vector selectedTarget, double targetMoveTolerance)
	{
		if (!this.WalkArrivalTargetValid)
		{
			return false;
		}
		if (GravityUtils.Instance.GetDistSquared2dForActor(follower, selectedTarget, this.WalkArrivalTarget) > targetMoveTolerance * targetMoveTolerance)
		{
			this.ResetWalkArrivalHold();
			return false;
		}
		this.StopConfirmTime = 0.0;
		if (this.WalkArrivalHoldRemaining > 0.0)
		{
			return true;
		}
		if (this.LeaderIsMoving)
		{
			this.ResetWalkArrivalHold();
			return false;
		}
		this.ResetWalkArrivalHold();
		this.IsDistanceFollowingActive = false;
		this.OuterRingGateArmed = true;
		this.State = EFreeFollowingState.Stable;
		this.RejoinDuration = 0.0;
		this.RecoverRate = 0.0;
		return true;
	}

	// Token: 0x0601AF78 RID: 110456 RVA: 0x007509D2 File Offset: 0x0074EBD2
	private void ResetWalkArrivalHold()
	{
		this.WalkArrivalTargetValid = false;
		this.WalkArrivalHoldRemaining = 0.0;
	}

	// Token: 0x0601AF79 RID: 110457 RVA: 0x007509EC File Offset: 0x0074EBEC
	private bool TryPauseForWalkBehindTarget(CharacterActorComponent leader, CharacterActorComponent follower, Vector selectedTarget, FreeFollowingParams parameters)
	{
		selectedTarget.Subtraction(follower.ActorLocationProxy, this.TempVector);
		Vector.VectorPlaneProject(this.TempVector, leader.ActorGravityDirectProxy, this.TempVector2);
		Vector.VectorPlaneProject(follower.ActorForwardProxy, leader.ActorGravityDirectProxy, this.TempVector3);
		if (!this.TempVector2.Normalize(9.99999993922529E-09) || !this.TempVector3.Normalize(9.99999993922529E-09))
		{
			return false;
		}
		double num = Math.Acos(MathUtils.Instance.Clamp(this.TempVector2.DotProduct(this.TempVector3), -1.0, 1.0)) * 57.295780181884766;
		if (!this.IsStopRadiusAccepted)
		{
			this.WalkBehindTargetPauseConsumed = false;
			return false;
		}
		if (num <= 80.0)
		{
			this.WalkBehindTargetPauseConsumed = false;
		}
		if (this.IsTargetDistanceAccepted || num < 100.0 || this.WalkBehindTargetPauseConsumed)
		{
			return false;
		}
		this.WalkBehindTargetPauseRemaining = parameters.WalkBehindTargetPauseTime;
		this.WalkBehindTargetPauseConsumed = true;
		this.StopConfirmTime = 0.0;
		return true;
	}

	// Token: 0x0601AF7A RID: 110458 RVA: 0x00750B0C File Offset: 0x0074ED0C
	private void UpdateLeaderMotion(double deltaSeconds, CharacterActorComponent leader, ECharMoveState? leaderMoveState, double illegalDistance, FreeFollowingParams parameters)
	{
		double num = this.CalculateLeaderMoveDirection(leader);
		double num2 = Math.Max(0.0, Math.Max(illegalDistance, this.ActiveStartFollowingRadius * 2.0));
		bool leaderMoveDiscontinuity = num > num2;
		double num3 = num / deltaSeconds;
		this.UpdateLeaderSpeedAndAcceleration(deltaSeconds, num3, leaderMoveDiscontinuity);
		this.UpdateMovementIntent(deltaSeconds, num3, leaderMoveDiscontinuity, parameters);
		this.UpdateForwardOffset(deltaSeconds, parameters);
		this.UpdateReferenceForward(deltaSeconds, leader, leaderMoveState, num3, leaderMoveDiscontinuity, parameters);
		this.LastLeaderLocation.DeepCopy(leader.ActorLocationProxy);
	}

	// Token: 0x0601AF7B RID: 110459 RVA: 0x00750B8C File Offset: 0x0074ED8C
	private void UpdateLeaderSpeedAndAcceleration(double deltaSeconds, double actualLeaderSpeed, bool leaderMoveDiscontinuity)
	{
		double num = (!leaderMoveDiscontinuity && actualLeaderSpeed >= 30.0) ? actualLeaderSpeed : 0.0;
		this.LeaderIsMoving = (num > 0.0);
		this.LeaderIsStand = !this.LeaderIsMoving;
		double filteredLeaderSpeed = this.FilteredLeaderSpeed;
		double exponentialAlpha = this.GetExponentialAlpha(deltaSeconds, 0.2);
		this.FilteredLeaderSpeed += (num - this.FilteredLeaderSpeed) * exponentialAlpha;
		double num2 = (this.FilteredLeaderSpeed - filteredLeaderSpeed) / deltaSeconds;
		double exponentialAlpha2 = this.GetExponentialAlpha(deltaSeconds, 0.12);
		this.FilteredLeaderAcceleration += (num2 - this.FilteredLeaderAcceleration) * exponentialAlpha2;
		this.FilteredLeaderAcceleration = MathUtils.Instance.Clamp(this.FilteredLeaderAcceleration, -1200.0, 1200.0);
	}

	// Token: 0x0601AF7C RID: 110460 RVA: 0x00750C64 File Offset: 0x0074EE64
	private double CalculateLeaderMoveDirection(CharacterActorComponent leader)
	{
		leader.ActorLocationProxy.Subtraction(this.LastLeaderLocation, this.TempVector);
		Vector.VectorPlaneProject(this.TempVector, leader.ActorGravityDirectProxy, this.LeaderMoveDirection);
		double num = this.LeaderMoveDirection.Size();
		if (num > 0.0)
		{
			this.LeaderMoveDirection.MultiplyEqual(1.0 / num);
		}
		return num;
	}

	// Token: 0x0601AF7D RID: 110461 RVA: 0x00750CD0 File Offset: 0x0074EED0
	private void UpdateForwardOffset(double deltaSeconds, FreeFollowingParams parameters)
	{
		double num = this.LocalMovementActive ? 0.0 : Math.Max(0.0, this.FilteredLeaderSpeed + this.FilteredLeaderAcceleration * 0.18);
		double num2 = MathUtils.Instance.Clamp(num / parameters.FullForwardOffsetSpeed, 0.0, 1.0);
		double num3 = num2 * num2 * (3.0 - 2.0 * num2);
		double num4 = parameters.MaxForwardOffset * num3;
		double exponentialAlpha = this.GetExponentialAlpha(deltaSeconds, 0.25);
		this.ForwardOffset += (num4 - this.ForwardOffset) * exponentialAlpha;
	}

	// Token: 0x0601AF7E RID: 110462 RVA: 0x00750D88 File Offset: 0x0074EF88
	private void UpdateReferenceForward(double deltaSeconds, CharacterActorComponent leader, ECharMoveState? leaderMoveState, double directionUpdateSpeed, bool leaderMoveDiscontinuity, FreeFollowingParams parameters)
	{
		if (this.LeaderCleanReversalThisFrame && !this.LocalMovementActive)
		{
			this.ReferenceForward.DeepCopy(this.LeaderMoveDirection);
			this.StopConfirmTime = 0.0;
			return;
		}
		Vector vector = this.LeaderMoveDirection;
		double num = directionUpdateSpeed;
		if (this.UseWalkFollowingRules)
		{
			num = this.FilteredMovementIntentVelocity.Size();
			if (num >= 30.0)
			{
				this.FilteredMovementIntentVelocity.Multiply(1.0 / num, this.TempVector3);
				vector = this.TempVector3;
			}
		}
		if (this.LeaderIsMoving && !this.LocalMovementActive && !leaderMoveDiscontinuity && num >= 30.0)
		{
			double num2 = (double)GravityUtils.Instance.GetAngleOffsetInGravityForActor(leader, this.ReferenceForward, vector);
			if (Math.Abs(num2) >= 135.0)
			{
				this.ReferenceForward.DeepCopy(vector);
				this.StopConfirmTime = 0.0;
				return;
			}
			if (this.UseWalkFollowingRules)
			{
				double num3 = 180.0 * deltaSeconds;
				double angleDeg = MathUtils.Instance.Clamp(num2, -num3, num3);
				this.ReferenceForward.RotateAngleAxis(angleDeg, leader.ActorUpProxy, this.TempVector2);
				if (this.TempVector2.Normalize(9.99999993922529E-09))
				{
					this.ReferenceForward.DeepCopy(this.TempVector2);
					return;
				}
			}
			else if (Math.Abs(num2) > 3.0)
			{
				double smoothingTimeSeconds = (leaderMoveState.GetValueOrDefault() == ECharMoveState.Sprint) ? parameters.SprintReferenceDirectionSmoothingTime : parameters.RunReferenceDirectionSmoothingTime;
				double exponentialAlpha = this.GetExponentialAlpha(deltaSeconds, smoothingTimeSeconds);
				Vector.Lerp(this.ReferenceForward, vector, exponentialAlpha, this.TempVector2);
				if (this.TempVector2.Normalize(9.99999993922529E-09))
				{
					this.ReferenceForward.DeepCopy(this.TempVector2);
					return;
				}
				this.ReferenceForward.DeepCopy(vector);
			}
		}
	}

	// Token: 0x0601AF7F RID: 110463 RVA: 0x00750F68 File Offset: 0x0074F168
	private void UpdateMovementIntent(double deltaSeconds, double directionUpdateSpeed, bool leaderMoveDiscontinuity, FreeFollowingParams parameters)
	{
		this.LeaderCleanReversalThisFrame = false;
		if (!this.LeaderIsMoving || leaderMoveDiscontinuity)
		{
			this.ResetMovementIntent();
			return;
		}
		this.TimeSinceLastReversal = Math.Min(1.5, this.TimeSinceLastReversal + deltaSeconds);
		double num = this.FilteredMovementIntentVelocity.Size();
		if (directionUpdateSpeed >= 60.0 && num >= 60.0 && this.FilteredMovementIntentVelocity.DotProduct(this.LeaderMoveDirection) / num <= -0.7071067811865476)
		{
			if (this.TimeSinceLastReversal >= 1.5)
			{
				this.LeaderCleanReversalThisFrame = true;
				this.LeaderMoveDirection.Multiply(directionUpdateSpeed, this.FilteredMovementIntentVelocity);
				this.FilteredMovementPathSpeed = directionUpdateSpeed;
				this.MovementIntentRate = 1.0;
				this.LocalMovementConfirmTime = 0.0;
			}
			this.TimeSinceLastReversal = 0.0;
		}
		double exponentialAlpha = this.GetExponentialAlpha(deltaSeconds, parameters.MovementIntentSmoothingTime);
		this.LeaderMoveDirection.Multiply(directionUpdateSpeed, this.TempVector3);
		this.FilteredMovementIntentVelocity.MultiplyEqual(1.0 - exponentialAlpha);
		this.TempVector3.MultiplyEqual(exponentialAlpha);
		this.FilteredMovementIntentVelocity.AdditionEqual(this.TempVector3);
		this.FilteredMovementPathSpeed += (directionUpdateSpeed - this.FilteredMovementPathSpeed) * exponentialAlpha;
		if (this.FilteredMovementPathSpeed < 30.0)
		{
			this.MovementIntentRate = 1.0;
			this.LocalMovementActive = false;
			this.HoldForLocalMovement = false;
			this.LocalMovementConfirmTime = 0.0;
			return;
		}
		this.MovementIntentRate = MathUtils.Instance.Clamp(this.FilteredMovementIntentVelocity.Size() / this.FilteredMovementPathSpeed, 0.0, 1.0);
		if (!parameters.EnableLocalMovementHold)
		{
			this.LocalMovementActive = false;
			this.HoldForLocalMovement = false;
			this.LocalMovementConfirmTime = 0.0;
			return;
		}
		if (!(this.LocalMovementActive ? (this.MovementIntentRate >= 0.7) : (this.MovementIntentRate <= parameters.LocalMovementEnterRate)))
		{
			this.LocalMovementConfirmTime = 0.0;
			return;
		}
		double num2 = this.LocalMovementActive ? 0.2 : parameters.LocalMovementEnterConfirmTime;
		this.LocalMovementConfirmTime = Math.Min(num2, this.LocalMovementConfirmTime + deltaSeconds);
		if (this.LocalMovementConfirmTime >= num2)
		{
			this.LocalMovementActive = !this.LocalMovementActive;
			this.LocalMovementConfirmTime = 0.0;
			this.StopConfirmTime = 0.0;
		}
	}

	// Token: 0x0601AF80 RID: 110464 RVA: 0x00751200 File Offset: 0x0074F400
	private void ResetMovementIntent()
	{
		this.FilteredMovementIntentVelocity.Reset();
		this.FilteredMovementPathSpeed = 0.0;
		this.MovementIntentRate = 1.0;
		this.LocalMovementActive = false;
		this.HoldForLocalMovement = false;
		this.LocalMovementConfirmTime = 0.0;
		this.TimeSinceLastReversal = 1.5;
	}

	// Token: 0x0601AF81 RID: 110465 RVA: 0x00751264 File Offset: 0x0074F464
	private void UpdateDistanceFollowingState()
	{
		if (this.HoldForLocalMovement)
		{
			this.ResetWalkArrivalHold();
			this.OuterRingGateArmed = true;
			this.IsDistanceFollowingActive = false;
			this.StopConfirmTime = 0.0;
			this.State = EFreeFollowingState.Stable;
			return;
		}
		if (this.LeaderIsStand)
		{
			this.OuterRingGateArmed = true;
		}
		if (this.IsDistanceFollowingActive)
		{
			return;
		}
		if (this.FollowerRadius > this.ActiveStartFollowingRadius + 1.0)
		{
			this.OuterRingGateArmed = false;
		}
		else if (this.OuterRingGateArmed)
		{
			this.State = EFreeFollowingState.Stable;
			return;
		}
		this.IsDistanceFollowingActive = true;
		this.StopConfirmTime = 0.0;
		this.State = EFreeFollowingState.FormationFollow;
	}

	// Token: 0x0601AF82 RID: 110466 RVA: 0x0075130C File Offset: 0x0074F50C
	private void UpdateFollowState(double deltaSeconds, double radialLag, double rejoinEnterDistance, double rejoinExitDistance)
	{
		if (!this.IsDistanceFollowingActive)
		{
			this.State = EFreeFollowingState.Stable;
			return;
		}
		if (this.UseWalkFollowingRules)
		{
			this.State = EFreeFollowingState.FormationFollow;
			this.RejoinDuration = 0.0;
			this.RecoverRate = 0.0;
			return;
		}
		double num = Math.Max(rejoinEnterDistance, rejoinExitDistance);
		double num2 = Math.Min(rejoinEnterDistance, rejoinExitDistance);
		if (radialLag > num)
		{
			if (this.State != EFreeFollowingState.Rejoin)
			{
				this.State = EFreeFollowingState.Rejoin;
				this.RejoinDuration = 0.0;
				this.RecoverRate = 0.0;
			}
			this.RejoinDuration += deltaSeconds;
			return;
		}
		if (this.State == EFreeFollowingState.Rejoin)
		{
			this.RejoinDuration += deltaSeconds;
			if (radialLag <= num2 && this.RejoinDuration >= 0.3)
			{
				this.State = EFreeFollowingState.Recover;
				this.RecoverRate = 0.0;
			}
			return;
		}
		if (this.State == EFreeFollowingState.Recover)
		{
			this.RecoverRate = Math.Min(1.0, this.RecoverRate + deltaSeconds / 0.4);
			if (this.RecoverRate >= 1.0)
			{
				this.State = EFreeFollowingState.FormationFollow;
			}
			return;
		}
		if (this.State == EFreeFollowingState.Stable)
		{
			this.State = EFreeFollowingState.FormationFollow;
		}
	}

	// Token: 0x0601AF83 RID: 110467 RVA: 0x00751444 File Offset: 0x0074F644
	private void CalculateFormationTarget(Vector output, CharacterActorComponent leader, double angleOffset, FreeFollowingParams parameters)
	{
		this.CalculateFormationDirection(this.TempVector2, leader, angleOffset, parameters);
		this.BuildTargetFromDirection(output, leader, this.TempVector2);
	}

	// Token: 0x0601AF84 RID: 110468 RVA: 0x00751464 File Offset: 0x0074F664
	private void CalculateFormationDirection(Vector output, CharacterActorComponent leader, double angleOffset, FreeFollowingParams parameters)
	{
		this.ReferenceForward.RotateAngleAxis(angleOffset, leader.ActorUpProxy, output);
		if (!output.Normalize(9.99999993922529E-09))
		{
			output.DeepCopy(this.ReferenceForward);
		}
		leader.ActorUpProxy.CrossProduct(output, this.TempVector4);
		if (!this.TempVector4.Normalize(9.99999993922529E-09))
		{
			this.TempVector4.DeepCopy(leader.ActorRightProxy);
		}
		double num = parameters.OffsetAngle * 0.01745329238474369;
		output.MultiplyEqual(Math.Sin(num));
		this.TempVector4.MultiplyEqual(Math.Cos(num) * (double)this.CurrentSide);
		output.AdditionEqual(this.TempVector4);
		output.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601AF85 RID: 110469 RVA: 0x00751530 File Offset: 0x0074F730
	private void CalculateRejoinTarget(Vector output, CharacterActorComponent leader, CharacterActorComponent follower, double angleOffset, FreeFollowingParams parameters)
	{
		follower.ActorLocationProxy.Subtraction(this.PredictionCenter, this.TempVector2);
		Vector.VectorPlaneProject(this.TempVector2, leader.ActorGravityDirectProxy, this.TempVector);
		this.TempVector2.DeepCopy(this.TempVector);
		this.GetReferenceRight(leader, this.TempVector3);
		if (!this.TempVector2.Normalize(9.99999993922529E-09) || this.TempVector2.DotProduct(this.TempVector3) * (double)this.CurrentSide <= 0.01)
		{
			this.CalculateFormationTarget(output, leader, angleOffset, parameters);
			return;
		}
		if (this.TempVector2.DotProduct(this.ReferenceForward) < 0.0)
		{
			this.TempVector3.Multiply((double)this.CurrentSide, this.TempVector2);
		}
		this.TempVector2.RotateAngleAxis(angleOffset, leader.ActorUpProxy, this.TempVector4);
		this.BuildTargetFromDirection(output, leader, this.TempVector4);
	}

	// Token: 0x0601AF86 RID: 110470 RVA: 0x0075162D File Offset: 0x0074F82D
	private void BuildTargetFromDirection(Vector output, CharacterActorComponent leader, Vector direction)
	{
		direction.Multiply(this.ActiveFollowRadius, output);
		output.AdditionEqual(this.PredictionCenter);
		GravityUtils.Instance.AddZnInGravityForActor(leader, output, (double)(-(double)leader.ScaledHalfHeight));
	}

	// Token: 0x0601AF87 RID: 110471 RVA: 0x00751660 File Offset: 0x0074F860
	private void UpdatePhysicalSide(CharacterActorComponent leader, CharacterActorComponent follower)
	{
		follower.ActorLocationProxy.Subtraction(this.PredictionCenter, this.TempVector2);
		Vector.VectorPlaneProject(this.TempVector2, leader.ActorGravityDirectProxy, this.TempVector3);
		if (!this.TempVector3.Normalize(9.99999993922529E-09))
		{
			this.FollowerSideRate = 0.0;
			return;
		}
		this.GetReferenceRight(leader, this.TempVector);
		this.FollowerSideRate = MathUtils.Instance.Clamp(this.TempVector3.DotProduct(this.TempVector), -1.0, 1.0);
		EFreeFollowingSide efreeFollowingSide = (this.FollowerSideRate > 0.0) ? EFreeFollowingSide.Right : EFreeFollowingSide.Left;
		double num = this.UseWalkFollowingRules ? 0.052335956242943835 : 0.25881904510252074;
		if (efreeFollowingSide == this.CurrentSide || Math.Abs(this.FollowerSideRate) < num)
		{
			return;
		}
		this.CurrentSide = efreeFollowingSide;
		this.StopConfirmTime = 0.0;
	}

	// Token: 0x0601AF88 RID: 110472 RVA: 0x00751763 File Offset: 0x0074F963
	private void GetReferenceRight(CharacterActorComponent leader, Vector output)
	{
		leader.ActorUpProxy.CrossProduct(this.ReferenceForward, output);
		if (!output.Normalize(9.99999993922529E-09))
		{
			output.DeepCopy(leader.ActorRightProxy);
		}
	}

	// Token: 0x0601AF89 RID: 110473 RVA: 0x00751794 File Offset: 0x0074F994
	private double GetExponentialAlpha(double deltaSeconds, double smoothingTimeSeconds)
	{
		if (smoothingTimeSeconds > 0.0)
		{
			return 1.0 - Math.Exp(-deltaSeconds / smoothingTimeSeconds);
		}
		return 1.0;
	}

	// Token: 0x0400D175 RID: 53621
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400D176 RID: 53622
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400D177 RID: 53623
	private readonly Vector TempVector3 = Vector.Create();

	// Token: 0x0400D178 RID: 53624
	private readonly Vector TempVector4 = Vector.Create();

	// Token: 0x0400D179 RID: 53625
	private bool Initialized;

	// Token: 0x0400D17A RID: 53626
	private int LeaderEntityId;

	// Token: 0x0400D17B RID: 53627
	public double FollowerRadius;

	// Token: 0x0400D17C RID: 53628
	public double ActiveFollowRadius;

	// Token: 0x0400D17D RID: 53629
	public double ActiveStartFollowingRadius;

	// Token: 0x0400D17E RID: 53630
	public bool IsStopRadiusAccepted;

	// Token: 0x0400D17F RID: 53631
	public bool UseWalkFollowingRules;

	// Token: 0x0400D180 RID: 53632
	public double StopAngleError = double.NaN;

	// Token: 0x0400D181 RID: 53633
	public bool IsStopAngleAccepted;

	// Token: 0x0400D182 RID: 53634
	public double TargetDistance = double.NaN;

	// Token: 0x0400D183 RID: 53635
	public bool IsTargetDistanceAccepted;

	// Token: 0x0400D184 RID: 53636
	public double StopConfirmTime;

	// Token: 0x0400D185 RID: 53637
	private double LastDeltaSeconds;

	// Token: 0x0400D186 RID: 53638
	private bool HadValidTargetLastFrame;

	// Token: 0x0400D187 RID: 53639
	private readonly Vector WalkArrivalTarget = Vector.Create();

	// Token: 0x0400D188 RID: 53640
	private bool WalkArrivalTargetValid;

	// Token: 0x0400D189 RID: 53641
	private double WalkArrivalHoldRemaining;

	// Token: 0x0400D18A RID: 53642
	public double WalkBehindTargetPauseRemaining;

	// Token: 0x0400D18B RID: 53643
	public bool WalkBehindTargetPauseConsumed;

	// Token: 0x0400D18C RID: 53644
	public readonly Vector ReferenceForward = Vector.Create();

	// Token: 0x0400D18D RID: 53645
	private readonly Vector LastLeaderLocation = Vector.Create();

	// Token: 0x0400D18E RID: 53646
	private readonly Vector LeaderMoveDirection = Vector.Create();

	// Token: 0x0400D18F RID: 53647
	private readonly Vector PredictionCenter = Vector.Create();

	// Token: 0x0400D190 RID: 53648
	public double FilteredLeaderSpeed;

	// Token: 0x0400D191 RID: 53649
	private double FilteredLeaderAcceleration;

	// Token: 0x0400D192 RID: 53650
	public double ForwardOffset;

	// Token: 0x0400D193 RID: 53651
	public bool LeaderIsMoving;

	// Token: 0x0400D194 RID: 53652
	public bool LeaderIsStand;

	// Token: 0x0400D195 RID: 53653
	private readonly Vector FilteredMovementIntentVelocity = Vector.Create();

	// Token: 0x0400D196 RID: 53654
	public double MovementIntentRate = 1.0;

	// Token: 0x0400D197 RID: 53655
	public bool LocalMovementActive;

	// Token: 0x0400D198 RID: 53656
	public bool HoldForLocalMovement;

	// Token: 0x0400D199 RID: 53657
	private double LocalMovementConfirmTime;

	// Token: 0x0400D19A RID: 53658
	private double FilteredMovementPathSpeed;

	// Token: 0x0400D19B RID: 53659
	private double TimeSinceLastReversal = 1.5;

	// Token: 0x0400D19C RID: 53660
	private bool LeaderCleanReversalThisFrame;

	// Token: 0x0400D19D RID: 53661
	public EFreeFollowingState State;

	// Token: 0x0400D19E RID: 53662
	private double RadialLag;

	// Token: 0x0400D19F RID: 53663
	public bool IsDistanceFollowingActive;

	// Token: 0x0400D1A0 RID: 53664
	public bool OuterRingGateArmed;

	// Token: 0x0400D1A1 RID: 53665
	private double RejoinDuration;

	// Token: 0x0400D1A2 RID: 53666
	private double RecoverRate;

	// Token: 0x0400D1A3 RID: 53667
	private readonly Vector FormationTarget = Vector.Create();

	// Token: 0x0400D1A4 RID: 53668
	private readonly Vector RejoinTarget = Vector.Create();

	// Token: 0x0400D1A5 RID: 53669
	public EFreeFollowingSide CurrentSide = EFreeFollowingSide.Right;

	// Token: 0x0400D1A6 RID: 53670
	public double FollowerSideRate;
}
