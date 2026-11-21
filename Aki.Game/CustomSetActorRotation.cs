using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200240B RID: 9227
[NullableContext(1)]
[Nullable(0)]
public class CustomSetActorRotation : CustomActionBase
{
	// Token: 0x06017178 RID: 94584 RVA: 0x006BFEEC File Offset: 0x006BE0EC
	public CustomSetActorRotation(CharacterActorComponent actorComp, BaseActorComponent targetActorComp, CharacterAnimationComponent animComp, double angle, ECustomSetRotationType rotationType, [Nullable(2)] Action callback = null, int modelBufferTime = 200)
	{
		this.ActorComp = actorComp;
		this.TargetActorComp = targetActorComp;
		this.AnimComp = animComp;
		this.Angle = angle;
		this.RotationType = rotationType;
		this.Callback = callback;
		this.ModelBufferTime = modelBufferTime;
	}

	// Token: 0x06017179 RID: 94585 RVA: 0x006BFF58 File Offset: 0x006BE158
	protected override void OnRunAction()
	{
		if (this.ActorComp == null || this.AnimComp == null || this.TargetActorComp == null)
		{
			base.Finish(false);
			return;
		}
		this.DeltaTime = 0f;
		this.CacheVector2.DeepCopy(this.ActorComp.ActorGravityDirectProxy);
		this.CacheVector2.UnaryNegation(this.CacheVector2);
		this.CacheVector2.Normalize(9.99999993922529E-09);
		if (this.RotationType == ECustomSetRotationType.FaceToTarget)
		{
			this.CacheVector.DeepCopy(this.TargetActorComp.ActorLocationProxy);
			this.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
			if (this.Angle != 0.0)
			{
				this.CacheVector.RotateAngleAxis(this.Angle, this.CacheVector2, this.CacheVector);
				return;
			}
		}
		else if (this.RotationType == ECustomSetRotationType.TargetForward)
		{
			this.CacheVector.DeepCopy(this.TargetActorComp.ActorForwardProxy);
			if (this.Angle != 0.0)
			{
				this.CacheVector.RotateAngleAxis(this.Angle, this.CacheVector2, this.CacheVector);
			}
		}
	}

	// Token: 0x0601717A RID: 94586 RVA: 0x006C0080 File Offset: 0x006BE280
	protected override void OnCheckFinish(float deltaTime)
	{
		if (this.IsFinish)
		{
			return;
		}
		this.DeltaTime += deltaTime;
		double value = (double)GravityUtils.Instance.GetAngleOffsetInGravityForActor(this.ActorComp, this.ActorComp.ActorForwardProxy, this.CacheVector);
		if (this.DeltaTime > 1000f || this.CacheVector.IsNearlyZero(9.999999747378752E-05) || Math.Abs(value) < 10.0)
		{
			if (this.CacheVector.IsNearlyZero(9.999999747378752E-05))
			{
				this.CacheRotator.DeepCopy(this.ActorComp.ActorRotationProxy);
			}
			else
			{
				MathUtils.Instance.LookRotationUpFirst(this.CacheVector, this.CacheVector2, this.CacheRotator);
			}
			CharacterAnimationComponent animComp = this.AnimComp;
			FTransformDouble? ftransformDouble = (animComp != null) ? new FTransformDouble?(animComp.GetMeshTransform()) : null;
			if (ftransformDouble != null)
			{
				this.ActorComp.SetActorRotation(this.CacheRotator.ToUeRotator(), "[CharacterCustomActionComponent]", false);
				this.ActorComp.ClearInput(false, true);
				CharacterAnimationComponent animComp2 = this.AnimComp;
				if (animComp2 != null)
				{
					animComp2.SetModelBuffer(ftransformDouble.Value, (float)this.ModelBufferTime);
				}
			}
			base.Finish(true);
			return;
		}
		this.ActorComp.SetInputFacing(this.CacheVector, true);
		this.ActorComp.SetOverrideTurnSpeed(new float?((float)180));
	}

	// Token: 0x0400C252 RID: 49746
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400C253 RID: 49747
	private readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400C254 RID: 49748
	private readonly Rotator CacheRotator = Rotator.Create();

	// Token: 0x0400C255 RID: 49749
	private float DeltaTime;

	// Token: 0x0400C256 RID: 49750
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400C257 RID: 49751
	private readonly BaseActorComponent TargetActorComp;

	// Token: 0x0400C258 RID: 49752
	private readonly CharacterAnimationComponent AnimComp;

	// Token: 0x0400C259 RID: 49753
	private readonly double Angle;

	// Token: 0x0400C25A RID: 49754
	private readonly ECustomSetRotationType RotationType;

	// Token: 0x0400C25B RID: 49755
	private readonly int ModelBufferTime;
}
