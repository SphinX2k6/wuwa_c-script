using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002707 RID: 9991
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillQingXiao : SpecialSkillBase
{
	// Token: 0x060190A5 RID: 102565 RVA: 0x007A0507 File Offset: 0x0079E707
	public SpecialSkillQingXiao(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x060190A6 RID: 102566 RVA: 0x007A053C File Offset: 0x0079E73C
	public override void OnStart()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		this.TagComp = entity.GetComponent<BaseTagComponent>();
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		this.AnimComp = entity.GetComponent<BaseAnimationComponent>();
		BaseTagComponent tagComp = this.TagComp;
		this.SpecialTagListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.状态标识.御剑飞行状态"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialTagChanged), null) : null);
	}

	// Token: 0x060190A7 RID: 102567 RVA: 0x007A05B2 File Offset: 0x0079E7B2
	public override void OnTick(float delta)
	{
		if (!this.InSwordRidingState)
		{
			return;
		}
		this.UpdateSwordRidingMix();
	}

	// Token: 0x060190A8 RID: 102568 RVA: 0x007A05C4 File Offset: 0x0079E7C4
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

	// Token: 0x060190A9 RID: 102569 RVA: 0x007A0794 File Offset: 0x0079E994
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

	// Token: 0x060190AA RID: 102570 RVA: 0x007A08FC File Offset: 0x0079EAFC
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

	// Token: 0x060190AB RID: 102571 RVA: 0x007A094D File Offset: 0x0079EB4D
	private void OnSpecialTagChanged(int tagId, bool bTagExists)
	{
		this.InSwordRidingState = bTagExists;
	}

	// Token: 0x0400DA6D RID: 55917
	private const string PROFILE_KEY = "SpecialSkillQingXiao";

	// Token: 0x0400DA6E RID: 55918
	private const int DETECT_FLOOR_HEIGHT = 60;

	// Token: 0x0400DA6F RID: 55919
	private bool InSwordRidingState;

	// Token: 0x0400DA70 RID: 55920
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DA71 RID: 55921
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400DA72 RID: 55922
	[Nullable(2)]
	private BaseAnimationComponent AnimComp;

	// Token: 0x0400DA73 RID: 55923
	[Nullable(2)]
	private ITagTask SpecialTagListener;

	// Token: 0x0400DA74 RID: 55924
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400DA75 RID: 55925
	private readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400DA76 RID: 55926
	private readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x0400DA77 RID: 55927
	private readonly Vector TmpVector4 = Vector.Create();
}
