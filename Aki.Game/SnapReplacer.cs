using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F79 RID: 12153
[NullableContext(1)]
[Nullable(0)]
public class SnapReplacer : BuffEffect
{
	// Token: 0x06019D36 RID: 105782 RVA: 0x006BCA7F File Offset: 0x006BAC7F
	public SnapReplacer(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D37 RID: 105783 RVA: 0x006BCA8E File Offset: 0x006BAC8E
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return base.InstigatorBuffComponent;
	}

	// Token: 0x06019D38 RID: 105784 RVA: 0x006BCA98 File Offset: 0x006BAC98
	[return: Nullable(2)]
	public static CharacterBuffComponent ApplyEffects([Nullable(2)] RequirementPayload requirements, CharacterBuffComponent attacker, CharacterBuffComponent victim)
	{
		ExtraEffectManager buffEffectManager = attacker.BuffEffectManager;
		IEnumerable<SnapReplacer> enumerable = (buffEffectManager != null) ? buffEffectManager.FilterById<SnapReplacer>(EExtraEffectId.ReplaceSnapshotBeforeCalculation, null) : null;
		if (enumerable != null)
		{
			foreach (SnapReplacer snapReplacer in enumerable)
			{
				EntityHandle instigatorEntity = snapReplacer.InstigatorEntity;
				if (instigatorEntity != null && instigatorEntity.Valid && snapReplacer.InstigatorEntity.Entity.Id != snapReplacer.OwnerBuffComponent.GetEntity().Id && snapReplacer.Check(requirements ?? new Partial_RequirementPayload(), victim))
				{
					return snapReplacer.Execute(Array.Empty<object>()) as CharacterBuffComponent;
				}
			}
			return attacker;
		}
		return attacker;
	}
}
