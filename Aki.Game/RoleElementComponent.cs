using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x0200323D RID: 12861
[NullableContext(1)]
[Nullable(0)]
public class RoleElementComponent : EntityComponent
{
	// Token: 0x0601BC20 RID: 113696 RVA: 0x007A6260 File Offset: 0x007A4460
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.AttributeComponent = base.Entity.GetComponent<BaseAttributeComponent>();
		this.BuffComponent = base.Entity.GetComponent<CharacterBuffComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.AddListener(EAttributeType.ElementEnergy, new Action<EAttributeType, float, float>(this.OnElementEnergyChanged), "RoleElementComponent");
		}
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRevive, new Action(this.OnRoleRevive));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(base.Entity, EEventName.CharHitLocal, new Action<global::HitInformation, HitContext>(this.CheckEnergyOnce));
		EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(base.Entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.CheckEnergyOnce));
		this.SummonedEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantCustom, 1);
		EntityHandle summonedEntity = this.SummonedEntity;
		WorldEntity worldEntity = (summonedEntity != null) ? summonedEntity.Entity : null;
		if (worldEntity != null && !EventSystem.Instance.HasWithTarget(worldEntity, EEventName.CharHitLocal, new Action<global::HitInformation, HitContext>(this.CheckEnergyOnce)))
		{
			EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(worldEntity, EEventName.CharHitLocal, new Action<global::HitInformation, HitContext>(this.CheckEnergyOnce));
		}
		this.NeedCheckEnergy = true;
		return true;
	}

	// Token: 0x0601BC21 RID: 113697 RVA: 0x007A63FC File Offset: 0x007A45FC
	protected override bool OnEnd()
	{
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.RemoveListener(EAttributeType.ElementEnergy, new Action<EAttributeType, float, float>(this.OnElementEnergyChanged));
		}
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRevive, new Action(this.OnRoleRevive));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharHitLocal, new Action<global::HitInformation, HitContext>(this.CheckEnergyOnce));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.CheckEnergyOnce));
		EntityHandle summonedEntity = this.SummonedEntity;
		if (summonedEntity != null && summonedEntity.Valid)
		{
			EventSystem.Instance.RemoveWithTarget(this.SummonedEntity.Entity, EEventName.CharHitLocal, new Action<global::HitInformation, HitContext>(this.CheckEnergyOnce));
		}
		this.SummonedEntity = null;
		this.NeedCheckEnergy = false;
		return true;
	}

	// Token: 0x17002641 RID: 9793
	// (get) Token: 0x0601BC23 RID: 113699 RVA: 0x007A65FD File Offset: 0x007A47FD
	// (set) Token: 0x0601BC22 RID: 113698 RVA: 0x007A6530 File Offset: 0x007A4730
	private bool ElementActivated
	{
		get
		{
			BaseTagComponent tagComponent = this.TagComponent;
			return tagComponent != null && tagComponent.HasExactTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE"]);
		}
		set
		{
			if (this.ElementActivated != value)
			{
				CharacterActorComponent actorComponent = this.ActorComponent;
				if (actorComponent != null && actorComponent.IsAutonomousProxy)
				{
					if (value)
					{
						bool flag = FormationDataController.Instance.IsBattleMulti();
						this.QteBuffId = (flag ? 3028L : 3029L);
						CharacterBuffComponent buffComponent = this.BuffComponent;
						if (buffComponent != null)
						{
							buffComponent.AddBuff(this.QteBuffId, new AddBuffParam
							{
								InstigatorId = this.BuffComponent.CreatureDataId,
								Reason = "RoleElementComponent获取激活QTE的Tag"
							});
						}
						if (flag)
						{
							this.MultiQteGuide();
							return;
						}
					}
					else
					{
						CharacterBuffComponent buffComponent2 = this.BuffComponent;
						if (buffComponent2 == null)
						{
							return;
						}
						buffComponent2.RemoveBuff(this.QteBuffId, -1, "RoleElementComponent移除激活QTE的Tag", null, null, null);
					}
				}
			}
		}
	}

	// Token: 0x17002642 RID: 9794
	// (get) Token: 0x0601BC24 RID: 113700 RVA: 0x007A661F File Offset: 0x007A481F
	public EElementType RoleElementType
	{
		get
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			return (EElementType)((attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.ElementPropertyType) : 0f);
		}
	}

	// Token: 0x17002643 RID: 9795
	// (get) Token: 0x0601BC25 RID: 113701 RVA: 0x007A663A File Offset: 0x007A483A
	public float RoleElementEnergy
	{
		get
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return 0f;
			}
			return attributeComponent.GetCurrentValue(EAttributeType.ElementEnergy);
		}
	}

	// Token: 0x17002644 RID: 9796
	// (get) Token: 0x0601BC26 RID: 113702 RVA: 0x007A6653 File Offset: 0x007A4853
	public float RoleElementEnergyMax
	{
		get
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return 0f;
			}
			return attributeComponent.GetCurrentValue(EAttributeType.ElementEnergyMax);
		}
	}

	// Token: 0x0601BC27 RID: 113703 RVA: 0x007A666C File Offset: 0x007A486C
	private void OnElementEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.CheckEnergyFull(newValue);
		EElementType roleElementType = this.RoleElementType;
		EventSystem.Instance.EmitWithTarget<EElementType, float, float>(base.Entity, EEventName.CharOnElementEnergyChanged, roleElementType, newValue, oldValue);
		EventSystem.Instance.Emit<EElementType, float, float>(EEventName.CharOnElementEnergyChanged, roleElementType, newValue, oldValue);
	}

	// Token: 0x0601BC28 RID: 113704 RVA: 0x007A66B4 File Offset: 0x007A48B4
	private void CheckEnergyFull(float energy)
	{
		if (energy >= this.TriggerEnergy - 1E-45f)
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			bool flag;
			if (instance == null)
			{
				flag = false;
			}
			else
			{
				SceneTeamItem teamItem = instance.GetTeamItem((long)base.Entity.Id, new GetTeamItemOptions
				{
					ParamType = ETeamParamType.EntityId
				});
				flag = ((teamItem != null) ? new bool?(teamItem.IsControl()) : null).GetValueOrDefault();
			}
			bool flag2 = flag;
			if (!this.ElementActivated && flag2 && FormationDataController.Instance.GlobalIsInFight)
			{
				this.ElementActivated = true;
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (buffComponent == null)
				{
					return;
				}
				buffComponent.TriggerEvents(EBuffTriggerType.ForWhenOneElementActivated, this.BuffComponent, new Partial_RequirementPayload
				{
					ElementType = new EElementType?(this.RoleElementType)
				});
				return;
			}
		}
		else
		{
			this.ElementActivated = false;
		}
	}

	// Token: 0x0601BC29 RID: 113705 RVA: 0x007A6774 File Offset: 0x007A4974
	private void OnStateInherit(Entity oldEntity, bool _)
	{
		if (FormationDataController.Instance.GlobalIsInFight)
		{
			this.NeedCheckEnergy = true;
		}
	}

	// Token: 0x0601BC2A RID: 113706 RVA: 0x007A6789 File Offset: 0x007A4989
	private void OnBattleStateChanged(bool inFight)
	{
		this.NeedCheckEnergy = inFight;
		if (!inFight)
		{
			this.ElementActivated = false;
		}
	}

	// Token: 0x0601BC2B RID: 113707 RVA: 0x007A679C File Offset: 0x007A499C
	private void CheckEnergyOnce(global::HitInformation hitInformation, HitContext hitContext)
	{
		if (this.NeedCheckEnergy)
		{
			this.CheckEnergyFull(this.RoleElementEnergy);
			this.NeedCheckEnergy = false;
		}
	}

	// Token: 0x0601BC2C RID: 113708 RVA: 0x007A67BC File Offset: 0x007A49BC
	public void TriggerEvents(Entity newRole)
	{
		RoleElementComponent component = newRole.GetComponent<RoleElementComponent>();
		Partial_RequirementPayload payload = new Partial_RequirementPayload
		{
			ElementType = new EElementType?(this.RoleElementType)
		};
		CharacterBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent != null)
		{
			buffComponent.TriggerEvents(EBuffTriggerType.ForWhenElementFusionGoDown, (component != null) ? component.BuffComponent : null, payload);
		}
		if (component != null)
		{
			CharacterBuffComponent buffComponent2 = component.BuffComponent;
			if (buffComponent2 == null)
			{
				return;
			}
			buffComponent2.TriggerEvents(EBuffTriggerType.ForWhenElementFusionGoBattle, this.BuffComponent, payload);
		}
	}

	// Token: 0x0601BC2D RID: 113709 RVA: 0x007A6823 File Offset: 0x007A4A23
	private void OnRoleRevive()
	{
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent != null && actorComponent.IsAutonomousProxy)
		{
			this.ClearElementEnergy(base.Entity, 0L);
		}
	}

	// Token: 0x0601BC2E RID: 113710 RVA: 0x007A6847 File Offset: 0x007A4A47
	private void OnRoleDead()
	{
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent != null && actorComponent.IsAutonomousProxy)
		{
			this.ClearElementEnergy(base.Entity, 0L);
		}
	}

	// Token: 0x0601BC2F RID: 113711 RVA: 0x007A686C File Offset: 0x007A4A6C
	public void ClearElementEnergy(Entity instigator, long consumeBuffId = 0L)
	{
		if (consumeBuffId == 0L)
		{
			consumeBuffId = 3027L;
		}
		CharacterBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent == null)
		{
			return;
		}
		long buffId = consumeBuffId;
		AddBuffParam addBuffParam = new AddBuffParam();
		CreatureDataComponent component = instigator.GetComponent<CreatureDataComponent>();
		addBuffParam.InstigatorId = ((component != null) ? component.GetCreatureDataId() : 0L);
		addBuffParam.Reason = "ClearElementEnergy消耗元素能量";
		buffComponent.AddBuff(buffId, addBuffParam);
	}

	// Token: 0x0601BC30 RID: 113712 RVA: 0x007A68C0 File Offset: 0x007A4AC0
	private void MultiQteGuide()
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		List<SceneTeamItem> list = (instance != null) ? instance.GetTeamItemsInRange(this.ActorComponent.ActorLocationProxy, 5000f) : null;
		if (list != null)
		{
			foreach (SceneTeamItem sceneTeamItem in list)
			{
				if (!sceneTeamItem.IsMyRole())
				{
					EntityHandle entityHandle = sceneTeamItem.EntityHandle;
					if (entityHandle != null)
					{
						WorldEntity entity = entityHandle.Entity;
						if (entity != null)
						{
							CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
							if (component != null)
							{
								component.AddBuff(3025L, new AddBuffParam
								{
									InstigatorId = this.BuffComponent.CreatureDataId,
									Reason = "用于联机QTE引导提示"
								});
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0601BC31 RID: 113713 RVA: 0x007A6988 File Offset: 0x007A4B88
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleElementComponent roleElementComponent = (RoleElementComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (roleElementComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeComponent"))
		{
			if (roleElementComponent.AttributeComponent == null)
			{
				this.AttributeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComponent), "AttributeComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (roleElementComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SummonedEntity"))
		{
			if (roleElementComponent.SummonedEntity == null)
			{
				this.SummonedEntity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.SummonedEntity), "SummonedEntity"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (roleElementComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("NeedCheckEnergy"))
		{
			this.NeedCheckEnergy = roleElementComponent.NeedCheckEnergy;
		}
		if (base.CanResetComponentProperty("TriggerEnergy"))
		{
			this.TriggerEnergy = roleElementComponent.TriggerEnergy;
		}
		if (base.CanResetComponentProperty("QteBuffId"))
		{
			this.QteBuffId = roleElementComponent.QteBuffId;
		}
		return true;
	}

	// Token: 0x0400DAA3 RID: 55971
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DAA4 RID: 55972
	[Nullable(2)]
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DAA5 RID: 55973
	[Nullable(2)]
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400DAA6 RID: 55974
	[Nullable(2)]
	private EntityHandle SummonedEntity;

	// Token: 0x0400DAA7 RID: 55975
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400DAA8 RID: 55976
	private bool NeedCheckEnergy;

	// Token: 0x0400DAA9 RID: 55977
	public float TriggerEnergy;

	// Token: 0x0400DAAA RID: 55978
	private long QteBuffId;
}
