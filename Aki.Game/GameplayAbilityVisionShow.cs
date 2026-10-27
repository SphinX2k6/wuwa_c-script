using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020031AC RID: 12716
[NullableContext(2)]
[Nullable(0)]
public class GameplayAbilityVisionShow : GameplayAbilityVisionBase
{
	// Token: 0x0601B683 RID: 112259 RVA: 0x0077E839 File Offset: 0x0077CA39
	[NullableContext(1)]
	public GameplayAbilityVisionShow(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x0601B684 RID: 112260 RVA: 0x0077E842 File Offset: 0x0077CA42
	protected override void OnCreate()
	{
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
	}

	// Token: 0x0601B685 RID: 112261 RVA: 0x0077E866 File Offset: 0x0077CA66
	protected override void OnDestroy()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
	}

	// Token: 0x0601B686 RID: 112262 RVA: 0x0077E88A File Offset: 0x0077CA8A
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

	// Token: 0x0601B687 RID: 112263 RVA: 0x0077E8BC File Offset: 0x0077CABC
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

	// Token: 0x0601B688 RID: 112264 RVA: 0x0077E924 File Offset: 0x0077CB24
	[NullableContext(1)]
	private void OnBulletDestroy(BulletInfo bulletInfo)
	{
		if (this.VisionEntity != null && bulletInfo.BulletDataMain.Execution.SendGameplayEventTagToAttackerOnEnd.TagId() == GameplayTagDefine.EGameplayTagId["幻象.展示.葫芦落地"] && !base.GameplayTagComponent.HasTag(GameplayAbilityVisionMisc.morphTag))
		{
			this.Summon(bulletInfo.MoveInfo.LastFramePosition.ToUeVector(false));
		}
	}

	// Token: 0x0601B689 RID: 112265 RVA: 0x0077E988 File Offset: 0x0077CB88
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

	// Token: 0x0601B68A RID: 112266 RVA: 0x0077EA58 File Offset: 0x0077CC58
	private void SetCollision(bool enable)
	{
		CollisionUtils.Instance.SetCollisionResponseToPawn(this.VisionActorComponent.Actor.CapsuleComponent, EPawnChannel.PawnPlayer, enable ? ECollisionResponse.ECR_Block : ECollisionResponse.ECR_Ignore);
		this.VisionActorComponent.Actor.CapsuleComponent.IgnoreActorWhenMoving(base.ActorComponent.Actor, !enable);
		base.ActorComponent.Actor.CapsuleComponent.IgnoreActorWhenMoving(this.VisionActorComponent.Actor, !enable);
	}

	// Token: 0x0400D6BA RID: 54970
	private EntityHandle VisionEntity;

	// Token: 0x0400D6BB RID: 54971
	private CharacterActorComponent VisionActorComponent;

	// Token: 0x0400D6BC RID: 54972
	private CharacterSkillComponent VisionSkillComponent;
}
