using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002543 RID: 9539
[NullableContext(1)]
[Nullable(0)]
public class GameplayEventTrigger : Trigger
{
	// Token: 0x06017945 RID: 96581 RVA: 0x006F6BAC File Offset: 0x006F4DAC
	[NullableContext(2)]
	public GameplayEventTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017946 RID: 96582 RVA: 0x006F6BC0 File Offset: 0x006F4DC0
	public override void OnInitParams(string[] triggerParams)
	{
		string tagName = (triggerParams.Length != 0) ? triggerParams[0].Trim() : string.Empty;
		this.TagId = GameplayTagUtils.GetTagIdByName(tagName);
	}

	// Token: 0x06017947 RID: 96583 RVA: 0x006F6BED File Offset: 0x006F4DED
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object obj;
		if (ownerTriggerComp == null)
		{
			obj = null;
		}
		else
		{
			Entity entity = ownerTriggerComp.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseAbilityComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.AddGameplayEventListener(this.TagId, new TGameplayEventCallback(this.OnEvent));
	}

	// Token: 0x06017948 RID: 96584 RVA: 0x006F6C29 File Offset: 0x006F4E29
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object obj;
		if (ownerTriggerComp == null)
		{
			obj = null;
		}
		else
		{
			Entity entity = ownerTriggerComp.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseAbilityComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.RemoveGameplayEventListener(this.TagId, new TGameplayEventCallback(this.OnEvent));
	}

	// Token: 0x06017949 RID: 96585 RVA: 0x006F6C68 File Offset: 0x006F4E68
	private void OnEvent(int _, FGameplayEventData payload)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		WorldEntity worldEntity;
		if (payload.Target == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(payload.Target, false);
			worldEntity = ((entityByActor != null) ? entityByActor.Entity : null);
		}
		WorldEntity value = worldEntity;
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Target"] = value;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601794A RID: 96586 RVA: 0x006F6CCB File Offset: 0x006F4ECB
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C898 RID: 51352
	protected int TagId;
}
