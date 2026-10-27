using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020032E2 RID: 13026
[NullableContext(1)]
[Nullable(0)]
public class MotorcyclePathMoveTask : VehiclePathMoveTask
{
	// Token: 0x0601C55F RID: 116063 RVA: 0x007EBF0C File Offset: 0x007EA10C
	public MotorcyclePathMoveTask(Entity entity, PathCurveInfo curveInfo, MoveStateInfo stateInfo) : base(entity, curveInfo, stateInfo)
	{
	}

	// Token: 0x0601C560 RID: 116064 RVA: 0x007EBF64 File Offset: 0x007EA164
	public override bool Update(float delta)
	{
		if (this.CurveInfo == null || this.StateInfo == null)
		{
			return false;
		}
		if (this.VehicleEntity == null || !this.VehicleEntity.Valid)
		{
			return false;
		}
		float timeDilation = this.VehicleEntity.TimeDilation;
		base.UpdateRatio(delta * timeDilation);
		this.UpdateTransform(delta * timeDilation);
		return true;
	}

	// Token: 0x0601C561 RID: 116065 RVA: 0x007EBFBC File Offset: 0x007EA1BC
	protected override void UpdateTransform(float delta)
	{
		MotorcyclePathMoveTask.<>c__DisplayClass11_0 CS$<>8__locals1 = new MotorcyclePathMoveTask.<>c__DisplayClass11_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.StateInfo == null || this.CurveInfo == null)
		{
			return;
		}
		base.GetRawUpdateTransform(this.TmpTrans);
		if (this.SimulateRotation)
		{
			this.AdjustSplineTransform(this.TmpTrans);
		}
		else if (this.KeepForward)
		{
			this.AdjustKeepForwardSplineTransform(this.TmpTrans);
		}
		Quat actorQuatProxy = this.ActorComp.ActorQuatProxy;
		float num = 180f * delta;
		float num2 = MathCommon.RadianToDegree((float)Quat.AngularDistance(actorQuatProxy, this.TmpTrans.GetRotation()));
		MathUtils instance = MathUtils.Instance;
		float num3 = (instance != null) ? instance.Clamp(num / num2, 0f, 1f) : 1f;
		Quat.Slerp(actorQuatProxy, this.TmpTrans.GetRotation(), num3, this.TmpQuat);
		CS$<>8__locals1.targetRotation = this.TmpQuat.Rotator(null).ToUeRotator();
		MotorcyclePathMoveTask.<>c__DisplayClass11_0 CS$<>8__locals2 = CS$<>8__locals1;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
		defaultInterpolatedStringHandler.AppendLiteral("VehiclePathMoveController.Update(SplineId:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurveInfo.SplineId);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		CS$<>8__locals2.context = defaultInterpolatedStringHandler.ToStringAndClear();
		this.AnimComp.Value.Switch(delegate(CharacterAnimationComponent t1)
		{
			t1.SetLocationAndRotatorWithKeepingModelBuffer(CS$<>8__locals1.<>4__this.TmpTrans.GetLocation().ToUeVector(false), CS$<>8__locals1.targetRotation, 0f, CS$<>8__locals1.context, ESetRotationPriority.Anim);
		}, delegate(VehicleAnimationComponent t2)
		{
			t2.SetLocationAndRotatorWithKeepingModelBuffer(CS$<>8__locals1.<>4__this.TmpTrans.GetLocation().ToUeVector(false), CS$<>8__locals1.targetRotation, 0f, CS$<>8__locals1.context, ESetRotationPriority.Anim);
		});
	}

	// Token: 0x0601C562 RID: 116066 RVA: 0x007EC108 File Offset: 0x007EA308
	private UTraceSphereElement CreateTraceElement()
	{
		UTraceSphereElement utraceSphereElement = new UTraceSphereElement();
		utraceSphereElement.bIsSingle = true;
		utraceSphereElement.bIgnoreSelf = true;
		utraceSphereElement.WorldContextObject = this.ActorComp.Owner;
		utraceSphereElement.Radius = 30f;
		utraceSphereElement.bTraceComplex = false;
		utraceSphereElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
		utraceSphereElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		return utraceSphereElement;
	}

	// Token: 0x0601C563 RID: 116067 RVA: 0x007EC161 File Offset: 0x007EA361
	public override void GetTransformAtSplineIndex(int index, Transform outTransform)
	{
		this.CurveInfo.SplineCurve.GetTransformAtSplineIndex(index, ESplineCoordinateSpace.World, outTransform);
		if (this.SimulateRotation)
		{
			this.AdjustSplineTransform(outTransform);
			return;
		}
		if (this.KeepForward)
		{
			this.AdjustKeepForwardSplineTransform(this.TmpTrans);
		}
	}

