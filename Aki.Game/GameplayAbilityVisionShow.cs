using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200271B RID: 10011
[NullableContext(2)]
[Nullable(0)]
public class GameplayAbilityVisionShow : GameplayAbilityVisionBase
{
	// Token: 0x060191B6 RID: 102838 RVA: 0x007A6B65 File Offset: 0x007A4D65
	[NullableContext(1)]
	public GameplayAbilityVisionShow(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x060191B7 RID: 102839 RVA: 0x007A6B6E File Offset: 0x007A4D6E
	protected override void OnCreate()
	{
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
	}

	// Token: 0x060191B8 RID: 102840 RVA: 0x007A6B92 File Offset: 0x007A4D92
	protected override void OnDestroy()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
	}

	// Token: 0x060191B9 RID: 102841 RVA: 0x007A6BB6 File Offset: 0x007A4DB6
	protected override bool OnActivateAbility()
	{
		if (!this.PreSummon())
		{
			return false;
		}
		base.SkillComponent.PlaySkillMontage(0, "", 0f, delegate(bool _)
		{
			BaseSkillComponent skillComponent = base.SkillComponent;
			Skill currentSkill = base.SkillComponent.CurrentSkill;
			skillComponent.EndSkill((currentSkill != null) ? currentSkill.SkillId : 0, "GameplayAbilityVisionShow.OnActivateAbility");
		}, null);
		return true;
	}

	// Token: 0x060191BA RID: 102842 RVA: 0x007A6BE8 File Offset: 0x007A4DE8
	private bool PreSummon()
	{
		this.VisionEntity = PhantomUtil.GetSummonedEntity(this.VisionComponent.Entity, ESummonType.ConcomitantVision, 1);
		if (this.VisionEntity.Entity.Active)
		{
			return false;
		}
		this.VisionActorComponent = this.VisionEntity.Entity.GetComponent<CharacterActorComponent>();
		this.VisionSkillComponent = this.VisionEntity.Entity.GetComponent<CharacterSkillComponent>();
		return true;
	}

	// Token: 0x060191BB RID: 102843 RVA: 0x007A6C50 File Offset: 0x007A4E50
	[NullableContext(1)]
	private void OnBulletDestroy(BulletInfo bulletInfo)
	{
		if (this.VisionEntity != null && bulletInfo.BulletDataMain.Execution.SendGameplayEventTagToAttackerOnEnd.TagId() == GameplayTagDefine.EGameplayTagId["幻象.展示.葫芦落地"] && !base.GameplayTagComponent.HasTag(GameplayAbilityVisionMisc.morphTag))
		{
			this.Summon(bulletInfo.MoveInfo.LastFramePosition.ToUeVector(false));
		}
	}

	// Token: 0x060191BC RID: 102844 RVA: 0x007A6CB4 File Offset: 0x007A4EB4
	private void Summon(FVectorDouble location)
	{
		float num = 1f;
		BP_BaseVision_C bp_BaseVision_C = this.VisionActorComponent.Actor as BP_BaseVision_C;
		if (bp_BaseVision_C != null)
		{
			num = bp_BaseVision_C.显像放大比例.Z;
		}
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, (double)(this.VisionActorComponent.ScaledHalfHeight * num));
		this.VisionActorComponent.SetActorLocationAndRotation(location + fvectorDouble, base.ActorComponent.ActorRotation, "召唤展示生成位置", false, null);
		CreatureController.Instance.SetEntityEnable(this.VisionEntity.Entity, true, "GameplayAbilityVisionShow.SetVisionEnable", true);
		this.SetCollision(false);
		this.VisionSkillComponent.BeginSkillAsync(1200000, new SkillParam
		{
			Reason = "GameplayAbilityVisionShow.PostSummon"
		});
	}

	// Token: 0x060191BD RID: 102845 RVA: 0x007A6D84 File Offset: 0x007A4F84
	private void SetCollision(bool enable)
	{
		CollisionUtils.Instance.SetCollisionResponseToPawn(this.VisionActorComponent.Actor.CapsuleComponent, EPawnChannel.PawnPlayer, enable ? ECollisionResponse.ECR_Block : ECollisionResponse.ECR_Ignore);
		this.VisionActorComponent.Actor.CapsuleComponent.IgnoreActorWhenMoving(base.ActorComponent.Actor, !enable);
		base.ActorComponent.Actor.CapsuleComponent.IgnoreActorWhenMoving(this.VisionActorComponent.Actor, !enable);
	}

	// Token: 0x0400DB41 RID: 56129
	private EntityHandle VisionEntity;

	// Token: 0x0400DB42 RID: 56130
	private CharacterActorComponent VisionActorComponent;

	// Token: 0x0400DB43 RID: 56131
	private CharacterSkillComponent VisionSkillComponent;
}
