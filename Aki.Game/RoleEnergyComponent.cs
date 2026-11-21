using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020027AE RID: 10158
[NullableContext(2)]
[Nullable(0)]
public class RoleEnergyComponent : EntityComponent
{
	// Token: 0x060197DC RID: 104412 RVA: 0x007CF3A4 File Offset: 0x007CD5A4
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.AttributeComponent = base.Entity.CheckGetComponent<BaseAttributeComponent>();
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.AddListeners(RoleEnergyConstants.energyAttrIds, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty), "RoleEnergyComponent");
		}
		this.RefreshStarScarMaterialProperty(EAttributeType.None, 0f, 0f);
		return true;
	}

	// Token: 0x060197DD RID: 104413 RVA: 0x007CF40C File Offset: 0x007CD60C
	protected override bool OnEnd()
	{
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.RemoveListeners(RoleEnergyConstants.energyAttrIds, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty));
		}
		return true;
	}

	// Token: 0x060197DE RID: 104414 RVA: 0x007CF431 File Offset: 0x007CD631
	private void RefreshStarScarMaterialProperty(EAttributeType attribute, float newValue, float oldValue)
	{
		this.RefreshStarScarMaterial();
	}

	// Token: 0x060197DF RID: 104415 RVA: 0x007CF43C File Offset: 0x007CD63C
	public void RefreshStarScarMaterial()
	{
		if (!this.EnableRefreshStarScarByEnergy)
		{
			return;
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		float num = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.Energy) : 0f;
		BaseAttributeComponent attributeComponent2 = this.AttributeComponent;
		float num2 = (attributeComponent2 != null) ? attributeComponent2.GetCurrentValue(EAttributeType.EnergyMax) : 1f;
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent == null)
		{
			return;
		}
		TsBaseCharacter actor = actorComponent.Actor;
		if (actor == null)
		{
			return;
		}
		CharRenderingComponent charRenderingComponent = actor.CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return;
		}
		charRenderingComponent.SetStarScarEnergy(num / num2);
	}

	// Token: 0x060197E0 RID: 104416 RVA: 0x007CF4AB File Offset: 0x007CD6AB
	public void SetEnableRefreshStarScarByEnergy(bool enable)
	{
		this.EnableRefreshStarScarByEnergy = enable;
	}

	// Token: 0x060197E1 RID: 104417 RVA: 0x007CF4B4 File Offset: 0x007CD6B4
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleEnergyComponent roleEnergyComponent = (RoleEnergyComponent)componentTemplate;
		if (roleEnergyComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		if (roleEnergyComponent.AttributeComponent == null)
		{
			this.AttributeComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComponent), "AttributeComponent"))
		{
			return false;
		}
		this.EnableRefreshStarScarByEnergy = roleEnergyComponent.EnableRefreshStarScarByEnergy;
		return true;
	}

	// Token: 0x170028A6 RID: 10406
	// (get) Token: 0x060197E2 RID: 104418 RVA: 0x007CF536 File Offset: 0x007CD736
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028A7 RID: 10407
	// (get) Token: 0x060197E3 RID: 104419 RVA: 0x007CF539 File Offset: 0x007CD739
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF4B RID: 57163
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DF4C RID: 57164
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DF4D RID: 57165
	private bool EnableRefreshStarScarByEnergy = true;
}
