using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BCC RID: 23500
	public abstract class EntitySceneInteractPointBase : IEntitySceneInteractPoint, ISceneInteractPoint
	{
		// Token: 0x06039C22 RID: 236578 RVA: 0x0103927C File Offset: 0x0103747C
		public virtual ESceneInteractSearchStrategyType? GetPointStrategyType()
		{
			return null;
		}

		// Token: 0x06039C23 RID: 236579 RVA: 0x01039292 File Offset: 0x01037492
		public virtual ESceneInteractType GetInteractType()
		{
			return ESceneInteractType.None;
		}

		// Token: 0x06039C24 RID: 236580 RVA: 0x01039295 File Offset: 0x01037495
		public virtual void Init()
		{
		}

		// Token: 0x06039C25 RID: 236581 RVA: 0x01039297 File Offset: 0x01037497
		public virtual void Clear()
		{
		}

		// Token: 0x06039C26 RID: 236582
		[NullableContext(1)]
		public abstract EntityHandle GetEntityHandle();

		// Token: 0x06039C27 RID: 236583 RVA: 0x01039299 File Offset: 0x01037499
		public int GetEntityId()
		{
			EntityHandle entityHandle = this.GetEntityHandle();
			if (entityHandle == null)
			{
				return -1;
			}
			return entityHandle.Id;
		}

		// Token: 0x06039C28 RID: 236584 RVA: 0x010392AC File Offset: 0x010374AC
		[NullableContext(2)]
		public virtual AActor GetOwnerActor()
		{
			WorldEntity entity = this.GetEntityHandle().Entity;
			if (entity == null)
			{
				return null;
			}
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return null;
			}
			return component.Owner;
		}

		// Token: 0x06039C29 RID: 236585 RVA: 0x010392D0 File Offset: 0x010374D0
		[NullableContext(2)]
		public virtual Vector GetLocation()
		{
			WorldEntity entity = this.GetEntityHandle().Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (((baseActorComponent != null) ? baseActorComponent.Owner : null) == null)
			{
				return null;
			}
			if (this.Location == null)
			{
				this.Location = Vector.Create();
			}
			this.Location.DeepCopy(baseActorComponent.ActorLocationProxy);
			return this.Location;
		}

		// Token: 0x0401E82F RID: 124975
		[Nullable(2)]
		private Vector Location;
	}
}
