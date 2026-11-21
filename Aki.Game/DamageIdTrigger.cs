using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x0200254A RID: 9546
[NullableContext(1)]
[Nullable(0)]
public class DamageIdTrigger : Trigger
{
	// Token: 0x06017971 RID: 96625 RVA: 0x006F7C62 File Offset: 0x006F5E62
	[NullableContext(2)]
	public DamageIdTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017972 RID: 96626 RVA: 0x006F7C80 File Offset: 0x006F5E80
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		double num = Convert.ToDouble((triggerParams.Length > 1) ? triggerParams[1] : "0");
		this.DistSquared = num * num;
		this.ListenDamageIds.Clear();
		string[] array = ((triggerParams.Length > 2) ? triggerParams[2] : string.Empty).Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			long item;
			if (long.TryParse(array[i], out item))
			{
				this.ListenDamageIds.Add(item);
			}
		}
	}

	// Token: 0x06017973 RID: 96627 RVA: 0x006F7D10 File Offset: 0x006F5F10
	protected override void OnActive()
	{
		if (this.TargetType == ETriggerTargetType.Enemy)
		{
			EventSystem.Instance.Add<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(EEventName.GlobalCharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
			return;
		}
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x06017974 RID: 96628 RVA: 0x006F7D98 File Offset: 0x006F5F98
	protected override void OnInactive()
	{
		if (this.TargetType == ETriggerTargetType.Enemy)
		{
			EventSystem.Instance.Remove<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(EEventName.GlobalCharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
			return;
		}
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x06017975 RID: 96629 RVA: 0x006F7E20 File Offset: 0x006F6020
	private void OnEvent(Entity attacker, Entity victim, RequirementPayload req, DamageResult result, FVectorDouble hitPos)
	{
		long id = result.DamageData.Id;
		bool flag = false;
		for (int i = 0; i < this.ListenDamageIds.Count; i++)
		{
			if (this.ListenDamageIds[i] == id)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		bool flag2;
		if (ownerTriggerComp == null)
		{
			flag2 = true;
		}
		else
		{
			Entity entity = ownerTriggerComp.Entity;
			flag2 = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
		}
		if (flag2)
		{
			return;
		}
		if (this.TargetType == ETriggerTargetType.Enemy)
		{
			CharacterTriggerComponent ownerTriggerComp2 = base.OwnerTriggerComp;
			ECamp? ecamp;
			if (ownerTriggerComp2 == null)
			{
				ecamp = null;
			}
			else
			{
				Entity entity2 = ownerTriggerComp2.Entity;
				if (entity2 == null)
				{
					ecamp = null;
				}
				else
				{
					CharacterActorComponent component = entity2.GetComponent<CharacterActorComponent>();
					ecamp = ((component != null) ? new ECamp?(component.Actor.Camp) : null);
				}
			}
			ECamp? ecamp2 = ecamp;
			CharacterActorComponent component2 = victim.GetComponent<CharacterActorComponent>();
			ECamp? ecamp3 = (component2 != null) ? new ECamp?(component2.Actor.Camp) : null;
			if (ecamp2 == null || ecamp3 == null)
			{
				return;
			}
			if (CampUtils.GetCampRelationship(ecamp2.Value, ecamp3.Value) != ERelation.Enemy)
			{
				return;
			}
		}
		CharacterTriggerComponent ownerTriggerComp3 = base.OwnerTriggerComp;
		Vector vector;
		if (ownerTriggerComp3 == null)
		{
			vector = null;
		}
		else
		{
			Entity entity3 = ownerTriggerComp3.Entity;
			if (entity3 == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent component3 = entity3.GetComponent<CharacterActorComponent>();
				vector = ((component3 != null) ? component3.ActorLocationProxy : null);
			}
		}
		Vector vector2 = vector;
		CharacterActorComponent component4 = victim.GetComponent<CharacterActorComponent>();
		Vector vector3 = (component4 != null) ? component4.ActorLocationProxy : null;
		if (vector2 == null || vector3 == null)
		{
			return;
		}
		if (Vector.DistSquared(vector2, vector3) > this.DistSquared)
		{
			return;
		}
		base.EvaluateAndExecute(null);
	}

	// Token: 0x06017976 RID: 96630 RVA: 0x006F7FC9 File Offset: 0x006F61C9
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8A9 RID: 51369
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C8AA RID: 51370
	protected double DistSquared;

	// Token: 0x0400C8AB RID: 51371
	protected readonly List<long> ListenDamageIds = new List<long>();
}
