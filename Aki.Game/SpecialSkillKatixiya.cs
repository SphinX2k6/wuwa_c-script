using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003194 RID: 12692
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillKatixiya : SpecialSkillMorphBase
{
	// Token: 0x170025C4 RID: 9668
	// (get) Token: 0x0601B542 RID: 111938 RVA: 0x0077697E File Offset: 0x00774B7E
	protected override string MorphBuffsConfigKey
	{
		get
		{
			return "KatixiyaMorphBuffs";
		}
	}

	// Token: 0x170025C5 RID: 9669
	// (get) Token: 0x0601B543 RID: 111939 RVA: 0x00776985 File Offset: 0x00774B85
	protected override string MorphCueIdConfigKey
	{
		get
		{
			return "KatixiyaMorphCues";
		}
	}

	// Token: 0x170025C6 RID: 9670
	// (get) Token: 0x0601B544 RID: 111940 RVA: 0x0077698C File Offset: 0x00774B8C
	protected override string ResetMorphSkillsConfigKey
	{
		get
		{
			return "KatixiyaResetMorphSkills";
		}
	}

	// Token: 0x170025C7 RID: 9671
	// (get) Token: 0x0601B545 RID: 111941 RVA: 0x00776993 File Offset: 0x00774B93
	protected override string NotResetMorphSkillsConfigKey
	{
		get
		{
			return "KatixiyaNotResetMorphSkills";
		}
	}

	// Token: 0x170025C8 RID: 9672
	// (get) Token: 0x0601B546 RID: 111942 RVA: 0x0077699A File Offset: 0x00774B9A
	protected override string ChangeRoleResetMorphTagsConfigKey
	{
		get
		{
			return "KatixiyaChangeRoleResetMorphTags";
		}
	}

	// Token: 0x0601B547 RID: 111943 RVA: 0x007769A1 File Offset: 0x00774BA1
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

	// Token: 0x0601B548 RID: 111944 RVA: 0x007769BD File Offset: 0x00774BBD
	public SpecialSkillKatixiya(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B549 RID: 111945 RVA: 0x007769C8 File Offset: 0x00774BC8
	public override void OnStart()
	{
		base.OnStart();
		Entity entity = this.SpecialSkillComponent.Entity;
		this.RoleEnergyComp = entity.GetComponent<RoleEnergyComponent>();
		EventSystem.Instance.AddWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnBeforeCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnBeforeCharacterMorphTypeChanged));
	}

	// Token: 0x0601B54A RID: 111946 RVA: 0x00776A10 File Offset: 0x00774C10
	public override void OnEnd()
	{
		base.OnEnd();
		Entity entity = this.SpecialSkillComponent.Entity;
		EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnBeforeCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnBeforeCharacterMorphTypeChanged));
		this.ClearTimer();
	}

	// Token: 0x0601B54B RID: 111947 RVA: 0x00776A52 File Offset: 0x00774C52
	private void ClearTimer()
	{
		if (this.UpdateMaterialTimer != null)
		{
			TimerSystem.Instance.Remove(this.UpdateMaterialTimer);
			this.UpdateMaterialTimer = null;
		}
	}

	// Token: 0x0601B54C RID: 111948 RVA: 0x00776A74 File Offset: 0x00774C74
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

	// Token: 0x0601B54D RID: 111949 RVA: 0x00776AF4 File Offset: 0x00774CF4
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

	// Token: 0x0601B54E RID: 111950 RVA: 0x00776B50 File Offset: 0x00774D50
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

	// Token: 0x0400D5BA RID: 54714
	private const int UPDATE_MATERIAL_DELAY = 500;

	// Token: 0x0400D5BB RID: 54715
	[Nullable(2)]
	private RoleEnergyComponent RoleEnergyComp;

	// Token: 0x0400D5BC RID: 54716
	[Nullable(2)]
	private TimerHandle UpdateMaterialTimer;
}
