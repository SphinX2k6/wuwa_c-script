using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02007084 RID: 28804
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractItemComponent : EntityComponent
	{
		// Token: 0x06046278 RID: 287352 RVA: 0x011869A0 File Offset: 0x01184BA0
		protected override bool OnStart()
		{
			AActor dynamicEntity = WorldFunctionLibrary.GetDynamicEntity(base.Entity.Id);
			if (dynamicEntity != null)
			{
				TArray<UActorComponent> componentsByTag = dynamicEntity.GetComponentsByTag(UChildActorComponent.StaticClass(), InteractItemComponent.POSITION_TAG);
				if (componentsByTag != null && componentsByTag.Num() > 0)
				{
					this.Position = (componentsByTag.Get(0) as UChildActorComponent);
				}
				this.Arrow = (dynamicEntity.GetComponentByClass(UArrowComponent.StaticClass()) as UArrowComponent);
				this.IsInit = true;
			}
			return true;
		}

		// Token: 0x06046279 RID: 287353 RVA: 0x01186A18 File Offset: 0x01184C18
		public FVectorDouble? GetInteractPosition()
		{
			if (this.Position != null)
			{
				return new FVectorDouble?(this.Position.D_K2_GetComponentLocation());
			}
			return null;
		}

		// Token: 0x0604627A RID: 287354 RVA: 0x01186A48 File Offset: 0x01184C48
		public FRotator? GetInteractRotator()
		{
			if (this.Arrow != null)
			{
				return new FRotator?(this.Arrow.K2_GetComponentRotation());
			}
			return null;
		}

		// Token: 0x0604627B RID: 287355 RVA: 0x01186A78 File Offset: 0x01184C78
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			InteractItemComponent interactItemComponent = (InteractItemComponent)componentTemplate;
			if (base.CanResetComponentProperty("Position"))
			{
				if (interactItemComponent.Position == null)
				{
					this.Position = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UChildActorComponent>(this.Position), "Position"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Arrow"))
			{
				if (interactItemComponent.Arrow == null)
				{
					this.Arrow = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UArrowComponent>(this.Arrow), "Arrow"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInit"))
			{
				this.IsInit = interactItemComponent.IsInit;
			}
			return true;
		}

		// Token: 0x04024C02 RID: 150530
		private static readonly FName POSITION_TAG = new FName("Position");

		// Token: 0x04024C03 RID: 150531
		private UChildActorComponent Position;

		// Token: 0x04024C04 RID: 150532
		private UArrowComponent Arrow;

		// Token: 0x04024C05 RID: 150533
		public bool IsInit;
	}
}
