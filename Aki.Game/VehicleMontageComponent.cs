using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002846 RID: 10310
[NullableContext(2)]
[Nullable(0)]
public class VehicleMontageComponent : BaseMontageComponent
{
	// Token: 0x0601A0F4 RID: 106740 RVA: 0x0080A0E2 File Offset: 0x008082E2
	protected override bool OnStart()
	{
		this.AnimationComponent = base.Entity.GetComponent<VehicleAnimationComponent>();
		return base.OnStart();
	}

	// Token: 0x0601A0F5 RID: 106741 RVA: 0x0080A100 File Offset: 0x00808300
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimationComponent.MainAnimInstance;
	}

	// Token: 0x0601A0F6 RID: 106742 RVA: 0x0080A10D File Offset: 0x0080830D
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		if (((VehicleMontageComponent)componentTemplate).AnimationComponent == null)
		{
			this.AnimationComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimationComponent), "AnimationComponent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002A5A RID: 10842
	// (get) Token: 0x0601A0F7 RID: 106743 RVA: 0x0080A14B File Offset: 0x0080834B
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A5B RID: 10843
	// (get) Token: 0x0601A0F8 RID: 106744 RVA: 0x0080A14E File Offset: 0x0080834E
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E495 RID: 58517
	public VehicleAnimationComponent AnimationComponent;
}
