using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002857 RID: 10327
[NullableContext(2)]
[Nullable(0)]
public class FishingBoatDeathComponent : BaseDeathComponent
{
	// Token: 0x0601A22B RID: 107051 RVA: 0x00813EA8 File Offset: 0x008120A8
	protected override bool OnInit()
	{
		this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		this.SkillComponent = base.Entity.GetComponent<BaseSkillComponent>();
		this.BuffComponent = base.Entity.GetComponent<CharacterBuffComponent>();
		this.AttributeComponent = base.Entity.GetComponent<BaseAttributeComponent>();
		return true;
	}

	// Token: 0x0601A22C RID: 107052 RVA: 0x00813F0C File Offset: 0x0081210C
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

	// Token: 0x0601A22D RID: 107053 RVA: 0x00813F4C File Offset: 0x0081214C
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
			buffComponent.RemoveAllDurationBuffs("实体死亡清理持续型buff", ERemoveAllBuffsReasonType.Death);
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.ClearSpecialEnergy();
		}
		base.PlayDeathMontageWithType(ECharacterDeathMontageType.Die, null, preMessageId, null);
		return true;
	}

	// Token: 0x0601A22E RID: 107054 RVA: 0x00813FDC File Offset: 0x008121DC
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

	// Token: 0x0601A22F RID: 107055 RVA: 0x00814034 File Offset: 0x00812234
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		FishingBoatDeathComponent fishingBoatDeathComponent = (FishingBoatDeathComponent)componentTemplate;
		if (fishingBoatDeathComponent.CreatureDataComponent == null)
		{
			this.CreatureDataComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
		{
			return false;
		}
		if (fishingBoatDeathComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (fishingBoatDeathComponent.SkillComponent == null)
		{
			this.SkillComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComponent), "SkillComponent"))
		{
			return false;
		}
		if (fishingBoatDeathComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		if (fishingBoatDeathComponent.AttributeComponent == null)
		{
			this.AttributeComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComponent), "AttributeComponent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002A90 RID: 10896
	// (get) Token: 0x0601A230 RID: 107056 RVA: 0x0081412B File Offset: 0x0081232B
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A91 RID: 10897
	// (get) Token: 0x0601A231 RID: 107057 RVA: 0x0081412E File Offset: 0x0081232E
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E54B RID: 58699
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400E54C RID: 58700
	private BaseTagComponent TagComponent;

	// Token: 0x0400E54D RID: 58701
	private BaseSkillComponent SkillComponent;

	// Token: 0x0400E54E RID: 58702
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400E54F RID: 58703
	private BaseAttributeComponent AttributeComponent;
}
