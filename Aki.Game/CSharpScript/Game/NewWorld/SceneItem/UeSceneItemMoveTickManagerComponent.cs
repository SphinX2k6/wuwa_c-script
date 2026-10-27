using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200719B RID: 29083
	[NullableContext(1)]
	[Nullable(0)]
	public class UeSceneItemMoveTickManagerComponent : EntityComponent
	{
		// Token: 0x0604729E RID: 291486 RVA: 0x01214F0C File Offset: 0x0121310C
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

		// Token: 0x0604729F RID: 291487 RVA: 0x01215043 File Offset: 0x01213243
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.OnChangeBasedPlatform, new Action<Entity, bool>(this.OnChangeBasedMovementActor));
			return true;
		}

		// Token: 0x060472A0 RID: 291488 RVA: 0x01215068 File Offset: 0x01213268
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

		// Token: 0x060472A1 RID: 291489 RVA: 0x012150A4 File Offset: 0x012132A4
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

		// Token: 0x060472A2 RID: 291490 RVA: 0x01215170 File Offset: 0x01213370
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			UeSceneItemMoveTickManagerComponent ueSceneItemMoveTickManagerComponent = (UeSceneItemMoveTickManagerComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (ueSceneItemMoveTickManagerComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComponent"))
			{
				if (ueSceneItemMoveTickManagerComponent.MoveComponent == null)
				{
					this.MoveComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroSceneItemMoveComponent>(this.MoveComponent), "MoveComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StandOnEntity") && ueSceneItemMoveTickManagerComponent.StandOnEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.StandOnEntity), "StandOnEntity"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("LastTickTime"))
			{
				this.LastTickTime = ueSceneItemMoveTickManagerComponent.LastTickTime;
			}
			if (base.CanResetComponentProperty("NeedTickOutside"))
			{
				this.NeedTickOutside = ueSceneItemMoveTickManagerComponent.NeedTickOutside;
			}
			return true;
		}

		// Token: 0x040256C7 RID: 153287
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x040256C8 RID: 153288
		[Nullable(2)]
		private UKuroSceneItemMoveComponent MoveComponent;

		// Token: 0x040256C9 RID: 153289
		private readonly HashSet<Entity> StandOnEntity = new HashSet<Entity>();

		// Token: 0x040256CA RID: 153290
		private int LastTickTime = -1;

		// Token: 0x040256CB RID: 153291
		private bool NeedTickOutside;
	}
}
