using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F63 RID: 12131
[NullableContext(2)]
[Nullable(0)]
public abstract class PassiveEffects : BuffEffect, IBuffTrigger
{
	// Token: 0x06019CDF RID: 105695 RVA: 0x006BADA4 File Offset: 0x006B8FA4
	public override void OnCreated()
	{
		BaseBuffComponent baseBuffComponent = this.OwnerBuffComponent as BaseBuffComponent;
		if (baseBuffComponent == null)
		{
			return;
		}
		baseBuffComponent.AddTrigger(this.ActiveHandleId, this.EventType, this);
	}

	// Token: 0x06019CE0 RID: 105696 RVA: 0x006BADC8 File Offset: 0x006B8FC8
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return;
		}
		ownerBuffComponent.RemoveTrigger(this.ActiveHandleId, this.EventType);
	}

	// Token: 0x06019CE1 RID: 105697 RVA: 0x006BADE6 File Offset: 0x006B8FE6
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019CE2 RID: 105698 RVA: 0x006BADF9 File Offset: 0x006B8FF9
	protected IBuffComponent GetEffectTarget()
	{
		return this.GetTargetByType(this.TargetType);
	}

	// Token: 0x06019CE3 RID: 105699 RVA: 0x006BAE07 File Offset: 0x006B9007
	protected IBuffComponent GetTargetByType(EPassiveEffectTargetType targetType)
	{
		switch (targetType)
		{
		case EPassiveEffectTargetType.ForSelf:
			return this.OwnerBuffComponent;
		case EPassiveEffectTargetType.ForTarget:
			return base.OpponentBuffComponent;
		case EPassiveEffectTargetType.ForBuffInstigator:
			return this.InstigatorBuffComponent;
		case EPassiveEffectTargetType.ForBuffHolderTarget:
			return this.GetBuffHolderSkillTarget();
		default:
			return null;
		}
	}

	// Token: 0x06019CE4 RID: 105700 RVA: 0x006BAE40 File Offset: 0x006B9040
	protected IBuffComponent GetBuffHolderSkillTarget()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		EntityHandle entityHandle;
		if (ownerBuffComponent == null)
		{
			entityHandle = null;
		}
		else
		{
			Entity entity = ownerBuffComponent.GetEntity();
			if (entity == null)
			{
				entityHandle = null;
			}
			else
			{
				CharacterSkillComponent characterSkillComponent = entity.CheckGetComponent<CharacterSkillComponent>();
				entityHandle = ((characterSkillComponent != null) ? characterSkillComponent.SkillTarget : null);
			}
		}
		EntityHandle entityHandle2 = entityHandle;
		if (entityHandle2 == null)
		{
			return this.OwnerBuffComponent;
		}
		WorldEntity entity2 = entityHandle2.Entity;
		if (entity2 == null)
		{
			return null;
		}
		return entity2.CheckGetComponent<BaseBuffComponent>();
	}

	// Token: 0x06019CE5 RID: 105701 RVA: 0x006BAE93 File Offset: 0x006B9093
	[NullableContext(1)]
	protected string GetDebugTriggerString()
	{
		return string.Empty;
	}

	// Token: 0x06019CE6 RID: 105702 RVA: 0x006BAE9A File Offset: 0x006B909A
	[NullableContext(1)]
	protected PassiveEffects(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x170023B0 RID: 9136
	// (get) Token: 0x06019CE7 RID: 105703 RVA: 0x006BAEA9 File Offset: 0x006B90A9
	public new int ActiveHandleId
	{
		get
		{
			return this.ActiveHandleId;
		}
	}

	// Token: 0x170023B1 RID: 9137
	// (get) Token: 0x06019CE8 RID: 105704 RVA: 0x006BAEB1 File Offset: 0x006B90B1
	public new BaseBuffComponent InstigatorBuffComponent
	{
		get
		{
			return base.InstigatorBuffComponent;
		}
	}

	// Token: 0x06019CE9 RID: 105705 RVA: 0x006BAEB9 File Offset: 0x006B90B9
	[NullableContext(1)]
	public bool TryExecute(Partial_RequirementPayload payload, IBuffComponent opponentBuffComp)
	{
		return base.TryExecute(payload, opponentBuffComp, Array.Empty<object>());
	}

	// Token: 0x0400C292 RID: 49810
	public EBuffTriggerType EventType;

	// Token: 0x0400C293 RID: 49811
	public EPassiveEffectTargetType TargetType;
}
