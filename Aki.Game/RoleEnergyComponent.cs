using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200323F RID: 12863
[NullableContext(2)]
[Nullable(0)]
public class RoleEnergyComponent : EntityComponent
{
	// Token: 0x0601BC34 RID: 113716 RVA: 0x007A6B2C File Offset: 0x007A4D2C
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

	// Token: 0x0601BC35 RID: 113717 RVA: 0x007A6B94 File Offset: 0x007A4D94
	protected override bool OnEnd()
	{
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.RemoveListeners(RoleEnergyConstants.energyAttrIds, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty));
		}
		return true;
	}

	// Token: 0x0601BC36 RID: 113718 RVA: 0x007A6BB9 File Offset: 0x007A4DB9
	private void RefreshStarScarMaterialProperty(EAttributeType attribute, float newValue, float oldValue)
	{
		this.RefreshStarScarMaterial();
	}

	// Token: 0x0601BC37 RID: 113719 RVA: 0x007A6BC4 File Offset: 0x007A4DC4
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

	// Token: 0x0601BC38 RID: 113720 RVA: 0x007A6C33 File Offset: 0x007A4E33
	public void SetEnableRefreshStarScarByEnergy(bool enable)
	{
		this.EnableRefreshStarScarByEnergy = enable;
	}

	// Token: 0x0601BC39 RID: 113721 RVA: 0x007A6C3C File Offset: 0x007A4E3C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleEnergyComponent roleEnergyComponent = (RoleEnergyComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (roleEnergyComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeComponent"))
		{
			if (roleEnergyComponent.AttributeComponent == null)
			{
				this.AttributeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComponent), "AttributeComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("EnableRefreshStarScarByEnergy"))
		{
			this.EnableRefreshStarScarByEnergy = roleEnergyComponent.EnableRefreshStarScarByEnergy;
		}
		return true;
	}

	// Token: 0x0400DAAC RID: 55980
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DAAD RID: 55981
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DAAE RID: 55982
	private bool EnableRefreshStarScarByEnergy = true;
}
