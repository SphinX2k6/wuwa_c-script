using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200272E RID: 10030
[NullableContext(1)]
[Nullable(0)]
public class LocomotionUtils
{
	// Token: 0x06019266 RID: 103014 RVA: 0x007AADF8 File Offset: 0x007A8FF8
	private static EDetectCapsuleResult DetectCapsuleSizeLocationInternal(UShapeComponent shape, UTraceCapsuleElement element, UTraceSphereElement element2, Vector start, Vector outVector)
	{
		TraceElementCommon.Instance.SetStartLocation(element, start);
		if (!TraceElementCommon.Instance.ShapeTrace(shape, element, "DetectCapsuleSizeLocation", "DetectCapsuleSizeLocation") || element.HitResult == null)
		{
			return EDetectCapsuleResult.None;
		}
		if (element.HitResult.bStartPenetrating || (double)element.HitResult.TimeArray.Get(0) <= 1E-08)
		{
			return EDetectCapsuleResult.StartPenetrate;
		}
		TraceElementCommon.Instance.SetEndLocation(element2, start);
		if (TraceElementCommon.Instance.ShapeTrace(shape, element2, "DetectCapsuleSizeLocation", "DetectCapsuleSizeLocation") && element2.HitResult != null && element2.HitResult.GetHitCount() > 0 && element2.HitResult.TimeArray.Get(0) < 0.95f)
		{
			return EDetectCapsuleResult.None;
		}
		TraceElementCommon.Instance.GetHitLocation(element.HitResult, 0, outVector);
		return EDetectCapsuleResult.NormalHit;
	}

