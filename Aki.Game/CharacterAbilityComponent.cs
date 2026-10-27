using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E9F RID: 11935
public class CharacterAbilityComponent : BaseAbilityComponent
{
	// Token: 0x060197E4 RID: 104420 RVA: 0x00694AAC File Offset: 0x00692CAC
	[NullableContext(2)]
	protected override UBaseAbilitySystemComponent GetAbilitySystemComponent()
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return null;
		}
		component.Actor.TryAddTsAbilitySystemComponent();
		return component.Actor.AbilitySystemComponent;
	}

	// Token: 0x060197E5 RID: 104421 RVA: 0x00694AE0 File Offset: 0x00692CE0
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterAbilityComponent characterAbilityComponent = (CharacterAbilityComponent)componentTemplate;
		return true;
	}
}
