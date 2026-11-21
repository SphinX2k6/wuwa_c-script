using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006250 RID: 25168
	[NullableContext(1)]
	[Nullable(0)]
	public class UeSceneItemMoveTickManagerComponent : EntityComponent
	{
		// Token: 0x0603CB92 RID: 248722 RVA: 0x0116EF64 File Offset: 0x0116D164
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (base.Entity.GameBudgetConfig.GroupName == FNameUtil.GetDynamicFName("MoveSceneItemEntity"))
			{
				this.NeedTickOutside = true;
			}
			this.MoveComponent = (this.ActorComp.Owner.GetComponentByClass(UKuroSceneItemMoveComponent.StaticClass()) as UKuroSceneItemMoveComponent);
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent == null || !moveComponent.IsValid())
			{
				AActor owner = this.ActorComp.Owner;
				TSubclassOf<UActorComponent> @class = UKuroSceneItemMoveComponent.StaticClass();
				bool bManualAttachment = false;
				FTransform ftransform = new FTransform();
				this.MoveComponent = (owner.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroSceneItemMoveComponent);
				UKuroSceneItemMoveComponent moveComponent2 = this.MoveComponent;
				FVectorDouble fvectorDouble = this.ActorComp.ActorGravityDirectProxy.ToUeVector(false);
				moveComponent2.Kuro_SetGravityDirect(fvectorDouble);
				this.MoveComponent.SetTickingMoveEnable(false);
				if (this.NeedTickOutside)
				{
					this.MoveComponent.SetKuroOnlyTickOutside(true);
				}
			}
			EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.OnChangeBasedPlatform, new Action<Entity, bool>(this.OnChangeBasedMovementActor));
			return true;
		}

		// Token: 0x0603CB93 RID: 248723 RVA: 0x0116F09B File Offset: 0x0116D29B
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.OnChangeBasedPlatform, new Action<Entity, bool>(this.OnChangeBasedMovementActor));
			return true;
		}

		// Token: 0x0603CB94 RID: 248724 RVA: 0x0116F0C0 File Offset: 0x0116D2C0
		private void OnChangeBasedMovementActor(Entity entity, bool isEnter)
		{
			if (isEnter)
			{
				this.StandOnEntity.Add(entity);
				return;
			}
			CharacterDriveVehicleComponent component = entity.GetComponent<CharacterDriveVehicleComponent>();
			if (((component != null) ? component.VehicleEntity : null) != base.Entity)
			{
				this.StandOnEntity.Remove(entity);
			}
		}

		// Token: 0x0603CB95 RID: 248725 RVA: 0x0116F0FC File Offset: 0x0116D2FC
		public void TickMovement(float delta, bool bForceTick = false)
		{
			if (bForceTick || (this.NeedTickOutside && this.LastTickTime < Time.Instance.Frame))
			{
				UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
				if (moveComponent != null && moveComponent.IsValid())
				{
					UKuroSceneItemMoveComponent moveComponent2 = this.MoveComponent;
					if (moveComponent2 != null)
					{
						moveComponent2.KuroTickComponentOutside(delta * 0.001f);
					}
					SceneItemActorComponent actorComp = this.ActorComp;
					if (actorComp != null)
					{
						actorComp.ResetAllCachedTime();
					}
					foreach (Entity entity in this.StandOnEntity)
					{
						BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
						if (component != null)
						{
							component.ResetAllCachedTime();
						}
					}
					this.LastTickTime = Time.Instance.Frame;
				}
			}
		}

		// Token: 0x0603CB96 RID: 248726 RVA: 0x0116F1C8 File Offset: 0x0116D3C8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			UeSceneItemMoveTickManagerComponent ueSceneItemMoveTickManagerComponent = (UeSceneItemMoveTickManagerComponent)componentTemplate;
			if (ueSceneItemMoveTickManagerComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (ueSceneItemMoveTickManagerComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
			if (ueSceneItemMoveTickManagerComponent.StandOnEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.StandOnEntity), "StandOnEntity"))
			{
				return false;
			}
			this.LastTickTime = ueSceneItemMoveTickManagerComponent.LastTickTime;
			this.NeedTickOutside = ueSceneItemMoveTickManagerComponent.NeedTickOutside;
			return true;
		}

		// Token: 0x170072E5 RID: 29413
		// (get) Token: 0x0603CB97 RID: 248727 RVA: 0x0116F278 File Offset: 0x0116D478
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072E6 RID: 29414
		// (get) Token: 0x0603CB98 RID: 248728 RVA: 0x0116F27B File Offset: 0x0116D47B
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020336 RID: 131894
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x04020337 RID: 131895
		[Nullable(2)]
		private UKuroSceneItemMoveComponent MoveComponent;

		// Token: 0x04020338 RID: 131896
		private readonly HashSet<Entity> StandOnEntity = new HashSet<Entity>();

		// Token: 0x04020339 RID: 131897
		private int LastTickTime = -1;

		// Token: 0x0402033A RID: 131898
		private bool NeedTickOutside;
	}
}
