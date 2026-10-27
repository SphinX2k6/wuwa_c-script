using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002FEE RID: 12270
[NullableContext(1)]
[Nullable(0)]
public class GameplayEventTrigger : Trigger
{
	// Token: 0x0601A011 RID: 106513 RVA: 0x006CED10 File Offset: 0x006CCF10
	[NullableContext(2)]
	public GameplayEventTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A012 RID: 106514 RVA: 0x006CED24 File Offset: 0x006CCF24
	public override void OnInitParams(string[] triggerParams)
	{
		string tagName = (triggerParams.Length != 0) ? triggerParams[0].Trim() : string.Empty;
		this.TagId = GameplayTagUtils.GetTagIdByName(tagName);
	}

	// Token: 0x0601A013 RID: 106515 RVA: 0x006CED51 File Offset: 0x006CCF51
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

	// Token: 0x0601A014 RID: 106516 RVA: 0x006CED8D File Offset: 0x006CCF8D
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

	// Token: 0x0601A015 RID: 106517 RVA: 0x006CEDCC File Offset: 0x006CCFCC
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

	// Token: 0x0601A016 RID: 106518 RVA: 0x006CEE2F File Offset: 0x006CD02F
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4D0 RID: 50384
	protected int TagId;
}
