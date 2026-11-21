using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x020027AC RID: 10156
[NullableContext(1)]
[Nullable(0)]
public class RoleElementComponent : EntityComponent
{
	// Token: 0x060197C6 RID: 104390 RVA: 0x007CEB3C File Offset: 0x007CCD3C
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

	// Token: 0x060197C7 RID: 104391 RVA: 0x007CECD8 File Offset: 0x007CCED8
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

	// Token: 0x170028A0 RID: 10400
	// (get) Token: 0x060197C9 RID: 104393 RVA: 0x007CEED9 File Offset: 0x007CD0D9
	// (set) Token: 0x060197C8 RID: 104392 RVA: 0x007CEE0C File Offset: 0x007CD00C
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

	// Token: 0x170028A1 RID: 10401
	// (get) Token: 0x060197CA RID: 104394 RVA: 0x007CEEFB File Offset: 0x007CD0FB
	public EElementType RoleElementType
	{
		get
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			return (EElementType)((attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.ElementPropertyType) : 0f);
		}
	}

	// Token: 0x170028A2 RID: 10402
	// (get) Token: 0x060197CB RID: 104395 RVA: 0x007CEF16 File Offset: 0x007CD116
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

	// Token: 0x170028A3 RID: 10403
	// (get) Token: 0x060197CC RID: 104396 RVA: 0x007CEF2F File Offset: 0x007CD12F
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

	// Token: 0x060197CD RID: 104397 RVA: 0x007CEF48 File Offset: 0x007CD148
	private void OnElementEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.CheckEnergyFull(newValue);
		EElementType roleElementType = this.RoleElementType;
		EventSystem.Instance.EmitWithTarget<EElementType, float, float>(base.Entity, EEventName.CharOnElementEnergyChanged, roleElementType, newValue, oldValue);
		EventSystem.Instance.Emit<EElementType, float, float>(EEventName.CharOnElementEnergyChanged, roleElementType, newValue, oldValue);
	}

	// Token: 0x060197CE RID: 104398 RVA: 0x007CEF90 File Offset: 0x007CD190
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

	// Token: 0x060197CF RID: 104399 RVA: 0x007CF050 File Offset: 0x007CD250
	private void OnStateInherit(Entity oldEntity, bool _)
	{
		if (FormationDataController.Instance.GlobalIsInFight)
		{
			this.NeedCheckEnergy = true;
		}
	}

	// Token: 0x060197D0 RID: 104400 RVA: 0x007CF065 File Offset: 0x007CD265
	private void OnBattleStateChanged(bool inFight)
	{
		this.NeedCheckEnergy = inFight;
		if (!inFight)
		{
			this.ElementActivated = false;
		}
	}

	// Token: 0x060197D1 RID: 104401 RVA: 0x007CF078 File Offset: 0x007CD278
	private void CheckEnergyOnce(global::HitInformation hitInformation, HitContext hitContext)
	{
		if (this.NeedCheckEnergy)
		{
			this.CheckEnergyFull(this.RoleElementEnergy);
			this.NeedCheckEnergy = false;
		}
	}

	// Token: 0x060197D2 RID: 104402 RVA: 0x007CF098 File Offset: 0x007CD298
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

	// Token: 0x060197D3 RID: 104403 RVA: 0x007CF0FF File Offset: 0x007CD2FF
	private void OnRoleRevive()
	{
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent != null && actorComponent.IsAutonomousProxy)
		{
			this.ClearElementEnergy(base.Entity, 0L);
		}
	}

	// Token: 0x060197D4 RID: 104404 RVA: 0x007CF123 File Offset: 0x007CD323
	private void OnRoleDead()
	{
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent != null && actorComponent.IsAutonomousProxy)
		{
			this.ClearElementEnergy(base.Entity, 0L);
		}
	}

	// Token: 0x060197D5 RID: 104405 RVA: 0x007CF148 File Offset: 0x007CD348
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

	// Token: 0x060197D6 RID: 104406 RVA: 0x007CF19C File Offset: 0x007CD39C
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

	// Token: 0x060197D7 RID: 104407 RVA: 0x007CF264 File Offset: 0x007CD464
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleElementComponent roleElementComponent = (RoleElementComponent)componentTemplate;
		if (roleElementComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		if (roleElementComponent.AttributeComponent == null)
		{
			this.AttributeComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComponent), "AttributeComponent"))
		{
			return false;
		}
		if (roleElementComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		if (roleElementComponent.SummonedEntity == null)
		{
			this.SummonedEntity = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SummonedEntity), "SummonedEntity"))
		{
			return false;
		}
		if (roleElementComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		this.NeedCheckEnergy = roleElementComponent.NeedCheckEnergy;
		this.TriggerEnergy = roleElementComponent.TriggerEnergy;
		this.QteBuffId = roleElementComponent.QteBuffId;
		return true;
	}

	// Token: 0x170028A4 RID: 10404
	// (get) Token: 0x060197D8 RID: 104408 RVA: 0x007CF37F File Offset: 0x007CD57F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028A5 RID: 10405
	// (get) Token: 0x060197D9 RID: 104409 RVA: 0x007CF382 File Offset: 0x007CD582
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF42 RID: 57154
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DF43 RID: 57155
	[Nullable(2)]
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DF44 RID: 57156
	[Nullable(2)]
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400DF45 RID: 57157
	[Nullable(2)]
	private EntityHandle SummonedEntity;

	// Token: 0x0400DF46 RID: 57158
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400DF47 RID: 57159
	private bool NeedCheckEnergy;

	// Token: 0x0400DF48 RID: 57160
	public float TriggerEnergy;

	// Token: 0x0400DF49 RID: 57161
	private long QteBuffId;
}
