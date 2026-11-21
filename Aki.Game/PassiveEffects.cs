using System;
using System.Runtime.CompilerServices;

// Token: 0x020024B7 RID: 9399
[NullableContext(2)]
[Nullable(0)]
public abstract class PassiveEffects : BuffEffect, IBuffTrigger
{
	// Token: 0x060175F1 RID: 95729 RVA: 0x006E1690 File Offset: 0x006DF890
	public override void OnCreated()
	{
		BaseBuffComponent baseBuffComponent = this.OwnerBuffComponent as BaseBuffComponent;
		if (baseBuffComponent == null)
		{
			return;
		}
		baseBuffComponent.AddTrigger(this.ActiveHandleId, this.EventType, this);
	}

	// Token: 0x060175F2 RID: 95730 RVA: 0x006E16B4 File Offset: 0x006DF8B4
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return;
		}
		ownerBuffComponent.RemoveTrigger(this.ActiveHandleId, this.EventType);
	}

	// Token: 0x060175F3 RID: 95731 RVA: 0x006E16D2 File Offset: 0x006DF8D2
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x060175F4 RID: 95732 RVA: 0x006E16E5 File Offset: 0x006DF8E5
	protected IBuffComponent GetEffectTarget()
	{
		return this.GetTargetByType(this.TargetType);
	}

	// Token: 0x060175F5 RID: 95733 RVA: 0x006E16F3 File Offset: 0x006DF8F3
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

	// Token: 0x060175F6 RID: 95734 RVA: 0x006E172C File Offset: 0x006DF92C
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

	// Token: 0x060175F7 RID: 95735 RVA: 0x006E177F File Offset: 0x006DF97F
	[NullableContext(1)]
	protected string GetDebugTriggerString()
	{
		return string.Empty;
	}

	// Token: 0x060175F8 RID: 95736 RVA: 0x006E1786 File Offset: 0x006DF986
	[NullableContext(1)]
	protected PassiveEffects(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x17002472 RID: 9330
	// (get) Token: 0x060175F9 RID: 95737 RVA: 0x006E1795 File Offset: 0x006DF995
	public new int ActiveHandleId
	{
		get
		{
			return this.ActiveHandleId;
		}
	}

	// Token: 0x17002473 RID: 9331
	// (get) Token: 0x060175FA RID: 95738 RVA: 0x006E179D File Offset: 0x006DF99D
	public new BaseBuffComponent InstigatorBuffComponent
	{
		get
		{
			return base.InstigatorBuffComponent;
		}
	}

	// Token: 0x060175FB RID: 95739 RVA: 0x006E17A5 File Offset: 0x006DF9A5
	[NullableContext(1)]
	public bool TryExecute(Partial_RequirementPayload payload, IBuffComponent opponentBuffComp)
	{
		return base.TryExecute(payload, opponentBuffComp, Array.Empty<object>());
	}

	// Token: 0x0400C63B RID: 50747
	public EBuffTriggerType EventType;

	// Token: 0x0400C63C RID: 50748
	public EPassiveEffectTargetType TargetType;
}