	// Token: 0x0601C564 RID: 116068 RVA: 0x007EC19C File Offset: 0x007EA39C
	private void AdjustSplineTransform(Transform outTransform)
	{
		if (this.StateInfo == null || this.CurveInfo == null)
		{
			return;
		}
		if (this.TraceElement == null)
		{
			this.TraceElement = this.CreateTraceElement();
		}
		float traceStartOffset = this.TraceStartOffset;
		float traceLength = this.TraceLength;
		outTransform.GetRotation().RotateVector(Vector.UpVectorProxy, this.UpDirection);
		Vector tmpVector = this.TmpVector;
		this.UpDirection.GetSafeNormal(tmpVector, 9.99999993922529E-09);
		tmpVector.MultiplyEqual((double)traceStartOffset);
		tmpVector.AdditionEqual(outTransform.GetLocation());
		Vector tmpVector2 = this.TmpVector2;
		this.UpDirection.GetSafeNormal(tmpVector2, 9.99999993922529E-09);
		tmpVector2.MultiplyEqual((double)(-(double)traceLength));
		tmpVector2.AdditionEqual(outTransform.GetLocation());
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, tmpVector);
		TraceElementCommon.Instance.SetEndLocation(this.TraceElement, tmpVector2);
		if (TraceElementCommon.Instance.SphereTrace(this.TraceElement, "BuildWallSpline") && this.TraceElement.HitResult != null)
		{
			Vector tmpVector3 = this.TmpVector;
			TraceElementCommon instance = TraceElementCommon.Instance;
			if (instance != null)
			{
				instance.GetImpactPoint(this.TraceElement.HitResult, 0, tmpVector3);
			}
			Vector tmpVector4 = this.TmpVector1;
			TraceElementCommon instance2 = TraceElementCommon.Instance;
			if (instance2 != null)
			{
				instance2.GetImpactNormal(this.TraceElement.HitResult, 0, tmpVector4);
			}
			tmpVector4.Multiply(50.0, this.TmpVector2);
			tmpVector3.AdditionEqual(this.TmpVector2);
			Vector tmpVector5 = this.TmpVector2;
			this.CurveInfo.SplineCurve.GetDirectionAtRateAlongSpline((float)this.StateInfo.PathRatio, ESplineCoordinateSpace.World, tmpVector5);
			tmpVector5.Normalize(9.99999993922529E-09);
			Vector vector = tmpVector4;
			vector.Normalize(9.99999993922529E-09);
			Vector tmpVector6 = this.TmpVector3;
			Vector.CrossProduct(vector, tmpVector5, tmpVector6);
			tmpVector6.Normalize(9.99999993922529E-09);
			FRotator frotator = UKismetMathLibrary.MakeRotationFromAxes(tmpVector5.ToUeVectorOld(), tmpVector6.ToUeVectorOld(), vector.ToUeVectorOld());
			this.TmpRotator.DeepCopy(frotator);
			Quat rotation = this.TmpRotator.Quaternion(null);
			outTransform.SetLocation(tmpVector3);
			outTransform.SetRotation(rotation);
		}
	}

	// Token: 0x0601C565 RID: 116069 RVA: 0x007EC3CC File Offset: 0x007EA5CC
	private void AdjustKeepForwardSplineTransform(Transform outTransform)
	{
		outTransform.GetRotation().RotateVector(Vector.UpVectorProxy, this.TmpVector);
		Vector tmpVector = this.TmpVector3;
		Vector.CrossProduct(this.TmpVector, this.ActorComp.ActorForwardProxy, tmpVector);
		FRotator frotator = UKismetMathLibrary.MakeRotationFromAxes(this.ActorComp.ActorForwardProxy.ToUeVectorOld(), tmpVector.ToUeVectorOld(), this.TmpVector.ToUeVectorOld());
		this.TmpRotator.DeepCopy(frotator);
		Quat rotation = this.TmpRotator.Quaternion(null);
		outTransform.SetRotation(rotation);
	}

	// Token: 0x0400E08C RID: 57484
	private const int MaxDegreePreSecond = 180;

	// Token: 0x0400E08D RID: 57485
	public float TraceLength = 1000f;

	// Token: 0x0400E08E RID: 57486
	public float TraceStartOffset = 500f;

	// Token: 0x0400E08F RID: 57487
	private const int MotorcycleOffset = 50;

	// Token: 0x0400E090 RID: 57488
	[Nullable(2)]
	private UTraceSphereElement TraceElement;

	// Token: 0x0400E091 RID: 57489
	private readonly Vector UpDirection = Vector.Create();

	// Token: 0x0400E092 RID: 57490
	protected Vector TmpVector1 = Vector.Create();

	// Token: 0x0400E093 RID: 57491
	protected Vector TmpVector3 = Vector.Create();

	// Token: 0x0400E094 RID: 57492
	protected Rotator TmpRotator = Rotator.Create();
}
