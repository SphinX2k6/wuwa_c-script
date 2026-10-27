using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A6F RID: 27247
	public abstract class EntitySceneInteractPointBase : IEntitySceneInteractPoint, ISceneInteractPoint
	{
		// Token: 0x06043BD4 RID: 277460 RVA: 0x01094A50 File Offset: 0x01092C50
		public virtual ESceneInteractSearchStrategyType? GetPointStrategyType()
		{
			return null;
		}

		// Token: 0x06043BD5 RID: 277461 RVA: 0x01094A66 File Offset: 0x01092C66
		public virtual ESceneInteractType GetInteractType()
		{
			return ESceneInteractType.None;
		}

		// Token: 0x06043BD6 RID: 277462 RVA: 0x01094A69 File Offset: 0x01092C69
		public virtual void Init()
		{
		}

		// Token: 0x06043BD7 RID: 277463 RVA: 0x01094A6B File Offset: 0x01092C6B
		public virtual void Clear()
		{
		}

		// Token: 0x06043BD8 RID: 277464
		[NullableContext(1)]
		public abstract EntityHandle GetEntityHandle();

		// Token: 0x06043BD9 RID: 277465 RVA: 0x01094A6D File Offset: 0x01092C6D
		public int GetEntityId()
		{
			EntityHandle entityHandle = this.GetEntityHandle();
			if (entityHandle == null)
			{
				return -1;
			}
			return entityHandle.Id;
		}

		// Token: 0x06043BDA RID: 277466 RVA: 0x01094A80 File Offset: 0x01092C80
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

		// Token: 0x06043BDB RID: 277467 RVA: 0x01094AA4 File Offset: 0x01092CA4
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

		// Token: 0x0402363D RID: 144957
		[Nullable(2)]
		private Vector Location;
	}
}
