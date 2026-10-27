using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020032C3 RID: 12995
public class VehicleAbilityComponent : BaseAbilityComponent
{
	// Token: 0x0601C35D RID: 115549 RVA: 0x007DB098 File Offset: 0x007D9298
	[NullableContext(2)]
	protected override UBaseAbilitySystemComponent GetAbilitySystemComponent()
	{
		VehicleActorComponent component = base.Entity.GetComponent<VehicleActorComponent>();
		if (component == null)
		{
			return null;
		}
		component.Actor.TryAddTsAbilitySystemComponent();
		return component.Actor.AbilitySystemComponent;
	}

	// Token: 0x0601C35E RID: 115550 RVA: 0x007DB0CC File Offset: 0x007D92CC
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleAbilityComponent vehicleAbilityComponent = (VehicleAbilityComponent)componentTemplate;
		return true;
	}
}
