using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Utils;

// Token: 0x02002FE3 RID: 12259
[NullableContext(1)]
[Nullable(0)]
public class AttributeChangedTrigger : Trigger
{
	// Token: 0x06019FC2 RID: 106434 RVA: 0x006CCC71 File Offset: 0x006CAE71
	[NullableContext(2)]
	public AttributeChangedTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FC3 RID: 106435 RVA: 0x006CCC82 File Offset: 0x006CAE82
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.AttributeId = (EAttributeType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0");
	}

	// Token: 0x06019FC4 RID: 106436 RVA: 0x006CCCB8 File Offset: 0x006CAEB8
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Add(target, EAbilityEventName.OnAttributeChange, (long)this.AttributeId, new Action<EAttributeType, Entity, float, float>(this.OnEvent));
		}
		switch (this.TargetType)
		{
		case ETriggerTargetType.Self:
		{
			CharacterTriggerComponent ownerTriggerComp2 = base.OwnerTriggerComp;
			this.TriggerEventOnActive((ownerTriggerComp2 != null) ? ownerTriggerComp2.Entity : null);
			return;
		}
		case ETriggerTargetType.LocalFormation:
		case ETriggerTargetType.AllFormation:
		{
			bool onlyMyRole = this.TargetType == ETriggerTargetType.LocalFormation;
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(onlyMyRole))
			{
				this.TriggerEventOnActive(entityHandle.Entity);
			}
			break;
		}
		case ETriggerTargetType.Enemy:
			break;
		default:
			return;
		}
	}

	// Token: 0x06019FC5 RID: 106437 RVA: 0x006CCD98 File Offset: 0x006CAF98
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Remove(target, EAbilityEventName.OnAttributeChange, (long)this.AttributeId, new Action<EAttributeType, Entity, float, float>(this.OnEvent));
		}
	}

	// Token: 0x06019FC6 RID: 106438 RVA: 0x006CCDE8 File Offset: 0x006CAFE8
	protected void OnEvent(EAttributeType _, Entity target, float newValue, float oldValue)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Target"] = target;
		dictionary["NewValue"] = newValue;
		dictionary["OldValue"] = oldValue;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x06019FC7 RID: 106439 RVA: 0x006CCE4C File Offset: 0x006CB04C
	[NullableContext(2)]
	private void TriggerEventOnActive(Entity entity)
	{
		BaseAttributeComponent baseAttributeComponent = (entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent != null && entity != null)
		{
			float currentValue = baseAttributeComponent.GetCurrentValue(this.AttributeId);
			this.OnEvent(this.AttributeId, entity, currentValue, currentValue);
		}
	}

	// Token: 0x06019FC8 RID: 106440 RVA: 0x006CCE88 File Offset: 0x006CB088
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4B4 RID: 50356
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4B5 RID: 50357
	protected EAttributeType AttributeId;
}
