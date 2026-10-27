using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002F30 RID: 12080
[NullableContext(1)]
[Nullable(0)]
public class DamageShare : BuffEffect
{
	// Token: 0x06019BBD RID: 105405 RVA: 0x006B3A33 File Offset: 0x006B1C33
	public DamageShare(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BBE RID: 105406 RVA: 0x006B3A44 File Offset: 0x006B1C44
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		float[] extraEffectGrowParameters = parameters.ExtraEffectGrowParameters1;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.ShareType = (EDamageShareType)int.Parse(extraEffectParameters_[0]);
		}
		else
		{
			this.ShareType = EDamageShareType.All;
		}
		this.ShareRate = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters, this.Level, 0f) * 0.0001f;
	}

	// Token: 0x06019BBF RID: 105407 RVA: 0x006B3A9C File Offset: 0x006B1C9C
	public static void ApplyBuffShare(Entity victim, Damage damageData, IBuffDamageParam damageParam, Partial_RequirementPayload payload, long contextId)
	{
		foreach (KeyValuePair<int, float> keyValuePair in DamageShare.GetShareRateMap(victim, damageData))
		{
			int num;
			float num2;
			keyValuePair.Deconstruct(out num, out num2);
			int id = num;
			float extraRate = num2;
			Entity entity = EntitySystem.Instance.Get(id);
			FVectorDouble? fvectorDouble;
			if (entity == null)
			{
				fvectorDouble = null;
			}
			else
			{
				BaseActorComponent baseActorComponent = entity.CheckGetComponent<BaseActorComponent>();
				fvectorDouble = ((baseActorComponent != null) ? new FVectorDouble?(baseActorComponent.ActorLocation) : null);
			}
			FVectorDouble? fvectorDouble2 = fvectorDouble;
			BaseDamageComponent baseDamageComponent = (entity != null) ? entity.CheckGetComponent<BaseDamageComponent>() : null;
			if (baseDamageComponent != null && fvectorDouble2 != null)
			{
				BuffDamageParam damageParam2 = new BuffDamageParam(damageParam, fvectorDouble2.Value);
				baseDamageComponent.ExecuteBuffShareDamage(damageParam2, payload, extraRate, contextId);
			}
		}
	}

	// Token: 0x06019BC0 RID: 105408 RVA: 0x006B3B74 File Offset: 0x006B1D74
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length != 0)
		{
			object obj = parameters[0];
			if (obj is Damage)
			{
				Damage damage = (Damage)obj;
				if (this.InstigatorEntityId == base.OwnerEntity.Id)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.ZQR;
					string message = "[DamageShare] Cannot Share damage to oneself.";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.InstigatorEntityId);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return new ValueTuple<int?, float>(null, 0f);
				}
				if (!this.IsShareable((ECalculationType)damage.CalculateType))
				{
					return null;
				}
				return new ValueTuple<int, float>(this.InstigatorEntityId, this.ShareRate);
			}
		}
		return new ValueTuple<int?, float>(null, 0f);
	}

	// Token: 0x06019BC1 RID: 105409 RVA: 0x006B3C38 File Offset: 0x006B1E38
	protected bool IsShareable(ECalculationType calculateType)
	{
		EDamageShareType shareType = this.ShareType;
		if (shareType != EDamageShareType.OnlyHurt)
		{
			return shareType != EDamageShareType.OnlyHeal || calculateType == ECalculationType.Heal;
		}
		return calculateType == ECalculationType.Hurt;
	}

	// Token: 0x06019BC2 RID: 105410 RVA: 0x006B3C60 File Offset: 0x006B1E60
	protected static Dictionary<int, float> GetShareRateMap(Entity victim, Damage damageData)
	{
		BaseBuffComponent component = victim.GetComponent<BaseBuffComponent>();
		IEnumerable<DamageShare> enumerable = component.BuffEffectManager.FilterById<DamageShare>(EExtraEffectId.ShareDamage, null);
		Dictionary<int, float> dictionary = new Dictionary<int, float>();
		foreach (DamageShare damageShare in enumerable)
		{
			if (damageShare.Check(new Partial_RequirementPayload(), component))
			{
				object obj = damageShare.Execute(new object[]
				{
					damageData
				});
				if (obj is ValueTuple<int?, float>)
				{
					ValueTuple<int?, float> valueTuple = (ValueTuple<int?, float>)obj;
					int? item = valueTuple.Item1;
					float item2 = valueTuple.Item2;
					if (item != null)
					{
						float valueOrDefault = dictionary.GetValueOrDefault(item.Value, 0f);
						dictionary[item.Value] = item2 + valueOrDefault;
					}
				}
			}
		}
		if (component.IsRoleBuffComponent())
		{
			RoleBuffComponent roleBuffComponent = component as RoleBuffComponent;
			if (roleBuffComponent != null && roleBuffComponent.HasBuffAuthority())
			{
				foreach (DamageShare damageShare2 in roleBuffComponent.GetFormationBuffComp().BuffEffectManager.FilterById<DamageShare>(EExtraEffectId.ShareDamage, null))
				{
					if (damageShare2.Check(new Partial_RequirementPayload(), component))
					{
						object obj2 = damageShare2.Execute(new object[]
						{
							damageData
						});
						if (obj2 is ValueTuple<int?, float>)
						{
							ValueTuple<int?, float> valueTuple2 = (ValueTuple<int?, float>)obj2;
							int? item3 = valueTuple2.Item1;
							float item4 = valueTuple2.Item2;
							if (item3 != null)
							{
								float valueOrDefault2 = dictionary.GetValueOrDefault(item3.Value, 0f);
								dictionary[item3.Value] = item4 + valueOrDefault2;
							}
						}
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0400C1F9 RID: 49657
	public EDamageShareType ShareType;

	// Token: 0x0400C1FA RID: 49658
	public float ShareRate;
}
