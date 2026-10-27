using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020032E5 RID: 13029
[NullableContext(2)]
[Nullable(0)]
public class FishingBoatDeathComponent : BaseDeathComponent
{
	// Token: 0x0601C585 RID: 116101 RVA: 0x007ED720 File Offset: 0x007EB920
	protected override bool OnInit()
	{
		this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		this.SkillComponent = base.Entity.GetComponent<BaseSkillComponent>();
		this.BuffComponent = base.Entity.GetComponent<CharacterBuffComponent>();
		this.AttributeComponent = base.Entity.GetComponent<BaseAttributeComponent>();
		return true;
	}

	// Token: 0x0601C586 RID: 116102 RVA: 0x007ED784 File Offset: 0x007EB984
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		if (this.CreatureDataComponent.GetLivingStatus().GetValueOrDefault() == LivingStatus.Dead)
		{
			this.ExecuteDeath(null);
		}
		return true;
	}

	// Token: 0x0601C587 RID: 116103 RVA: 0x007ED7C4 File Offset: 0x007EB9C4
	public override bool ExecuteDeath(long? preMessageId)
	{
		if (!base.ExecuteDeath(preMessageId))
		{
			return false;
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]));
		}
		BaseSkillComponent skillComponent = this.SkillComponent;
		if (skillComponent != null)
		{
			skillComponent.StopAllSkills("RoleDeathComponent.ExecuteDeath");
		}
		CharacterBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent != null)
		{
			buffComponent.RemoveAllDurationBuffs("实体死亡清理持续型buff");
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.ClearSpecialEnergy();
		}
		base.PlayDeathMontageWithType(ECharacterDeathMontageType.Die, null, preMessageId, null);
		return true;
	}

	// Token: 0x0601C588 RID: 116104 RVA: 0x007ED854 File Offset: 0x007EBA54
	public void ExecuteRevive()
	{
		Log.Instance.Info(ELogModule.Battle, ELogAuthor.LYY, "执行捕鱼船复活", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.IsDeadInternal = false;
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]));
	}

	// Token: 0x0601C589 RID: 116105 RVA: 0x007ED8AC File Offset: 0x007EBAAC
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		FishingBoatDeathComponent fishingBoatDeathComponent = (FishingBoatDeathComponent)componentTemplate;
		if (base.CanResetComponentProperty("CreatureDataComponent"))
		{
			if (fishingBoatDeathComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (fishingBoatDeathComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComponent"))
		{
			if (fishingBoatDeathComponent.SkillComponent == null)
			{
				this.SkillComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseSkillComponent>(this.SkillComponent), "SkillComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (fishingBoatDeathComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeComponent"))
		{
			if (fishingBoatDeathComponent.AttributeComponent == null)
			{
				this.AttributeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComponent), "AttributeComponent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400E0A0 RID: 57504
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400E0A1 RID: 57505
	private BaseTagComponent TagComponent;

	// Token: 0x0400E0A2 RID: 57506
	private BaseSkillComponent SkillComponent;

	// Token: 0x0400E0A3 RID: 57507
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400E0A4 RID: 57508
	private BaseAttributeComponent AttributeComponent;
}
