using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002EB8 RID: 11960
[NullableContext(1)]
[Nullable(0)]
public class CustomSetActorRotation : CustomActionBase
{
	// Token: 0x06019892 RID: 104594 RVA: 0x00699C2C File Offset: 0x00697E2C
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

	// Token: 0x06019893 RID: 104595 RVA: 0x00699C98 File Offset: 0x00697E98
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

	// Token: 0x06019894 RID: 104596 RVA: 0x00699DC0 File Offset: 0x00697FC0
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

	// Token: 0x0400BEB7 RID: 48823
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400BEB8 RID: 48824
	private readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400BEB9 RID: 48825
	private readonly Rotator CacheRotator = Rotator.Create();

	// Token: 0x0400BEBA RID: 48826
	private float DeltaTime;

	// Token: 0x0400BEBB RID: 48827
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400BEBC RID: 48828
	private readonly BaseActorComponent TargetActorComp;

	// Token: 0x0400BEBD RID: 48829
	private readonly CharacterAnimationComponent AnimComp;

	// Token: 0x0400BEBE RID: 48830
	private readonly double Angle;

	// Token: 0x0400BEBF RID: 48831
	private readonly ECustomSetRotationType RotationType;

	// Token: 0x0400BEC0 RID: 48832
	private readonly int ModelBufferTime;
}
