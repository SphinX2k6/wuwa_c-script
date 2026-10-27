using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003199 RID: 12697
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillQingXiao : SpecialSkillBase
{
	// Token: 0x0601B585 RID: 112005 RVA: 0x0077827B File Offset: 0x0077647B
	public SpecialSkillQingXiao(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B586 RID: 112006 RVA: 0x007782B0 File Offset: 0x007764B0
	public override void OnStart()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		this.TagComp = entity.GetComponent<BaseTagComponent>();
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		this.AnimComp = entity.GetComponent<BaseAnimationComponent>();
		BaseTagComponent tagComp = this.TagComp;
		this.SpecialTagListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.状态标识.御剑飞行状态"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialTagChanged), null) : null);
	}

	// Token: 0x0601B587 RID: 112007 RVA: 0x00778326 File Offset: 0x00776526
	public override void OnTick(float delta)
	{
		if (!this.InSwordRidingState)
		{
			return;
		}
		this.UpdateSwordRidingMix();
	}

	// Token: 0x0601B588 RID: 112008 RVA: 0x00778338 File Offset: 0x00776538
	private void UpdateSwordRidingMix()
	{
		this.TmpVector4.DeepCopy(this.ActorComp.ActorForwardProxy);
		this.TmpVector4.MultiplyEqual((double)this.ActorComp.ScaledRadius);
		this.TmpVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.TmpVector.AdditionEqual(this.TmpVector4);
		UKuroHitResult ukuroHitResult = this.DetectFloor(this.TmpVector);
		if (ukuroHitResult == null)
		{
			return;
		}
		TraceElementCommon.Instance.GetHitLocation(ukuroHitResult, 0, this.TmpVector3);
		this.TmpVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.TmpVector.SubtractionEqual(this.TmpVector4);
		UKuroHitResult ukuroHitResult2 = this.DetectFloor(this.TmpVector);
		TraceElementCommon.Instance.GetHitLocation(ukuroHitResult2, 0, this.TmpVector4);
		if (ukuroHitResult2 == null)
		{
			return;
		}
		this.TmpVector.DeepCopy(this.TmpVector3);
		this.TmpVector.SubtractionEqual(this.TmpVector4);
		this.TmpVector2.DeepCopy(this.ActorComp.ActorGravityDirectProxy);
		this.TmpVector2.Normalize(9.99999993922529E-09);
		double num = this.TmpVector.DotProduct(this.TmpVector);
		if (num < 1E-06)
		{
			return;
		}
		double num2 = this.TmpVector.DotProduct(this.TmpVector2);
		double x = Math.Sqrt(Math.Max(0.0, num - num2 * num2));
		double value = Math.Atan2(-num2, x);
		double num3 = MathUtils.Instance.RangeClamp(value, -3.141592653589793, 3.141592653589793, -1.0, 1.0);
		BaseAnimationComponent animComp = this.AnimComp;
		UKuroAnimInstanceRole ukuroAnimInstanceRole = ((animComp != null) ? animComp.MainAnimInstance : null) as UKuroAnimInstanceRole;
		if (ukuroAnimInstanceRole != null)
		{
			ukuroAnimInstanceRole.SlideMix = (float)num3;
		}
	}

	// Token: 0x0601B589 RID: 112009 RVA: 0x00778508 File Offset: 0x00776708
	[return: Nullable(2)]
	private UKuroHitResult DetectFloor(Vector loc)
	{
		if (this.ActorComp == null)
		{
			return null;
		}
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Actor;
		actorTrace.Radius = this.ActorComp.ScaledRadius;
		this.TmpVector2.DeepCopy(loc);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector2, (double)(60f - actorTrace.Radius - this.ActorComp.ScaledHalfHeight));
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.TmpVector2);
		this.TmpVector2.DeepCopy(loc);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector2, (double)(-60f + actorTrace.Radius - this.ActorComp.ScaledHalfHeight));
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TmpVector2);
		actorTrace.ActorsToIgnore.Empty(true);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		if (!TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "SpecialSkillQingXiao", "SpecialSkillQingXiao"))
		{
			return null;
		}
		return actorTrace.HitResult;
	}

	// Token: 0x0601B58A RID: 112010 RVA: 0x00778670 File Offset: 0x00776870
	public override void OnEnd()
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.状态标识.御剑飞行状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialTagChanged));
		}
		ITagTask specialTagListener = this.SpecialTagListener;
		if (specialTagListener != null)
		{
			specialTagListener.EndTask();
		}
		this.SpecialTagListener = null;
	}

	// Token: 0x0601B58B RID: 112011 RVA: 0x007786C1 File Offset: 0x007768C1
	private void OnSpecialTagChanged(int tagId, bool bTagExists)
	{
		this.InSwordRidingState = bTagExists;
	}

	// Token: 0x0400D5EA RID: 54762
	private const string PROFILE_KEY = "SpecialSkillQingXiao";

	// Token: 0x0400D5EB RID: 54763
	private const int DETECT_FLOOR_HEIGHT = 60;

	// Token: 0x0400D5EC RID: 54764
	private bool InSwordRidingState;

	// Token: 0x0400D5ED RID: 54765
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D5EE RID: 54766
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D5EF RID: 54767
	[Nullable(2)]
	private BaseAnimationComponent AnimComp;

	// Token: 0x0400D5F0 RID: 54768
	[Nullable(2)]
	private ITagTask SpecialTagListener;

	// Token: 0x0400D5F1 RID: 54769
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400D5F2 RID: 54770
	private readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400D5F3 RID: 54771
	private readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x0400D5F4 RID: 54772
	private readonly Vector TmpVector4 = Vector.Create();
}