	// Token: 0x06019267 RID: 103015 RVA: 0x007AAEC8 File Offset: 0x007A90C8
	public static EResultForExitClimb FindSpaceForExitClimb(CharacterActorComponent actorComp, float halfHeight, float radius, float minRadius, Vector outVector)
	{
		UCapsuleComponent capsuleComponent = actorComp.Actor.CapsuleComponent;
		if (capsuleComponent == null)
		{
			return EResultForExitClimb.NoHit;
		}
		UTraceCapsuleElement capsuleTrace = TraceElementModel.Instance.GetCapsuleTrace();
		capsuleTrace.WorldContextObject = actorComp.Actor;
		capsuleTrace.Radius = radius;
		capsuleTrace.HalfHeight = halfHeight;
		actorComp.ActorUpProxy.Multiply(1.0, LocomotionUtils.TmpVector);
		LocomotionUtils.TmpVector.AdditionEqual(actorComp.ActorLocationProxy);
		TraceElementCommon.Instance.SetStartLocation(capsuleTrace, LocomotionUtils.TmpVector);
		TraceElementCommon.Instance.SetEndLocation(capsuleTrace, actorComp.ActorLocationProxy);
		capsuleTrace.ActorsToIgnore.Empty(true);
		if (!TraceElementCommon.Instance.ShapeTrace(capsuleComponent, capsuleTrace, "DetectCapsuleSizeLocation", "DetectCapsuleSizeLocation") || capsuleTrace.HitResult == null)
		{
			return EResultForExitClimb.NoHit;
		}
		if (!capsuleTrace.HitResult.bStartPenetrating && (double)capsuleTrace.HitResult.TimeArray.Get(0) > 1E-08)
		{
			TraceElementCommon.Instance.GetHitLocation(capsuleTrace.HitResult, 0, outVector);
			return EResultForExitClimb.Safety;
		}
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = actorComp.Actor;
		actorTrace.Radius = minRadius;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, actorComp.ActorLocationProxy);
		actorComp.ActorUpProxy.Multiply((double)(halfHeight / 2f), LocomotionUtils.TmpVector2);
		actorComp.ActorLocationProxy.Addition(LocomotionUtils.TmpVector2, LocomotionUtils.TmpVector);
		EDetectCapsuleResult edetectCapsuleResult = LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector);
		if (edetectCapsuleResult == EDetectCapsuleResult.NormalHit)
		{
			return EResultForExitClimb.Safety;
		}
		if (edetectCapsuleResult == EDetectCapsuleResult.StartPenetrate)
		{
			LocomotionUtils.TmpVector.AdditionEqual(LocomotionUtils.TmpVector2);
			if (LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector) == EDetectCapsuleResult.NormalHit)
			{
				return EResultForExitClimb.Safety;
			}
		}
		actorComp.ActorForwardProxy.Multiply((double)(-(double)radius), LocomotionUtils.TmpVector2);
		actorComp.ActorLocationProxy.Addition(LocomotionUtils.TmpVector2, LocomotionUtils.TmpVector);
		edetectCapsuleResult = LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector);
		if (edetectCapsuleResult == EDetectCapsuleResult.NormalHit)
		{
			return EResultForExitClimb.Safety;
		}
		if (edetectCapsuleResult == EDetectCapsuleResult.StartPenetrate)
		{
			LocomotionUtils.TmpVector.AdditionEqual(LocomotionUtils.TmpVector2);
			if (LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector) == EDetectCapsuleResult.NormalHit)
			{
				return EResultForExitClimb.Safety;
			}
		}
		actorComp.ActorUpProxy.Multiply((double)halfHeight, LocomotionUtils.TmpVector);
		LocomotionUtils.TmpVector2.AdditionEqual(LocomotionUtils.TmpVector);
		actorComp.ActorLocationProxy.Addition(LocomotionUtils.TmpVector2, LocomotionUtils.TmpVector);
		edetectCapsuleResult = LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector);
		if (edetectCapsuleResult == EDetectCapsuleResult.NormalHit)
		{
			return EResultForExitClimb.Safety;
		}
		if (edetectCapsuleResult == EDetectCapsuleResult.StartPenetrate)
		{
			LocomotionUtils.TmpVector.AdditionEqual(LocomotionUtils.TmpVector2);
			if (LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector) == EDetectCapsuleResult.NormalHit)
			{
				return EResultForExitClimb.Safety;
			}
		}
		return EResultForExitClimb.NoSafety;
	}

	// Token: 0x06019268 RID: 103016 RVA: 0x007AB140 File Offset: 0x007A9340
	public static bool FindSpaceForSafety(CharacterActorComponent actorComp, float halfHeight, float radius, Vector outVector)
	{
		UCapsuleComponent capsuleComponent = actorComp.Actor.CapsuleComponent;
		if (capsuleComponent == null)
		{
			return false;
		}
		UTraceCapsuleElement capsuleTrace = TraceElementModel.Instance.GetCapsuleTrace();
		capsuleTrace.WorldContextObject = actorComp.Actor;
		capsuleTrace.Radius = radius;
		capsuleTrace.HalfHeight = halfHeight;
		TraceElementCommon.Instance.SetEndLocation(capsuleTrace, actorComp.ActorLocationProxy);
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = actorComp.Actor;
		actorTrace.Radius = 1f;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, actorComp.ActorLocationProxy);
		foreach (Vector inV in new Vector[]
		{
			Vector.Create(0.0, 0.0, (double)(halfHeight / 2f)),
			Vector.Create((double)(radius * 4f), 0.0, (double)(halfHeight / 2f)),
			Vector.Create((double)(-(double)radius * 4f), 0.0, (double)(halfHeight / 2f)),
			Vector.Create(0.0, (double)(radius * 4f), (double)(halfHeight / 2f)),
			Vector.Create(0.0, (double)(-(double)radius * 4f), (double)(halfHeight / 2f)),
			Vector.Create((double)(LocomotionUtils.SinCos45 * radius * 4f), (double)(LocomotionUtils.SinCos45 * radius * 4f), (double)(halfHeight / 2f)),
			Vector.Create((double)(-(double)LocomotionUtils.SinCos45 * radius * 4f), (double)(LocomotionUtils.SinCos45 * radius * 4f), (double)(halfHeight / 2f)),
			Vector.Create((double)(LocomotionUtils.SinCos45 * radius * 4f), (double)(-(double)LocomotionUtils.SinCos45 * radius * 4f), (double)(halfHeight / 2f)),
			Vector.Create((double)(-(double)LocomotionUtils.SinCos45 * radius * 4f), (double)(-(double)LocomotionUtils.SinCos45 * radius * 4f), (double)(halfHeight / 2f))
		})
		{
			actorComp.ActorQuatProxy.RotateVector(inV, LocomotionUtils.TmpVector2);
			actorComp.ActorLocationProxy.Addition(LocomotionUtils.TmpVector2, LocomotionUtils.TmpVector);
			EDetectCapsuleResult edetectCapsuleResult = LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector);
			if (edetectCapsuleResult == EDetectCapsuleResult.NormalHit)
			{
				return true;
			}
			if (edetectCapsuleResult == EDetectCapsuleResult.StartPenetrate)
			{
				LocomotionUtils.TmpVector.AdditionEqual(LocomotionUtils.TmpVector2);
				if (LocomotionUtils.DetectCapsuleSizeLocationInternal(capsuleComponent, capsuleTrace, actorTrace, LocomotionUtils.TmpVector, outVector) == EDetectCapsuleResult.NormalHit)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0400DBCF RID: 56271
	private const string PROFILE_KEY = "DetectCapsuleSizeLocation";

	// Token: 0x0400DBD0 RID: 56272
	private const float HIT_TIME_THREHOLD = 0.95f;

	// Token: 0x0400DBD1 RID: 56273
	[StaticVariableRuleIgnore]
	private static readonly float SinCos45 = (float)Math.Cos(0.7853981633974483);

	// Token: 0x0400DBD2 RID: 56274
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400DBD3 RID: 56275
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();
}
