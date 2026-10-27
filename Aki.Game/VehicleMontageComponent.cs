using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020032D5 RID: 13013
[NullableContext(2)]
[Nullable(0)]
public class VehicleMontageComponent : BaseMontageComponent
{
	// Token: 0x0601C477 RID: 115831 RVA: 0x007E364C File Offset: 0x007E184C
	protected override bool OnStart()
	{
		this.AnimationComponent = base.Entity.GetComponent<VehicleAnimationComponent>();
		return base.OnStart();
	}

	// Token: 0x0601C478 RID: 115832 RVA: 0x007E366A File Offset: 0x007E186A
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimationComponent.MainAnimInstance;
	}

	// Token: 0x0601C479 RID: 115833 RVA: 0x007E3678 File Offset: 0x007E1878
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleMontageComponent vehicleMontageComponent = (VehicleMontageComponent)componentTemplate;
		if (base.CanResetComponentProperty("AnimationComponent"))
		{
			if (vehicleMontageComponent.AnimationComponent == null)
			{
				this.AnimationComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleAnimationComponent>(this.AnimationComponent), "AnimationComponent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DFF2 RID: 57330
	public VehicleAnimationComponent AnimationComponent;
}
