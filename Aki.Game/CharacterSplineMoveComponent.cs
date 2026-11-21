using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Role.Common;
using AkiClient.Game.Aki.Data.Fight.AssestStruct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x020025E3 RID: 9699
[NullableContext(1)]
[Nullable(0)]
public class CharacterSplineMoveComponent : BaseSplineMoveComponent, IStaticVariableResetter
{
	// Token: 0x060182B2 RID: 98994 RVA: 0x00742506 File Offset: 0x00740706
	static CharacterSplineMoveComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSplineMoveComponent.CreateStaticDefaultValue), new Action(CharacterSplineMoveComponent.ResetStaticDefaultValue));
	}

	// Token: 0x170025E8 RID: 9704
	// (get) Token: 0x060182B3 RID: 98995 RVA: 0x00742535 File Offset: 0x00740735
	public static BP_SplineMoveConfig_C SplineMoveConfig
	{
		get
		{
			if (CharacterSplineMoveComponent.SplineMoveConfigInternal == null)
			{
				CharacterSplineMoveComponent.SplineMoveConfigInternal = ResourceSystem.Instance.GetLoadedAsset<BP_SplineMoveConfig_C>(CharacterSplineMoveComponent.DaPath);
			}
			return CharacterSplineMoveComponent.SplineMoveConfigInternal;
		}
	}

	// Token: 0x060182B4 RID: 98996 RVA: 0x00742558 File Offset: 0x00740758
	protected override bool OnStart()
	{
		base.OnStart();
		CharacterActorComponent characterActorComponent = this.ActorComp as CharacterActorComponent;
		if (characterActorComponent != null)
		{
			this.CharActorComp = characterActorComponent;
		}
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.UnifiedComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.AttributeComp = base.Entity.GetComponent<BaseAttributeComponent>();
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		return true;
	}

	// Token: 0x060182B5 RID: 98997 RVA: 0x007425E9 File Offset: 0x007407E9
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		return base.OnEnd();
	}

	// Token: 0x060182B6 RID: 98998 RVA: 0x00742614 File Offset: 0x00740814
	protected override void PositionAdjust(float timeKey, float deltaSeconds)
	{
		switch (base.CurrentSplineMoveType)
		{
		case ESplineMovePattern.PathLine:
		case ESplineMovePattern.SlideTrack:
			this.PositionAdjustCommon(timeKey, deltaSeconds);
			return;
		case ESplineMovePattern.RacingTrack:
			this.PositionAdjustRacingTrack(timeKey, deltaSeconds);
			return;
		case ESplineMovePattern.AirPassage:
			this.PositionAdjustAirPassage(timeKey, deltaSeconds);
			return;
		default:
			return;
		}
	}

	// Token: 0x060182B7 RID: 98999 RVA: 0x0074265C File Offset: 0x0074085C
	private void PositionAdjustRacingTrack(float timeKey, float deltaSeconds)
	{
		this.TargetLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.RacingLeftRight(deltaSeconds);
		if (!base.CheckAndLimitOnlyForwardMove() && this.LastSplineDirection.Normalize(9.99999993922529E-09))
		{
			this.CommonVelocityAdjusted();
			this.AdjustTargetLocationRacingTrack();
		}
		base.LimitMaxMove();
		this.MoveToTargetLocation(deltaSeconds);
	}

	// Token: 0x060182B8 RID: 99000 RVA: 0x007426C0 File Offset: 0x007408C0
	protected void PositionAdjustAirPassage(float timeKey, float deltaSeconds)
	{
		if (!this.CurrentSplineMoveParamsInternal.NeedLimitSoarTransform)
		{
			return;
		}
		CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
		if (unifiedComp == null || unifiedComp.MoveState != global::ECharMoveState.Soar)
		{
			return;
		}
		if (this.SplineDirection.Equals(global::Vector.ZeroVectorProxy, 9.999999747378752E-05))
		{
			return;
		}
		this.TargetLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		base.CheckAndLimitOnlyForwardMove();
		this.TargetLocation.Subtraction(this.SplineLocation, this.OffsetVector);
		this.UpdateCrossSectionParamsAirPassage();
		this.RotationAndVelocityAdjustAirPassage();
		this.LimitCircleAxisMove();
		this.MoveToTargetLocation(deltaSeconds);
	}

	// Token: 0x060182B9 RID: 99001 RVA: 0x00742764 File Offset: 0x00740964
	protected void RotationAndVelocityAdjustAirPassage()
	{
		SplineMoveParams currentSplineMoveParamsInternal = this.CurrentSplineMoveParamsInternal;
		CurveBase edgeLimitCurve = this.CurrentSplineMoveParamsInternal.EdgeLimitCurve;
		float num = (this.CurMaxWidth != 0f) ? edgeLimitCurve.GetCurrentValue((float)Math.Abs(this.LocalOffset.Y) / this.CurMaxWidth) : 1f;
		float num2 = (this.CurMaxHeight != 0f) ? edgeLimitCurve.GetCurrentValue((float)Math.Abs(this.LocalOffset.Z) / this.CurMaxHeight) : 1f;
		float num3 = -currentSplineMoveParamsInternal.InputLimitAngle;
		float num4 = currentSplineMoveParamsInternal.InputLimitAngle;
		float num5 = -currentSplineMoveParamsInternal.InputLimitAngle;
		float num6 = currentSplineMoveParamsInternal.InputLimitAngle;
		if (this.LocalOffset.Y < 0.0)
		{
			num3 *= 1f - num;
		}
		else
		{
			num4 *= 1f - num;
		}
		this.TmpVector1.DeepCopy(this.ActorComp.ActorForwardProxy);
		GravityUtils.Instance.GetBaseQuatInGravityForActor(this.ActorComp, this.TmpQuat);
		this.TmpQuat.Inverse(this.TmpQuat1);
		this.TmpQuat1.RotateVector(this.ActorComp.ActorForwardProxy, this.TmpVector1);
		double num7 = this.TmpVector1.HeadingAngle() * 57.295780181884766;
		this.TmpQuat1.RotateVector(this.SplineDirection, this.TmpVector1);
		double num8 = this.TmpVector1.HeadingAngle() * 57.295780181884766;
		double minAngle = num8 + (double)num3;
		double maxAngle = num8 + (double)num4;
		if (!this.InAngleRange(num7, minAngle, maxAngle))
		{
			double angleB = this.ClampAngle(num7, minAngle, maxAngle);
			double num9 = this.LerpAngle(num7, angleB, (double)num);
			double num10 = MathUtils.Instance.WrapAngle(num9 - num7);
			this.TmpRotator.Set(0f, (float)num10, 0f);
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.AddActorLocalRotation(this.TmpRotator.ToUeRotator(), "轨道模式修正", true);
			}
			this.TmpQuat1.RotateVector(this.CharActorComp.ActorVelocityProxy, this.TmpVector1);
			this.TmpRotator.Quaternion(this.TmpQuat1);
			this.TmpQuat1.RotateVector(this.TmpVector1, this.TmpVector);
			this.TmpQuat.RotateVector(this.TmpVector, this.TmpVector1);
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.SetForceSpeed(this.TmpVector1);
			}
			if (this.DebugMode)
			{
				this.TmpQuat1.RotateVector(this.ActorComp.ActorForwardProxy, this.TmpVector1);
				this.TmpVector1.HeadingAngle();
			}
		}
		if (this.LocalOffset.Z < 0.0)
		{
			num5 *= 1f - num2;
		}
		else
		{
			num6 *= 1f - num2;
		}
		this.CharActorComp.ActorVelocityProxy.GetSafeNormal(this.TmpVector1, 9.99999993922529E-09);
		double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVector1);
		float num11 = (float)(Math.Asin(MathUtils.Instance.Clamp(znInGravityForActor, -1.0, 1.0)) * 57.295780181884766);
		double znInGravityForActor2 = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.SplineDirection);
		float num12 = (float)(Math.Asin(MathUtils.Instance.Clamp(znInGravityForActor2, -1.0, 1.0)) * 57.295780181884766);
		float num13 = num12 + num5;
		float num14 = num12 + num6;
		if (!this.InAngleRange((double)num11, (double)num13, (double)num14))
		{
			double angleB2 = this.ClampAngle((double)num11, (double)num13, (double)num14);
			double num15 = this.LerpAngle((double)num11, angleB2, (double)num2);
			MathUtils.Instance.WrapAngle(num15 - (double)num11);
			double inB = this.CharActorComp.ActorVelocityProxy.Size();
			this.TmpRotator.Set((float)num15, 0f, 0f);
			this.TmpRotator.Quaternion(this.TmpQuat);
			this.ActorComp.ActorQuatProxy.Multiply(this.TmpQuat, this.TmpQuat1);
			this.TmpQuat1.GetForwardVector(this.TmpVector1);
			this.TmpVector1.MultiplyEqual(inB);
			this.MoveComp.SetForceSpeed(this.TmpVector1);
			if (this.DebugMode)
			{
				this.TmpQuat1.Rotator(this.TmpRotator);
			}
		}
	}

	// Token: 0x060182BA RID: 99002 RVA: 0x00742BCC File Offset: 0x00740DCC
	protected void UpdateCrossSectionParamsAirPassage()
	{
		MathUtils.Instance.LookRotationUpFirst(this.SplineDirection, this.MoveComp.GravityUp, this.LocalQuat);
		this.LocalQuat.GetForwardVector(this.TmpVector);
		this.TmpVector.Multiply(this.OffsetVector.DotProduct(this.TmpVector), this.TmpVector1);
		this.OffsetVector.SubtractionEqual(this.TmpVector1);
		this.LocalQuat.Inverse(this.TmpQuat1);
		this.TmpQuat1.RotateVector(this.OffsetVector, this.LocalOffset);
		SplineMoveParams currentSplineMoveParamsInternal = this.CurrentSplineMoveParamsInternal;
		double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.SplineDirection);
		if (Math.Abs(znInGravityForActor) > 0.7070000171661377)
		{
			this.CurShortLen = 0f;
			this.CurLongLen = 0f;
			this.CurMaxWidth = 0f;
			this.CurMaxHeight = 0f;
			return;
		}
		this.CurShortLen = currentSplineMoveParamsInternal.MaxOffsetDist;
		this.CurLongLen = this.CurShortLen / (float)Math.Sqrt(1.0 - znInGravityForActor * znInGravityForActor);
		double y = this.LocalOffset.Y;
		double z = this.LocalOffset.Z;
		float curShortLen = this.CurShortLen;
		float curLongLen = this.CurLongLen;
		double num = (double)(curShortLen * curShortLen) - (double)(curShortLen * curShortLen) * z * z / (double)(curLongLen * curLongLen);
		double num2 = (double)(curLongLen * curLongLen) - (double)(curLongLen * curLongLen) * y * y / (double)(curShortLen * curShortLen);
		this.CurMaxWidth = ((num <= 0.0) ? 0f : ((float)Math.Sqrt(num)));
		this.CurMaxHeight = ((num2 <= 0.0) ? 0f : ((float)Math.Sqrt(num2)));
		if (this.DebugMode)
		{
			this.DrawDebugInfo();
		}
	}

	// Token: 0x060182BB RID: 99003 RVA: 0x00742DA0 File Offset: 0x00740FA0
	protected void LimitCircleAxisMove()
	{
		if (this.IsInEllipseRange(this.LocalOffset.Y, this.LocalOffset.Z, (double)this.CurShortLen, (double)this.CurLongLen))
		{
			return;
		}
		if (Math.Abs(this.LocalOffset.Y) < 1.0)
		{
			float val = (float)Math.Abs(this.LocalOffset.Z);
			float num = (float)Math.Sign(this.LocalOffset.Z) * Math.Max(this.CurLongLen, val);
			double addZ = (double)num - this.LocalOffset.Z;
			GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, this.OffsetVector, (double)num);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TargetLocation, addZ);
			return;
		}
		double num2 = this.LocalOffset.Z / this.LocalOffset.Y;
		float curShortLen = this.CurShortLen;
		float curLongLen = this.CurLongLen;
		double d = 1.0 / ((double)(1f / (curShortLen * curShortLen)) + num2 * num2 / (double)(curLongLen * curLongLen));
		float num3 = (float)Math.Sign(this.LocalOffset.Y) * (float)Math.Sqrt(d);
		this.LocalOffset.Set(0.0, (double)num3, num2 * (double)num3);
		this.LocalQuat.RotateVector(this.LocalOffset, this.TmpVector);
		this.TmpVector.Subtraction(this.OffsetVector, this.TmpVector1);
		this.OffsetVector.DeepCopy(this.TmpVector);
		this.TargetLocation.AdditionEqual(this.TmpVector1);
	}

	// Token: 0x060182BC RID: 99004 RVA: 0x00742F3C File Offset: 0x0074113C
	protected void DrawDebugInfo()
	{
		BaseActorComponent actorComp = this.ActorComp;
		UKismetSystemLibrary.DrawDebugArrow((actorComp != null) ? actorComp.Owner : null, this.SplineLocation.ToUeVectorOld(), this.TargetLocation.ToUeVectorOld(), 10f, new FLinearColor(0f, 0f, 1f, 1f), 1f, 5f);
		this.LocalQuat.GetRightVector(this.TmpVector);
		this.TmpVector.MultiplyEqual((double)this.CurShortLen);
		this.TmpVector.AdditionEqual(this.SplineLocation);
		BaseActorComponent actorComp2 = this.ActorComp;
		UKismetSystemLibrary.DrawDebugArrow((actorComp2 != null) ? actorComp2.Owner : null, this.SplineLocation.ToUeVectorOld(), this.TmpVector.ToUeVectorOld(), 10f, new FLinearColor(1f, 0f, 0f, 1f), 1f, 5f);
		this.LocalQuat.GetUpVector(this.TmpVector);
		this.TmpVector.MultiplyEqual((double)this.CurLongLen);
		this.TmpVector.AdditionEqual(this.SplineLocation);
		BaseActorComponent actorComp3 = this.ActorComp;
		UKismetSystemLibrary.DrawDebugArrow((actorComp3 != null) ? actorComp3.Owner : null, this.SplineLocation.ToUeVectorOld(), this.TmpVector.ToUeVectorOld(), 10f, new FLinearColor(0f, 1f, 0f, 1f), 1f, 5f);
	}

	// Token: 0x060182BD RID: 99005 RVA: 0x007430B8 File Offset: 0x007412B8
	protected bool IsInEllipseRange(double x, double y, double a, double b)
	{
		return !MathUtils.Instance.IsNearlyZero(a, null) && !MathUtils.Instance.IsNearlyZero(b, null) && x * x / (a * a) + y * y / (b * b) <= 1.0;
	}

	// Token: 0x060182BE RID: 99006 RVA: 0x00743114 File Offset: 0x00741314
	protected override void PositionAdjustCommon(float timeKey, float deltaSeconds)
	{
		this.TargetLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		if (!base.CheckAndLimitOnlyForwardMove() && this.LastSplineDirection.Normalize(9.99999993922529E-09))
		{
			this.CommonVelocityAdjusted();
		}
		base.LimitMaxMove();
		this.MoveToTargetLocation(deltaSeconds);
	}

	// Token: 0x060182BF RID: 99007 RVA: 0x00743168 File Offset: 0x00741368
	protected override void MoveToTargetLocation(float deltaSeconds)
	{
		if (global::Vector.DistSquared(this.ActorComp.ActorLocationProxy, this.TargetLocation) <= 1E-08)
		{
			return;
		}
		if (this.MoveComp == null)
		{
			this.ActorComp.SetActorLocation(this.TargetLocation.ToUeVector(false), "样条移动", false);
			return;
		}
		this.TargetLocation.Subtraction(this.ActorComp.ActorLocationProxy, this.OffsetVector);
		this.MoveComp.MoveCharacter(this.OffsetVector, deltaSeconds, "");
	}

	// Token: 0x060182C0 RID: 99008 RVA: 0x007431F4 File Offset: 0x007413F4
	private void CommonVelocityAdjusted()
	{
		if (this.CharActorComp == null)
		{
			return;
		}
		this.TmpVector.DeepCopy(this.CharActorComp.ActorVelocityProxy);
		Quat.FindBetween(this.LastSplineDirection, this.SplineDirection, this.TmpQuat);
		this.TmpQuat.RotateVector(this.TmpVector, this.TmpVector);
		this.CharActorComp.SetActorVelocity(this.TmpVector);
	}

	// Token: 0x060182C1 RID: 99009 RVA: 0x00743260 File Offset: 0x00741460
	private void AdjustTargetLocationRacingTrack()
	{
		if (this.CurrentSplineMoveParamsInternal.Type != ESplineMovePattern.RacingTrack)
		{
			return;
		}
		if (!this.LastSplineDirection.Normalize(9.99999993922529E-09))
		{
			return;
		}
		this.TargetLocation.Subtraction(this.LastSplineLocation, this.OffsetVector);
		this.OffsetVector.Z = 0.0;
		this.LastSplineDirection.Multiply(this.OffsetVector.DotProduct(this.LastSplineDirection), this.TmpVector);
		this.OffsetVector.SubtractionEqual(this.TmpVector);
		this.TmpQuat.RotateVector(this.OffsetVector, this.TmpVector);
		double z = this.TargetLocation.Z;
		this.SplineLocation.Addition(this.TmpVector, this.TargetLocation);
		this.TargetLocation.Z = z;
	}

	// Token: 0x060182C2 RID: 99010 RVA: 0x0074333C File Offset: 0x0074153C
	private void RacingLeftRight(float deltaSeconds)
	{
		if (this.CharActorComp == null || this.CurrentSplineMoveParamsInternal.Type != ESplineMovePattern.RacingTrack)
		{
			return;
		}
		global::Vector inputDirectProxy = this.CharActorComp.InputDirectProxy;
		this.TmpVector.X = -this.SplineDirection.Y;
		this.TmpVector.Y = this.SplineDirection.X;
		this.TmpVector.Z = 0.0;
		double num = this.TmpVector.DotProduct(inputDirectProxy);
		if (num < (double)(-(double)this.CurrentSplineMoveParamsInternal.InputLimitSin))
		{
			num = (double)(-(double)this.CurrentSplineMoveParamsInternal.InputLimitSin);
		}
		else if (num > (double)this.CurrentSplineMoveParamsInternal.InputLimitSin)
		{
			num = (double)this.CurrentSplineMoveParamsInternal.InputLimitSin;
		}
		double num2 = (double)this.MoveComp.CharacterMovement.MaxWalkSpeed * num;
		float maxAcceleration = this.MoveComp.CharacterMovement.MaxAcceleration;
		double num3 = num2 - (double)this.LastRightSpeed;
		float num4 = maxAcceleration * deltaSeconds;
		float num5;
		if (Math.Abs(num3) > (double)num4)
		{
			if (num3 * (double)this.LastRightSpeed < 0.0)
			{
				num5 = this.LastRightSpeed * (float)Math.Pow(0.9599999785423279, (double)(deltaSeconds * 60f));
			}
			else
			{
				num5 = this.LastRightSpeed;
			}
			num5 += (float)Math.Sign(num3) * num4;
		}
		else
		{
			num5 = (float)num2;
		}
		this.TmpVector.MultiplyEqual((double)((this.LastRightSpeed + num5) / 2f * deltaSeconds));
		this.TargetLocation.AdditionEqual(this.TmpVector);
		this.LastRightSpeed = num5;
	}

	// Token: 0x060182C3 RID: 99011 RVA: 0x007434C4 File Offset: 0x007416C4
	protected override void InputAdjust()
	{
		if (this.CharActorComp == null)
		{
			return;
		}
		if (base.CurrentSplineMoveType == ESplineMovePattern.AirPassage)
		{
			return;
		}
		CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
		if (unifiedComp != null && unifiedComp.PositionState == global::ECharPositionState.Climb)
		{
			this.InputAdjustClimbState();
			return;
		}
		this.InputAdjustWithSplineType(this.CharActorComp.InputDirectProxy);
	}

	// Token: 0x060182C4 RID: 99012 RVA: 0x00743514 File Offset: 0x00741714
	private void InputAdjustClimbState()
	{
		global::Vector inputDirectProxy = this.CharActorComp.InputDirectProxy;
		SplineMoveParams currentSplineMoveParams = base.CurrentSplineMoveParams;
		if (currentSplineMoveParams == null || !currentSplineMoveParams.IsAdaptiveClimbInput)
		{
			CameraModel.Instance.MainModel.CameraRotator.Quaternion(this.TmpQuat);
			this.TmpQuat.RotateVector(inputDirectProxy, this.TmpVector);
			this.CharActorComp.SetInputDirect(this.TmpVector, false, EInputDirectSpace.World);
			this.InputAdjustWithSplineType(inputDirectProxy);
			this.ActorComp.ActorQuatProxy.Inverse(this.TmpQuat);
			this.TmpQuat.RotateVector(inputDirectProxy, this.TmpVector);
			this.TmpVector.Z = 0.0;
			this.CharActorComp.SetInputDirect(this.TmpVector, false, EInputDirectSpace.Relative);
			return;
		}
		this.TmpVector.Z = inputDirectProxy.X;
		this.TmpVector.Y = inputDirectProxy.Y;
		this.TmpVector.X = 0.0;
		CameraModel.Instance.MainModel.CameraRotator.Quaternion(this.TmpQuat);
		this.TmpQuat.RotateVector(this.TmpVector, this.TmpVector);
		this.ActorComp.ActorQuatProxy.UnRotateVector(this.TmpVector, this.TmpVector);
		if (MathUtils.Instance.IsNearlyZero(this.TmpVector.Y, null) && MathUtils.Instance.IsNearlyZero(this.TmpVector.Z, null))
		{
			this.CharActorComp.SetInputDirect(this.TmpVector, false, EInputDirectSpace.Relative);
			return;
		}
		double num = Math.Atan2(this.TmpVector.X, this.TmpVector.Z) * 57.295780181884766;
		if (num > -30.0 && num < 150.0)
		{
			this.CharActorComp.SetInputDirect(global::Vector.ForwardVectorProxy, false, EInputDirectSpace.Relative);
			return;
		}
		this.CharActorComp.SetInputDirect(global::Vector.BackwardVectorProxy, false, EInputDirectSpace.Relative);
	}

	// Token: 0x060182C5 RID: 99013 RVA: 0x00743730 File Offset: 0x00741930
	private void InputAdjustWithSplineType(global::Vector inputDirect)
	{
		switch (this.CurrentSplineMoveParamsInternal.Type)
		{
		case ESplineMovePattern.PathLine:
			this.InputAdjustPathLine(inputDirect);
			return;
		case ESplineMovePattern.RacingTrack:
			this.InputAdjustRacingTrack(inputDirect);
			return;
		case ESplineMovePattern.SlideTrack:
			this.InputAdjustSlideTrack(inputDirect);
			return;
		default:
			return;
		}
	}

	// Token: 0x060182C6 RID: 99014 RVA: 0x00743774 File Offset: 0x00741974
	private void InputAdjustSlideTrack(global::Vector inputDirect)
	{
		SplineMoveParams currentSplineMoveParamsInternal = this.CurrentSplineMoveParamsInternal;
		this.SplineQuat.Inverse(this.TmpQuat);
		this.ActorComp.ActorLocationProxy.Subtraction(this.SplineLocation, this.TmpVector);
		this.TmpQuat.RotateVector(this.TmpVector, this.TmpVector);
		float currentValue = currentSplineMoveParamsInternal.EdgeLimitCurve.GetCurrentValue((float)Math.Abs(this.TmpVector.Y) / currentSplineMoveParamsInternal.MaxOffsetDist);
		float num = -currentSplineMoveParamsInternal.InputLimitAngle;
		float num2 = currentSplineMoveParamsInternal.InputLimitAngle;
		if (this.TmpVector.Y < 0.0)
		{
			num *= 1f - currentValue;
		}
		else
		{
			num2 *= 1f - currentValue;
		}
		this.MinTurnAngle = num;
		this.MaxTurnAngle = num2;
		if (inputDirect.IsNearlyZero(9.999999747378752E-05))
		{
			this.SplineQuat.RotateVector(global::Vector.ForwardVectorProxy, this.TmpVector);
			this.CharActorComp.SetInputDirect(this.TmpVector, false, EInputDirectSpace.World);
			this.CharActorComp.SetInputFacing(this.TmpVector, true);
			return;
		}
		CameraModel.Instance.MainModel.CameraRotator.Quaternion(this.TmpQuat);
		this.TmpQuat.RotateVector(global::Vector.ForwardVectorProxy, this.TmpVector);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector);
		if (this.TmpVector.IsNearlyZero(9.999999747378752E-05))
		{
			this.TmpQuat.RotateVector(global::Vector.UpVectorProxy, this.TmpVector);
		}
		this.ActorComp.ActorGravityDirectProxy.UnaryNegation(this.TmpVector1);
		MathUtils.Instance.LookRotationUpFirst(this.TmpVector, this.TmpVector1, this.TmpQuat);
		this.TmpQuat.Inverse(this.TmpQuat);
		this.TmpQuat.RotateVector(inputDirect, this.TmpVector);
		double currentValue2 = this.TmpVector.HeadingAngle() * 57.295780181884766;
		float num3 = (float)(MathUtils.Instance.Clamp(currentValue2, (double)num, (double)num2) * 0.01745329238474369);
		this.TmpVector.Set((double)((float)Math.Cos((double)num3)), (double)((float)Math.Sin((double)num3)), 0.0);
		this.SplineQuat.RotateVector(this.TmpVector, this.TmpVector);
		this.CharActorComp.SetInputDirect(this.TmpVector, false, EInputDirectSpace.World);
		this.CharActorComp.SetInputFacing(this.TmpVector, true);
	}

	// Token: 0x060182C7 RID: 99015 RVA: 0x007439FC File Offset: 0x00741BFC
	private void InputAdjustPathLine(global::Vector inputDirect)
	{
		SplineMoveParams currentSplineMoveParamsInternal = this.CurrentSplineMoveParamsInternal;
		CharacterInputComponent component = base.Entity.GetComponent<CharacterInputComponent>();
		if (!currentSplineMoveParamsInternal.OnlyForward || component == null || !component.TryGetManualWorldMoveDirection(this.PathLineInputDirection))
		{
			this.PathLineInputDirection.DeepCopy(inputDirect);
		}
		if (inputDirect.IsNearlyZero(9.999999747378752E-05))
		{
			this.InputAdjustPathLineFacing(currentSplineMoveParamsInternal);
			return;
		}
		if (this.PathLineInputDirection.IsNearlyZero(9.999999747378752E-05))
		{
			this.CharActorComp.ClearInput(true, true);
			this.InputAdjustPathLineFacing(currentSplineMoveParamsInternal);
			return;
		}
		double num = this.PathLineInputDirection.DotProduct(this.SplineDirection);
		float num2;
		if (currentSplineMoveParamsInternal.OnlyForward)
		{
			if (num < 0.7070000171661377)
			{
				this.CharActorComp.ClearInput(true, true);
				this.InputAdjustPathLineFacing(currentSplineMoveParamsInternal);
				return;
			}
			num2 = 1f;
		}
		else
		{
			if (Math.Abs(num) < 0.7070000171661377)
			{
				this.CharActorComp.ClearInput(true, true);
				this.InputAdjustPathLineFacing(currentSplineMoveParamsInternal);
				return;
			}
			num2 = (float)Math.Sign(num);
		}
		this.SplineDirection.Multiply((double)(num2 * 500f), this.TmpVector);
		this.TmpVector.AdditionEqual(this.SplineLocation);
		this.TmpVector.SubtractionEqual(this.TargetLocation);
		this.TmpVector.Z = 0.0;
		this.TmpVector.Normalize(9.99999993922529E-09);
		this.CharActorComp.SetInputDirect(this.TmpVector, false, EInputDirectSpace.World);
		this.CharActorComp.SetInputFacing(this.TmpVector, true);
		this.InputAdjustPathLineFacing(currentSplineMoveParamsInternal);
	}

	// Token: 0x060182C8 RID: 99016 RVA: 0x00743B9C File Offset: 0x00741D9C
	private void InputAdjustPathLineFacing(SplineMoveParams @params)
	{
		EPathLineFacingType? adjustFacingType = @params.AdjustFacingType;
		if (adjustFacingType != null)
		{
			EPathLineFacingType valueOrDefault = adjustFacingType.GetValueOrDefault();
			if (valueOrDefault != EPathLineFacingType.Current)
			{
				if (valueOrDefault != EPathLineFacingType.Custom)
				{
					return;
				}
				this.TmpVector.Set((double)((float)Math.Cos((double)(0.017453292f * @params.AdjustFacingLimit))), (double)((float)Math.Sin((double)(0.017453292f * @params.AdjustFacingLimit))), 0.0);
				this.CharActorComp.SetInputFacing(this.TmpVector, true);
			}
			else if (Math.Abs(this.SplineDirection.DotProduct(this.MoveComp.GravityUp)) < 0.9999)
			{
				MathUtils.Instance.LookRotationUpFirst(this.SplineDirection, this.MoveComp.GravityUp, this.TmpQuat);
				this.TmpVector1.Set((double)((float)Math.Cos((double)(0.017453292f * @params.AdjustFacingLimit))), (double)((float)Math.Sin((double)(0.017453292f * @params.AdjustFacingLimit))), 0.0);
				this.TmpQuat.RotateVector(this.TmpVector1, this.TmpVector);
				this.CharActorComp.SetInputFacing(this.TmpVector, true);
				return;
			}
		}
	}

	// Token: 0x060182C9 RID: 99017 RVA: 0x00743CD8 File Offset: 0x00741ED8
	private void InputAdjustRacingTrack(global::Vector inputDirect)
	{
		SplineMoveParams currentSplineMoveParamsInternal = this.CurrentSplineMoveParamsInternal;
		this.CharActorComp.SetInputFacing(this.SplineDirection, true);
		if (inputDirect.IsNearlyZero(9.999999747378752E-05))
		{
			this.LastForward = true;
			this.CharActorComp.SetInputDirect(this.SplineDirection, false, EInputDirectSpace.World);
			return;
		}
		double num = this.SplineDirection.DotProduct(inputDirect);
		if (currentSplineMoveParamsInternal.OnlyForward || num > (double)(this.LastForward ? -0.5f : 0.5f))
		{
			this.LastForward = true;
			this.CharActorComp.SetInputDirect(this.SplineDirection, false, EInputDirectSpace.World);
			return;
		}
		this.LastForward = false;
		this.SplineDirection.UnaryNegation(this.TmpVector);
		this.CharActorComp.SetInputDirect(this.TmpVector, false, EInputDirectSpace.World);
	}

	// Token: 0x060182CA RID: 99018 RVA: 0x00743DB4 File Offset: 0x00741FB4
	protected double NormalizeAngle(double angle)
	{
		double num = angle % 360.0;
		if (num < 0.0)
		{
			num += 360.0;
		}
		return num;
	}

	// Token: 0x060182CB RID: 99019 RVA: 0x00743DE8 File Offset: 0x00741FE8
	protected bool InAngleRange(double angle, double minAngle, double maxAngle)
	{
		double num = this.NormalizeAngle(maxAngle - minAngle);
		return this.NormalizeAngle(angle - minAngle) < num;
	}

	// Token: 0x060182CC RID: 99020 RVA: 0x00743E0C File Offset: 0x0074200C
	protected double ClampAngle(double angle, double minAngle, double maxAngle)
	{
		if (this.InAngleRange(angle, minAngle, maxAngle))
		{
			return MathUtils.Instance.WrapAngle(angle);
		}
		float num = (float)Math.Abs(MathUtils.Instance.WrapAngle(angle - minAngle));
		float num2 = (float)Math.Abs(MathUtils.Instance.WrapAngle(angle - maxAngle));
		if (num >= num2)
		{
			return MathUtils.Instance.WrapAngle(maxAngle);
		}
		return MathUtils.Instance.WrapAngle(minAngle);
	}

	// Token: 0x060182CD RID: 99021 RVA: 0x00743E71 File Offset: 0x00742071
	protected double LerpAngle(double angleA, double angleB, double alpha)
	{
		return MathUtils.Instance.WrapAngle(angleA + MathUtils.Instance.WrapAngle(angleB - angleA) * alpha);
	}

	// Token: 0x060182CE RID: 99022 RVA: 0x00743E90 File Offset: 0x00742090
	public unsafe override void StartSplineMoveInternal(SplineMoveParams config)
	{
		int id = config.Id;
		if (this.DisableKey != null)
		{
			base.Enable(new int?(this.DisableKey.Value), "SplineMoveComponent.StartSplineMoveInternal");
			this.DisableKey = null;
			this.OnSplineMoveEnable(id, config);
		}
		base.AddSplineMoveParams(id, config);
		base.SelectNextSplineMove();
		this.LastRightSpeed = 0f;
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "StartSplineMove";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Spline Id", id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", this.ActorComp.Owner);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StackCount", this.SplineStack.Count);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x060182CF RID: 99023 RVA: 0x00743F83 File Offset: 0x00742183
	public override bool IsPlannerMove()
	{
		return base.CurrentSplineMoveType != ESplineMovePattern.AirPassage;
	}

	// Token: 0x060182D0 RID: 99024 RVA: 0x00743F91 File Offset: 0x00742191
	protected void ApplySplineMoveDaConfig(SplineMoveParams config)
	{
		if (config.Type != ESplineMovePattern.PathLine)
		{
			return;
		}
		this.ApplySplineMoveDaConfigInternal(true, config);
	}

	// Token: 0x060182D1 RID: 99025 RVA: 0x00743FA4 File Offset: 0x007421A4
	protected void ResetSplineMoveDaConfig()
	{
		this.ApplySplineMoveDaConfigInternal(false, null);
	}

	// Token: 0x060182D2 RID: 99026 RVA: 0x00743FB0 File Offset: 0x007421B0
	[NullableContext(2)]
	private void ApplySplineMoveDaConfigInternal(bool apply, SplineMoveParams config = null)
	{
		if (apply)
		{
			BP_SplineMoveConfig_C bp_SplineMoveConfig_C = null;
			if (!string.IsNullOrEmpty((config != null) ? config.ConfigDaPath : null))
			{
				bp_SplineMoveConfig_C = ResourceSystem.Instance.Load<BP_SplineMoveConfig_C>(config.ConfigDaPath, "js_undefined");
			}
			if (bp_SplineMoveConfig_C == null)
			{
				bp_SplineMoveConfig_C = CharacterSplineMoveComponent.SplineMoveConfig;
			}
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.SetTurnRate(bp_SplineMoveConfig_C.TurnRate);
			}
			CharacterMoveComponent moveComp2 = this.MoveComp;
			if (moveComp2 != null)
			{
				moveComp2.SetAirControl(bp_SplineMoveConfig_C.AirControl);
			}
			CharacterMoveComponent moveComp3 = this.MoveComp;
			if (moveComp3 != null)
			{
				moveComp3.SetOverrideMaxFallingSpeed(bp_SplineMoveConfig_C.MaxFlySpeed);
			}
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.超级跳跃"]));
			}
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp != null)
			{
				attributeComp.SetBaseValue(EAttributeType.Jump, 10000f * bp_SplineMoveConfig_C.JumpHeightRate);
			}
			CharacterAnimationComponent animComp = this.AnimComp;
			UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
			if (UKuroStaticLibrary.IsObjectClassByName(uanimInstance, CharacterNameDefines.Instance.ABP_BASEROLE))
			{
				ABP_BaseRole_C abp_BaseRole_C = uanimInstance as ABP_BaseRole_C;
				if (abp_BaseRole_C == null)
				{
					return;
				}
				abp_BaseRole_C.设置跳跃速率(bp_SplineMoveConfig_C.JumpTimeScale);
				return;
			}
		}
		else
		{
			CharacterMoveComponent moveComp4 = this.MoveComp;
			if (moveComp4 != null)
			{
				moveComp4.ResetTurnRate();
			}
			CharacterMoveComponent moveComp5 = this.MoveComp;
			if (moveComp5 != null)
			{
				moveComp5.ResetAirControl();
			}
			CharacterMoveComponent moveComp6 = this.MoveComp;
			if (moveComp6 != null)
			{
				moveComp6.ResetOverrideMaxFallingSpeed();
			}
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null)
			{
				tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.超级跳跃"]));
			}
			BaseAttributeComponent attributeComp2 = this.AttributeComp;
			if (attributeComp2 != null)
			{
				attributeComp2.SetBaseValue(EAttributeType.Jump, 10000f);
			}
			CharacterAnimationComponent animComp2 = this.AnimComp;
			UAnimInstance uanimInstance2 = (animComp2 != null) ? animComp2.MainAnimInstance : null;
			if (UKuroStaticLibrary.IsObjectClassByName(uanimInstance2, CharacterNameDefines.Instance.ABP_BASEROLE))
			{
				ABP_BaseRole_C abp_BaseRole_C2 = uanimInstance2 as ABP_BaseRole_C;
				if (abp_BaseRole_C2 == null)
				{
					return;
				}
				abp_BaseRole_C2.设置跳跃速率(1f);
			}
		}
	}

	// Token: 0x060182D3 RID: 99027 RVA: 0x00744170 File Offset: 0x00742370
	protected override void OnSplineMoveEnable(int id, SplineMoveParams config)
	{
		base.OnSplineMoveEnable(id, config);
		this.ApplySplineMoveDaConfig(config);
	}

	// Token: 0x060182D4 RID: 99028 RVA: 0x00744181 File Offset: 0x00742381
	protected override void OnSplineMoveDisable()
	{
		base.OnSplineMoveDisable();
		this.ResetSplineMoveDaConfig();
	}

	// Token: 0x060182D5 RID: 99029 RVA: 0x00744190 File Offset: 0x00742390
	protected override void OnSelectNextSplineMoveEnd()
	{
		if (!this.InheritThisFrame)
		{
			CharacterActorComponent charActorComp = this.CharActorComp;
			if (charActorComp != null)
			{
				charActorComp.ClearInput(false, true);
			}
			this.RefreshTurnAngleLimit();
		}
		RoleGaitComponent component = base.Entity.GetComponent<RoleGaitComponent>();
		if (component != null)
		{
			SplineMoveParams currentSplineMoveParams = base.CurrentSplineMoveParams;
			component.SetDisableStopAnim(currentSplineMoveParams != null && currentSplineMoveParams.IsDisableStopAnim);
		}
		CharacterClimbComponent component2 = base.Entity.GetComponent<CharacterClimbComponent>();
		if (component2 != null)
		{
			SplineMoveParams currentSplineMoveParams2 = base.CurrentSplineMoveParams;
			component2.SetIsAllowEarlyExitClimb(currentSplineMoveParams2 != null && currentSplineMoveParams2.IsAllowEarlyExitClimb);
		}
		base.OnSelectNextSplineMoveEnd();
	}

	// Token: 0x060182D6 RID: 99030 RVA: 0x00744214 File Offset: 0x00742414
	private void RefreshTurnAngleLimit()
	{
		if (this.CurrentSplineMoveParamsInternal == null)
		{
			return;
		}
		this.MinTurnAngle = -this.CurrentSplineMoveParamsInternal.InputLimitAngle;
		this.MaxTurnAngle = this.CurrentSplineMoveParamsInternal.InputLimitAngle;
	}

	// Token: 0x060182D7 RID: 99031 RVA: 0x00744244 File Offset: 0x00742444
	private unsafe void OnStateInherit(Entity oldEntity, bool notInheritMoveAndAnim)
	{
		CharacterSplineMoveComponent component = oldEntity.GetComponent<CharacterSplineMoveComponent>();
		if (component == null || !component.Active)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[CharacterSplineMoveComp] 轨道模式继承";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastEntity", oldEntity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurEntity", base.Entity.Id);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.InheritThisFrame = true;
		foreach (int key in component.SplineStack)
		{
			SplineMoveParams splineMoveParams = component.SplineMoveParamsMap[key];
			if (splineMoveParams.AllowInherit)
			{
				base.InheritStartSplineMove(splineMoveParams);
			}
		}
		this.LastTimeKey = component.LastTimeKey;
		this.LastSplineLocation.DeepCopy(component.LastSplineLocation);
		this.LastSplineDirection.DeepCopy(component.LastSplineDirection);
		this.LastLocation.DeepCopy(component.LastLocation);
		this.LastRightSpeed = component.LastRightSpeed;
		this.LastForward = component.LastForward;
		foreach (int num in component.SplineStack)
		{
			if (component.SplineMoveParamsMap[num].AllowInherit)
			{
				component.EndSplineMove(num);
			}
		}
		this.InheritThisFrame = false;
	}

	// Token: 0x060182D8 RID: 99032 RVA: 0x007443F4 File Offset: 0x007425F4
	public static void CreateStaticDefaultValue()
	{
		CharacterSplineMoveComponent.SplineMoveConfigInternal = null;
	}

	// Token: 0x060182D9 RID: 99033 RVA: 0x007443FC File Offset: 0x007425FC
	public static void ResetStaticDefaultValue()
	{
		CharacterSplineMoveComponent.SplineMoveConfigInternal = null;
	}

	// Token: 0x060182DA RID: 99034 RVA: 0x00744404 File Offset: 0x00742604
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSplineMoveComponent characterSplineMoveComponent = (CharacterSplineMoveComponent)componentTemplate;
		if (characterSplineMoveComponent.CharActorComp == null)
		{
			this.CharActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharActorComp), "CharActorComp"))
		{
			return false;
		}
		if (characterSplineMoveComponent.UnifiedComp == null)
		{
			this.UnifiedComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedComp), "UnifiedComp"))
		{
			return false;
		}
		if (characterSplineMoveComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterSplineMoveComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterSplineMoveComponent.AttributeComp == null)
		{
			this.AttributeComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComp), "AttributeComp"))
		{
			return false;
		}
		if (characterSplineMoveComponent.PathLineInputDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PathLineInputDirection), "PathLineInputDirection"))
		{
			return false;
		}
		this.LastRightSpeed = characterSplineMoveComponent.LastRightSpeed;
		this.LastForward = characterSplineMoveComponent.LastForward;
		this.MinTurnAngle = characterSplineMoveComponent.MinTurnAngle;
		this.MaxTurnAngle = characterSplineMoveComponent.MaxTurnAngle;
		this.CurMaxWidth = characterSplineMoveComponent.CurMaxWidth;
		this.CurMaxHeight = characterSplineMoveComponent.CurMaxHeight;
		this.CurLongLen = characterSplineMoveComponent.CurLongLen;
		this.CurShortLen = characterSplineMoveComponent.CurShortLen;
		if (characterSplineMoveComponent.LocalOffset == null)
		{
			this.LocalOffset = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LocalOffset), "LocalOffset"))
		{
			return false;
		}
		if (characterSplineMoveComponent.LocalQuat == null)
		{
			this.LocalQuat = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LocalQuat), "LocalQuat"))
		{
			return false;
		}
		this.DebugMode = characterSplineMoveComponent.DebugMode;
		return true;
	}

	// Token: 0x170025E9 RID: 9705
	// (get) Token: 0x060182DB RID: 99035 RVA: 0x007445DF File Offset: 0x007427DF
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025EA RID: 9706
	// (get) Token: 0x060182DC RID: 99036 RVA: 0x007445E2 File Offset: 0x007427E2
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025EB RID: 9707
	// (get) Token: 0x060182DD RID: 99037 RVA: 0x007445E5 File Offset: 0x007427E5
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CFE1 RID: 53217
	private const float COSINE_45 = 0.707f;

	// Token: 0x0400CFE2 RID: 53218
	private const float MAX_INPUT_COS = 0.707f;

	// Token: 0x0400CFE3 RID: 53219
	private const float FORWARD_BACKWARD_THRESHOLD = 0.5f;

	// Token: 0x0400CFE4 RID: 53220
	private const float FORECAST_DIST = 500f;

	// Token: 0x0400CFE5 RID: 53221
	private const float DAMPING = 0.96f;

	// Token: 0x0400CFE6 RID: 53222
	private const float STANDARD_FPS = 60f;

	// Token: 0x0400CFE7 RID: 53223
	[StaticVariableRuleIgnore]
	public static readonly string DaPath = "/Game/Aki/Data/Fight/DA_SplineMoveConfig.DA_SplineMoveConfig";

	// Token: 0x0400CFE8 RID: 53224
	[Nullable(2)]
	private static BP_SplineMoveConfig_C SplineMoveConfigInternal = null;

	// Token: 0x0400CFE9 RID: 53225
	[Nullable(2)]
	private CharacterActorComponent CharActorComp;

	// Token: 0x0400CFEA RID: 53226
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400CFEB RID: 53227
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400CFEC RID: 53228
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400CFED RID: 53229
	[Nullable(2)]
	private BaseAttributeComponent AttributeComp;

	// Token: 0x0400CFEE RID: 53230
	private readonly global::Vector PathLineInputDirection = global::Vector.Create();

	// Token: 0x0400CFEF RID: 53231
	public float LastRightSpeed;

	// Token: 0x0400CFF0 RID: 53232
	protected bool LastForward = true;

	// Token: 0x0400CFF1 RID: 53233
	public float MinTurnAngle;

	// Token: 0x0400CFF2 RID: 53234
	public float MaxTurnAngle;

	// Token: 0x0400CFF3 RID: 53235
	public float CurMaxWidth;

	// Token: 0x0400CFF4 RID: 53236
	public float CurMaxHeight;

	// Token: 0x0400CFF5 RID: 53237
	public float CurLongLen;

	// Token: 0x0400CFF6 RID: 53238
	public float CurShortLen;

	// Token: 0x0400CFF7 RID: 53239
	public global::Vector LocalOffset = global::Vector.Create();

	// Token: 0x0400CFF8 RID: 53240
	public Quat LocalQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CFF9 RID: 53241
	public bool DebugMode;
}
