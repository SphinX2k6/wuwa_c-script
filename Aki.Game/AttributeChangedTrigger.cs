using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Utils;

// Token: 0x02002538 RID: 9528
[NullableContext(1)]
[Nullable(0)]
public class AttributeChangedTrigger : Trigger
{
	// Token: 0x060178F6 RID: 96502 RVA: 0x006F4B11 File Offset: 0x006F2D11
	[NullableContext(2)]
	public AttributeChangedTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060178F7 RID: 96503 RVA: 0x006F4B22 File Offset: 0x006F2D22
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.AttributeId = (EAttributeType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0");
	}

	// Token: 0x060178F8 RID: 96504 RVA: 0x006F4B58 File Offset: 0x006F2D58
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

	// Token: 0x060178F9 RID: 96505 RVA: 0x006F4C38 File Offset: 0x006F2E38
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Remove(target, EAbilityEventName.OnAttributeChange, (long)this.AttributeId, new Action<EAttributeType, Entity, float, float>(this.OnEvent));
		}
	}

	// Token: 0x060178FA RID: 96506 RVA: 0x006F4C88 File Offset: 0x006F2E88
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

	// Token: 0x060178FB RID: 96507 RVA: 0x006F4CEC File Offset: 0x006F2EEC
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

	// Token: 0x060178FC RID: 96508 RVA: 0x006F4D28 File Offset: 0x006F2F28
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C87C RID: 51324
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C87D RID: 51325
	protected EAttributeType AttributeId;
}
