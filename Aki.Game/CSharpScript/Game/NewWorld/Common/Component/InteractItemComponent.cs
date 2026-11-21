using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006205 RID: 25093
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractItemComponent : EntityComponent
	{
		// Token: 0x0603C495 RID: 246933 RVA: 0x0112FF28 File Offset: 0x0112E128
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

		// Token: 0x0603C496 RID: 246934 RVA: 0x0112FFA0 File Offset: 0x0112E1A0
		public FVectorDouble? GetInteractPosition()
		{
			if (this.Position != null)
			{
				return new FVectorDouble?(this.Position.D_K2_GetComponentLocation());
			}
			return null;
		}

		// Token: 0x0603C497 RID: 246935 RVA: 0x0112FFD0 File Offset: 0x0112E1D0
		public FRotator? GetInteractRotator()
		{
			if (this.Arrow != null)
			{
				return new FRotator?(this.Arrow.K2_GetComponentRotation());
			}
			return null;
		}

		// Token: 0x0603C498 RID: 246936 RVA: 0x01130000 File Offset: 0x0112E200
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			InteractItemComponent interactItemComponent = (InteractItemComponent)componentTemplate;
			if (interactItemComponent.Position == null)
			{
				this.Position = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Position), "Position"))
			{
				return false;
			}
			if (interactItemComponent.Arrow == null)
			{
				this.Arrow = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Arrow), "Arrow"))
			{
				return false;
			}
			this.IsInit = interactItemComponent.IsInit;
			return true;
		}

		// Token: 0x170071C7 RID: 29127
		// (get) Token: 0x0603C499 RID: 246937 RVA: 0x01130082 File Offset: 0x0112E282
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEBD RID: 130749
		private static readonly FName POSITION_TAG = new FName("Position");

		// Token: 0x0401FEBE RID: 130750
		private UChildActorComponent Position;

		// Token: 0x0401FEBF RID: 130751
		private UArrowComponent Arrow;

		// Token: 0x0401FEC0 RID: 130752
		public bool IsInit;
	}
}
