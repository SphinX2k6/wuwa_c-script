using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.AI.AIMoveSplineCount;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002FCE RID: 12238
public class GameplayCueMoveSpline : GameplayCueEffect
{
	// Token: 0x06019F1E RID: 106270 RVA: 0x006C996C File Offset: 0x006C7B6C
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

	// Token: 0x06019F1F RID: 106271 RVA: 0x006C99EE File Offset: 0x006C7BEE
	protected override void OnDestroy()
	{
		ActorSystem.Instance.Put("GameplayCueMoveSpline.OnDestroy", this.KuroMoveSplineInternal.GetOwner(), null);
		base.OnDestroy();
	}

	// Token: 0x06019F20 RID: 106272 RVA: 0x006C9A14 File Offset: 0x006C7C14
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
			FSplinePoint value = new FSplinePoint((float)i, *span[i], *span2[i], *span2[i], Rotator.ZeroRotator, Vector.OneVector, ESplinePointType.CurveCustomTangent);
			tarray.Add(value);
		}
		this.KuroMoveSplineInternal.AddPoints(tarray, true);
	}

	// Token: 0x06019F21 RID: 106273 RVA: 0x006C9BE8 File Offset: 0x006C7DE8
	[NullableContext(1)]
	private UKuroMoveSplineComponent SpawnKuroMoveSpline()
	{
		AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), this.ActorInternal.D_GetTransform(), null, true);
		TSubclassOf<UActorComponent> @class = UKuroMoveSplineComponent.StaticClass();
		bool bManualAttachment = false;
		FTransformDouble ftransformDouble = this.ActorInternal.D_GetTransform();
		return aactor.D_AddComponentByClass(@class, bManualAttachment, ftransformDouble, false, default(FName)) as UKuroMoveSplineComponent;
	}

	// Token: 0x0400C45A RID: 50266
	private const float WIDTH = 70f;

	// Token: 0x0400C45B RID: 50267
	private const float LENGTH = 100f;

	// Token: 0x0400C45C RID: 50268
	private const float TANGENT = 130f;

	// Token: 0x0400C45D RID: 50269
	private const float SPLINE_MOVE_SPEED = 520f;

	// Token: 0x0400C45E RID: 50270
	private const float SPLINE_ROTATION_SPEED = 20f;

	// Token: 0x0400C45F RID: 50271
	[Nullable(2)]
	private UKuroMoveSplineComponent KuroMoveSplineInternal;

	// Token: 0x0400C460 RID: 50272
	private float SplinePosition;

	// Token: 0x0400C461 RID: 50273
	private float SplineRotationSpeedAccumulation;

	// Token: 0x0400C462 RID: 50274
	private bool IsBackward;
}
