using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.AI.AIMoveSplineCount;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002522 RID: 9506
public class GameplayCueMoveSpline : GameplayCueEffect
{
	// Token: 0x06017830 RID: 96304 RVA: 0x006F0240 File Offset: 0x006EE440
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (!EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			return;
		}
		AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(this.EffectViewHandle);
		if (sureEffectActor != null)
		{
			MoveSplineAI_C.元素球跟随(delta, sureEffectActor, this.ActorInternal as TsBaseCharacter, this.KuroMoveSplineInternal, this.SplinePosition, 520f, 20f, this.SplineRotationSpeedAccumulation, this.IsBackward, null, ref this.SplinePosition, ref this.SplineRotationSpeedAccumulation, ref this.IsBackward);
		}
	}

	// Token: 0x06017831 RID: 96305 RVA: 0x006F02C2 File Offset: 0x006EE4C2
	protected override void OnDestroy()
	{
		ActorSystem.Instance.Put("GameplayCueMoveSpline.OnDestroy", this.KuroMoveSplineInternal.GetOwner(), null);
		base.OnDestroy();
	}

	// Token: 0x06017832 RID: 96306 RVA: 0x006F02E8 File Offset: 0x006EE4E8
	protected unsafe override void AttachEffect(bool _ = false)
	{
		<>y__InlineArray4<FVector> <>y__InlineArray = default(<>y__InlineArray4<FVector>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray, 0) = new FVector(-70f, 0f, 0f);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray, 1) = new FVector(0f, 100f, 0f);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray, 2) = new FVector(70f, 0f, 0f);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray, 3) = new FVector(0f, -100f, 0f);
		Span<FVector> span = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray, 4);
		<>y__InlineArray4<FVector> <>y__InlineArray2 = default(<>y__InlineArray4<FVector>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray2, 0) = new FVector(0f, 130f, 0f);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray2, 1) = new FVector(130f, 0f, 0f);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray2, 2) = new FVector(0f, -130f, 0f);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray2, 3) = new FVector(-130f, 0f, 0f);
		Span<FVector> span2 = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray4<FVector>, FVector>(ref <>y__InlineArray2, 4);
		this.KuroMoveSplineInternal = this.SpawnKuroMoveSpline();
		this.KuroMoveSplineInternal.SetClosedLoop(true, true);
		this.KuroMoveSplineInternal.ClearSplinePoints(true);
		TArray<FSplinePoint> tarray = new TArray<FSplinePoint>();
		for (int i = 0; i < span.Length; i++)
		{
			FSplinePoint value = new FSplinePoint
			{
				InputKey = (float)i,
				Position = *span[i],
				ArriveTangent = *span2[i],
				LeaveTangent = *span2[i],
				Scale = Vector.OneVector,
				Type = ESplinePointType.CurveCustomTangent
			};
			tarray.Add(value);
		}
		this.KuroMoveSplineInternal.AddPoints(tarray, true);
	}

	// Token: 0x06017833 RID: 96307 RVA: 0x006F04DC File Offset: 0x006EE6DC
	[NullableContext(1)]
	private UKuroMoveSplineComponent SpawnKuroMoveSpline()
	{
		AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), this.ActorInternal.D_GetTransform(), null, true);
		TSubclassOf<UActorComponent> @class = UKuroMoveSplineComponent.StaticClass();
		bool bManualAttachment = false;
		FTransformDouble ftransformDouble = this.ActorInternal.D_GetTransform();
		return aactor.D_AddComponentByClass(@class, bManualAttachment, ftransformDouble, false, default(FName)) as UKuroMoveSplineComponent;
	}

	// Token: 0x0400C803 RID: 51203
	private const float WIDTH = 70f;

	// Token: 0x0400C804 RID: 51204
	private const float LENGTH = 100f;

	// Token: 0x0400C805 RID: 51205
	private const float TANGENT = 130f;

	// Token: 0x0400C806 RID: 51206
	private const float SPLINE_MOVE_SPEED = 520f;

	// Token: 0x0400C807 RID: 51207
	private const float SPLINE_ROTATION_SPEED = 20f;

	// Token: 0x0400C808 RID: 51208
	[Nullable(2)]
	private UKuroMoveSplineComponent KuroMoveSplineInternal;

	// Token: 0x0400C809 RID: 51209
	private float SplinePosition;

	// Token: 0x0400C80A RID: 51210
	private float SplineRotationSpeedAccumulation;

	// Token: 0x0400C80B RID: 51211
	private bool IsBackward;
}
