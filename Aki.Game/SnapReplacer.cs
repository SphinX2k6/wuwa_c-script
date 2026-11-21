using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024CD RID: 9421
[NullableContext(1)]
[Nullable(0)]
public class SnapReplacer : BuffEffect
{
	// Token: 0x06017648 RID: 95816 RVA: 0x006E338F File Offset: 0x006E158F
	public SnapReplacer(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017649 RID: 95817 RVA: 0x006E339E File Offset: 0x006E159E
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return base.InstigatorBuffComponent;
	}

	// Token: 0x0601764A RID: 95818 RVA: 0x006E33A8 File Offset: 0x006E15A8
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
