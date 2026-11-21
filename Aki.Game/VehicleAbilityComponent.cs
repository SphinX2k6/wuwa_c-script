using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002834 RID: 10292
public class VehicleAbilityComponent : BaseAbilityComponent
{
	// Token: 0x06019FAB RID: 106411 RVA: 0x00802038 File Offset: 0x00800238
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

	// Token: 0x17002A1A RID: 10778
	// (get) Token: 0x06019FAC RID: 106412 RVA: 0x0080206C File Offset: 0x0080026C
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A1B RID: 10779
	// (get) Token: 0x06019FAD RID: 106413 RVA: 0x0080206F File Offset: 0x0080026F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A1C RID: 10780
	// (get) Token: 0x06019FAE RID: 106414 RVA: 0x00802072 File Offset: 0x00800272
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A1D RID: 10781
	// (get) Token: 0x06019FAF RID: 106415 RVA: 0x00802075 File Offset: 0x00800275
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}
}
