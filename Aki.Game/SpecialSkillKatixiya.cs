using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002701 RID: 9985
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillKatixiya : SpecialSkillMorphBase
{
	// Token: 0x170027B5 RID: 10165
	// (get) Token: 0x06019046 RID: 102470 RVA: 0x0079E2F6 File Offset: 0x0079C4F6
	protected override string MorphBuffsConfigKey
	{
		get
		{
			return "KatixiyaMorphBuffs";
		}
	}

	// Token: 0x170027B6 RID: 10166
	// (get) Token: 0x06019047 RID: 102471 RVA: 0x0079E2FD File Offset: 0x0079C4FD
	protected override string MorphCueIdConfigKey
	{
		get
		{
			return "KatixiyaMorphCues";
		}
	}

	// Token: 0x170027B7 RID: 10167
	// (get) Token: 0x06019048 RID: 102472 RVA: 0x0079E304 File Offset: 0x0079C504
	protected override string ResetMorphSkillsConfigKey
	{
		get
		{
			return "KatixiyaResetMorphSkills";
		}
	}

	// Token: 0x170027B8 RID: 10168
	// (get) Token: 0x06019049 RID: 102473 RVA: 0x0079E30B File Offset: 0x0079C50B
	protected override string NotResetMorphSkillsConfigKey
	{
		get
		{
			return "KatixiyaNotResetMorphSkills";
		}
	}

	// Token: 0x170027B9 RID: 10169
	// (get) Token: 0x0601904A RID: 102474 RVA: 0x0079E312 File Offset: 0x0079C512
	protected override string ChangeRoleResetMorphTagsConfigKey
	{
		get
		{
			return "KatixiyaChangeRoleResetMorphTags";
		}
	}

	// Token: 0x0601904B RID: 102475 RVA: 0x0079E319 File Offset: 0x0079C519
	protected override string GetSubMeshConfigKey(EMorphType morphType)
	{
		if (morphType == EMorphType.默认形态)
		{
			return "KatixiyaMorph0SubMeshList";
		}
		if (morphType != EMorphType.变身形态)
		{
			return "";
		}
		return "KatixiyaMorph1SubMeshList";
	}

	// Token: 0x0601904C RID: 102476 RVA: 0x0079E335 File Offset: 0x0079C535
	public SpecialSkillKatixiya(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601904D RID: 102477 RVA: 0x0079E340 File Offset: 0x0079C540
	public override void OnStart()
	{
		base.OnStart();
		Entity entity = this.SpecialSkillComponent.Entity;
		this.RoleEnergyComp = entity.GetComponent<RoleEnergyComponent>();
		EventSystem.Instance.AddWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnBeforeCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnBeforeCharacterMorphTypeChanged));
	}

	// Token: 0x0601904E RID: 102478 RVA: 0x0079E388 File Offset: 0x0079C588
	public override void OnEnd()
	{
		base.OnEnd();
		Entity entity = this.SpecialSkillComponent.Entity;
		EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnBeforeCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnBeforeCharacterMorphTypeChanged));
		this.ClearTimer();
	}

	// Token: 0x0601904F RID: 102479 RVA: 0x0079E3CA File Offset: 0x0079C5CA
	private void ClearTimer()
	{
		if (this.UpdateMaterialTimer != null)
		{
			TimerSystem.Instance.Remove(this.UpdateMaterialTimer);
			this.UpdateMaterialTimer = null;
		}
	}

	// Token: 0x06019050 RID: 102480 RVA: 0x0079E3EC File Offset: 0x0079C5EC
	private void CheckCurrentSkill()
	{
		BaseSkillComponent skillComp = this.SkillComp;
		Skill skill = (skillComp != null) ? skillComp.CurrentSkill : null;
		if (skill == null)
		{
			return;
		}
		UAnimMontage[] loadedMontages = skill.GetLoadedMontages();
		if (loadedMontages == null)
		{
			return;
		}
		BaseAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		if (uanimInstance == null)
		{
			return;
		}
		UAnimMontage[] array = loadedMontages;
		int i = 0;
		while (i < array.Length)
		{
			UAnimMontage montage = array[i];
			if (uanimInstance.Montage_IsPlaying(montage))
			{
				BaseSkillComponent skillComp2 = this.SkillComp;
				if (skillComp2 == null)
				{
					return;
				}
				skillComp2.StopGroup1Skill("形态变化时存在正在播放的技能动画");
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x06019051 RID: 102481 RVA: 0x0079E46C File Offset: 0x0079C66C
	protected override void OnCharacterMorphTypeChanged(Entity entity, EMorphType newMorphType, EMorphType oldMorphType)
	{
		if (newMorphType == EMorphType.默认形态)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.IsRoleAndCtrlByMe)
			{
				this.ClearTimer();
				this.UpdateMaterialTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					RoleEnergyComponent roleEnergyComp = this.RoleEnergyComp;
					if (roleEnergyComp != null)
					{
						roleEnergyComp.RefreshStarScarMaterial();
					}
					this.UpdateMaterialTimer = null;
				}, 500f, null, null, true, 1f);
			}
		}
		base.RefreshNoUpdateMeshes(newMorphType);
	}

	// Token: 0x06019052 RID: 102482 RVA: 0x0079E4C8 File Offset: 0x0079C6C8
	private void OnBeforeCharacterMorphTypeChanged(Entity entity, EMorphType newMorphType, EMorphType oldMorphType)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe)
		{
			this.CheckCurrentSkill();
			CharacterDitherEffectController ditherEffectController = this.ActorComp.Actor.DitherEffectController;
			if (ditherEffectController == null || ditherEffectController.CurrentDitherValue != (double)1)
			{
				CharRenderingComponent charRenderingComponent = this.ActorComp.Actor.CharRenderingComponent;
				if (charRenderingComponent == null)
				{
					return;
				}
				charRenderingComponent.SetDitherEffect(1f, ECharacterDitherType.Fight);
			}
		}
	}

	// Token: 0x0400DA1D RID: 55837
	private const int UPDATE_MATERIAL_DELAY = 500;

	// Token: 0x0400DA1E RID: 55838
	[Nullable(2)]
	private RoleEnergyComponent RoleEnergyComp;

	// Token: 0x0400DA1F RID: 55839
	[Nullable(2)]
	private TimerHandle UpdateMaterialTimer;
}
