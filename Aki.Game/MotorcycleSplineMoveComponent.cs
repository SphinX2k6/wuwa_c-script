using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020032FC RID: 13052
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleSplineMoveComponent : VehicleSplineMoveComponent
{
	// Token: 0x17002759 RID: 10073
	// (get) Token: 0x0601C6DF RID: 116447 RVA: 0x007F9021 File Offset: 0x007F7221
	// (set) Token: 0x0601C6E0 RID: 116448 RVA: 0x007F902C File Offset: 0x007F722C
	protected bool AutopilotBraking
	{
		get
		{
			return this.AutopilotBrakingInternal;
		}
		set
		{
			if (this.AutopilotBrakingInternal == value)
			{
				return;
			}
			this.AutopilotBrakingInternal = value;
			MotorcycleMoveComponent component = base.Entity.GetComponent<MotorcycleMoveComponent>();
			if (component != null)
			{
				component.BackBraking = value;
			}
		}
	}

	// Token: 0x1700275A RID: 10074
	// (get) Token: 0x0601C6E1 RID: 116449 RVA: 0x007F9060 File Offset: 0x007F7260
	// (set) Token: 0x0601C6E2 RID: 116450 RVA: 0x007F9068 File Offset: 0x007F7268
	protected bool AutopilotSprint
	{
		get
		{
			return this.AutopilotSprintInternal;
		}
		set
		{
			if (this.AutopilotSprintInternal == value)
			{
				return;
			}
			this.AutopilotSprintInternal = value;
			if (value)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null)
				{
					return;
				}
				tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺.路网自动"]));
				return;
			}
			else
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 == null)
				{
					return;
				}
				tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺.路网自动"]));
				return;
			}
		}
	}

	// Token: 0x0601C6E3 RID: 116451 RVA: 0x007F90D3 File Offset: 0x007F72D3
	protected override bool OnInit()
	{
		this.DetectedRecordList = new DoublyLinkedList<MotorcycleSplineMoveComponent.RoadBlockDetectRecord>(null);
		return base.OnInit();
	}

	// Token: 0x0601C6E4 RID: 116452 RVA: 0x007F90E7 File Offset: 0x007F72E7
	protected override void PositionAdjust(float timeKey, float deltaSeconds)
	{
		this.CalAdjustRotation(timeKey, deltaSeconds);
		this.PositionAdjustCommon(timeKey, deltaSeconds);
	}

	// Token: 0x0601C6E5 RID: 116453 RVA: 0x007F90FC File Offset: 0x007F72FC
	protected unsafe override void MoveToTargetLocation(float deltaSeconds)
	{
		if (this.IsDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "SplineMove MoveToTargetLocation";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TimeKey", this.SplineTimeKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Current", this.VehicleActorComp.ActorLocationProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Target", this.TargetLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("QuatDelta", this.QuatDelta);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		if (this.TargetLocation.Equals(this.VehicleActorComp.ActorLocationProxy, 9.999999747378752E-05) && this.QuatDelta.Equals(Quat.IdentityProxy, 0.0001f))
		{
			return;
		}
		VehicleActorComponent vehicleActorComp = this.VehicleActorComp;
		UKuroVehicleMovementComponent ukuroVehicleMovementComponent;
		if (vehicleActorComp == null)
		{
			ukuroVehicleMovementComponent = null;
		}
		else
		{
			TsBaseVehicle vehicleOwner = vehicleActorComp.VehicleOwner;
			ukuroVehicleMovementComponent = ((vehicleOwner != null) ? vehicleOwner.VehicleMovementComponent : null);
		}
		UKuroVehicleMovementComponent ukuroVehicleMovementComponent2 = ukuroVehicleMovementComponent;
		if (ukuroVehicleMovementComponent2 == null)
		{
			base.MoveToTargetLocation(deltaSeconds);
			this.ActorComp.AddActorWorldRotation(this.QuatDelta.Rotator(null).ToUeRotator(), "MotorSplineMove", false);
			this.ActorComp.ResetRotationCachedTime();
			return;
		}
		this.TargetLocation.Subtraction(this.ActorComp.ActorLocationProxy, this.TmpVector);
		Vector tmpVector = this.TmpVector1;
		FVector motorNormal = ukuroVehicleMovementComponent2.GetMotorNormal();
		tmpVector.FromUeVector(motorNormal);
		double num = this.TmpVector.DotProduct(this.TmpVector1);
		if (num < 0.0)
		{
			this.MoveDelta.DeepCopy(this.TmpVector);
		}
		else
		{
			Vector.VectorPlaneProject(this.TmpVector, this.TmpVector1, this.MoveDelta);
		}
		if (this.IsDebug)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "SplineMove MoveToTargetLocation2";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("dot", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Offset", this.TmpVector);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Normal", this.TmpVector1);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("MoveDelta", this.MoveDelta);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		}
		ukuroVehicleMovementComponent2.MoveMotorcycle(this.MoveDelta.ToUeVectorOld(), this.QuatDelta.ToUeQuat(), true);
		BaseActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.DebugMovementComp : null) != null)
		{
			this.ActorComp.DebugMovementComp.MarkDebugRecord("SplineMove.SetActorLocation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		this.ActorComp.ResetLocationCachedTime();
		this.ActorComp.ResetRotationCachedTime();
	}

	// Token: 0x0601C6E6 RID: 116454 RVA: 0x007F93C4 File Offset: 0x007F75C4
	protected unsafe void CalAdjustRotation(float timeKey, float deltaSeconds)
	{
		Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
		float num = base.CurrentSplineMoveParams.PredictDist;
		if (!base.IsPositiveMoving)
		{
			num *= -1f;
		}
		USplineComponent spline = base.CurrentSplineMoveParams.Spline;
		float distanceAlongSplineAtSplineInputKey = spline.GetDistanceAlongSplineAtSplineInputKey(this.SplineTimeKey);
		Vector tmpVector = this.TmpVector;
		FVectorDouble fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(distanceAlongSplineAtSplineInputKey + num, ESplineCoordinateSpace.World);
		tmpVector.FromUeVector(fvectorDouble);
		this.TmpVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.SplineQuat.UnRotateVector(actorForwardProxy, this.TmpVector);
		bool flag = false;
		if (Math.Abs(this.TmpVector.Z) > (double)base.CurrentSplineMoveParams.AdjustFacingLimitPitchSin)
		{
			this.TmpVector.Z = (double)((float)Math.Sign(this.TmpVector.Z) * base.CurrentSplineMoveParams.AdjustFacingLimitPitchSin);
			flag = true;
		}
		double num2 = Math.Sqrt(1.0 - this.TmpVector.Z * this.TmpVector.Z);
		if (MathUtils.Instance.IsNearlyZero(this.TmpVector.X, null) && MathUtils.Instance.IsNearlyZero(this.TmpVector.Y, null))
		{
			this.TmpVector.X = num2;
			this.TmpVector.Y = 0.0;
		}
		else
		{
			float num3 = base.CurrentSplineMoveParams.AdjustFacingLimit * 0.017453292f;
			SplineMoveParams currentSplineMoveParams = base.CurrentSplineMoveParams;
			if (((currentSplineMoveParams != null) ? currentSplineMoveParams.AdjustFacingLimitCurve : null) != null)
			{
				this.ActorComp.ActorLocationProxy.Subtraction(this.SplineLocation, this.TmpVector1);
				this.SplineQuat.UnRotateVector(this.TmpVector1, this.TmpVector1);
				double value = this.TmpVector1.Y / (double)base.CurrentSplineMoveParams.MaxOffsetDist;
				num3 *= base.CurrentSplineMoveParams.AdjustFacingLimitCurve.GetFloatValue((float)Math.Abs(value));
			}
			double num4 = Math.Atan2(this.TmpVector.Y, this.TmpVector.X);
			if (num4 > (double)num3)
			{
				this.TmpVector.X = Math.Cos((double)num3);
				this.TmpVector.Y = Math.Sin((double)num3);
				flag = true;
			}
			else if (num4 < (double)(-(double)num3))
			{
				this.TmpVector.X = Math.Cos((double)(-(double)num3));
				this.TmpVector.Y = Math.Sin((double)(-(double)num3));
				flag = true;
			}
			else
			{
				this.TmpVector.X = Math.Cos(num4);
				this.TmpVector.Y = Math.Sin(num4);
			}
			this.TmpVector.X *= num2;
			this.TmpVector.Y *= num2;
		}
		if (flag)
		{
			if (this.IsDebug)
			{
				this.SplineQuat.UnRotateVector(this.ActorComp.ActorForwardProxy, this.TmpVector1);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "Motor SplineMove CalAdjustRotation";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TimeKey", this.SplineTimeKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OnlyForward", base.CurrentSplineMoveParams.OnlyForward);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Local", this.TmpVector1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("NewLocal", this.TmpVector);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Limit", base.CurrentSplineMoveParams.AdjustFacingLimit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("PitchCos", base.CurrentSplineMoveParams.AdjustFacingLimitPitchSin);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			this.SplineQuat.RotateVector(this.TmpVector, this.TmpVector1);
			Quat.FindBetween(actorForwardProxy, this.TmpVector1, this.QuatDelta);
			return;
		}
		this.QuatDelta.Reset();
	}

	// Token: 0x0601C6E7 RID: 116455 RVA: 0x007F97EC File Offset: 0x007F79EC
	protected override void InputAdjust()
	{
		if (base.CurrentSplineMoveParams == null)
		{
			return;
		}
		if (base.CurrentSplineMoveParams.AutopilotRoute != null)
		{
			if (this.DetectRoadBlock(4000f))
			{
				this.InputAdjustInternal(0f, 0f, true, -500f, 1000f);
				return;
			}
			this.InputAdjustInternal(0f, 0f, true, 0f, 0f);
			return;
		}
		else
		{
			if (base.CurrentSplineMoveParams.AutoDriveStandbyTime >= 0f && base.Entity.GetComponent<MotorcycleInputComponent>().LastInputSeconds + (double)base.CurrentSplineMoveParams.AutoDriveStandbyTime <= Time.Instance.NowSeconds)
			{
				this.InputAdjustInternal(0f, 0f, false, 0f, 0f);
				return;
			}
			UCurveFloat inputCorrectionCurve = base.CurrentSplineMoveParams.InputCorrectionCurve;
			if (inputCorrectionCurve == null)
			{
				this.InputAdjustInternal(-1f, 1f, false, 0f, 0f);
				return;
			}
			this.TmpVector.DeepCopy(this.SplineDirection);
			if (!base.IsPositiveMoving)
			{
				this.TmpVector.MultiplyEqual(-1.0);
			}
			this.ActorComp.ActorLocationProxy.Subtraction(this.SplineLocation, this.TmpVector1);
			this.SplineQuat.UnRotateVector(this.TmpVector1, this.TmpVector1);
			this.TmpVector1.X = 0.0;
			double num = (this.Using3d ? this.TmpVector1.Size() : this.TmpVector1.Y) / (double)base.CurrentSplineMoveParams.MaxOffsetDist;
			float floatValue = inputCorrectionCurve.GetFloatValue((float)num);
			float left = -inputCorrectionCurve.GetFloatValue((float)(-(float)num));
			this.InputAdjustInternal(left, floatValue, false, 0f, 0f);
			return;
		}
	}

	// Token: 0x0601C6E8 RID: 116456 RVA: 0x007F99A1 File Offset: 0x007F7BA1
	private void InputAdjustInternal(float left, float right, bool canAutoBrakeAndSprint = false, float predictRightOffset = 0f, float newPredictLength = 0f)
	{
		if (this.Using3d)
		{
			this.InputAdjust3dInternal(left, right, newPredictLength);
			return;
		}
		this.InputAdjust2dInternal(left, right, canAutoBrakeAndSprint, predictRightOffset, newPredictLength);
	}

	// Token: 0x0601C6E9 RID: 116457 RVA: 0x007F99C4 File Offset: 0x007F7BC4
	private unsafe void InputAdjust2dInternal(float left, float right, bool canAutoBrakeAndSprint = false, float predictRightOffset = 0f, float newPredictLength = 0f)
	{
		float num = (newPredictLength > 0f) ? newPredictLength : base.CurrentSplineMoveParams.PredictDist;
		if (!base.IsPositiveMoving)
		{
			num *= -1f;
		}
		USplineComponent spline = base.CurrentSplineMoveParams.Spline;
		float distanceAlongSplineAtSplineInputKey = spline.GetDistanceAlongSplineAtSplineInputKey(this.SplineTimeKey);
		Vector tmpVector = this.TmpVector;
		FVectorDouble fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(distanceAlongSplineAtSplineInputKey + num, ESplineCoordinateSpace.World);
		tmpVector.FromUeVector(fvectorDouble);
		if (predictRightOffset != 0f)
		{
			this.SplineQuat.GetRightVector(this.TmpVector1);
			this.TmpVector1.MultiplyEqual((double)(base.IsPositiveMoving ? predictRightOffset : (-(double)predictRightOffset)));
			this.TmpVector.AdditionEqual(this.TmpVector1);
		}
		if (this.IsDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Motor auto pilot";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TimeKey", this.SplineTimeKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", this.SplineLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("dist", distanceAlongSplineAtSplineInputKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("WithOffset", this.TmpVector);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Owner, this.ActorComp.ActorLocation, this.TmpVector.ToUeVector(false), 5f, MotorcycleSplineMoveComponent.greenColor, 0f, 10f);
		}
		this.TmpVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.TmpVector.Normalize(9.99999993922529E-09);
		float angleOffsetInGravityForActor = GravityUtils.Instance.GetAngleOffsetInGravityForActor(this.ActorComp, this.ActorComp.ActorForwardProxy, this.TmpVector);
		float num2 = angleOffsetInGravityForActor / base.CurrentSplineMoveParams.InputCorrectionBaseAngle;
		if ((double)(num2 + right) < this.VehicleActorComp.InputDirectProxy.Y)
		{
			num2 += right;
		}
		else if ((double)(num2 + left) > this.VehicleActorComp.InputDirectProxy.Y)
		{
			num2 += left;
		}
		else
		{
			num2 = (float)this.VehicleActorComp.InputDirectProxy.Y;
		}
		VehicleActorComponent vehicleActorComp = this.VehicleActorComp;
		SplineMoveParams currentSplineMoveParams = base.CurrentSplineMoveParams;
		vehicleActorComp.SetInputDirectByNumber((currentSplineMoveParams != null && currentSplineMoveParams.DisableAutoForward) ? ((float)this.VehicleActorComp.InputDirectProxy.X) : 1f, MathUtils.Instance.Clamp(num2, -1f, 1f), 0f);
		if (canAutoBrakeAndSprint)
		{
			if (Math.Abs(angleOffsetInGravityForActor) > (this.AutopilotBraking ? 30f : 90f))
			{
				this.AutopilotBraking = true;
			}
			else
			{
				this.AutopilotBraking = false;
			}
			this.AutopilotSprint = (!this.AutopilotBraking && base.CurrentSplineMoveParams.AutoSprint && MathUtils.Instance.IsNearlyZero((double)predictRightOffset, null) && this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.无限氮气.路网"]));
			return;
		}
		this.AutopilotBraking = false;
		this.AutopilotSprint = false;
	}

	// Token: 0x0601C6EA RID: 116458 RVA: 0x007F9CE8 File Offset: 0x007F7EE8
	private unsafe void InputAdjust3dInternal(float left, float right, float newPredictLength = 0f)
	{
		this.ActorComp.ActorLocationProxy.Subtraction(this.SplineLocation, this.TmpVector1);
		this.SplineQuat.UnRotateVector(this.TmpVector1, this.TmpVector1);
		if (this.TmpVector1.Normalize(9.99999993922529E-09))
		{
			this.TmpVector1.MultiplyEqual((double)(-(double)(left + right) / 2f));
		}
		else
		{
			this.TmpVector1.Reset();
		}
		float num = (right - left) / 2f;
		float num2 = (newPredictLength > 0f) ? newPredictLength : base.CurrentSplineMoveParams.PredictDist;
		if (!base.IsPositiveMoving)
		{
			num2 *= -1f;
		}
		USplineComponent spline = base.CurrentSplineMoveParams.Spline;
		float distanceAlongSplineAtSplineInputKey = spline.GetDistanceAlongSplineAtSplineInputKey(this.SplineTimeKey);
		Vector tmpVector = this.TmpVector;
		FVectorDouble fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(distanceAlongSplineAtSplineInputKey + num2, ESplineCoordinateSpace.World);
		tmpVector.FromUeVector(fvectorDouble);
		if (this.IsDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Motor auto pilot";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TimeKey", this.SplineTimeKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", this.SplineLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("dist", distanceAlongSplineAtSplineInputKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("WithOffset", this.TmpVector);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Owner, this.ActorComp.ActorLocation, this.TmpVector.ToUeVector(false), 5f, MotorcycleSplineMoveComponent.greenColor, 0f, 10f);
			this.SplineDirection.Multiply((double)(base.IsPositiveMoving ? 500 : -500), this.TmpVector);
			this.TmpVector.AdditionEqual(this.SplineLocation);
			UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Owner, this.SplineLocation.ToUeVector(false), this.TmpVector.ToUeVector(false), 5f, MotorcycleSplineMoveComponent.blueColor, 0f, 10f);
		}
		this.TmpVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.TmpVector.Normalize(9.99999993922529E-09);
		this.SplineQuat.UnRotateVector(this.TmpVector, this.TmpVector);
		double num3 = (90.0 - Math.Acos(this.TmpVector.Z) * 57.295780181884766) / (double)base.CurrentSplineMoveParams.InputCorrectionBaseAngle;
		double num4 = (!MathUtils.Instance.IsNearlyZero(this.TmpVector.X, null) || !MathUtils.Instance.IsNearlyZero(this.TmpVector.Y, null)) ? (Math.Atan2(this.TmpVector.Y, this.TmpVector.X) * 57.295780181884766 / (double)base.CurrentSplineMoveParams.InputCorrectionBaseAngle) : 0.0;
		bool isDebug = this.IsDebug;
		num3 += this.TmpVector1.Z;
		double num5 = num4 + this.TmpVector1.Y;
		this.SplineQuat.UnRotateVector(this.ActorComp.ActorForwardProxy, this.TmpVector);
		double num6 = (90.0 - Math.Acos(this.TmpVector.Z) * 57.295780181884766) / (double)base.CurrentSplineMoveParams.InputCorrectionBaseAngle;
		double num7 = (!MathUtils.Instance.IsNearlyZero(this.TmpVector.X, null) || !MathUtils.Instance.IsNearlyZero(this.TmpVector.Y, null)) ? (Math.Atan2(this.TmpVector.Y, this.TmpVector.X) * 57.295780181884766 / (double)base.CurrentSplineMoveParams.InputCorrectionBaseAngle) : 0.0;
		MotorcycleActorComponent motorcycleActorComponent = this.ActorComp as MotorcycleActorComponent;
		double num8 = num6 + motorcycleActorComponent.AirRotateInputProxy.X;
		double num9 = num7 + motorcycleActorComponent.AirRotateInputProxy.Y;
		bool isDebug2 = this.IsDebug;
		double num10 = num3 - num8;
		double num11 = num5 - num9;
		double num12 = Math.Sqrt(num10 * num10 + num11 * num11);
		if (num12 < (double)num)
		{
			return;
		}
		double num13 = (num12 - (double)num) / num12;
		num10 *= num13;
		num11 *= num13;
		this.TmpVector.Set(num10 + motorcycleActorComponent.AirRotateInputProxy.X, num11 + motorcycleActorComponent.AirRotateInputProxy.Y, 0.0);
		bool isDebug3 = this.IsDebug;
		if (false)
		{
			double num14 = this.TmpVector.SizeSquared();
			if (num14 > 1.0)
			{
				this.TmpVector.DivisionEqual(Math.Sqrt(num14));
			}
		}
		else
		{
			this.TmpVector.X = MathUtils.Instance.Clamp(this.TmpVector.X, -1.0, 1.0);
			this.TmpVector.Y = MathUtils.Instance.Clamp(this.TmpVector.Y, -1.0, 1.0);
		}
		motorcycleActorComponent.SetAirRotateInput(this.TmpVector);
	}

	// Token: 0x0601C6EB RID: 116459 RVA: 0x007FA25C File Offset: 0x007F845C
	protected unsafe override void UpdateSplineLocationAndDirection()
	{
		this.Using3d = (this.ActorComp.VehicleMoveComp.GetMotorSubState() == EMotorSubState.Soaring);
		USplineComponent spline = base.CurrentSplineMoveParams.Spline;
		float maxOffsetDist = base.CurrentSplineMoveParams.MaxOffsetDist;
		float searchRadius = MathUtils.Instance.Clamp(maxOffsetDist * 2f, 200f, 50000f);
		int num = spline.GetNumberOfSplinePoints() - 1;
		bool flag = base.CurrentSplineMoveParams.AutopilotRoute != null && this.LastTimeKey != -1f && num >= 5;
		float num2 = flag ? this.FindInputKeyInCurrentRouteRange(spline, num) : this.FindInputKeyByPartition(spline, searchRadius);
		if (num2 < 0f)
		{
			num2 = this.FindInputKeyByPartition(spline, 50000f);
		}
		if (this.IsDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "MotorSplineMove Update (Partition)";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timeKey", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UseRangeSearch", flag);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.SplineTimeKey = num2;
		Vector splineLocation = this.SplineLocation;
		FVectorDouble fvectorDouble = spline.D_GetLocationAtSplineInputKey(num2, ESplineCoordinateSpace.World);
		splineLocation.FromUeVector(fvectorDouble);
		Vector splineDirection = this.SplineDirection;
		FVector directionAtSplineInputKey = spline.GetDirectionAtSplineInputKey(num2, ESplineCoordinateSpace.World);
		fvectorDouble = directionAtSplineInputKey;
		splineDirection.DeepCopy(fvectorDouble);
		if (base.CurrentSplineMoveParams.OnlyForward || base.CurrentSplineMoveParams.OnlyPositiveMove)
		{
			base.IsPositiveMoving = true;
		}
		else
		{
			Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
			double num3 = this.SplineDirection.DotProduct(actorForwardProxy);
			base.IsPositiveMoving = (num3 >= 0.0);
		}
		if (this.IsPlannerMove())
		{
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.SplineDirection);
		}
		this.SplineDirection.Normalize(9.99999993922529E-09);
		this.ActorComp.ActorGravityDirectProxy.UnaryNegation(this.TmpVector);
		if (base.IsPositiveMoving)
		{
			this.TmpVector1.DeepCopy(this.SplineDirection);
		}
		else
		{
			this.SplineDirection.UnaryNegation(this.TmpVector1);
		}
		if (this.Using3d)
		{
			MathUtils.Instance.LookRotationForwardFirst(this.TmpVector1, this.TmpVector, this.SplineQuat);
		}
		else
		{
			MathUtils.Instance.LookRotationUpFirst(this.TmpVector1, this.TmpVector, this.SplineQuat);
		}
		base.CurrentSplineMoveParams.UpdateParamsByTimeKey(this.SplineTimeKey);
	}

	// Token: 0x0601C6EC RID: 116460 RVA: 0x007FA4DC File Offset: 0x007F86DC
	private float FindInputKeyInCurrentRouteRange(USplineComponent splineComp, int maxTimeKey)
	{
		float num = this.LastTimeKey;
		float num2 = this.LastTimeKey;
		if (base.IsPositiveMoving)
		{
			num = this.LastTimeKey - 1f;
			num2 = this.LastTimeKey + 3f;
		}
		else
		{
			num = this.LastTimeKey - 3f;
			num2 = this.LastTimeKey + 1f;
		}
		float result;
		if (!splineComp.IsClosedLoop())
		{
			FVectorDouble fvectorDouble = this.ActorComp.ActorLocation;
			result = splineComp.D_FindInputKeyClosestToWorldLocationInRange(fvectorDouble, (int)num, (int)num2);
		}
		else if (num < 0f)
		{
			FVectorDouble fvectorDouble = this.ActorComp.ActorLocation;
			float num3 = splineComp.D_FindInputKeyClosestToWorldLocationInRange(fvectorDouble, (int)(num + (float)maxTimeKey), maxTimeKey);
			fvectorDouble = this.ActorComp.ActorLocation;
			float num4 = splineComp.D_FindInputKeyClosestToWorldLocationInRange(fvectorDouble, 0, (int)num2);
			Vector tmpVector = this.TmpVector;
			fvectorDouble = splineComp.D_GetLocationAtSplineInputKey(num3, ESplineCoordinateSpace.World);
			tmpVector.FromUeVector(fvectorDouble);
			Vector tmpVector2 = this.TmpVector1;
			fvectorDouble = splineComp.D_GetLocationAtSplineInputKey(num4, ESplineCoordinateSpace.World);
			tmpVector2.FromUeVector(fvectorDouble);
			if (Vector.DistSquared(this.ActorComp.ActorLocationProxy, this.TmpVector) < Vector.DistSquared(this.ActorComp.ActorLocationProxy, this.TmpVector1))
			{
				result = num3;
			}
			else
			{
				result = num4;
			}
		}
		else if (num2 > (float)maxTimeKey)
		{
			FVectorDouble fvectorDouble = this.ActorComp.ActorLocation;
			float num5 = splineComp.D_FindInputKeyClosestToWorldLocationInRange(fvectorDouble, 0, (int)(num2 - (float)maxTimeKey));
			fvectorDouble = this.ActorComp.ActorLocation;
			float num6 = splineComp.D_FindInputKeyClosestToWorldLocationInRange(fvectorDouble, (int)num, maxTimeKey);
			Vector tmpVector3 = this.TmpVector;
			fvectorDouble = splineComp.D_GetLocationAtSplineInputKey(num5, ESplineCoordinateSpace.World);
			tmpVector3.FromUeVector(fvectorDouble);
			Vector tmpVector4 = this.TmpVector1;
			fvectorDouble = splineComp.D_GetLocationAtSplineInputKey(num6, ESplineCoordinateSpace.World);
			tmpVector4.FromUeVector(fvectorDouble);
			if (Vector.DistSquared(this.ActorComp.ActorLocationProxy, this.TmpVector) < Vector.DistSquared(this.ActorComp.ActorLocationProxy, this.TmpVector1))
			{
				result = num5;
			}
			else
			{
				result = num6;
			}
		}
		else
		{
			FVectorDouble fvectorDouble = this.ActorComp.ActorLocation;
			result = splineComp.D_FindInputKeyClosestToWorldLocationInRange(fvectorDouble, (int)num, (int)num2);
		}
		return result;
	}

	// Token: 0x0601C6ED RID: 116461 RVA: 0x007FA6CC File Offset: 0x007F88CC
	private float FindInputKeyByPartition(USplineComponent splineComp, float searchRadius)
	{
		FVectorDouble fvectorDouble;
		if (base.CurrentSplineMoveParams.UseSplineGravity || this.Using3d)
		{
			fvectorDouble = this.ActorComp.ActorLocationProxy.ToUeVector(false);
			return splineComp.D_FindInputKeyClosestToWorldLocationByPartition(fvectorDouble, searchRadius);
		}
		fvectorDouble = this.ActorComp.ActorLocationProxy.ToUeVector(false);
		return splineComp.D_FindInputKeyClosestToWorldLocationByPartitionInGravity(fvectorDouble, this.ActorComp.ActorGravityDirectProxy.ToUeVectorOld(), searchRadius, base.CurrentSplineMoveParams.LayerVerticalLimit);
	}

	// Token: 0x0601C6EE RID: 116462 RVA: 0x007FA740 File Offset: 0x007F8940
	private bool DetectRoadBlock(float detectDistance = 4000f)
	{
		float num = detectDistance;
		if (!base.IsPositiveMoving)
		{
			num *= -1f;
		}
		float distanceAlongSplineAtSplineInputKey = base.CurrentSplineMoveParams.Spline.GetDistanceAlongSplineAtSplineInputKey(this.SplineTimeKey);
		float num2 = distanceAlongSplineAtSplineInputKey + num;
		DoublyLinkedNode<MotorcycleSplineMoveComponent.RoadBlockDetectRecord> doublyLinkedNode = this.DetectedRecordList.GetHeadNode().Next;
		while (((doublyLinkedNode != null) ? doublyLinkedNode.Element : null) != null && doublyLinkedNode != this.DetectedRecordList.GetHeadNode())
		{
			DoublyLinkedNode<MotorcycleSplineMoveComponent.RoadBlockDetectRecord> next = doublyLinkedNode.Next;
			if (doublyLinkedNode.Element.DetectFrame < Time.Instance.Frame - 15)
			{
				this.DetectedRecordList.RemoveThis(doublyLinkedNode);
			}
			doublyLinkedNode = next;
		}
		this.TryRoadBlockDetect(distanceAlongSplineAtSplineInputKey, num2);
		if (this.IsDebug)
		{
			this.DrawBlockDetectRecord();
		}
		doublyLinkedNode = this.DetectedRecordList.GetHeadNode().Next;
		while (((doublyLinkedNode != null) ? doublyLinkedNode.Element : null) != null && doublyLinkedNode != this.DetectedRecordList.GetHeadNode())
		{
			MotorcycleSplineMoveComponent.RoadBlockDetectRecord element = doublyLinkedNode.Element;
			if (element.BlockDist >= 0f && element.StartDist < num2 && element.EndDist > distanceAlongSplineAtSplineInputKey)
			{
				return true;
			}
			doublyLinkedNode = doublyLinkedNode.Next;
		}
		return false;
	}

	// Token: 0x0601C6EF RID: 116463 RVA: 0x007FA850 File Offset: 0x007F8A50
	private void TryRoadBlockDetect(float startDist, float endDist)
	{
		for (int i = 0; i < 1; i++)
		{
			float num = base.IsPositiveMoving ? startDist : (-startDist);
			float num2 = base.IsPositiveMoving ? (endDist + 100f) : (-endDist - 100f);
			DoublyLinkedNode<MotorcycleSplineMoveComponent.RoadBlockDetectRecord> next = this.DetectedRecordList.GetHeadNode().Next;
			while (((next != null) ? next.Element : null) != null && next != this.DetectedRecordList.GetHeadNode())
			{
				MotorcycleSplineMoveComponent.RoadBlockDetectRecord element = next.Element;
				if (element.StartDist >= num2)
				{
					break;
				}
				if (element.StartDist > num)
				{
					num2 = element.StartDist;
					break;
				}
				if (element.EndDist >= num2)
				{
					num = 0f;
					num2 = 0f;
					break;
				}
				num = element.EndDist;
				next = next.Next;
			}
			if (num >= num2 || num >= endDist)
			{
				break;
			}
			this.TryRoadBlockDetectOnePiece(num, num2, (next != null) ? next.Pre : null);
		}
	}

	// Token: 0x0601C6F0 RID: 116464 RVA: 0x007FA930 File Offset: 0x007F8B30
	private bool TryRoadBlockDetectOnePiece(float inStartDist, float inEndDist, [Nullable(new byte[]
	{
		2,
		1
	})] DoublyLinkedNode<MotorcycleSplineMoveComponent.RoadBlockDetectRecord> currentNode)
	{
		float num = Math.Abs(inStartDist);
		float num2 = Math.Abs(inEndDist);
		USplineComponent spline = base.CurrentSplineMoveParams.Spline;
		Vector tmpVector = this.TmpVector;
		FVectorDouble fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(num, ESplineCoordinateSpace.World);
		tmpVector.FromUeVector(fvectorDouble);
		Vector tmpVector2 = this.TmpVector2;
		FVector directionAtDistanceAlongSpline = spline.GetDirectionAtDistanceAlongSpline(num, ESplineCoordinateSpace.World);
		tmpVector2.FromUeVector(directionAtDistanceAlongSpline);
		float num3 = num2;
		while (Math.Abs(num3 - num) > MotorcycleSplineMoveComponent.MIN_DETECT_DIST * 2f)
		{
			Vector tmpVector3 = this.TmpVector1;
			fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(num3, ESplineCoordinateSpace.World);
			tmpVector3.FromUeVector(fvectorDouble);
			this.TmpVector1.SubtractionEqual(this.TmpVector);
			if (!this.TmpVector1.Normalize(9.99999993922529E-09) || Vector.DotProduct(this.TmpVector1, this.TmpVector2) > MotorcycleSplineMoveComponent.ROAD_BLOCK_DETECT_MAX_ANGLE_COS)
			{
				break;
			}
			num3 = (num3 + num) * 0.5f;
		}
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Owner;
		actorTrace.Radius = 15f;
		actorTrace.ActorsToIgnore.Empty(true);
		VehiclePerformComponent performComp = this.PerformComp;
		AActor aactor;
		if (performComp == null)
		{
			aactor = null;
		}
		else
		{
			Entity driver = performComp.Driver;
			if (driver == null)
			{
				aactor = null;
			}
			else
			{
				BaseActorComponent component = driver.GetComponent<BaseActorComponent>();
				aactor = ((component != null) ? component.Owner : null);
			}
		}
		AActor aactor2 = aactor;
		if (aactor2 != null)
		{
			actorTrace.ActorsToIgnore.Add(aactor2);
		}
		BaseActorComponent actorComp = this.ActorComp;
		Vector vector;
		if (actorComp == null)
		{
			vector = null;
		}
		else
		{
			BaseMoveComponent moveComp = actorComp.MoveComp;
			vector = ((moveComp != null) ? moveComp.GravityDirect : null);
		}
		Vector gravityDirect = vector ?? Vector.DownVectorProxy;
		GravityUtils.Instance.AddZnInGravity(gravityDirect, this.TmpVector, 100.0);
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.TmpVector);
		Vector tmpVector4 = this.TmpVector1;
		fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(num3, ESplineCoordinateSpace.World);
		tmpVector4.FromUeVector(fvectorDouble);
		GravityUtils.Instance.AddZnInGravity(gravityDirect, this.TmpVector1, 100.0);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TmpVector1);
		UCapsuleComponent capsuleComponent = this.VehicleActorComp.VehicleOwner.CapsuleComponent;
		bool flag = TraceElementCommon.Instance.ShapeTrace(capsuleComponent, actorTrace, "Motor SplineMove RoadBlock", "Motor SplineMove RoadBlock");
		MotorcycleSplineMoveComponent.RoadBlockDetectRecord roadBlockDetectRecord = new MotorcycleSplineMoveComponent.RoadBlockDetectRecord();
		roadBlockDetectRecord.StartDist = inStartDist;
		roadBlockDetectRecord.EndDist = (float)Math.Sign(num2) * num3;
		roadBlockDetectRecord.DetectFrame = Time.Instance.Frame;
		if (flag)
		{
			roadBlockDetectRecord.BlockDist = actorTrace.HitResult.TimeArray.Get(0) * (roadBlockDetectRecord.EndDist - roadBlockDetectRecord.StartDist);
		}
		else
		{
			roadBlockDetectRecord.BlockDist = -1f;
		}
		if (currentNode != null)
		{
			this.DetectedRecordList.Insert(roadBlockDetectRecord, currentNode);
			return flag;
		}
		this.DetectedRecordList.AddTail(roadBlockDetectRecord);
		return flag;
	}

	// Token: 0x0601C6F1 RID: 116465 RVA: 0x007FABC8 File Offset: 0x007F8DC8
	private void DrawBlockDetectRecord()
	{
		USplineComponent spline = base.CurrentSplineMoveParams.Spline;
		DoublyLinkedNode<MotorcycleSplineMoveComponent.RoadBlockDetectRecord> next = this.DetectedRecordList.GetHeadNode().Next;
		BaseActorComponent actorComp = this.ActorComp;
		Vector vector;
		if (actorComp == null)
		{
			vector = null;
		}
		else
		{
			BaseMoveComponent moveComp = actorComp.MoveComp;
			vector = ((moveComp != null) ? moveComp.GravityDirect : null);
		}
		Vector gravityDirect = vector ?? Vector.DownVectorProxy;
		while (((next != null) ? next.Element : null) != null && next != this.DetectedRecordList.GetHeadNode())
		{
			MotorcycleSplineMoveComponent.RoadBlockDetectRecord element = next.Element;
			float num = element.StartDist;
			FVectorDouble fvectorDouble;
			if (element.BlockDist >= 0f)
			{
				num += element.BlockDist;
				Vector tmpVector = this.TmpVector;
				fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(Math.Abs(element.StartDist), ESplineCoordinateSpace.World);
				tmpVector.FromUeVector(fvectorDouble);
				GravityUtils.Instance.AddZnInGravity(gravityDirect, this.TmpVector, 100.0);
				Vector tmpVector2 = this.TmpVector1;
				fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(Math.Abs(num), ESplineCoordinateSpace.World);
				tmpVector2.FromUeVector(fvectorDouble);
				GravityUtils.Instance.AddZnInGravity(gravityDirect, this.TmpVector1, 100.0);
				UKismetSystemLibrary.D_DrawDebugLine(this.ActorComp.Owner, this.TmpVector.ToUeVector(false), this.TmpVector1.ToUeVector(false), MotorcycleSplineMoveComponent.redColor, 0.05f, 25f);
			}
			Vector tmpVector3 = this.TmpVector;
			fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(Math.Abs(num), ESplineCoordinateSpace.World);
			tmpVector3.FromUeVector(fvectorDouble);
			GravityUtils.Instance.AddZnInGravity(gravityDirect, this.TmpVector, 100.0);
			Vector tmpVector4 = this.TmpVector1;
			fvectorDouble = spline.D_GetLocationAtDistanceAlongSpline(Math.Abs(element.EndDist), ESplineCoordinateSpace.World);
			tmpVector4.FromUeVector(fvectorDouble);
			GravityUtils.Instance.AddZnInGravity(gravityDirect, this.TmpVector1, 100.0);
			UKismetSystemLibrary.D_DrawDebugLine(this.ActorComp.Owner, this.TmpVector.ToUeVector(false), this.TmpVector1.ToUeVector(false), MotorcycleSplineMoveComponent.greenColor, 0.05f, 25f);
			next = next.Next;
		}
	}

	// Token: 0x0601C6F2 RID: 116466 RVA: 0x007FADC5 File Offset: 0x007F8FC5
	protected override void OnSelectNextSplineMoveBegin()
	{
		this.AutopilotBraking = false;
		this.AutopilotSprint = false;
		base.OnSelectNextSplineMoveBegin();
	}

	// Token: 0x0601C6F3 RID: 116467 RVA: 0x007FADDB File Offset: 0x007F8FDB
	protected override void OnSelectNextSplineMoveEnd()
	{
		base.OnSelectNextSplineMoveEnd();
		MotorcycleInputComponent component = base.Entity.GetComponent<MotorcycleInputComponent>();
		if (component != null)
		{
			component.ForceRefreshBraking();
		}
		this.DetectedRecordList.RemoveAllNodeWithoutHead();
	}

	// Token: 0x0601C6F4 RID: 116468 RVA: 0x007FAE04 File Offset: 0x007F9004
	public void ForceClearUpdate()
	{
		this.LastTimeKey = -1f;
	}

	// Token: 0x0601C6F5 RID: 116469 RVA: 0x007FAE14 File Offset: 0x007F9014
	protected override void UpdateSplineGravity(ESplineGravityUpdateType type)
	{
		base.UpdateSplineGravity(type);
		if (this.IsDebug)
		{
			SplineMoveParams currentSplineMoveParams = base.CurrentSplineMoveParams;
			if (currentSplineMoveParams != null && currentSplineMoveParams.UseSplineGravity)
			{
				this.TmpVector.DeepCopy(this.VehicleActorComp.VehicleMoveComp.GravityUp);
				this.TmpVector.MultiplyEqual(300.0);
				this.TmpVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
				UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Owner, this.ActorComp.ActorLocation, this.TmpVector.ToUeVector(false), 5f, MotorcycleSplineMoveComponent.yellowColor, 0f, 10f);
				Vector tmpVector = this.TmpVector;
				FVector motorNormal = this.ActorComp.VehicleMoveComp.VehicleMovement.GetMotorNormal();
				tmpVector.FromUeVector(motorNormal);
				this.TmpVector.MultiplyEqual(300.0);
				this.TmpVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
				UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Owner, this.ActorComp.ActorLocation, this.TmpVector.ToUeVector(false), 5f, MotorcycleSplineMoveComponent.blueColor, 0f, 10f);
			}
		}
	}

	// Token: 0x0601C6F6 RID: 116470 RVA: 0x007FAF56 File Offset: 0x007F9156
	protected override void OnPositiveMovingChanged()
	{
		this.DetectedRecordList.RemoveAllNodeWithoutHead();
	}

	// Token: 0x0601C6F7 RID: 116471 RVA: 0x007FAF64 File Offset: 0x007F9164
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleSplineMoveComponent motorcycleSplineMoveComponent = (MotorcycleSplineMoveComponent)componentTemplate;
		if (base.CanResetComponentProperty("OnTick1") && motorcycleSplineMoveComponent.OnTick1 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.OnTick1), "OnTick1"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("QuatDelta"))
		{
			if (motorcycleSplineMoveComponent.QuatDelta == null)
			{
				this.QuatDelta = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.QuatDelta), "QuatDelta"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveDelta"))
		{
			if (motorcycleSplineMoveComponent.MoveDelta == null)
			{
				this.MoveDelta = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.MoveDelta), "MoveDelta"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AutopilotBrakingInternal"))
		{
			this.AutopilotBrakingInternal = motorcycleSplineMoveComponent.AutopilotBrakingInternal;
		}
		if (base.CanResetComponentProperty("AutopilotSprintInternal"))
		{
			this.AutopilotSprintInternal = motorcycleSplineMoveComponent.AutopilotSprintInternal;
		}
		if (base.CanResetComponentProperty("DetectedRecordList"))
		{
			if (motorcycleSplineMoveComponent.DetectedRecordList == null)
			{
				this.DetectedRecordList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DoublyLinkedList<MotorcycleSplineMoveComponent.RoadBlockDetectRecord>>(this.DetectedRecordList), "DetectedRecordList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsDebug"))
		{
			this.IsDebug = motorcycleSplineMoveComponent.IsDebug;
		}
		return true;
	}

	// Token: 0x0400E1AD RID: 57773
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor redColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400E1AE RID: 57774
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor greenColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400E1AF RID: 57775
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor yellowColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x0400E1B0 RID: 57776
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor blueColor = new FLinearColor(0f, 0f, 1f, 1f);

	// Token: 0x0400E1B1 RID: 57777
	private const float AUTOPILOT_BRAKING_THRESHOLD_MIN = 30f;

	// Token: 0x0400E1B2 RID: 57778
	private const float AUTOPILOT_BRAKING_THRESHOLD_MAX = 90f;

	// Token: 0x0400E1B3 RID: 57779
	private const float ROAD_BLOCK_DETECT_RADIUS = 15f;

	// Token: 0x0400E1B4 RID: 57780
	private const float ROAD_BLOCK_DETECT_DIS = 4000f;

	// Token: 0x0400E1B5 RID: 57781
	private const float ROAD_BLOCK_DETECT_MAX_ANGLE = 10f;

	// Token: 0x0400E1B6 RID: 57782
	[StaticVariableRuleIgnore]
	private static readonly double ROAD_BLOCK_DETECT_MAX_ANGLE_COS = Math.Cos(0.1745329201221466);

	// Token: 0x0400E1B7 RID: 57783
	private const float ROAD_BLOCK_DETECT_HEIGHT = 100f;

	// Token: 0x0400E1B8 RID: 57784
	private const float ROAD_BLOCK_RIGHT_OFFSET = -500f;

	// Token: 0x0400E1B9 RID: 57785
	private const float ROAD_BLOCK_NEW_PREDICT_DIST = 1000f;

	// Token: 0x0400E1BA RID: 57786
	private const float ROAD_BLOCK_DETECT_ADD_DIST_AT_END = 100f;

	// Token: 0x0400E1BB RID: 57787
	private const int MAX_DETECT_TIMES_ONE_FRAME = 1;

	// Token: 0x0400E1BC RID: 57788
	private const int PARTITION_SEARCH_RADIUS_MIN = 200;

	// Token: 0x0400E1BD RID: 57789
	private const int PARTITION_SEARCH_RADIUS_MAX = 50000;

	// Token: 0x0400E1BE RID: 57790
	private const int ROAD_BLOCK_DETECTE_MAX_CACHE_FRAME = 15;

	// Token: 0x0400E1BF RID: 57791
	[StaticVariableRuleIgnore]
	private static readonly float MIN_DETECT_DIST = 266.66666f;

	// Token: 0x0400E1C0 RID: 57792
	private const string PROFILE_KEY = "Motor SplineMove RoadBlock";

	// Token: 0x0400E1C1 RID: 57793
	private readonly Stat OnTick1 = Stat.Create("MotorcycleSplineMoveComponent Tick", "", "");

	// Token: 0x0400E1C2 RID: 57794
	protected Quat QuatDelta = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E1C3 RID: 57795
	protected Vector MoveDelta = Vector.Create();

	// Token: 0x0400E1C4 RID: 57796
	protected bool AutopilotBrakingInternal;

	// Token: 0x0400E1C5 RID: 57797
	protected bool AutopilotSprintInternal;

	// Token: 0x0400E1C6 RID: 57798
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private DoublyLinkedList<MotorcycleSplineMoveComponent.RoadBlockDetectRecord> DetectedRecordList;

	// Token: 0x0400E1C7 RID: 57799
	public bool IsDebug;

	// Token: 0x0200978A RID: 38794
	[NullableContext(0)]
	public class RoadBlockDetectRecord
	{
		// Token: 0x04030711 RID: 198417
		public float StartDist;

		// Token: 0x04030712 RID: 198418
		public float EndDist;

		// Token: 0x04030713 RID: 198419
		public int DetectFrame = -1;

		// Token: 0x04030714 RID: 198420
		public float BlockDist = -1f;
	}
}
