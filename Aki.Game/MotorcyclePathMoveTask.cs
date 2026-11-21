using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002854 RID: 10324
[NullableContext(1)]
[Nullable(0)]
public class MotorcyclePathMoveTask : VehiclePathMoveTask
{
	// Token: 0x0601A205 RID: 107013 RVA: 0x00812694 File Offset: 0x00810894
	public MotorcyclePathMoveTask(Entity entity, PathCurveInfo curveInfo, MoveStateInfo stateInfo) : base(entity, curveInfo, stateInfo)
	{
	}

	// Token: 0x0601A206 RID: 107014 RVA: 0x008126EC File Offset: 0x008108EC
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

	// Token: 0x0601A207 RID: 107015 RVA: 0x00812744 File Offset: 0x00810944
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

	// Token: 0x0601A208 RID: 107016 RVA: 0x00812890 File Offset: 0x00810A90
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

	// Token: 0x0601A209 RID: 107017 RVA: 0x008128E9 File Offset: 0x00810AE9
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

	// Token: 0x0601A20A RID: 107018 RVA: 0x00812924 File Offset: 0x00810B24
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

	// Token: 0x0601A20B RID: 107019 RVA: 0x00812B54 File Offset: 0x00810D54
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

	// Token: 0x0400E537 RID: 58679
	private const int MaxDegreePreSecond = 180;

	// Token: 0x0400E538 RID: 58680
	public float TraceLength = 1000f;

	// Token: 0x0400E539 RID: 58681
	public float TraceStartOffset = 500f;

	// Token: 0x0400E53A RID: 58682
	private const int MotorcycleOffset = 50;

	// Token: 0x0400E53B RID: 58683
	[Nullable(2)]
	private UTraceSphereElement TraceElement;

	// Token: 0x0400E53C RID: 58684
	private readonly Vector UpDirection = Vector.Create();

	// Token: 0x0400E53D RID: 58685
	protected Vector TmpVector1 = Vector.Create();

	// Token: 0x0400E53E RID: 58686
	protected Vector TmpVector3 = Vector.Create();

	// Token: 0x0400E53F RID: 58687
	protected Rotator TmpRotator = Rotator.Create();
}
